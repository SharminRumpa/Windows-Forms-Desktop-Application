using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDesktopProject
{
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=LibraryManagementBD;Integrated Security=True;");

        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Field can not be empty");
            }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Password not match.");
            }
            else
            {

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT into Login values ('" + textBox1.Text + "', '" + textBox2.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Wellcome " + textBox1.Text + "! You are Registrated Successfully");

                Login firstPage = new Login();
                this.Hide();
                firstPage.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            this.Hide();
            form1.Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
