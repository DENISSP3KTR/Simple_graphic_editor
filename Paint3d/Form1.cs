using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Paint3d
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen pen = new Pen(Color.Black, 1);
        Pen eraser = new Pen(Color.White, 10);
        int index;
        Color color;
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox1.Image = bm;
            
        }
        System.Windows.Forms.ToolTip tip = new System.Windows.Forms.ToolTip();
        private void Form1_Load(object sender, EventArgs e)
        {
            tip.SetToolTip(btn_SelColor, btn_SelColor.BackColor.Name);
        }

        private const int cGrip = 16;
        private const int cCaption = 32;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void btn_White_Click(object sender, EventArgs e)
        {
            colorDialog1= new ColorDialog();
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btn_SelColor.BackColor = colorDialog1.Color;
                tip.SetToolTip(btn_SelColor, btn_SelColor.BackColor.Name);
            }
            pen.Color = colorDialog1.Color;
            color = colorDialog1.Color;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(pen, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(eraser, px, py);
                    py = px;
                }
                
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void button_Eraser_Click(object sender, EventArgs e)
        {
            index = 2;
            Cursor = Cursors.Default;
        }

        private void button_Pen_Click(object sender, EventArgs e)
        {
            index = 1;
            Cursor = Cursors.Default;
        }
        static Point set_point(PictureBox pic, Point p)
        {
            float px = 1f * pic.Image.Width / pic.Width;
            float py = 1f * pic.Image.Height / pic.Height;
            return new Point((int)(p.X * px), (int)(p.Y * py));
        }
        private void validate(Bitmap bm,Stack<Point> p,int x,int y,Color c2, Color c1)
        {
            Color cx = bm.GetPixel(x,y);
            if (cx == c2)
            {
                p.Push(new Point(x, y));
                bm.SetPixel(x, y, c1);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 3)
            {
                Point p = set_point(pictureBox1, e.Location);
                Fill(bm, p.X, p.Y, color);
            }
            if (index == 4)
            {
                Font myfont = new Font("Arial", 14);
                Label label= new Label();
                label.Font = myfont;
                label.BackColor = color;
            }
        }

        private void button_Fill_Click(object sender, EventArgs e)
        {
            index = 3; 
            Cursor = Cursors.Default;
        }

        private void button_AddText_Click(object sender, EventArgs e)
        {
            index = 4;
            Cursor = Cursors.IBeam;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            pen = new Pen(colorDialog1.Color, trackBar1.Value);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Fill(Bitmap bm, int x, int y, Color c1)
        {
            Color c2 = bm.GetPixel(x,y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x,y));
            bm.SetPixel(x,y,c1);
            if (c2 == c1) return;
            while(pixel.Count > 0 )
            {
                Point p = (Point)pixel.Pop();
                if (p.X > 0 && p.Y > 0 && p.X < bm.Width - 1 && p.Y < bm.Height - 1)  {
                    validate(bm, pixel, p.X - 1, p.Y - 1, c2, c1);
                    validate(bm, pixel, p.X, p.Y - 1, c2, c1);
                    validate(bm, pixel, p.X + 1, p.Y, c2, c1);
                    validate(bm, pixel, p.X, p.Y + 1, c2, c1);

                }
            }
        }
    }
}
