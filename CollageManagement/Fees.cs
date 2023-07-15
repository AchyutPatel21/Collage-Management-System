using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CollageManagement
{
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void RegTextBox_TextChanged(object sender, EventArgs e)
        {
            if(RegTextBox.Text != ""){

                MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=cmdb;");
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select fname,fname2,semester,duration from newadmission where id = " + RegTextBox.Text + ""; ;
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) { 
                    while (reader.Read())
                    {
                        string name = reader.GetString(0);
                        string fatherName = reader.GetString(1);
                        string semester = reader.GetString(2);
                        string duration = reader.GetString(3);

                        NameText.Text = name;
                        FatherText.Text = fatherName;
                        SemText.Text = semester;
                        DurationText.Text = duration;
                    }
                }
                else
                {
                    MessageBox.Show("Invaild Registraction Number..!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }


                con.Close();
            }
            else
            {
                RegTextBox.Text = "";
                NameText.Text = "";
                FatherText.Text = "";
                SemText.Text = "";
                DurationText.Text = "";
                FeesTextBox.Text = "";
            }
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MySqlConnection con1 = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=cmdb;");
            con1.Open();
            MySqlCommand cmd1 = new MySqlCommand();
            cmd1.Connection = con1;
            cmd1.CommandText = "select * from fees where sid = "+RegTextBox.Text+"";
            int v1 = cmd1.ExecuteNonQuery();
            

            int count = Convert.ToInt32(cmd1.ExecuteScalar());
            if (count == 0)
            {
                MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=cmdb;");
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into fees(sid,ssem,fees) values ('" + RegTextBox.Text + "','" + SemText.Text + "','" + FeesTextBox.Text + "')";
                int v = cmd.ExecuteNonQuery();
                con.Close();
                if (v == 1)
                {
                    MessageBox.Show("Fees Paid Successfully...!", "Fees Paid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fees Not Paid...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fees Already Paid..!!", "Already Paid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            con1.Close();

        }

        private void Fees_Load(object sender, EventArgs e)
        {

        }
    }
}
