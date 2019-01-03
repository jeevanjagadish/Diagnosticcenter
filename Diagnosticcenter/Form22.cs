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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            panel1.Height = 516;
            panel1.Width = 289;
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            panel1.Height = 226;
            panel1.Width = 289;
           
            panel3.Height = 516;
            panel3.Width = 289;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            panel1.Height = 226;
            panel1.Width = 289;
            button1.Visible = true;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            panel3.Height = 516;
            panel3.Width = 289;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            panel3.Height = 226;
            panel3.Width = 289;
            button2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            panel4.Height = 516;
            panel4.Width = 289;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            panel4.Height = 226;
            panel4.Width = 289;
            button3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            panel7.Height = 329; 
            panel7.Width = 289;
        }

        private void label23_Click(object sender, EventArgs e)
        {
            panel7.Height = 224; 
            panel7.Width = 289;
            button3.Visible = true;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
