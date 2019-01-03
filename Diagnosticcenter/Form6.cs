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

namespace Diagnosticcenter
{
    public partial class Form6 : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;
        SqlDataAdapter sda;
        public String constring = "Data Source = dell; Initial Catalog = Diagnosticcenter; Integrated Security = True";

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.TextLength > 0) && (textBox2.TextLength > 0) && (textBox11.TextLength > 0))
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                String query = "update [Staffdetails] set [Password]='" + textBox11.Text.ToString() + "' where [Username]='" + textBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                if (textBox11.Text != textBox1.Text)
                {
                    MessageBox.Show("check your password");
                }
                else
                {
                    MessageBox.Show("successfully updated", "password changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Login lg = new Login();
                    lg.Show();

                }
            }
            else
            {
                MessageBox.Show("enter all the required fields ");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to Cancel?","Cancel",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Login lg = new Login();
                lg.Show();
                this.Hide();
           }
            else
            {
                this.Activate();
            }
        }
    }
}
