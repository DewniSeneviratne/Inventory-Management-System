using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_ES
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void itemManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Size = new Size(314, 183);
            label2.AutoSize = false;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            this.Hide();
            f6.Show();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = Color.LightCoral;
            pictureBox6.BackColor = Color.LightCoral;

        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.White;
            pictureBox6.BackColor = Color.White;
        }
        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.BackColor = Color.LightCoral;
            pictureBox10.BackColor = Color.LightCoral;

        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.White;
            pictureBox10.BackColor = Color.White;
        }
        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.BackColor = Color.LightCoral;
            pictureBox11.BackColor = Color.LightCoral;

        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.White;
            pictureBox11.BackColor = Color.White;
        }
        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.BackColor = Color.LightCoral;
            pictureBox12.BackColor = Color.LightCoral;

        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.BackColor = Color.White;
            pictureBox12.BackColor = Color.White;
        }
        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.BackColor = Color.LightCoral;
            pictureBox13.BackColor = Color.LightCoral;

        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.White;
            pictureBox13.BackColor = Color.White;
        }
        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.BackColor = Color.LightCoral;
            pictureBox14.BackColor = Color.LightCoral;

        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.BackColor = Color.White;
            pictureBox14.BackColor = Color.White;
        }

        private void monitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            this.Hide();
            form7.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
