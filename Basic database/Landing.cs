using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_database
{
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }
        
        AddStudent As = new AddStudent();
        private void button1_Click(object sender, EventArgs e)
        {
            As.Show();
            this.Hide();
        }
        Editstudent Es = new Editstudent();
        private void button2_Click(object sender, EventArgs e)
        {
            Es.Show();
            this.Hide();
        }
        remove_student Rs = new remove_student();
        private void button3_Click(object sender, EventArgs e)
        {
            Rs.Show();
            this.Hide();
        }
    }
}
