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
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
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
            label1.Location = new Point(452, 256);
            label1.Name = "label1";
            label1.Size = new Size(175, 58);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // rec
            // 
            rec.Image = (Image)resources.GetObject("rec.Image");
            rec.Location = new Point(256, 134);
            rec.Margin = new Padding(3, 2, 3, 2);
            rec.Name = "rec";
            rec.Size = new Size(541, 464);
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
            pro.Location = new Point(452, 66);
            pro.Margin = new Padding(3, 2, 3, 2);
            pro.Name = "pro";
            pro.Size = new Size(166, 142);
            pro.SizeMode = PictureBoxSizeMode.StretchImage;
            pro.TabIndex = 2;
            pro.TabStop = false;
            pro.Click += pictureBox2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(343, 373);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "User Name";
            textBox1.Size = new Size(364, 36);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(343, 465);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(364, 36);
            textBox2.TabIndex = 5;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(135, 228, 218);
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(297, 590);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(452, 53);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(942, 602);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(49, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(640, 167);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(551, 417);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(189, 226, 239);
            ClientSize = new Size(1424, 845);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pro);
            Controls.Add(label1);
            Controls.Add(rec);
            ForeColor = Color.FromArgb(24, 57, 58);
            Margin = new Padding(3, 2, 3, 2);
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
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}