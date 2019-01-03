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
    public partial class Form10 : Form
    {
        DatabaseConnection objconnect;
     //  public String constring = "Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True";
        DataSet ds;
        int maxrows;
        int inc = 0;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        int em = 1;



        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        { 
            SqlConnection con = new SqlConnection (@"Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True");
            con.Open();
            label14.Visible = true;

            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max(cast(DoctorID as int)),0)+1 from Refdoc", con);
            DataTable dtx = new DataTable();
            sda.Fill(dtx);
            label14.Text = dtx.Rows[0][0].ToString();
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Visible = true;
            //SqlDataAdapter sda = new SqlDataAdapter("select isnull(max(cast(DoctorID as int)),00)+1 from Refdoc", constring);
           // DataTable dt = new DataTable();
         // sda.Fill(dt);
           // textBox1.Text = dt.Rows[0][0].ToString();

            if ((textBox2.TextLength > 0) && (textBox3.TextLength > 0) && (textBox4.TextLength > 0) && (textBox5.TextLength > 0) && (textBox6.TextLength > 0) && (textBox7.TextLength > 0))
            {
                String q = "select * from [Refdoc] where [DoctorID]='" + label14.Text.ToString() + "'";
        
                
                if (maxrows == 1)
                {
                   // MessageBox.Show("doctor id exist", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    try
                    {
                        con = new SqlConnection(@"Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True");
                        con.Open();
                        cmd = new SqlCommand("insert into Refdoc(DoctorID,Name,Address,Contactno,EMail,Orgname,Compensation) values (@DoctorID,@Name,@Address,@Contactno,@EMail,@Orgname,@Compensation)", con);

                        cmd.Parameters.AddWithValue("@DoctorID", label14.Text);
                        cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                        cmd.Parameters.AddWithValue("@Address", textBox3.Text);
                        cmd.Parameters.AddWithValue("@Contactno", textBox4.Text);
                        cmd.Parameters.AddWithValue("@EMail", textBox5.Text);
                        cmd.Parameters.AddWithValue("@Orgname", textBox6.Text);
                        cmd.Parameters.AddWithValue("@Compensation", textBox7.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();


                        MessageBox.Show("Registered successfully");
              

                    }
                    catch(Exception er)
                    {
                        MessageBox.Show("doctor exist","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }

                }
            }

            else
            {

                MessageBox.Show("fill required field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
           // textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter character only");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter number only");
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            String reg1 = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex regexVeh = new Regex(reg1, RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.CultureInvariant | RegexOptions.Compiled);
            Match match = regexVeh.Match(textBox5.Text.Trim());
            if (match.Success)
            {
                em = 0;
            }
            else
            {
                MessageBox.Show("Enter the valid email ID" + Environment.NewLine + "(Ex: abc@gmail.com)", "Information Details");
                em = 1;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter number only");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            Regex pattern = new Regex(@"^((\+){0,1}91(\s){0,1}(\-){0,1}(\s){0,1}){0,1}9[0-9](\s){0,1}(\-){0,1}(\s){0,1}[1-9]{1}[0-9]{7}$");
            if (pattern.IsMatch(textBox4.Text))
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
