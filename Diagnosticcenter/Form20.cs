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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((comboBox1.SelectedIndex > 0))
            {
                SqlConnection con = new SqlConnection(@"Data Source=dell;Initial Catalog=Diagnosticcenter;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select Patientname,PatientID,Sex,Age,Phoneno,Regdate from Registration where Type = @Type", con);

                cmd.Parameters.AddWithValue("@Type", comboBox1.SelectedItem);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("select the type of patient");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // comboBox1.ResetText();
           // dataGridView1.Rows.Clear();
           // dataGridView1.Refresh();
        }

        private void Form20_Load(object sender, EventArgs e)
        {

        }
    }
}
