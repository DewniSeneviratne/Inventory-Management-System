namespace Assignment_ES
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            rec = new PictureBox();
            pro = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)rec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(147, 191, 216);
            label1.Font = new Font("Inter ExtraBold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(24, 57, 58);
            label1.Location = new Point(517, 341);
            label1.Name = "label1";
            label1.Size = new Size(216, 72);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // rec
            // 
            rec.Image = (Image)resources.GetObject("rec.Image");
            rec.Location = new Point(293, 179);
            rec.Name = "rec";
            rec.Size = new Size(618, 619);
            rec.SizeMode = PictureBoxSizeMode.StretchImage;
            rec.TabIndex = 1;
            rec.TabStop = false;
            rec.Click += pictureBox1_Click;
            // 
            // pro
            // 
            pro.BackColor = Color.Transparent;
            pro.BackgroundImage = (Image)resources.GetObject("pro.BackgroundImage");
            pro.BackgroundImageLayout = ImageLayout.None;
            pro.Image = (Image)resources.GetObject("pro.Image");
            pro.Location = new Point(517, 88);
            pro.Name = "pro";
            pro.Size = new Size(190, 189);
            pro.SizeMode = PictureBoxSizeMode.StretchImage;
            pro.TabIndex = 2;
            pro.TabStop = false;
            pro.Click += pictureBox2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(392, 497);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "User Name";
            textBox1.Size = new Size(415, 43);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(392, 620);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(415, 43);
            textBox2.TabIndex = 5;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(135, 228, 218);
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(339, 787);
            button1.Name = "button1";
            button1.Size = new Size(517, 71);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(731, 223);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(630, 556);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(147, 191, 216);
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(547, 456);
            label2.Name = "label2";
            label2.Size = new Size(127, 31);
            label2.TabIndex = 33;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(147, 191, 216);
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(555, 588);
            label3.Name = "label3";
            label3.Size = new Size(110, 31);
            label3.TabIndex = 34;
            label3.Text = "Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(189, 226, 239);
            ClientSize = new Size(1627, 1055);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pro);
            Controls.Add(label1);
            Controls.Add(rec);
            ForeColor = Color.FromArgb(24, 57, 58);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)rec).EndInit();
            ((System.ComponentModel.ISupportInitialize)pro).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox rec;
        private PictureBox pro;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
    }
}