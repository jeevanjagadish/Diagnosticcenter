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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            fillcombobox();
        }
        private void fillcombobox()
        {
            try
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((comboBox1.SelectedIndex > 0))
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();

                SqlConnection con = new SqlConnection(@"Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True");
                con.Open();
                string q1 = "select * from Refdoc where Name ='" + comboBox1.SelectedItem.ToString() + "'";
                SqlCommand cmd = new SqlCommand(q1, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox1.Text = reader["Name"].ToString();
                    textBox2.Text = reader["Address"].ToString();
                    textBox3.Text = reader["Contactno"].ToString();
                    textBox4.Text = reader["Orgname"].ToString();
                    textBox5.Text = reader["EMail"].ToString();
                    textBox6.Text = reader["Compensation"].ToString();
                    reader.Close();
                    con.Close();
                }

                SqlConnection con1 = new SqlConnection(@"Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True");
                con1.Open();
                string q2 = "select * from Registration where RDoctorname ='" + comboBox1.SelectedItem.ToString() + "'";
                SqlCommand cmd2 = new SqlCommand(q2, con1);
                DataTable dt = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter(cmd2);
                ad.Fill(dt);
                // SqlDataReader r = cmd2.ExecuteReader();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    listBox1.Items.Add(dt.Rows[x]["Billno"].ToString());
                    listBox2.Items.Add(dt.Rows[x]["Patientname"].ToString());
                    listBox3.Items.Add(dt.Rows[x]["Regdate"].ToString());
                    listBox4.Items.Add(dt.Rows[x]["Billamount"].ToString());
                }

                con1.Close();
            }
            else
            {
                MessageBox.Show("select the doctor name");
            }
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
        }
    }
}
