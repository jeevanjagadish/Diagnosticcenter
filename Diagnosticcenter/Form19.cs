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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form15 f15 = new Form15();
            f15.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((radioButton1.Checked == true) || (radioButton2.Checked == true))
            {
                if (radioButton1.Checked == true)
                {
                    panel1.Visible = true;
                    panel3.Visible = false;
                    panel1.Location = new Point(150, 180);
                }
                else
                {

                    panel3.Visible = true;
                    panel1.Visible = false;
                    panel3.Location = new Point(150, 180);
                }
            }
            else
            {
                MessageBox.Show("select the button to view");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Testcode from Addtest1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["Testcode"].ToString());
            }
            
           /* SqlCommand cmd2 = new SqlCommand("select * from Addtest1", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd2);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1; */
            con.Close();

            
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((comboBox1.SelectedIndex > 0))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Addtest1 where Testcode like '" + comboBox1.SelectedItem + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("select the test code");
            }

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            label2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            label3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            textBox1.Text = "";
           // label4.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((dateTimePicker1.Checked == true) && (dateTimePicker2.Checked == true))
            {

                con.Open();
                SqlCommand command = new SqlCommand("Select * from Stock Where Date BETWEEN @from AND @to", con);
                command.Parameters.AddWithValue("@from", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@to", dateTimePicker2.Value);

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("select the date for the report");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dataGridView2.Rows[i].Cells["Amount"].Value);
            }
            label13.Text = total.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();
            String q = "update [Addtest1] set [Testamount]='" + textBox1.Text.ToString() + "' where [Testname]='" + label1.Text + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("successfully  updated", "Password changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.ReadOnly = true;
            con.Close();
        }
    }
}
