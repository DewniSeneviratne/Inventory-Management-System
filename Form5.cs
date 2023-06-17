using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            textBox1.Size = new Size(287, 36);
            textBox1.AutoSize = false;
            textBox2.Size = new Size(287, 56);
            textBox2.AutoSize = false;
            textBox3.Size = new Size(287, 36);
            textBox3.AutoSize = false;
            textBox4.Size = new Size(287, 36);
            textBox4.AutoSize = false;
            textBox5.Size = new Size(287, 36);
            textBox5.AutoSize = false;
            textBox6.Size = new Size(287, 36);
            textBox6.AutoSize = false;
            label2.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            richTextBox1.Hide();
            richTextBox2.Hide();
            button4.Hide();
            dataGridView3.DefaultCellStyle.Font = new Font("Arial", 13);
            dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 13);

            button1.Hide();

        }

        public void loadData()
        {

            var database = new Database();
            if (database.connect_db())
            {
                string query = "select name, address, phone_number, selling_brands, email from suppliers";

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
            dataGridView3.Show();
            textBox1.Show();
            pictureBox6.Show();
            pictureBox7.Show();
            label3.Show();
            label2.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            richTextBox1.Hide();
            richTextBox2.Hide();
            button4.Hide();
            loadData();
            button1.Hide();
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
            pictureBox6.Hide();
            pictureBox7.Hide();
            label3.Hide();

            label2.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();
            textBox5.Show();
            textBox6.Show();
            richTextBox1.Show();
            richTextBox2.Show();
            button4.Show();
            button1.Hide();

        }

        private void button3rem_Click(object sender, EventArgs e)
        {
            button3rem.BackColor = Color.White;
            button3rem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#015963");
            button1add.BackColor = System.Drawing.ColorTranslator.FromHtml("#00ABB2");
            button1add.ForeColor = Color.White;
            button2up.BackColor = System.Drawing.ColorTranslator.FromHtml("#00ABB2");
            button2up.ForeColor = Color.White;
            label2.Show();
            label4.Show();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Show();
            textBox5.Hide();
            textBox6.Hide();
            richTextBox1.Show();
            richTextBox2.Hide();
            button4.Hide();
            label2.Text = "Supplier ID :";
            label4.Text = "Supplier Name :";
            button1.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            var database = new Database();
            if (database.connect_db())
            {
                string supplierCode = textBox1.Text;
                string query = "select name, address, phone_number, selling_brands, email from suppliers where supplier_ID=" + supplierCode + "";

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

        private void button4_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=sunethra_pharmacy; password=";
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);


                string name = textBox4.Text.ToString();
                string address = richTextBox1.Text.ToString();
                string phone = textBox2.Text.ToString();
                string account = textBox3.Text.ToString();
                string bank = textBox5.Text.ToString();
                string brands = richTextBox2.Text.ToString();
                string email = textBox6.Text.ToString();
                if (name.Length == 0 || address.Length == 0 || phone.Length == 0 || account.Length == 0 || bank.Length == 0 || brands.Length == 0 || email.Length == 0)
                {
                    MessageBox.Show("No empty feilds allowed");
                }
                else
                {

                    mySqlConnection.Open();
                    string query = "INSERT INTO suppliers (name, address, phone_number, account_number, bank_name, selling_brands, email) VALUES (@name, @address, @phone, @account, @bank, @brands, @email)";
                    using (MySqlCommand cmd = new MySqlCommand(query, mySqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@account", account);
                        cmd.Parameters.AddWithValue("@bank", bank);
                        cmd.Parameters.AddWithValue("@brands", brands);
                        cmd.Parameters.AddWithValue("@email", email);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record added successfully");
                        }
                        else
                        {
                            MessageBox.Show("Record not added");
                        }
                    }

                    mySqlConnection.Close();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=sunethra_pharmacy; password=";
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

                string supId = textBox4.Text.ToString();
                string SupName = richTextBox1.Text.ToString();

                if (supId.Length == 0 || SupName.Length == 0)
                {
                    MessageBox.Show("No empty feilds allowed");
                }
                else
                {

                    mySqlConnection.Open();
                    string query = "delete from suppliers where supplier_ID=" + supId + "";

                    MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Supplier Deleted Successfully");
                    mySqlConnection.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
