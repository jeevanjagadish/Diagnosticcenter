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
    public partial class Form8 : Form
    {
        
        SqlCommand cmd,dj;
      // public String conString = "Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True";
        SqlConnection con;
        DatabaseConnection objconnect;
        SqlDataAdapter sda;
        DataSet ds;
        int maxrows;
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True");

            con.Open();
            label1.Visible = true;
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max(cast(Testcode as int)),0)+1 from Addtest1", con);
            DataTable dtx = new DataTable();
            sda.Fill(dtx);
            label8.Text = dtx.Rows[0][0].ToString();


            
            if ((textBox1.TextLength > 0)  && (comboBox1.SelectedIndex >= 0) && (textBox3.TextLength > 0)) 
            {
                con = new SqlConnection(@"Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True");
                con.Open();
                 string dj = ("select * from [Addtest1] where [Testname]='" + textBox1.Text.ToString() + "'");
                SqlDataAdapter da = new SqlDataAdapter(dj, con);
                SqlCommand jeev = new SqlCommand(dj, con);
                jeev.ExecuteNonQuery();
                DataTable dtb1 = new DataTable();
                da.Fill(dtb1);
                if (dtb1.Rows.Count == 1)
                {
                    
      
                   MessageBox.Show("Test already exist");
                    
                }
                else
                {
                    try
                    {
                       
                        cmd = new SqlCommand("Insert into Addtest1 (Testname,Testcode,Department,Testamount) Values (@Testname,@Testcode,@Department,@Testamount)", con);

                        cmd.Parameters.AddWithValue("@Testname", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Testcode", label8.Text);
                        cmd.Parameters.AddWithValue("@Department", comboBox1.SelectedItem);
                        cmd.Parameters.AddWithValue("@Testamount", textBox3.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Insert is done successfully");
                    }
                    catch(Exception er)
                    {
                       // MessageBox.Show(er.Message);
                        MessageBox.Show("done");
                    }
                }
               
            }
            else
            {
                MessageBox.Show("fill all the required fields");
            }
        
            
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            //textBox2.Clear();
            textBox3.Clear();
            comboBox1.ResetText();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter character only");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter number only");
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                int i;
                if (int.TryParse(tb.Text, out i))
                {
                    if (i >= 0 && i <= 3000)
                        return;
                }
            }
            MessageBox.Show("Check the Amount");
           // e.Cancel = true;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True");

            con.Open();
            label1.Visible = true;
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max(cast(Testcode as int)),0)+1 from Addtest1", con);
            DataTable dtx = new DataTable();
            sda.Fill(dtx);
            label8.Text = dtx.Rows[0][0].ToString();
            con.Close();
        }
    }
}
