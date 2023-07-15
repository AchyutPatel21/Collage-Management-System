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
    public partial class RemoveTeacher : Form
    {
        public RemoveTeacher()
        {
            InitializeComponent();
        }

        private void RemoveTeacher_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=cmdb;");
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select tid as Teacher_ID,fname as Full_Name,gender as Gender,dob as Date_Of_Birth,mobile as Mobile,email as Email_ID,semester as Semester,programming as Programming_Language,duration as Course_Duration,address as Address from teacher";
            cmd.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure...!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=cmdb;");
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from teacher where tid = " + RegTextBox.Text + "";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select tid as Teacher_ID,fname as Full_Name,gender as Gender,dob as Date_Of_Birth,mobile as Mobile,email as Email_ID,semester as Semester,programming as Programming_Language,duration as Course_Duration,address as Address from teacher";
                cmd.ExecuteNonQuery();
                RegTextBox.Clear();

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                con.Close();
                MessageBox.Show("Teacher Removed...!", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
