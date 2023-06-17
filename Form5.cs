using MySql.Data.MySqlClient;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Size = new Size(327, 51);
            textBox1.AutoSize = false;
            loadData();
            dataGridView3.Show();
        }

        public void loadData()
        {

            var database = new Database();
            if (database.connect_db())
            {
                string query = "select * from suppliers";

                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridView3.DataSource = bindingSource;

                database.close_db();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1add_Click(object sender, EventArgs e)
        {
            button1add.BackColor = Color.White;
            button1add.ForeColor = System.Drawing.ColorTranslator.FromHtml("#015963");
            button2up.BackColor = System.Drawing.ColorTranslator.FromHtml("#00ABB2");
            button2up.ForeColor = Color.White;
            button3rem.BackColor = System.Drawing.ColorTranslator.FromHtml("#00ABB2");
            button3rem.ForeColor = Color.White;



        }

        private void button2up_Click(object sender, EventArgs e)
        {
            button2up.BackColor = Color.White;
            button2up.ForeColor = System.Drawing.ColorTranslator.FromHtml("#015963");
            button1add.BackColor = System.Drawing.ColorTranslator.FromHtml("#00ABB2");
            button1add.ForeColor = Color.White;
            button3rem.BackColor = System.Drawing.ColorTranslator.FromHtml("#00ABB2");
            button3rem.ForeColor = Color.White;
            dataGridView3.Hide();
            textBox1.Hide();
            pictureBox6
        }

        private void button3rem_Click(object sender, EventArgs e)
        {
            button3rem.BackColor = Color.White;
            button3rem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#015963");
            button1add.BackColor = System.Drawing.ColorTranslator.FromHtml("#00ABB2");
            button1add.ForeColor = Color.White;
            button2up.BackColor = System.Drawing.ColorTranslator.FromHtml("#00ABB2");
            button2up.ForeColor = Color.White;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            var database = new Database();
            if (database.connect_db())
            {
                string supplierCode = textBox1.Text;
                string query = "select * from suppliers where supplier_ID=" + supplierCode + "";

                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridView3.DataSource = bindingSource;

                database.close_db();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();

        }

        private void itemManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void monitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }
    }
}
