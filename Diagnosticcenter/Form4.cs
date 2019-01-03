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
using System.Diagnostics;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;

namespace Diagnosticcenter
{
    public partial class Form4 : Form
    {
        SqlCommand cmd, cmd1, cmd2, cmd3, cmd4, cmd5, cmd6, cmd12, cmd25, cmd26, cmd27, cmdxxx;
        SqlConnection con;
        SqlDataAdapter sda;
        DataRow drow;
        SqlDataReader dr;
        DataSet ds;
        int maxrows;
        int sum = 0, sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0, sum5 = 0;
        int i = 0;
        int em = 1;
        public String vardj;
        public Form4()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Text = vardj;
            label3.Text = textBox1.Text;

            con = new SqlConnection(@"Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True");
            con.Open();
            label4.Visible = true;
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max(cast(Billno as int)),0)+1 from Registration", con);
            DataTable dtx = new DataTable();
            sda.Fill(dtx);
            label4.Text = dtx.Rows[0][0].ToString();

            label16.Visible = true;
           // SqlDataAdapter sda1 = new SqlDataAdapter("select isnull(max(cast(PatientID as int)),0)+1 from Registration", con);
           // DataTable dt1 = new DataTable();
           // sda1.Fill(dt1);
            label16.Text = "CA"+dtx.Rows[0][0].ToString();

            //search data
            textBox2.Text = Form12.pt2;
            comboBox1.Text = Form12.pt3;
            textBox3.Text = Form12.pt4;

