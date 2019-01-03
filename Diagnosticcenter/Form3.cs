using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Diagnosticcenter
{
    public partial class Form3 : Form
    {   
       
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;
        int em = 1;
        public Form3()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if ((bunifuMaterialTextbox1.Text.Length > 0) && (bunifuMaterialTextbox2.Text.Length > 0) && (bunifuMaterialTextbox3.Text.Length > 0) && (bunifuMaterialTextbox4.Text.Length > 0) && (bunifuMaterialTextbox5.Text.Length > 0) && (bunifuMaterialTextbox6.Text.Length > 0) && (bunifuMaterialTextbox7.Text.Length > 0))
            {
                con = new SqlConnection(@"Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("INSERT INTO Staffdetails (Name,Phoneno,MailID,Qualification,DOB,Profession,Username,Password) VALUES(@Name,@Phoneno,@MailID,@Qualification,@DOB,@Profession,@Username,@Password)", con);

                cmd.Parameters.AddWithValue("@Name", bunifuMaterialTextbox1.Text);
                // MessageBox.Show("Insert is done");
                cmd.Parameters.AddWithValue("@Phoneno", bunifuMaterialTextbox2.Text);
                // MessageBox.Show("Insert is done");
                cmd.Parameters.AddWithValue("@MailID", bunifuMaterialTextbox3.Text);
                // MessageBox.Show("Insert is done");
                cmd.Parameters.AddWithValue("@Qualification", bunifuMaterialTextbox4.Text);
                // MessageBox.Show("Insert is done");
                cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Text);
                // MessageBox.Show("Insert is done");
                cmd.Parameters.AddWithValue("@Profession", bunifuMaterialTextbox5.Text);
                // MessageBox.Show("Insert is done");
                cmd.Parameters.AddWithValue("@Username", bunifuMaterialTextbox6.Text);
                // MessageBox.Show("Insert is done");
                cmd.Parameters.AddWithValue("@Password", bunifuMaterialTextbox7.Text);
                // MessageBox.Show("Insert is done");
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Insert is done");
                this.Hide();
                Login lg = new Login();
                lg.Show();
            }
            else
            {
                MessageBox.Show("fill all the entries");
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Text = "";
            bunifuMaterialTextbox2.Text = "";
            bunifuMaterialTextbox3.Text = "";
            bunifuMaterialTextbox4.Text = "";
            bunifuMaterialTextbox5.Text = "";
            bunifuMaterialTextbox6.Text = "";
            bunifuMaterialTextbox7.Text = "";


            //this.Hide();
            //Login lg = new Login();
            //lg.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = ! (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter number only");
            }
        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void bunifuMaterialTextbox3_Leave(object sender, EventArgs e)
        {
            String reg1 = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex regexVeh = new Regex(reg1, RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.CultureInvariant | RegexOptions.Compiled);
            Match match = regexVeh.Match(bunifuMaterialTextbox3.Text.Trim());
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

        private void bunifuMaterialTextbox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter character only");
            }
        }

        private void bunifuMaterialTextbox2_Leave(object sender, EventArgs e)
        {
            Regex pattern = new Regex(@"^((\+){0,1}91(\s){0,1}(\-){0,1}(\s){0,1}){0,1}9[0-9](\s){0,1}(\-){0,1}(\s){0,1}[1-9]{1}[0-9]{7}$");
            if (pattern.IsMatch(bunifuMaterialTextbox2.Text))
            {
               // MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Invalid phone number");
            }
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
