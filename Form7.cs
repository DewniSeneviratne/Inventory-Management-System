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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
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

                dataGridView1.DataSource = bindingSource;

                database.close_db();

            }
            else
            {
                MessageBox.Show("Error");
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
