namespace Assignment_ES
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(160, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1235, 707);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 37);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(189, 226, 239);
            label2.Font = new Font("Inter ExtraBold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(24, 57, 58);
            label2.Location = new Point(160, 37);
            label2.Name = "label2";
            label2.Size = new Size(299, 72);
            label2.TabIndex = 2;
            label2.Text = "Products";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(83, 23);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 4;
            label3.Text = "Back";
            label3.Click += label3_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(189, 226, 239);
            ClientSize = new Size(1627, 1055);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
    }
}