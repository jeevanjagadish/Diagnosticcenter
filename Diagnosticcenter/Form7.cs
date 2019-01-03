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
    public partial class Form7 : Form
    {
        public string varx;
        private EventHandler changeimage;

        public Form7()
        {
            InitializeComponent();
        }

        private void searchFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void addTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
            textBox1.Text = varx;
           
            if (textBox1.Text=="Admin")
            {
                pictureBox6.Visible = true;
                label9.Visible = true;
            }
            else
            {
                pictureBox6.Visible = false;
                label9.Visible = false;
            }

            Form4 f4 = new Form4();
            f4.vardj = this.textBox1.Text;
            ////f4.Show();
            ////this.Hide();

            //pictureBox6.Visible = true;

            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("https://www.google.co.in/maps/place/Kare+Scanning+Centre/@12.9600914,77.614695,15z/data=!4m5!3m4!1s0x0:0xd500f2db43f0e8c8!8m2!3d12.9600914!4d77.614695");
                webBrowser1.Navigate(sb.ToString());
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message.ToString(), "error");
            }

            pictureBox2.Image = Properties.Resources._20160413_IMG_0344__tojpeg_1460634251808_x2;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            Timer tm = new Timer();
            tm.Interval = 100;
            tm.Tick += new EventHandler(Changeimage);
            tm.Start();
 
        }
        private void Changeimage (object sender, EventArgs e)
        {
            List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Properties.Resources._20160413_IMG_0344__tojpeg_1460634251808_x2);
            b1.Add(Properties.Resources._284ebb8);
            b1.Add(Properties.Resources.kare_scan_and_diagnostic_centre_austin_town_bangalore_diagnostic_centres_1ncyj2l);
            b1.Add(Properties.Resources.multi_clinics_slide_3_13);
            b1.Add(Properties.Resources.peerless_diagnostic_centre_chittaranjan_avenue_kolkata_diagnostic_centres_2nb1iwr);
            b1.Add(Properties.Resources.photodune_5079010_female_doctor_in_front_of_medical_group_m_820x498);
            int index = DateTime.Now.Second % b1.Count;
            pictureBox2.Image = b1[index];


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            Application.Exit();
        }

        private void searchFormToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.vardj = this.textBox1.Text;
            f4.Show();
            this.Hide();

            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;

        }

        private void fileToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void fileToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        }

        private void fileToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
        }

        private void masterSetupToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            this.masterSetupToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        }

        private void masterSetupToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            this.masterSetupToolStripMenuItem.ForeColor = System.Drawing.Color.White;
        }

        private void registrationToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            this.registrationToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        }

        private void registrationToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            this.registrationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
        }

        private void sectionToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            this.sectionToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        }

        private void sectionToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            this.sectionToolStripMenuItem.ForeColor = System.Drawing.Color.White; ;
        }

        private void reportsToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            //this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        }

        private void reportsToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {

           // this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
        }

        private void mISReportsToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            this.mISReportsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        }

        private void mISReportsToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            this.mISReportsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
        }

        private void windowsToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
           // this.windowsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        }

        private void windowsToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
           // this.windowsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
        }

        private void helpToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        }

        private void helpToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();

        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to exit?", "info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                this.Hide();
                Login lg = new Login();
                lg.Show();
            }
            else
            {

            }
        }

        private void reffDoctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Hide();

        }

        private void expensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void newFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Hide();
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void refDocCompToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
            this.Hide();
           
        }

        private void addTestToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            this.Hide();
        }

        private void regularPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form20 f20 = new Form20();
            f20.Show();
            this.Hide();
        }

        private void testPriceListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form21 f21 = new Form21();
            f21.Show();
            this.Hide();
        }

        private void expensesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
            this.Hide();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchForHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form22 f22 = new Form22();
            f22.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to signout?", "infor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
            else
            {
                this.Activate();
            }


           
        }
    }
}
