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
    public partial class Form11 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Form11()
        {
            InitializeComponent();
            
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                panel1.Visible = true;
                panel6.Visible = false;
                panel1.Location = new Point(150, 141);
            }
            else
            {

                panel6.Visible = true;
                panel1.Visible = false;
                panel6.Location = new Point(150, 141);
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diagnosticcenterDataSet2.Stock' table. You can move, or remove it, as needed.
           // this.stockTableAdapter.Fill(this.diagnosticcenterDataSet2.Stock);
            panel1.Visible = false;
            panel6.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox1.TextLength > 0) && (textBox2.TextLength > 0))
            {
                con = new SqlConnection(@"Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True");
                con.Open();
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
                {

                }
                else
                {

                    cmd = new SqlCommand("insert into Stock (Date,Items,Amount,Total)values(@Date,@Items,@Amount,@Total)", con);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@Items", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Amount", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Total", textBox19.Text);
                    cmd.ExecuteNonQuery();

                    // MessageBox.Show("Registrated successfully");
                }
                if (string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
                {

                }
                else
                {

                    cmd = new SqlCommand("insert into Stock (Date,Items,Amount,Total)values(@Date,@Items,@Amount,@Total)", con);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@Items", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Amount", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Total", textBox19.Text);
                    cmd.ExecuteNonQuery();

                    // MessageBox.Show("Registrated successfully");
                }
                if (string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox12.Text))
                {

                }
                else
                {

                    cmd = new SqlCommand("insert into Stock (Date,Items,Amount,Total)values(@Date,@Items,@Amount,@Total)", con);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@Items", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Amount", textBox12.Text);
                    cmd.Parameters.AddWithValue("@Total", textBox19.Text);
                    cmd.ExecuteNonQuery();

                    // MessageBox.Show("Registrated successfully");
                }
                if (string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox13.Text))
                {

                }
                else
                {

                    cmd = new SqlCommand("insert into Stock (Date,Items,Amount,Total)values(@Date,@Items,@Amount,@Total)", con);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@Items", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Amount", textBox13.Text);
                    cmd.Parameters.AddWithValue("@Total", textBox19.Text);
                    cmd.ExecuteNonQuery();

                    // MessageBox.Show("Registrated successfully");
                }
                if (string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox14.Text))
                {

                }
                else
                {

                    cmd = new SqlCommand("insert into Stock (Date,Items,Amount,Total)values(@Date,@Items,@Amount,@Total)", con);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@Items", textBox7.Text);
                    cmd.Parameters.AddWithValue("@Amount", textBox14.Text);
                    cmd.Parameters.AddWithValue("@Total", textBox19.Text);
                    cmd.ExecuteNonQuery();

                    // MessageBox.Show("Registrated successfully");
                }

                if (string.IsNullOrEmpty(textBox8.Text) || string.IsNullOrEmpty(textBox15.Text))
                {

                }
                else
                {

                    cmd = new SqlCommand("insert into Stock (Date,Items,Amount,Total)values(@Date,@Items,@Amount,@Total)", con);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@Items", textBox8.Text);
                    cmd.Parameters.AddWithValue("@Amount", textBox15.Text);
                    cmd.Parameters.AddWithValue("@Total", textBox19.Text);
                    cmd.ExecuteNonQuery();

                    // MessageBox.Show("Registrated successfully");
                }

                if (string.IsNullOrEmpty(textBox9.Text) || string.IsNullOrEmpty(textBox16.Text))
                {

                }
                else
                {

                    cmd = new SqlCommand("insert into Stock (Date,Items,Amount,Total)values(@Date,@Items,@Amount,@Total)", con);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@Items", textBox9.Text);
                    cmd.Parameters.AddWithValue("@Amount", textBox16.Text);
                    cmd.Parameters.AddWithValue("@Total", textBox19.Text);
                    cmd.ExecuteNonQuery();

                    // MessageBox.Show("Registrated successfully");
                }

                if (string.IsNullOrEmpty(textBox10.Text) || string.IsNullOrEmpty(textBox17.Text))
                {

                }
                else
                {

                    cmd = new SqlCommand("insert into Stock (Date,Items,Amount,Total)values(@Date,@Items,@Amount,@Total)", con);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@Items", textBox10.Text);
                    cmd.Parameters.AddWithValue("@Amount", textBox17.Text);
                    cmd.Parameters.AddWithValue("@Total", textBox19.Text);
                    cmd.ExecuteNonQuery();

                    // MessageBox.Show("Registrated successfully");
                }

                if (string.IsNullOrEmpty(textBox11.Text) || string.IsNullOrEmpty(textBox18.Text))
                {

                }
                else
                {

                    cmd = new SqlCommand("insert into Stock (Date,Items,Amount,Total)values(@Date,@Items,@Amount,@Total)", con);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@Items", textBox11.Text);
                    cmd.Parameters.AddWithValue("@Amount", textBox18.Text);
                    cmd.Parameters.AddWithValue("@Total", textBox19.Text);
                    cmd.ExecuteNonQuery();

                    // MessageBox.Show("Registrated successfully");
                }
                MessageBox.Show("Registrated successfully");
                con.Close();
            }
            else
            {
                MessageBox.Show("enter all the fields");
            }
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Text ="0";
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                textBox4.Text = "0";
            }
            if (string.IsNullOrEmpty(textBox12.Text))
            {
                textBox12.Text = "0";
            }
            if (string.IsNullOrEmpty(textBox13.Text))
            {
                textBox13.Text = "0";
            }
            if (string.IsNullOrEmpty(textBox14.Text))
            {
                textBox14.Text = "0";
            }
            if (string.IsNullOrEmpty(textBox15.Text))

            {
                textBox15.Text = "0";
            }
            if (string.IsNullOrEmpty(textBox16.Text))
            {
                textBox16.Text = "0";
            }
            if (string.IsNullOrEmpty(textBox17.Text))
            {
                textBox17.Text = "0";
            }
            if (string.IsNullOrEmpty(textBox18.Text))
            {
                textBox18.Text = "0";
            }
            int a = Convert.ToInt32(textBox2.Text);
            int b = Convert.ToInt32(textBox4.Text);
            int c = Convert.ToInt32(textBox12.Text);
            int d = Convert.ToInt32(textBox13.Text);
            int y = Convert.ToInt32(textBox14.Text);
            int f = Convert.ToInt32(textBox15.Text);
            int r = Convert.ToInt32(textBox16.Text);
            int h = Convert.ToInt32(textBox17.Text);
            int i = Convert.ToInt32(textBox18.Text);
            int sum = (a + b + c + d + y + f + r + h + i );
            textBox19.Text = sum.ToString();


        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            string from = dateTimePicker2.Value.Date.ToString();
            SqlConnection con = new SqlConnection(@"Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True");
           
            SqlCommand cmd = new SqlCommand("select Items,Amount,Total from Stock where Date = @Date",con);
            
            cmd.Parameters.AddWithValue("@Date", dateTimePicker2.Value.Date);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void stockBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox4.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter number only");
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

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter number only");
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter number only");
            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter number only");
            }
        }
    }
}
