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
    public partial class Form9 : Form
    {
        DatabaseConnection objconnect;
        public String conString = "Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True";
        DataSet ds;
        DataRow drow;
        int maxrows;
        int inc = 0;
        public Form9()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            objconnect = new DatabaseConnection();
            objconnect.Connection_String = conString;
            textBox1.Text = Class1.UserName;
           // textBox1.Enabled = false;
            textBox2.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.TextLength > 0) && (textBox2.TextLength > 0) && (textBox3.TextLength > 0) && (textBox4.TextLength > 0) && (textBox5.TextLength > 0))
            {
                objconnect.Sql = " select [Password] from [Staffdetails] where [Username]='" + textBox1.Text + "'";
                //  ds = objconnect.GetConnection;
                // drow = ds.Tables[0].Rows[0];
                if (textBox3.TextLength > 0)
                {
                    if ((textBox4.Text == textBox5.Text) && (textBox4.TextLength > 0))
                    {
                        SqlConnection con = new SqlConnection(conString);
                        con.Open();
                        if (con.State == System.Data.ConnectionState.Open)
                        {
                            String q = "update [Staffdetails] set [Password]='" + textBox4.Text.ToString() + "' where [Username]='" + textBox1.Text + "'";
                            SqlCommand cmd = new SqlCommand(q, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("successfully  updated", "Password changed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        if (textBox1.Text != textBox2.Text)
                        {
                            MessageBox.Show("Do you want to change your Username", "Username", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (DialogResult == DialogResult.Yes)
                            {
                                SqlConnection con1 = new SqlConnection(conString);
                                con.Open();
                                if (con.State == System.Data.ConnectionState.Open)
                                {
                                    String q = "update [Staffdetails] set [Username]='" + textBox2.Text.ToString() + "' where [Username]'" + textBox1.Text + "'";

                                    SqlCommand cmd = new SqlCommand(q, con);
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("successfullly updated", "Username changed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mismatch of passwords", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Please check your current passwords", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
            }
            else
            {
                MessageBox.Show("enter all the requried fields");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            
                
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();

        }
    }
}
