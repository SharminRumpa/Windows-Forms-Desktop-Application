using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDesktopProject
{
    public partial class Book : Form
    {

        string con = @"Data Source=.\sqlexpress;Initial Catalog=LibraryManagementBD;Integrated Security=True";

        string filePath = "";

        public Book()
        {
            InitializeComponent();
        }






        private void Book_Load(object sender, EventArgs e)
        {




            string query = @" SELECT [FacultyID],[FacultyName] FROM [dbo].[Faculty]";
            DataTable dt = fillData(query);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "FacultyName";
            comboBox1.ValueMember = "FacultyID";


            dataGridView1.DataSource = fillData(@"SELECT BookID, BookTitle, AuthorName, ISBN, NoOfPage, ImageFile, Books.FacultyID, FacultyName " +
                "FROM Books JOIN Faculty ON Books.FacultyID = Faculty.FacultyID;");


        }


        private DataTable fillData(string query)
        {

            using (SqlConnection conn = new SqlConnection(con))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {

                    da.SelectCommand = new SqlCommand(query, conn);
                    da.SelectCommand.CommandType = CommandType.Text;

                    DataSet ds = new DataSet();
                    try
                    {
                        da.Fill(ds, "BooksDetails");
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    if (ds.Tables.Count == 0)
                    {
                        DataTable dt = new DataTable();
                        ds.Tables.Add(dt);
                    }
                    return ds.Tables[0];

                }
            }
        }





        private void InsertB_Click(object sender, EventArgs e)
        {

            string queryInsert = @"INSERT INTO [dbo].[Books]
           ([BookTitle]
           ,[AuthorName]
           ,[ISBN]
           ,[NoOfPage]
           ,[FacultyID]
           ,[ImageFile]) VALUES('" + textBox2.Text + "','" + textBox3.Text + "' ,'" + textBox4.Text + "' ," + textBox5.Text + " ," + comboBox1.SelectedValue + " ,'" + pictureBox1.ImageLocation + "')";

            DataTable dtInsert = fillData(queryInsert);


            dataGridView1.DataSource = fillData(@"SELECT BookID, BookTitle, AuthorName, ISBN, NoOfPage, ImageFile, Books.FacultyID, FacultyName " +
                "FROM Books JOIN Faculty ON Books.FacultyID = Faculty.FacultyID;");


        }

        private void updateB_Click(object sender, EventArgs e)
        {

            string queryupdate = @"update Books set BookTitle ='" + textBox2.Text + "', AuthorName ='" + textBox3.Text + "', ISBN ='" + textBox4.Text + "', NoOfPage ='" + textBox5.Text + "', FacultyID ='" + comboBox1.SelectedValue + "', ImageFile ='" + pictureBox1.Image + "'  where BookId = " + textBox1.Text + "";
            DataTable dtInsert = fillData(queryupdate);


            dataGridView1.DataSource = fillData(@"SELECT BookID, BookTitle, AuthorName, ISBN, NoOfPage, ImageFile, Books.FacultyID, FacultyName " +
                 "FROM Books JOIN Faculty ON Books.FacultyID = Faculty.FacultyID;");


        }

        private void delectB_Click(object sender, EventArgs e)
        {
            SqlConnection cons = new SqlConnection(con);
            cons.Open();
            SqlCommand cmd = cons.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Books where BookId ='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            cons.Close();

            dataGridView1.DataSource = fillData(@"SELECT BookID, BookTitle, AuthorName, ISBN, NoOfPage, ImageFile, Books.FacultyID, FacultyName " +
                            "FROM Books JOIN Faculty ON Books.FacultyID = Faculty.FacultyID;");




        }



        private void uploadF_Click(object sender, EventArgs e)
        {

            OpenFileDialog op1 = new OpenFileDialog();
            op1.Multiselect = false;
            op1.ShowDialog();
            op1.Filter = "allfiles|*";
            lab.Text = op1.FileName;
            pictureBox1.ImageLocation = lab.Text;


            int count = 0;
            string[] FName;
            foreach (string s in op1.FileNames)
            {
                FName = s.Split('\\');
                File.Copy(s, "D:\\" + FName[FName.Length - 1], true);
                filePath = "D:\\" + FName[FName.Length - 1];
                count++;
            }

            MessageBox.Show(Convert.ToString(count) + " File(s) copied");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
