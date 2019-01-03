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
    public partial class Form17 : Form
    {
        public Form17()
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

        private void Form17_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True");
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
                comboBox1.Items.Add(dr["Name"].ToString());
            }


            SqlCommand cmd2 = new SqlCommand("select * from Refdoc", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd2);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((comboBox1.SelectedIndex > 0))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Refdoc where Name like '" + comboBox1.SelectedItem + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("select the doctor name");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label11.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            label12.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            label13.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            label14.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            label15.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            label16.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
           // label17.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            
           // textBox1.ReadOnly = false;
            
           
        }

        private void label21_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            String q = "update [Refdoc] set [Compensation]='" + textBox1.Text.ToString() + "' where [Name]='" + label12.Text + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("successfully  updated", "Password changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.ReadOnly = true;
            con.Close();
        }
    }
}
