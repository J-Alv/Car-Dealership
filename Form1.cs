using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

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
            cars_comboBox.Items.Add("Show Inventory");
            cars_comboBox.Items.Add("Add Car");
            cars_comboBox.Items.Add("Search Car");
            cars_comboBox.SelectedIndex = 0;

            cars_ByComboBox.Items.Add("VIN");
            cars_ByComboBox.Items.Add("Make and Model");

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

        private void cust_CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connString);
                conn.Open();
                string CmdString = "NEED TO IMPLEMENT";
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

        private void car_SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = null;
                MySqlDataAdapter sda = null;
                conn = new MySqlConnection(connString);
                DataSet ds = new DataSet();
                conn.Open();

                string VIN = cars_VINTxtB.Text.ToString();
                string Make = cars_makeTxtB.Text.ToString();
                string Model = cars_modelTxtB.Text.ToString();
                string Year = cars_YearTxtB.Text.ToString();
                string Color = cars_ColorTxtB.Text.ToString();
                string Mileage = cars_MileageTxtB.Text.ToString();
                bool Used = cars_YesCheckBox.Checked;
                string CmdString = "";

                switch (cars_comboBox.SelectedIndex)
                {
                    case 0:
                        CmdString = "SELECT * FROM Car";
                        sda = new MySqlDataAdapter(CmdString, conn);

                        sda.Fill(ds);
                        cars_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;
                    case 1:
                        if (cars_YesCheckBox.Checked == true)
                        {
                            CmdString = "INSERT INTO Car (VIN, Make, Model, Year, Color, Mileage, Used) VALUES ('"
                            + VIN + "', '" + Make + "', '" + Model + "', " + Year + ", '" + Color + "', " + Mileage + ", 1)";
                        }
                        else
                        {
                            CmdString = "INSERT INTO Car (VIN, Make, Model, Year, Color, Mileage, Used) VALUES ('"
                            + VIN + "', '" + Make + "', '" + Model + "', " + Year + ", '" + Color + "', " + Mileage + ", 0)";
                        }

                        cmd = new MySqlCommand(CmdString, conn);
                        cmd.ExecuteNonQuery();

                        CmdString = "SELECT * FROM Car WHERE ID = last_insert_id()";
                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        cars_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;
                    case 2:
                        switch (cars_ByComboBox.SelectedIndex)
                        {
                            case 0:
                                CmdString = "SELECT * FROM Car " +
                                "WHERE VIN = '" + VIN + "'";
                                break;
                            case 1:
                                CmdString = "SELECT * FROM Car " +
                                "WHERE Make = '" + Make + "'" +
                                "AND Model = '" + Model + "'";
                                break;
                        }

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        cars_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cars_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cars_comboBox.SelectedIndex)
            {
                case 0:
                    cars_VINLbl.Text = "VIN";
                    car_SearchBtn.Text = "Show Inventory";
                    cars_makeLbl.Text = "Make";
                    cars_modelLbl.Text = "Model";

                    cars_VINLbl.Visible = false;
                    cars_VINTxtB.Visible = false;

                    cars_makeLbl.Visible = false;
                    cars_makeTxtB.Visible = false;

                    cars_modelLbl.Visible = false;
                    cars_modelTxtB.Visible = false;

                    cars_YearLbl.Visible = false;
                    cars_YearTxtB.Visible = false;

                    cars_ColorLbl.Visible = false;
                    cars_ColorTxtB.Visible = false;

                    cars_MilageLbl.Visible = false;
                    cars_MileageTxtB.Visible = false;

                    cars_usedLbl.Visible = false;

                    cars_YesCheckBox.Visible = false;
                    cars_NoCheckBox.Visible = false;

                    cars_ByLbl.Visible = false;
                    cars_ByComboBox.Visible = false;
                    break;
                case 1:
                    car_SearchBtn.Text = "Add Car";
                    cars_VINLbl.Text = "VIN";
                    cars_makeLbl.Text = "Make";
                    cars_modelLbl.Text = "Model";

                    cars_VINLbl.Visible = true;
                    cars_VINTxtB.Visible = true;

                    cars_makeLbl.Visible = true;
                    cars_makeTxtB.Visible = true;

                    cars_modelLbl.Visible = true;
                    cars_modelTxtB.Visible = true;

                    cars_YearLbl.Visible = true;
                    cars_YearTxtB.Visible = true;

                    cars_ColorLbl.Visible = true;
                    cars_ColorTxtB.Visible = true;

                    cars_MilageLbl.Visible = true;
                    cars_MileageTxtB.Visible = true;

                    cars_usedLbl.Visible = true;

                    cars_YesCheckBox.Visible = true;
                    cars_NoCheckBox.Visible = true;

                    cars_ByLbl.Visible = false;
                    cars_ByComboBox.Visible = false;
                    break;
                case 2:
                    car_SearchBtn.Text = "Search";
                    cars_VINLbl.Text = "* VIN";
                    cars_makeLbl.Text = "* Make";
                    cars_modelLbl.Text = "* Model";

                    cars_VINLbl.Visible = false;
                    cars_VINTxtB.Visible = false;

                    cars_makeLbl.Visible = false;
                    cars_makeTxtB.Visible = false;

                    cars_modelLbl.Visible = false;
                    cars_modelTxtB.Visible = false;

                    cars_YearLbl.Visible = false;
                    cars_YearTxtB.Visible = false;

                    cars_ColorLbl.Visible = false;
                    cars_ColorTxtB.Visible = false;

                    cars_MilageLbl.Visible = false;
                    cars_MileageTxtB.Visible = false;

                    cars_usedLbl.Visible = false;

                    cars_YesCheckBox.Visible = false;
                    cars_NoCheckBox.Visible = false;

                    cars_ByLbl.Visible = true;
                    cars_ByComboBox.Visible = true;

                    break;
            }
        }

        private void cars_YesCheckBox_Click(object sender, EventArgs e)
        {
            if (cars_YesCheckBox.Checked == true)
            {
                if (cars_NoCheckBox.Checked == true)
                {
                    cars_YesCheckBox.Checked = false;
                }
            }
        }

        private void cars_NoCheckBox_Click(object sender, EventArgs e)
        {
            if (cars_NoCheckBox.Checked == true)
            {
                if (cars_YesCheckBox.Checked == true)
                {
                    cars_NoCheckBox.Checked = false;
                }
            }
        }

        private void cars_ByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cars_ByComboBox.SelectedIndex)
            {
                case 0:
                    cars_VINLbl.Visible = true;
                    cars_VINTxtB.Visible = true;

                    cars_makeLbl.Visible = false;
                    cars_makeTxtB.Visible = false;

                    cars_modelLbl.Visible = false;
                    cars_modelTxtB.Visible = false;

                    cars_YearLbl.Visible = false;
                    cars_YearTxtB.Visible = false;

                    cars_ColorLbl.Visible = false;
                    cars_ColorTxtB.Visible = false;

                    cars_MilageLbl.Visible = false;
                    cars_MileageTxtB.Visible = false;

                    cars_usedLbl.Visible = false;

                    cars_YesCheckBox.Visible = false;
                    cars_NoCheckBox.Visible = false;

                    cars_ByLbl.Visible = true;
                    cars_ByComboBox.Visible = true;
                    break;

                case 1:
                    cars_VINLbl.Visible = false;
                    cars_VINTxtB.Visible = false;

                    cars_makeLbl.Visible = true;
                    cars_makeTxtB.Visible = true;

                    cars_modelLbl.Visible = true;
                    cars_modelTxtB.Visible = true;

                    cars_YearLbl.Visible = false;
                    cars_YearTxtB.Visible = false;

                    cars_ColorLbl.Visible = false;
                    cars_ColorTxtB.Visible = false;

                    cars_MilageLbl.Visible = false;
                    cars_MileageTxtB.Visible = false;

                    cars_usedLbl.Visible = false;

                    cars_YesCheckBox.Visible = false;
                    cars_NoCheckBox.Visible = false;

                    cars_ByLbl.Visible = true;
                    cars_ByComboBox.Visible = true;

                    break;
            }
        }
    }
}
