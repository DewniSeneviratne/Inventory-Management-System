using MySql.Data.MySqlClient;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment_ES
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();


        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Size = new Size(415, 83);
            textBox2.Size = new Size(415, 83);
            textBox1.AutoSize = false;
            textBox2.AutoSize = false;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string mysqlCon = "server=127.0.0.1; user=root; database=sunethra_pharmacy; password=";
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

                string uname = textBox1.Text.ToString();
                string password = textBox2.Text.ToString();
                if (uname.Length == 0 || password.Length == 0)
                {
                    MessageBox.Show("No empty feilds allowed");
                }
                else
                {

                    mySqlConnection.Open();


                    MySqlCommand mySqlCommand = new MySqlCommand("select * from users", mySqlConnection);

                    MySqlDataReader reader = mySqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        if (uname.Equals(reader.GetString("username")) && password.Equals(reader.GetString("password")))
                        {
                            Form2 f = new Form2();
                            this.Hide();
                            f.Show();

                        }
                        else
                        {
                            MessageBox.Show("Invalid login");
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