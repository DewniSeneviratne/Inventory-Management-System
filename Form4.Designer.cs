namespace Assignment_ES
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            itemManagementToolStripMenuItem = new ToolStripMenuItem();
            aToolStripMenuItem = new ToolStripMenuItem();
            bToolStripMenuItem = new ToolStripMenuItem();
            cToolStripMenuItem = new ToolStripMenuItem();
            suppliersToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            stockReportToolStripMenuItem = new ToolStripMenuItem();
            deliveryReportToolStripMenuItem = new ToolStripMenuItem();
            salesReportToolStripMenuItem = new ToolStripMenuItem();
            monitorToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            outOfStockToolStripMenuItem = new ToolStripMenuItem();
            expiredToolStripMenuItem = new ToolStripMenuItem();
            button3rem = new Button();
            button2up = new Button();
            button1add = new Button();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            dataGridView1 = new DataGridView();
            pictureBox7 = new PictureBox();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonFace;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(80, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(143, 77);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1322, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1234, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, itemManagementToolStripMenuItem, suppliersToolStripMenuItem, reportsToolStripMenuItem, monitorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(270, 20, 21, 20);
            menuStrip1.Size = new Size(1627, 95);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Padding = new Padding(30, 10, 30, 10);
            homeToolStripMenuItem.Size = new Size(139, 55);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // itemManagementToolStripMenuItem
            // 
            itemManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aToolStripMenuItem, bToolStripMenuItem, cToolStripMenuItem });
            itemManagementToolStripMenuItem.Name = "itemManagementToolStripMenuItem";
            itemManagementToolStripMenuItem.Padding = new Padding(30, 10, 30, 10);
            itemManagementToolStripMenuItem.Size = new Size(267, 55);
            itemManagementToolStripMenuItem.Text = "Item Management";
            itemManagementToolStripMenuItem.Click += itemManagementToolStripMenuItem_Click;
            // 
            // aToolStripMenuItem
            // 
            aToolStripMenuItem.Name = "aToolStripMenuItem";
            aToolStripMenuItem.Size = new Size(183, 36);
            aToolStripMenuItem.Text = "Add";
            // 
            // bToolStripMenuItem
            // 
            bToolStripMenuItem.Name = "bToolStripMenuItem";
            bToolStripMenuItem.Size = new Size(183, 36);
            bToolStripMenuItem.Text = "Update";
            // 
            // cToolStripMenuItem
            // 
            cToolStripMenuItem.Name = "cToolStripMenuItem";
            cToolStripMenuItem.Size = new Size(183, 36);
            cToolStripMenuItem.Text = "Remove";
            // 
            // suppliersToolStripMenuItem
            // 
            suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            suppliersToolStripMenuItem.Padding = new Padding(30, 10, 30, 10);
            suppliersToolStripMenuItem.Size = new Size(173, 55);
            suppliersToolStripMenuItem.Text = "Suppliers";
            suppliersToolStripMenuItem.Click += suppliersToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stockReportToolStripMenuItem, deliveryReportToolStripMenuItem, salesReportToolStripMenuItem });
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Padding = new Padding(30, 10, 30, 10);
            reportsToolStripMenuItem.Size = new Size(156, 55);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // stockReportToolStripMenuItem
            // 
            stockReportToolStripMenuItem.Name = "stockReportToolStripMenuItem";
            stockReportToolStripMenuItem.Size = new Size(258, 36);
            stockReportToolStripMenuItem.Text = "Stock Report";
            // 
            // deliveryReportToolStripMenuItem
            // 
            deliveryReportToolStripMenuItem.Name = "deliveryReportToolStripMenuItem";
            deliveryReportToolStripMenuItem.Size = new Size(258, 36);
            deliveryReportToolStripMenuItem.Text = "Delivery Report";
            // 
            // salesReportToolStripMenuItem
            // 
            salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
            salesReportToolStripMenuItem.Size = new Size(258, 36);
            salesReportToolStripMenuItem.Text = "Sales Report";
            // 
            // monitorToolStripMenuItem
            // 
            monitorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchToolStripMenuItem, outOfStockToolStripMenuItem, expiredToolStripMenuItem });
            monitorToolStripMenuItem.Name = "monitorToolStripMenuItem";
            monitorToolStripMenuItem.Padding = new Padding(30, 10, 30, 10);
            monitorToolStripMenuItem.Size = new Size(160, 55);
            monitorToolStripMenuItem.Text = "Monitor";
            monitorToolStripMenuItem.Click += monitorToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(225, 36);
            searchToolStripMenuItem.Text = "Search";
            // 
            // outOfStockToolStripMenuItem
            // 
            outOfStockToolStripMenuItem.Name = "outOfStockToolStripMenuItem";
            outOfStockToolStripMenuItem.Size = new Size(225, 36);
            outOfStockToolStripMenuItem.Text = "Out of stock";
            // 
            // expiredToolStripMenuItem
            // 
            expiredToolStripMenuItem.Name = "expiredToolStripMenuItem";
            expiredToolStripMenuItem.Size = new Size(225, 36);
            expiredToolStripMenuItem.Text = "Expired";
            // 
            // button3rem
            // 
            button3rem.BackColor = Color.FromArgb(0, 171, 178);
            button3rem.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3rem.ForeColor = Color.White;
            button3rem.Location = new Point(428, 164);
            button3rem.Name = "button3rem";
            button3rem.Size = new Size(155, 52);
            button3rem.TabIndex = 24;
            button3rem.Text = "Expired";
            button3rem.UseVisualStyleBackColor = false;
            button3rem.Click += button3rem_Click;
            // 
            // button2up
            // 
            button2up.BackColor = Color.FromArgb(0, 171, 178);
            button2up.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2up.ForeColor = Color.White;
            button2up.Location = new Point(229, 164);
            button2up.Name = "button2up";
            button2up.Size = new Size(202, 52);
            button2up.TabIndex = 23;
            button2up.Text = "Out of Stock";
            button2up.UseVisualStyleBackColor = false;
            button2up.Click += button2up_Click;
            // 
            // button1add
            // 
            button1add.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1add.ForeColor = Color.FromArgb(1, 89, 99);
            button1add.Location = new Point(112, 164);
            button1add.Name = "button1add";
            button1add.Size = new Size(120, 52);
            button1add.TabIndex = 22;
            button1add.Text = "Search";
            button1add.UseVisualStyleBackColor = true;
            button1add.Click += button1add_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(112, 206);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1272, 759);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(168, 240);
            label1.Name = "label1";
            label1.Size = new Size(263, 38);
            label1.TabIndex = 25;
            label1.Text = "Enter Product Code:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(480, 241);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(327, 27);
            textBox1.TabIndex = 26;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(824, 250);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(0, 0);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(0, 171, 178);
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(804, 241);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(47, 51);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 28;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(112, 323);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(1272, 543);
            dataGridView1.TabIndex = 0;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(0, 171, 178);
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(873, 240);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(51, 52);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 29;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.GridColor = Color.White;
            dataGridView2.Location = new Point(112, 323);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.ShowEditingIcon = false;
            dataGridView2.Size = new Size(1272, 543);
            dataGridView2.TabIndex = 30;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AllowUserToResizeColumns = false;
            dataGridView3.AllowUserToResizeRows = false;
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.GridColor = Color.White;
            dataGridView3.Location = new Point(112, 323);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.ShowEditingIcon = false;
            dataGridView3.Size = new Size(1272, 521);
            dataGridView3.TabIndex = 31;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(189, 226, 239);
            ClientSize = new Size(1627, 1055);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(pictureBox7);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox4);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button3rem);
            Controls.Add(button2up);
            Controls.Add(button1add);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem itemManagementToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem bToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem suppliersToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem stockReportToolStripMenuItem;
        private ToolStripMenuItem deliveryReportToolStripMenuItem;
        private ToolStripMenuItem salesReportToolStripMenuItem;
        private ToolStripMenuItem monitorToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem outOfStockToolStripMenuItem;
        private ToolStripMenuItem expiredToolStripMenuItem;
        private Button button3rem;
        private Button button2up;
        private Button button1add;
        private PictureBox pictureBox5;
        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private DataGridView dataGridView1;
        private PictureBox pictureBox7;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
    }
}