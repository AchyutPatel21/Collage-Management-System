using Google.Protobuf.WellKnownTypes;
using K4os.Compression.LZ4.Internal;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace CollageManagement
{
    public partial class NewAddmission : Form
    {
        public NewAddmission()
        {
            InitializeComponent();
        }

        private void NewAddmission_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=cmdb;");
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select max(id) from newadmission;";

            cmd.ExecuteNonQuery();
            //MySqlDataReader Reader = cmd.ExecuteReader();

            //while (Reader.Read())
            //{
            //    int regNo = Reader.GetInt32("id");
            //    label12.Text = Convert.ToString(regNo);
            //}

            object result = cmd.ExecuteScalar();

            // Check if the result is not null
            if (result != null)
            {
                int maxId = Convert.ToInt32(result);

                label12.Text =Convert.ToString(maxId+1);
            }

            con.Close();


        }
        private void Submit_Click(object sender, EventArgs e)
        {
            String name = FullNameText.Text;
            String father_name = FatherText.Text;
            String gender = "";
            bool isChecked = Male.Checked;
            if (isChecked){ gender = Male.Text; }
            else { gender = Female.Text; }
            string dob = DOB.Text;
            Int64 mobile = Int64.Parse(Mobile.Text);
            String email = Email.Text;
            String sem = Semester.Text;
            String school = SchoolText.Text;
            String duration = Duration.Text;
            String address = Address.Text;

            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=cmdb;");
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO `newadmission`(`fname`, `fname2`, `gender`, `dob`, `mobile`, `email`, `semester`, `sname`, `duration`, `address`) VALUES ('"+name+"','"+father_name+"','"+gender+"','"+dob+"','"+mobile+"' ,'"+email+"', '"+sem+"','"+school+"','"+duration+"' ,'"+address+"')";

            int v = cmd.ExecuteNonQuery();
            con.Close();
            if (v == 1)
            {
                MessageBox.Show("Data Saved and Remember the Registration Number...!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Not Saved...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            FullNameText.Clear();
            FatherText.Clear();
            Male.Checked = false;
            Female.Checked = false;
            Email.Clear();
            Mobile.Clear();
            Semester.ResetText();
            SchoolText.Clear();
            Duration.ResetText();
            Address.ResetText();
            DOB.ResetText();
        }
    }
}
