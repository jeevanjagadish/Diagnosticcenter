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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void timer1_Tick(object sender, EventArgs e)
        {
           if(timeleft > 0)
            {
                timeleft = timeleft - 1;
            }
           else
            { 
                timer1.Stop();
                this.Hide();
                 Login lg = new Login();
                 lg.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#008ed6");
            timeleft = 100;
            timer1.Start();
        }
       
        public int timeleft { get; set; }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label4.Location = new Point(label4.Location.X + 5, label4.Location.Y);
            if(label4.Location.X > this.Width)
            {
                label4.Location = new Point(0 - label4.Width, label4.Location.Y);
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

       /* private void timer1_Tick(object sender, EventArgs e)
        {

        }

        /* private void bunifuImageButton1_Click(object sender, EventArgs e)
         {
             Application.Exit();
         }

        /* private void bunifuImageButton2_Click(object sender, EventArgs e)
         {
             if(WindowState == FormWindowState.Normal)
             {
                 WindowState = FormWindowState.Minimized;
             }
         }*/
    }
}
