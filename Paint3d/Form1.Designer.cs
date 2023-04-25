namespace Paint3d
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.clear_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btn_SelColor = new System.Windows.Forms.Button();
            this.button_HandMove = new System.Windows.Forms.Button();
            this.button_AddText = new System.Windows.Forms.Button();
            this.button_Fill = new System.Windows.Forms.Button();
            this.button_Eraser = new System.Windows.Forms.Button();
            this.button_Pen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.clear_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.btn_SelColor);
            this.panel1.Controls.Add(this.button_HandMove);
            this.panel1.Controls.Add(this.button_AddText);
            this.panel1.Controls.Add(this.button_Fill);
            this.panel1.Controls.Add(this.button_Eraser);
            this.panel1.Controls.Add(this.button_Pen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 64);
            this.panel1.TabIndex = 0;
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.clear_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_btn.Location = new System.Drawing.Point(604, 12);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(47, 33);
            this.clear_btn.TabIndex = 8;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(256, 12);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(283, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btn_SelColor
            // 
            this.btn_SelColor.BackColor = System.Drawing.Color.Black;
            this.btn_SelColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SelColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SelColor.Location = new System.Drawing.Point(215, 10);
            this.btn_SelColor.Name = "btn_SelColor";
            this.btn_SelColor.Size = new System.Drawing.Size(35, 33);
            this.btn_SelColor.TabIndex = 5;
            this.btn_SelColor.UseVisualStyleBackColor = false;
            this.btn_SelColor.Click += new System.EventHandler(this.btn_White_Click);
            // 
            // button_HandMove
            // 
            this.button_HandMove.BackColor = System.Drawing.Color.Gainsboro;
            this.button_HandMove.BackgroundImage = global::Paint3d.Properties.Resources.palm_of_hand;
            this.button_HandMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_HandMove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_HandMove.Location = new System.Drawing.Point(174, 10);
            this.button_HandMove.Name = "button_HandMove";
            this.button_HandMove.Size = new System.Drawing.Size(35, 33);
            this.button_HandMove.TabIndex = 4;
            this.button_HandMove.UseVisualStyleBackColor = false;
            // 
            // button_AddText
            // 
            this.button_AddText.BackColor = System.Drawing.Color.Gainsboro;
            this.button_AddText.BackgroundImage = global::Paint3d.Properties.Resources.font;
            this.button_AddText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AddText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddText.Location = new System.Drawing.Point(133, 10);
            this.button_AddText.Name = "button_AddText";
            this.button_AddText.Size = new System.Drawing.Size(35, 33);
            this.button_AddText.TabIndex = 3;
            this.button_AddText.Text = ".";
            this.button_AddText.UseVisualStyleBackColor = false;
            this.button_AddText.Click += new System.EventHandler(this.button_AddText_Click);
            // 
            // button_Fill
            // 
            this.button_Fill.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Fill.BackgroundImage = global::Paint3d.Properties.Resources.color;
            this.button_Fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Fill.Location = new System.Drawing.Point(92, 10);
            this.button_Fill.Name = "button_Fill";
            this.button_Fill.Size = new System.Drawing.Size(35, 33);
            this.button_Fill.TabIndex = 2;
            this.button_Fill.UseVisualStyleBackColor = false;
            this.button_Fill.Click += new System.EventHandler(this.button_Fill_Click);
            // 
            // button_Eraser
            // 
            this.button_Eraser.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Eraser.BackgroundImage = global::Paint3d.Properties.Resources.eraser;
            this.button_Eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Eraser.Location = new System.Drawing.Point(51, 10);
            this.button_Eraser.Name = "button_Eraser";
            this.button_Eraser.Size = new System.Drawing.Size(35, 33);
            this.button_Eraser.TabIndex = 1;
            this.button_Eraser.UseVisualStyleBackColor = false;
            this.button_Eraser.Click += new System.EventHandler(this.button_Eraser_Click);
            // 
            // button_Pen
            // 
            this.button_Pen.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Pen.BackgroundImage = global::Paint3d.Properties.Resources.pen;
            this.button_Pen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Pen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Pen.Location = new System.Drawing.Point(10, 10);
            this.button_Pen.Name = "button_Pen";
            this.button_Pen.Size = new System.Drawing.Size(35, 33);
            this.button_Pen.TabIndex = 0;
            this.button_Pen.UseVisualStyleBackColor = false;
            this.button_Pen.Click += new System.EventHandler(this.button_Pen_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 620);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 10);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1160, 566);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 630);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_AddText;
        private System.Windows.Forms.Button button_Fill;
        private System.Windows.Forms.Button button_Eraser;
        private System.Windows.Forms.Button button_Pen;
        private System.Windows.Forms.Button button_HandMove;
        private System.Windows.Forms.Button btn_SelColor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button clear_btn;
    }
}

