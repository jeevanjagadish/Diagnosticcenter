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
    public partial class Form5 : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;
        SqlDataAdapter sda;

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.TextLength > 0)&& (dateTimePicker1.Value.ToString() == ""))
            {


                SqlConnection con = new SqlConnection(@"Data Source = dell; Initial Catalog = Diagnosticcenter; Integrated Security = True");
                string query = "select * from [Staffdetails] where [DOB]='" + dateTimePicker1.Text.ToString() + "' and [Phoneno] = '" + textBox1.Text.ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtb1 = new DataTable();
                sda.Fill(dtb1);
                if (dtb1.Rows.Count == 1)
                {
                    Form6 f6 = new Form6();
                    f6.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Unauthorized Access");
                }
            }
            else
            {
                MessageBox.Show("enter the fields");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Regex pattern = new Regex(@"^((\+){0,1}91(\s){0,1}(\-){0,1}(\s){0,1}){0,1}9[0-9](\s){0,1}(\-){0,1}(\s){0,1}[1-9]{1}[0-9]{7}$");
            if (pattern.IsMatch(textBox1.Text))
            {
                // MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Invalid phone number");
            }
        }
    }
}
