using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagnosticcenter
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Form17 f17 = new Form17();
            f17.Show();
            this.Hide();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Form19 f19 = new Form19();
            f19.Show();
            this.Hide();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Form18 f18 = new Form18();
            f18.Show();
            this.Hide();
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            panel3.Visible = true;
            button1.Visible = true;


        }

        private void Form15_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            button1.Visible = false;
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            panel3.Visible = false;
            button1.Visible = false;
        }

        private void S_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to signout?", "infor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                this.Close();
                Login f2 = new Login();
                f2.Show();
            }
        }
    }
}
