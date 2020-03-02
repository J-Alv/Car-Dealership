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
        MySqlConnection conn;
        string connString = "SERVER=remotemysql.com;PORT=3306;DATABASE=3tF0bDdaYH;UID=3tF0bDdaYH;PASSWORD=WaMppdwyis";

        public Dealership()
        {
            InitializeComponent();
            conn = new MySqlConnection(connString);
            conn.Open();
            string CmdString = "SELECT FirstName, MiddleName, LastName FROM Customer WHERE " + "FirstName = '" + cust_firstNMTxtB.Text.ToString() + "' AND MiddleName = '" + cust_middleNMTxtB.Text.ToString() + "' AND LastName = '" + cust_lastNMTxtB.Text.ToString() + "' AND Email = '" + cust_emailTxtB.Text.ToString() + "'";

            MySqlDataAdapter sda = new MySqlDataAdapter(CmdString, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cust_dataGridView.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }
    }
}
