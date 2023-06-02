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
    public partial class remove_student : Form
    {
        public remove_student()
        {
            InitializeComponent();
        }

        private void remove_student_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @"E:\MY FILES\PROJECTS\VisualStudio\basic database\Basic database\Database1.mdf" + ";Integrated Security=True");
            sqlConnection.Open();
            string query = "SELECT name FROM students";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name = reader["Name"].ToString();
                comboBox1.Items.Add(name);
            }
            sqlConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = comboBox1.SelectedItem.ToString();
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @"E:\MY FILES\PROJECTS\VisualStudio\basic database\Basic database\Database1.mdf" + ";Integrated Security=True");
            sqlConnection.Open();
            string sqlquery = "DELETE FROM students WHERE name='" + name + "'";
            SqlCommand command = new SqlCommand(sqlquery, sqlConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("deleted");
            sqlConnection.Close();
        }
        
        private void remove_student_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
