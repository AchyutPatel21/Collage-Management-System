using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollageManagement
{
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }

        private void DeleteStudent_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=cmdb;");
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select newadmission.id as Student_ID,newadmission.fname as Full_Name,newadmission.fname2 as Father_Name,newadmission.gender as Gender,newadmission.dob as Date_Of_Birth,newadmission.mobile as Mobile,newadmission.email as Email_ID,newadmission.semester,newadmission.sname as School_Name,newadmission.duration as Course_Duration,newadmission.address as Address,fees.fees as fees from newadmission inner join fees on newadmission.id=fees.sid;";
            cmd.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure...!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK) {
                MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=cmdb;");
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from newadmission where id = " + RegTextBox.Text + "";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select newadmission.id as Student_ID,newadmission.fname as Full_Name,newadmission.fname2 as Father_Name,newadmission.gender as Gender,newadmission.dob as Date_Of_Birth,newadmission.mobile as Mobile,newadmission.email as Email_ID,newadmission.semester,newadmission.sname as School_Name,newadmission.duration as Course_Duration,newadmission.address as Address from newadmission ";

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                con.Close();
                MessageBox.Show("Student Removed...!", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }
    }
}
