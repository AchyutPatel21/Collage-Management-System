using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CollageManagement
{
    public partial class NewTeacher : Form
    {
        public NewTeacher()
        {
            InitializeComponent();
        }

        private void NewTeacher_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String name = FullNameText.Text;
            String gender = "";
            bool isChecked = Male.Checked;
            if (isChecked) { gender = Male.Text; }
            else { gender = Female.Text; }
            string dob = DOB.Text;
            Int64 mobile = Int64.Parse(MobileText.Text);
            String email = EmailText.Text;
            String sem = SemComboBox.Text;
            string prog_language = ProgrammingComboBox.Text;
            String duration = DurationComboBox.Text;
            String address = AddressText.Text;

            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=cmdb;");
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO `teacher`(`fname`, `gender`, `dob`, `mobile`, `email`, `semester`, `programming`, `duration`, `address`) VALUES ('" + name + "','" + gender + "','" + dob + "','" + mobile + "' ,'" + email + "', '" + sem + "','" + prog_language + "','" + duration + "' ,'" + address + "')";

            int v = cmd.ExecuteNonQuery();
            con.Close();
            if (v == 1)
            {
                MessageBox.Show("Data Saved...!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Not Saved...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FullNameText.Clear();
            Male.Checked = false;
            Female.Checked = false;
            EmailText.Clear();
            MobileText.Clear();
            SemComboBox.ResetText();
            ProgrammingComboBox.ResetText();
            DurationComboBox.ResetText();
            AddressText.ResetText();
            DOB.ResetText();
        }
    }
}
