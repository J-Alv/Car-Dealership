using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dealership
{
    public partial class Dealership : Form
    {
        //Test example comment
        //Another one
        // and another one
        MySqlConnection conn;
        // OLD SERVER string connString = "SERVER=remotemysql.com;PORT=3306;DATABASE=3tF0bDdaYH;UID=3tF0bDdaYH;PASSWORD=WaMppdwyis";
        string connString = "SERVER=sql3.freemysqlhosting.net;PORT=3306;DATABASE=sql3326055;UID=sql3326055;PASSWORD=F23ItuHar5";
        public Dealership()
        {
            InitializeComponent();
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connString);
                conn.Open();
                string CmdString = "SELECT * FROM Customer";
                MySqlCommand cmd = null;
                cmd = new MySqlCommand(CmdString, conn);
                cmd.ExecuteNonQuery();

                MySqlDataAdapter sda = new MySqlDataAdapter(CmdString, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                cars_dataGridView.DataSource = ds.Tables[0].DefaultView;
                conn.Close();   
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cust_ListAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connString);
                conn.Open();
                string CmdString = "SELECT * FROM Customer";
                MySqlCommand cmd = null;
                cmd = new MySqlCommand(CmdString, conn);
                cmd.ExecuteNonQuery();

                MySqlDataAdapter sda = new MySqlDataAdapter(CmdString, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                cust_dataGridView.DataSource = ds.Tables[0].DefaultView;
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
