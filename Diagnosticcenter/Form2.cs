using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;



namespace Diagnosticcenter
{
    public partial class Login : Form
    {
       // Login loginform;
        DatabaseConnection objconnect;
        public string constring = "Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True";
       // DataSet ds;
       // DataRow drow;
        //int maxrows;
       // inc inc = 0;



        public Login()
        {
            Thread t = new Thread(new ThreadStart(Startform));
            t.Start();
            Thread.Sleep(100);
            InitializeComponent();
            t.Abort();
        }

       public void Startform()
        {
            //Application.Run(new Form1());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Form3 sin = new Form3();
            sin.Show();*/
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                objconnect = new DatabaseConnection();
                objconnect.Connection_String = constring;
                
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            /*textBox1.Text = bunifuMaterialTextbox1.Text;
            SqlConnection sqlcon = new SqlConnection(@"Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True");

            string query = "select* from [Staffdetails] where [Username]='" + bunifuMaterialTextbox1.Text.ToString() + "' and [Password]='" + bunifuMaterialTextbox2.Text.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtb1 = new DataTable();
            sda.Fill(dtb1);
            if (dtb1.Rows.Count == 1)
            {

                Form4 f4 = new Form4();
                f4.var = this.textBox1.Text;
                f4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check Your Username and Password");
            }*/
            
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = bunifuMaterialTextbox1.Text;
            SqlConnection sqlcon = new SqlConnection(@"Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True");

            string query = "select* from [Staffdetails] where [Username]='" + bunifuMaterialTextbox1.Text.ToString() + "' and [Password]='" + bunifuMaterialTextbox2.Text.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtb1 = new DataTable();
            sda.Fill(dtb1);
            if (dtb1.Rows.Count == 1)
            {
                
                Form7 f7 = new Form7();
                f7.varx = this .textBox1.Text;
                f7.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check Your Username and Password");
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 sin = new Form3();
            sin.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
           // bunifuMaterialTextbox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
           // bunifuMaterialTextbox1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#004559");

        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            //bunifuMaterialTextbox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            //bunifuMaterialTextbox2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#004559");
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            //bunifuMaterialTextbox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#004559");
            //bunifuMaterialTextbox1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
        }

        private void bunifuMaterialTextbox2_Leave(object sender, EventArgs e)
        {
            //bunifuMaterialTextbox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#004559");
            //bunifuMaterialTextbox2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            //button1.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            //button1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#004559");
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            //button1.BackColor = System.Drawing.ColorTranslator.FromHtml("#004559");
           // button1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
        }

        private void button2_Enter(object sender, EventArgs e)
        {
            //button2.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            //button2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#004559");
        }

        private void button2_Leave(object sender, EventArgs e)
        {
           // button2.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            //button2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#004559");
        }

        private void bunifuMaterialTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar)==13)
            {
                button1_Click(sender, e);
            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

            

        }
    }
}
