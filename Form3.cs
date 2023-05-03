using Google.Protobuf;
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

namespace Assignment_ES
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Size = new Size(287, 36);
            textBox1.AutoSize = false;
            textBox2.Size = new Size(287, 36);
            textBox2.AutoSize = false;
            textBox3.Size = new Size(287, 36);
            textBox3.AutoSize = false;
            textBox4.Size = new Size(287, 36);
            textBox4.AutoSize = false;
            textBox5.Size = new Size(287, 36);
            textBox5.AutoSize = false;
            textBox6.Size = new Size(287, 36);
            textBox6.AutoSize = false;
            textBox5.Hide();
            textBox6.Hide();
            label3.Hide();
            label4.Hide();
            button4.Show();
            button1.Hide();
            button2.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1add.BackColor = Color.White;
            button1add.ForeColor = System.Drawing.ColorTranslator.FromHtml("#015963");
            button2up.BackColor = System.Drawing.ColorTranslator.FromHtml("#00ABB2");
            button2up.ForeColor = Color.White;
            button3rem.BackColor = System.Drawing.ColorTranslator.FromHtml("#00ABB2");
            button3rem.ForeColor = Color.White;
            textBox5.Hide();
            textBox6.Hide();
            label3.Hide();
            label4.Hide();
            label6.Text = "Manufacturer";
            label7.Text = "Product Name";
            label6.Show();
            label7.Show();
            button4.Show();
            button1.Hide();
            button2.Hide();
            textBox2.Show();
            textBox3.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2up.BackColor = Color.White;
            button2up.ForeColor = System.Drawing.ColorTranslator.FromHtml("#015963");
            button1add.BackColor = System.Drawing.ColorTranslator.FromHtml("#00ABB2");
            button1add.ForeColor = Color.White;
            button3rem.BackColor = System.Drawing.ColorTranslator.FromHtml("#00ABB2");
            button3rem.ForeColor = Color.White;
            label6.Text = "Exp. Date";
            label7.Text = "Unit cost";
            textBox5.Show();
            textBox6.Show();
            label3.Show();
            label4.Show();
            label6.Show();
            label7.Show();
            textBox2.Show();
            textBox3.Show();

            button4.Hide();
            button1.Show();
            button2.Hide();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3rem.BackColor = Color.White;
            button3rem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#015963");
            button1add.BackColor = System.Drawing.ColorTranslator.FromHtml("#00ABB2");
            button1add.ForeColor = Color.White;
            button2up.BackColor = System.Drawing.ColorTranslator.FromHtml("#00ABB2");
            button2up.ForeColor = Color.White;
            label6.Hide();
            label7.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox5.Hide();
            textBox6.Hide();
            label3.Hide();
            label4.Hide();
            button4.Hide();
            button1.Hide();
            button2.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=sunethra_pharmacy; password=";
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

                string date = textBox4.Text.ToString();
                DateTime dt = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                string product_code = textBox1.Text.ToString();
                string manufacturer = textBox2.Text.ToString();
                string name = textBox3.Text.ToString();
                if (date.Length == 0 || product_code.Length == 0 || manufacturer.Length == 0 || name.Length == 0)
                {
                    MessageBox.Show("No empty feilds allowed");
                }
                else
                {

                    mySqlConnection.Open();
                    string query = "INSERT INTO products (date, product_code, manufacturer, product_name) VALUES (@date, @product_code, @manufacturer, @name)";
                    using (MySqlCommand cmd = new MySqlCommand(query, mySqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@date", dt);
                        cmd.Parameters.AddWithValue("@product_code", product_code);
                        cmd.Parameters.AddWithValue("@manufacturer", manufacturer);
                        cmd.Parameters.AddWithValue("@name", name);
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
    }
}
