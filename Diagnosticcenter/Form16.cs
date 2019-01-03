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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Username from Staffdetails";
           cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["Username"].ToString());
            }

            // SqlConnection con = new SqlConnection(@"Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True");
            //SqlCommand cmd2 = new SqlCommand("select * from Staffdetails", con);
            SqlCommand cmd2 = new SqlCommand("select Name,Phoneno,MailID,Qualification,DOB,Profession,Username from Staffdetails", con);
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
                SqlDataAdapter sda = new SqlDataAdapter("select * from Staffdetails where Username like '" + comboBox1.SelectedItem + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("select the Staff name");
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
            label17.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form15 f15 = new Form15();
            f15.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            comboBox1.ResetText();
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = ""; 

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {
           

        }
    }
}
