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
    public partial class Faculty : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=LibraryManagementBD;Integrated Security=True;");
        public Faculty()
        {
            InitializeComponent();
        }

        private void Faculty_Load(object sender, EventArgs e)
        {
            Display();

        }

        private void Display()
        {
            con.Open();
            SqlCommand cm = con.CreateCommand();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from Faculty";
            cm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void InsertF_Click(object sender, EventArgs e)
        {
           
            con.Open();
            SqlCommand cm = con.CreateCommand();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "insert into Faculty values ('" + textBox2.Text + "')";
            cm.ExecuteNonQuery();
            con.Close();
            Display();

        }

        private void updateF_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cm = con.CreateCommand();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "update Faculty set FacultyName ='" + textBox2.Text + "' where FacultyID = " + textBox1.Text + "";
            cm.ExecuteNonQuery();
            con.Close();
            Display();

        }

        private void delectF_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cm = con.CreateCommand();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "delete from Faculty where FacultyID = " + textBox1.Text + "";
            cm.ExecuteNonQuery();
            con.Close();
            Display();

        }
    }
}
