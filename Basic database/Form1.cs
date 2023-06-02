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

namespace Basic_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Landing landing = new Landing();

        private void button1_Click(object sender, EventArgs e)
            
        {
        {try

            {
                string username = textBox1.Text;
                string password = textBox2.Text;

                SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @"E:\MY FILES\PROJECTS\VisualStudio\basic database\Basic database\Database1.mdf" + ";Integrated Security=True");
                sqlConnection.Open();
                string query = " SELECT password FROM users WHERE username= '" + username + "'";
                SqlCommand command = new SqlCommand(query,sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                string pass = reader["password"].ToString();
                if (password == pass)
                {
                    landing.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(" Username or password incorrect");
                }
                sqlConnection.Close();

            }  catch (Exception ex)

                {
                    MessageBox.Show(" Username or password incorrect");
                }

        }




        } 
            

    }
}
