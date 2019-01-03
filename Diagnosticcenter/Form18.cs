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
    public partial class Form18 : Form
    {
        DataTable dt = new DataTable();
        public Form18()
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
            if ((dateTimePicker1.Value.ToString() == "") && (dateTimePicker2.Value.ToString() == ""))
            {

                //String from = dateTimePicker1.Value.Date.ToString();
                //String to = dateTimePicker2.Value.Date.ToString();
                con.Open();
                SqlCommand command = new SqlCommand("Select * from Registration Where Regdate BETWEEN @Regdate AND @Deldate", con);
                command.Parameters.AddWithValue("@Regdate", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@Deldate", dateTimePicker2.Value);

                SqlDataAdapter da = new SqlDataAdapter(command);
                // DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("select the date for the report");
            }
            


        }

        private void Form18_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0, sum1 = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["Amount"].ToString() == "CASH")
                {
                    sum = sum + 1;
                }
                else
                {
                    sum1++;
                }
            }
            label2.Text = sum.ToString();
            label7.Text = sum1.ToString();
            label11.Text= dt.Rows.Count.ToString();

            //total amt
            decimal total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dataGridView1.Rows[i].Cells["Totalamount"].Value);
            }
            label1.Text = total.ToString();

            //no of cards and cash
            // var count = this.dataGridView1.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Amount"].Value.ToString() == "CASH");
            // this.label2.Text = count.ToString();
            //demo
                //int total1 = dataGridView1.SelectedRows.Cast<DataGridViewRow>().Count(row => row.Cells["Amount"].Value.ToString() == "CASH");
                //this.label2.Text = total1.ToString();
                con.Close();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
            label1.ResetText();
            label2.ResetText();
            label7.ResetText();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
