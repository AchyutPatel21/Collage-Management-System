using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollageManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;

            if (username == "" && password == "")
            {
                menuStrip1.Visible = true;
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Invaild Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void oldAddmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpgradeSem gs = new UpgradeSem();
            gs.Show();
        }

        private void addmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
        }

        private void newAddmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAddmission na = new NewAddmission();
            na.Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fees fe = new Fees();
            fe.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudent ss = new SearchStudent();
            ss.Show();
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTeacher nt = new NewTeacher();
            nt.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTeacher st = new SearchTeacher();
            st.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure..!!","Confirmation Dialog",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void removeStudentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DeleteStudent ds = new DeleteStudent();
            ds.Show();
        }

        private void removeTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveTeacher rt = new RemoveTeacher();
            rt.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutCreator ac = new AboutCreator();
            ac.Show();
        }

        private void aboutMarwadiUniversityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://www.marwadiuniversity.ac.in/";
            System.Diagnostics.Process.Start(websiteUrl);
        }
    }
}
