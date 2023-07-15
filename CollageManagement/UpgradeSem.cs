using Google.Protobuf.WellKnownTypes;
using K4os.Compression.LZ4.Internal;
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
using System.Xml.Linq;

namespace CollageManagement
{
    public partial class UpgradeSem : Form
    {
        public UpgradeSem()
        {
            InitializeComponent();
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=cmdb;");
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update newadmission SET semester='"+ TocomboBox.Text + "' WHERE semester='"+ FromcomboBox.Text + "'";
            int v = cmd.ExecuteNonQuery();
            con.Close();
            if (v == 1)
            {
                MessageBox.Show("Semester Upgraded...!", "Upgraded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Semester Not Upgraded...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
        }
    }
}
