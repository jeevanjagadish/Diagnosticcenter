using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Diagnosticcenter
{
    public partial class Form12 : Form
    {
        public static string pt2,pt3,pt4;
        public Form12()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter number only");
            }

           
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            if(str.Length == 10)
            {
               // MessageBox.Show("invalid no");
            }
            else
            {
                MessageBox.Show("Invalid phone no ");
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if ((textBox1.TextLength > 0))
            {
                SqlConnection con = new SqlConnection(@"Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True");
                con.Open();
                string q1 = "select * from Registration where Phoneno='" + textBox1.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(q1, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox2.Text = reader["Patientname"].ToString();
                    textBox3.Text = reader["Sex"].ToString();
                    textBox4.Text = reader["Phoneno"].ToString();
                    reader.Close();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Patient not found");
                }
            }
            else
            {
                MessageBox.Show("enter the phone no");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pt2 = textBox2.Text;
            pt3 = textBox3.Text;
            pt4 = textBox4.Text;
            Form4 f4 = new Form4();
            f4.Show();
        }
    }
}