            fillcombobox();
                     panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#0486DB");
            button6.Visible = false;
            button7.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            //bunifuThinButton23.BackColor = System.Drawing.ColorTranslator.FromHtml("#293E6A");
            con = new SqlConnection(@"Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT * from [Staffdetails] where [Username]='" + label3.Text + "'");
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label1.Text = dr.GetString(6);
                label2.Text = dr.GetString(2);
            }

            dr.Close();

            //laboratory
            cmd1 = new SqlCommand("select Testname,Testamount from Addtest1 where Department='Laboratory'");
            cmd1.Connection = con;
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(cmd1);
            sd.Fill(dt);
            for (int x = 0; x < dt.Rows.Count; x++)
            {
                comboBox2.Items.Add(dt.Rows[x]["Testname"].ToString());// + "          " + "                                                                                                                                                                                                                               " + (dt.Rows[x]["Testamount"].ToString()));
            }
            //Ultra sound
            cmd2 = new SqlCommand("select Testname,Testamount from Addtest1 where Department='Ultra sound'");
            cmd2.Connection = con;
            DataTable dt1x = new DataTable();
            SqlDataAdapter sd1 = new SqlDataAdapter(cmd2);
            sd1.Fill(dt1x);
            for (int x = 0; x < dt1x.Rows.Count; x++)
            {
                comboBox3.Items.Add(dt1x.Rows[x]["Testname"].ToString());// + "          "+"                                                                                                                                                                                                                               " + (dt1.Rows[x]["Testamount"].ToString()));
            }

            //X-Ray
            cmd3 = new SqlCommand("select Testname,Testamount from Addtest1 where Department='X-Ray'");
            cmd3.Connection = con;
            DataTable dt2 = new DataTable();
            SqlDataAdapter sd2 = new SqlDataAdapter(cmd3);
            sd2.Fill(dt2);
            for (int x = 0; x < dt2.Rows.Count; x++)
            {
                comboBox7.Items.Add(dt2.Rows[x]["Testname"].ToString());// + "          " + "                                                                                                                                                                                                                               " + (dt2.Rows[x]["Testamount"].ToString()));


            }

            //ECG
            cmd4 = new SqlCommand("select Testname,Testamount from Addtest1 where Department='ECG'");
            cmd4.Connection = con;
            DataTable dt3 = new DataTable();
            SqlDataAdapter sd3 = new SqlDataAdapter(cmd4);
            sd3.Fill(dt3);
            for (int x = 0; x < dt3.Rows.Count; x++)
            {
                comboBox4.Items.Add(dt3.Rows[x]["Testname"].ToString());// + "          " + "                                                                                                                                                                                                                               " + (dt.Rows[x]["Testamount"].ToString()));

            }

            //ECHO
            cmd5 = new SqlCommand("select Testname,Testamount from Addtest1 where Department='ECHO'");
            cmd5.Connection = con;
            DataTable dt4 = new DataTable();
            SqlDataAdapter sd4 = new SqlDataAdapter(cmd5);
            sd4.Fill(dt4);
            for (int x = 0; x < dt4.Rows.Count; x++)
            {
                comboBox5.Items.Add(dt4.Rows[x]["Testname"].ToString());// + "          " + "                                                                                                                                                                                                                               " + (dt.Rows[x]["Testamount"].ToString()));


            }
            //Scan
            cmd6 = new SqlCommand("select Testname,Testamount from Addtest1 where Department='Scan'");
            cmd6.Connection = con;
            DataTable dt5 = new DataTable();
            SqlDataAdapter sd5 = new SqlDataAdapter(cmd6);
            sd5.Fill(dt5);
            for (int x = 0; x < dt5.Rows.Count; x++)
            {
                comboBox8.Items.Add(dt5.Rows[x]["Testname"].ToString());// + "          " + "                                                                                                                                                                                                                               " + (dt.Rows[x]["Testamount"].ToString()));

            }

        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {


        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (panel1.Height == 733 & panel1.Width == 285)
            {
                panel1.Height = 733;
                panel1.Width = 58;
                pictureBox6.Visible = true;
                button7.Visible = false;
                //bunifuThinButton21.Visible = false;
                //bunifuThinButton22.Visible = false;
                // bunifuThinButton23.Visible = false;
                panel6.Visible = false;
                button6.Visible = false;
                label2.Visible = false;
                panel6.Visible = false;
                //label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label44.Visible = true;
                //label27.Visible = true;
                //label26.Visible = true;
                //label25.Visible = true;
                label5.Visible = true;
                label28.Visible = true;
                // label29.Visible = true;
                // label30.Visible = true;
                label6.Visible = true;
                label34.Visible = true;
                label35.Visible = true;
                textBox1.Visible = false;
                //label20.Visible = true;
                //label19.Visible = true;
                //label18.Visible = true;
                // panel7.Visible = true;
                textBox1.Visible = true;
                //textBox10.Visible = true;
                //textBox9.Visible = true;
                //textBox11.Visible = true;
            }
            else
            {
                panel1.Height = 733;
                panel1.Width = 285;
                panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#0486DB");
                button7.Visible = true;
                textBox1.Visible = false;
                pictureBox6.Visible = false;
                //bunifuThinButton21.Visible = true;
                //bunifuThinButton22.Visible = true;
                /// bunifuThinButton23.Visible = true;
                panel6.Visible = true;
                button6.Visible = true;

                panel6.Visible = true;
                //label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                label44.Visible = false;
                //label27.Visible = false;
                //label26.Visible = false;
                //label25.Visible = false;
                label5.Visible = false;
                label28.Visible = false;
                // label29.Visible = false;
                // label30.Visible = false;
                label6.Visible = false;
                label34.Visible = false;
                label35.Visible = false;
                //label20.Visible = false;
                //label19.Visible = false;
                //label18.Visible = false;
                //panel7.Visible = false;
                textBox1.Visible = false;
                //textBox10.Visible = false;
                //textBox9.Visible = false;
                //textBox11.Visible = false;

            }
        }

        private void fillcombobox()
        {
            try
            {
                con = new SqlConnection(@"Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Name from Refdoc";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox6.Items.Add(dr["Name"].ToString());
                }


                con.Close();
            }
            catch (Exception er)
            {
                //exception  message
            }


        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to signout?", "infor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                this.Hide();
                Form7 f =new  Form7();
                f.Show();
            }
            else
            {
                this.Activate();
            }

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {


            if ((string.IsNullOrEmpty(textBox2.Text)) || (string.IsNullOrEmpty(comboBox1.Text)) || (string.IsNullOrEmpty(textBox3.Text)) || (string.IsNullOrEmpty(textBox4.Text)))
            {
                MessageBox.Show("enter the required fields in Patient information");
            }
            else if((string.IsNullOrEmpty(comboBox6.Text)) )//||  (string.IsNullOrEmpty(textBox8.Text)) || (string.IsNullOrEmpty(textBox9.Text)) || (string.IsNullOrEmpty(textBox10.Text)) || (string.IsNullOrEmpty(textBox15.Text)) || (string.IsNullOrEmpty(textBox14.Text)) || (string.IsNullOrEmpty(textBox15.Text)))
            {
                MessageBox.Show("enter the required fields in Registration information");
            }
            else if ((string.IsNullOrEmpty(textBox11.Text)) || (string.IsNullOrEmpty(comboBox9.Text))) // || (string.IsNullOrEmpty(listBox1.Items.Count()==0))||(string.IsNullOrEmpty(comboBox11.Text)))
            {
                MessageBox.Show("enter the required fields in Billing information");
            }
            else
            {
               
                con = new SqlConnection(@"Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("insert into Registration (Patientname,Sex,Billno,PatientID,Age,Phoneno,RDoctorname,RMailID,RPhoneno,NDoctorname,NPhoneno,NMailID,Regdate,Deldate,Billamount,Discount,Disamount,Advanceamount,Balamount,Totalamount,Amount,Testitem,Testamount,Type)Values (@Patientname,@Sex,@Billno,@PatientID,@Age,@Phoneno,@RDoctorname,@RMailID,@RPhoneno,@NDoctorname,@NPhoneno,@NMailID,@Regdate,@Deldate,@Billamount,@Discount,@Disamount,@Advanceamount,@Balamount,@Totalamount,@Amount,@Testitem,@Testamount,@Type)", con);
                
                cmd.Parameters.AddWithValue("@Patientname", textBox2.Text);
                cmd.Parameters.AddWithValue("@Sex", comboBox1.SelectedItem);
                cmd.Parameters.AddWithValue("@Billno", label4.Text);
                cmd.Parameters.AddWithValue("@PatientID", label16.Text);
                cmd.Parameters.AddWithValue("@Age", textBox4.Text);
                cmd.Parameters.AddWithValue("@Phoneno", textBox3.Text);
                if (string.IsNullOrEmpty(textBox8.Text))
                {
                    cmd.Parameters.AddWithValue("@RDoctorname", comboBox6.SelectedItem);
                    cmd.Parameters.AddWithValue("@RMailID", textBox6.Text);
                    cmd.Parameters.AddWithValue("@RPhoneno", textBox7.Text);
                    cmd.Parameters.AddWithValue("@NDoctorname"," ");
                   cmd.Parameters.AddWithValue("@NPhoneno", " ");
                    cmd.Parameters.AddWithValue("@NMailID", "");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@RDoctorname"," " );
                    cmd.Parameters.AddWithValue("@RMailID", " ");
                    cmd.Parameters.AddWithValue("@RPhoneno", " ");
                    cmd.Parameters.AddWithValue("@NDoctorname", textBox8.Text);
                    cmd.Parameters.AddWithValue("@NPhoneno", textBox9.Text);
                    cmd.Parameters.AddWithValue("@NMailID", textBox10.Text);
                }
                cmd.Parameters.AddWithValue("@Regdate", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@Deldate", dateTimePicker2.Value.Date);
                cmd.Parameters.AddWithValue("@Billamount", textBox13.Text);
                cmd.Parameters.AddWithValue("@Discount", textBox11.Text);
                cmd.Parameters.AddWithValue("@Disamount", textBox18.Text);
                cmd.Parameters.AddWithValue("@Advanceamount", textBox20.Text);
                cmd.Parameters.AddWithValue("@Balamount", textBox21.Text);
                cmd.Parameters.AddWithValue("@Totalamount", textBox22.Text);
                cmd.Parameters.AddWithValue("@Amount", comboBox9.SelectedItem);
                cmd.Parameters.AddWithValue("@Type", comboBox11.SelectedItem);
                string test = "", amt = "";
                for (int i = 0; i < listBox1.Items.Count; i++)
                    test += listBox1.Items[i] + ",";
                for (int i = 0; i < listBox2.Items.Count; i++)
                    amt += listBox2.Items[i] + ",";
                cmd.Parameters.AddWithValue("@Testamount", amt);
                cmd.Parameters.AddWithValue("@Testitem", test);
              cmd.ExecuteNonQuery();
                if (string.IsNullOrEmpty(textBox8.Text))
                {

                }
                else
                {


                    cmd = new SqlCommand("insert into Refdoc(Name,Address,Contactno,EMail,Orgname,Compensation)values(@Name,@Address,@Contactno,@EMail,@Orgname,@Compensation)", con);
                    cmd.Parameters.AddWithValue("@Name", textBox8.Text);
                    cmd.Parameters.AddWithValue("@Address", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Contactno", textBox9.Text);
                    cmd.Parameters.AddWithValue("@EMail", textBox10.Text);
                    cmd.Parameters.AddWithValue("@Orgname", textBox14.Text);
                    cmd.Parameters.AddWithValue("@Compensation", textBox15.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Registrated successfully");
                comboBox6.Items.Clear();
                fillcombobox();
            }

           

        }
        private void label7_Click(object sender, EventArgs e)
        {
           // label7.BackColor = System.Drawing.ColorTranslator.FromHtml("#fafafa");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            /*String q = "select * from [Addtest1] from [Testname]='" + comboBox2.Text.ToString() + "'";
             SqlCommand cmd = new SqlCommand(q, con);
             SqlDataAdapter mr;
             con.Open();
             mr = cmd.ExecuteReader();
             while(mr.read())
             {

             }*/
            SqlCommand cmd2;
            cmd2 = new SqlCommand("select Testamount from Addtest1 where Testname ='" + comboBox2.SelectedItem + "'");
            cmd2.Connection = con;
            DataTable dt3 = new DataTable();
             SqlDataAdapter sd3 = new SqlDataAdapter(cmd2);
             sd3.Fill(dt3);
            /*for (int x = 0; x < dt.Rows.Count; x++)
            {
                comboBox2.Items.Add(dt.Rows[x]["Testname"].ToString() + "           " + "                                                                                                                                                                                                                                " + (dt.Rows[x]["Testamount"].ToString()));
            }
            */
            // SqlDataReader d1 = cmd1.ExecuteReader();
            
            if (dt3.Rows.Count>0)
            {
                // label45.Text= dt3.Rows[0]["Testamount"].ToString();
                listBox1.Items.Add(comboBox2.SelectedItem);
                listBox2.Items.Add(dt3.Rows[0]["Testamount"].ToString());
                
               // sum =sum+ Convert.ToInt32(label45.Text);
            }
           
           
         
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int result = 0;
            for(int i=0; i<listBox2.Items.Count;i++)
            {
                result += Convert.ToInt32(listBox2.Items[i].ToString());
            }
            textBox12.Text = Convert.ToString(result);
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason==CloseReason.UserClosing)
            {
                DialogResult d = MessageBox.Show("Do you want to leave this page?", "info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(d == DialogResult.Yes)
                {
                    Form7 f7 = new Form7();
                    f7.Show();
                    e.Cancel = true;
                    this.Hide();
                   
                }
                else
                {
                    this.Activate();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to go to previous page?", "info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                this.Hide();
                Form7 f7 = new Form7();
                f7.Show();
            }
            else
            {
                this.Activate();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if(textBox12.Text != "" && textBox11.Text != "")
            {
                decimal A = Convert.ToInt32(textBox12.Text) * Convert.ToInt32(textBox11.Text) / 100;
                textBox18.Text = A.ToString();
            }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            if(textBox20.Text !="")
            {
                
                    decimal A = Convert.ToInt32(textBox22.Text) - Convert.ToInt32(textBox20.Text) ;
                    textBox21.Text = A.ToString();
                
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            decimal A = Convert.ToInt32(textBox12.Text) - Convert.ToInt32(textBox18.Text);
            textBox22.Text = A.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.Untitled;
            Image newimage = bmp;
            e.Graphics.DrawImage(newimage, 10, 15, newimage.Width, newimage.Height);
            e.Graphics.DrawString("Patient Name: " + textBox2.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(20, 280));
            e.Graphics.DrawString("phone No: " + textBox3.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(20, 300));
            e.Graphics.DrawString("Age: " + textBox4.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(20, 320));
            e.Graphics.DrawString("sex: " + comboBox1.SelectedItem, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(20, 340));
            e.Graphics.DrawString("Date: " + dateTimePicker1.Value.ToString("yyyy-MM-dd"), new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(410, 280));
            e.Graphics.DrawString("Bill NO: " + label4.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(410, 300));
            if (comboBox6.SelectedItem != "" && textBox8.Text.Length > 1)
            {
                e.Graphics.DrawString("Reffered Doctor Name: " + textBox8.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(410, 320));
            }
            else if (comboBox6.SelectedItem != "" && textBox8.Text != "")
            {
                e.Graphics.DrawString("Reffered Doctor Name: " + "Self", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(410, 320));
            }
            else
            {
                e.Graphics.DrawString("Reffered Doctor Name: " + comboBox6.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(410, 320));
            }
            e.Graphics.DrawString("Reffered Doctor Name: " + comboBox6.SelectedItem, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(410, 320));

            e.Graphics.DrawString(label55.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(20, 360));
           
            e.Graphics.DrawString("Payment method: " + comboBox9.SelectedItem, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(410, 340));
           
            
           
            e.Graphics.DrawString("Test Name ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(20, 380));
            e.Graphics.DrawString("Test Amount", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(400, 380));
            e.Graphics.DrawString("Test State", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(600, 380));


            string test = "", amt = "";
            for (int i = 0; i < listBox1.Items.Count; i++)
                test += listBox1.Items[i] + "\n";
            for (int i = 0; i < listBox2.Items.Count; i++)
                amt += listBox2.Items[i] + "\n";

            e.Graphics.DrawString(test, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(20, 430));
            e.Graphics.DrawString(amt, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(430, 430));
            e.Graphics.DrawString(label21.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(420, 830));
            e.Graphics.DrawString("Total Bill Amount: " +       textBox12.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(240, 850));
            e.Graphics.DrawString(label21.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(420, 870));
            e.Graphics.DrawString(label55.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(20, 880));
            e.Graphics.DrawString(label55.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(20, 890));
            e.Graphics.DrawString("Total Bill Amount: " + textBox12.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(20, 920));
            e.Graphics.DrawString("Discount % / Discount Amount: " + textBox11.Text + "%" + "/" + textBox18.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(20, 940));
            e.Graphics.DrawString("Bill Amount after Discount: " + textBox22.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(20, 960));
            e.Graphics.DrawString("Advance Amount Paid: " + textBox20.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(450, 920));
            e.Graphics.DrawString("Balance Amount Remaining: " + textBox21.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(450, 940));
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter number only");
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter character only");
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            String reg1 = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex regexVeh = new Regex(reg1, RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.CultureInvariant | RegexOptions.Compiled);
            Match match = regexVeh.Match(textBox10.Text.Trim());
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

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter character only");
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter number only");
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter number only");
            }
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
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
            string str = textBox3.Text;
            if (str.Length == 10)
            {
                // MessageBox.Show("invalid no");
            }
            else
            {
                MessageBox.Show("Invalid phone no ");
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            string str = textBox9.Text;
            if (str.Length == 10)
            {
                // MessageBox.Show("invalid no");
            }
            else
            {
                MessageBox.Show("Invalid phone no ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox10.Clear();
            textBox9.Clear();
            textBox8.Clear();
            //textBox19.Clear();
            textBox11.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox20.Clear();
            //textBox18.Clear();
            textBox12.Clear();
            comboBox1.ResetText();
            comboBox6.ResetText();
            comboBox9.ResetText();
            listBox1.ResetText();
            listBox2.ResetText();


            //private void CleanForm()
            //{
            /* foreach (var c in this.Controls)
             {
                 if (c is TextBox)
                 {
                     ((TextBox)c).Text = String.Empty;
                 }
            // }
             }*/

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd22;
            cmd22 = new SqlCommand("select EMail from Refdoc where Name ='" + comboBox6.SelectedItem + "'");
            cmd22.Connection = con;
            DataTable dt22 = new DataTable();
            SqlDataAdapter sd22 = new SqlDataAdapter(cmd22);
            sd22.Fill(dt22);
            if (dt22.Rows.Count > 0)
            {
                textBox6.Text = (dt22.Rows[0]["EMail"].ToString());

            }

            SqlCommand cmd23;
            cmd23 = new SqlCommand("select Contactno from Refdoc where Name ='" + comboBox6.SelectedItem + "'");
            cmd23.Connection = con;
            DataTable dt23 = new DataTable();
            SqlDataAdapter sd23 = new SqlDataAdapter(cmd23);
            sd23.Fill(dt23);
            if (dt23.Rows.Count > 0)
            {
                textBox7.Text = (dt23.Rows[0]["Contactno"].ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // button2.BackColor = System.Drawing.ColorTranslator.FromHtml("#00743F");
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd3;
            cmd3 = new SqlCommand("select Testamount from Addtest1 where Testname ='" + comboBox3.SelectedItem + "'");
            cmd3.Connection = con;
            DataTable dt4 = new DataTable();
            SqlDataAdapter sd4 = new SqlDataAdapter(cmd3);
            sd4.Fill(dt4);

            if (dt4.Rows.Count > 0)
            {
                // label45.Text= dt4.Rows[0]["Testamount"].ToString();
                listBox1.Items.Add(comboBox3.SelectedItem);
                listBox2.Items.Add (dt4.Rows[0]["Testamount"].ToString());
                //sum1 = sum1 + Convert.ToInt32(label45.Text);
            }


        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd4;
            cmd4 = new SqlCommand("select Testamount from Addtest1 where Testname ='" + comboBox7.SelectedItem + "'");
            cmd4.Connection = con;
            DataTable dt5 = new DataTable();
            SqlDataAdapter sd5 = new SqlDataAdapter(cmd4);
            sd5.Fill(dt5);

            if (dt5.Rows.Count > 0)
            
            {
                // label45.Text= dt5.Rows[0]["Testamount"].ToString();
                listBox1.Items.Add(comboBox7.SelectedItem);
                listBox2.Items.Add(dt5.Rows[0]["Testamount"].ToString());
               // sum2 = sum2 + Convert.ToInt32(label45.Text);
            }
           
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd5;
            cmd5 = new SqlCommand("select Testamount from Addtest1 where Testname ='" + comboBox4.SelectedItem + "'");
            cmd5.Connection = con;
            DataTable dt6 = new DataTable();
            SqlDataAdapter sd6 = new SqlDataAdapter(cmd5);
            sd6.Fill(dt6);

            if (dt6.Rows.Count > 0)
            {
                // label45.Text= dt6.Rows[0]["Testamount"].ToString();
                listBox1.Items.Add(comboBox4.SelectedItem);
                listBox2.Items.Add(dt6.Rows[0]["Testamount"].ToString());
               // sum3 = sum3 + Convert.ToInt32(label45.Text);
            }
        
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd6;
            cmd6 = new SqlCommand("select Testamount from Addtest1 where Testname ='" + comboBox5.SelectedItem + "'");
            cmd6.Connection = con;
            DataTable dt7 = new DataTable();
            SqlDataAdapter sd7 = new SqlDataAdapter(cmd6);
            sd7.Fill(dt7);

            if (dt7.Rows.Count > 0)
            {
                // label45.Text= dt7.Rows[0]["Testamount"].ToString();
                listBox1.Items.Add(comboBox5.SelectedItem);
                listBox2.Items.Add (dt7.Rows[0]["Testamount"].ToString());
               // sum4 = sum4 + Convert.ToInt32(label45.Text);
            }
      
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd7;
            cmd7 = new SqlCommand("select Testamount from Addtest1 where Testname ='" + comboBox8.SelectedItem + "'");
            cmd7.Connection = con;
            DataTable dt8 = new DataTable();
            SqlDataAdapter sd8 = new SqlDataAdapter(cmd7);
            sd8.Fill(dt8);

            if (dt8.Rows.Count > 0)
            {
                // label45.Text= dt8.Rows[0]["Testamount"].ToString();
                listBox1.Items.Add(comboBox8.SelectedItem);
                listBox2.Items.Add(dt8.Rows[0]["Testamount"].ToString());
              //  sum5 = sum5 + Convert.ToInt32(label45.Text);
            }
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("bill" + sum);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        /* private void Form4_FormClosing(object sender, FormClosingEventArgs e)
         {
             if(e.CloseReason == CloseReason.UserClosing)
             {
                 DialogResult d = MessageBox.Show("Do you want to exit?", "info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 if(d == DialogResult.Yes)
                 {
                     e.Cancel = true;
                     Application.Exit();
                 }
             }
         }*/
    }
}
