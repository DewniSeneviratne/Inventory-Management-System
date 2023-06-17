using Google.Protobuf.WellKnownTypes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment_ES
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Size = new Size(327, 51);
            textBox1.AutoSize = false;
            loadData();
            dataGridView1.Show();
            dataGridView2.Hide();
            dataGridView3.Hide();
            label1.Show();
            textBox1.Show();
            pictureBox6.Show();
            pictureBox7.Show();
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 13);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 13);
            dataGridView2.DefaultCellStyle.Font = new Font("Arial", 13);
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 13);
            dataGridView3.DefaultCellStyle.Font = new Font("Arial", 13);
            dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 13);

        }
        public void loadData()
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "select stocks.product_code, products.product_name, products.manufacturer, stocks.selling_price, stocks.exp_date, stocks.quantity from stocks, products where stocks.product_code=products.product_code";

                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridView1.DataSource = bindingSource;

                database.close_db();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
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
            dataGridView1.Show();
            dataGridView2.Hide();
            dataGridView3.Hide();
            label1.Show();
            textBox1.Show();
            pictureBox6.Show();
            pictureBox7.Show();
        }

        private void button2up_Click(object sender, EventArgs e)
        {
            button2up.BackColor = Color.White;
            button2up.ForeColor = System.Drawing.ColorTranslator.FromHtml("#015963");
            button1add.BackColor = System.Drawing.ColorTranslator.FromHtml("#00ABB2");
            button1add.ForeColor = Color.White;
            button3rem.BackColor = System.Drawing.ColorTranslator.FromHtml("#00ABB2");
            button3rem.ForeColor = Color.White;
            dataGridView1.Hide();
            dataGridView2.Show();
            dataGridView3.Hide();
            label1.Hide();
            textBox1.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            var database = new Database();
            if (database.connect_db())
            {
                string query = "select stocks.product_code, products.product_name, products.manufacturer, stocks.selling_price, stocks.exp_date, stocks.quantity from stocks, products where stocks.product_code=products.product_code && stocks.quantity<20";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridView2.DataSource = bindingSource;

                database.close_db();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button3rem_Click(object sender, EventArgs e)
        {

            button3rem.BackColor = Color.White;
            button3rem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#015963");
            button1add.BackColor = System.Drawing.ColorTranslator.FromHtml("#00ABB2");
            button1add.ForeColor = Color.White;
            button2up.BackColor = System.Drawing.ColorTranslator.FromHtml("#00ABB2");
            button2up.ForeColor = Color.White;
            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Show();
            label1.Hide();
            textBox1.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();

            var database = new Database();
            DateTime currentDate = DateTime.Now;
            string date = currentDate.ToString("yyyy-MM-dd");
            if (database.connect_db())
            {
                string query = "select stocks.product_code, products.product_name, products.manufacturer, stocks.selling_price, stocks.exp_date, stocks.quantity from stocks, products where stocks.product_code=products.product_code && stocks.exp_date< '" + date + "' ";
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            var database = new Database();
            if (database.connect_db())
            {
                string productCode = textBox1.Text;
                string query = "select stocks.product_code, products.product_name, products.manufacturer, stocks.selling_price, stocks.exp_date, stocks.quantity from stocks, products where stocks.product_code=products.product_code && stocks.product_code=" + productCode + " ";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridView1.DataSource = bindingSource;

                database.close_db();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "select stocks.product_code, products.product_name, products.manufacturer, stocks.selling_price, stocks.exp_date, stocks.quantity from stocks, products where stocks.product_code=products.product_code";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridView1.DataSource = bindingSource;

                database.close_db();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void itemManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        private void monitorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }
    }
}
