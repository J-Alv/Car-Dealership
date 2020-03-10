using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Dealership
{
    public partial class Dealership : Form
    {
        MySqlConnection conn;
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

            emp_comboBox.Items.Add("All Employees");
            emp_comboBox.Items.Add("Search Employee");
            emp_comboBox.Items.Add("Add New Employee");
            emp_comboBox.Items.Add("Update Employee");
            emp_comboBox.Items.Add("Delete Employee");
            emp_comboBox.SelectedIndex = 0;

        }

        private void cust_ListAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connString);
                conn.Open();
                string CmdString = "SELECT FirstName, MiddleName, LastName, Number, Email FROM Customer " +
                    "JOIN PhoneInfo on (PhoneInfo.CustomerID=Customer.ID)";
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
                string CmdString = "INSERT INTO Customer(";
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
                int VinLength = VIN.Length;
                string Make = cars_makeTxtB.Text.ToString();
                int MakeLength = Make.Length;
                string Model = cars_modelTxtB.Text.ToString();
                int ModelLength = Model.Length;
                string Year = cars_YearTxtB.Text.ToString();
                string Color = cars_ColorTxtB.Text.ToString();
                string Mileage = cars_MileageTxtB.Text.ToString();
                bool Used = cars_YesCheckBox.Checked;
                string CmdString = "";

                switch (cars_comboBox.SelectedIndex)
                {
                    case 0:
                        CmdString = "SELECT VIN, Make, Model, Year, Color, Mileage, Used FROM Car";
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
                                if (VinLength == 17)
                                {
                                    CmdString = "SELECT VIN, Make, Model, Year, Color, Mileage, Used FROM Car " +
                                    "WHERE VIN LIKE '" + VIN + "'";
                                }else if (VinLength!=17)
                                {
                                    //MessageBox.Show("Wrong VIN Length");
                                    CmdString = "SELECT VIN, Make, Model, Year, Color, Mileage, Used FROM Car " +
                                    "WHERE VIN LIKE '" + VIN + "%'";
                                }else if (VinLength == 0)
                                {
                                 
                                    CmdString = "SELECT VIN, Make, Model, Year, Color, Mileage, Used FROM Car";
                                }
                                break;
                            case 1:
                                if (MakeLength != 0 && ModelLength != 0)
                                {
                                    CmdString = "SELECT VIN, Make, Model, Year, Color, Mileage, Used FROM Car " +
                                    "WHERE Make LIKE '" + Make + "'" +
                                    "AND Model LIKE '" + Model + "'";

                                }
                                else 
                                 if (MakeLength != 0 && ModelLength == 0)
                                {
                                    CmdString = "SELECT VIN, Make, Model, Year, Color, Mileage, Used FROM Car " +
                                    "WHERE Make LIKE '" + Make + "'";

                                    
                                }
                                else
                                    if (MakeLength == 0 && ModelLength != 0)
                                {
                                    CmdString = "SELECT VIN, Make, Model, Year, Color, Mileage, Used FROM Car " +
                                    "WHERE Model LIKE '" + Model + "'";
                                }
                                else
                                if (MakeLength == 0 && ModelLength == 0)
                                {
                                    CmdString = "SELECT VIN, Make, Model, Year, Color, Mileage, Used FROM Car";
                                    
                                }
                                
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
                    cars_VINLbl.Text = " VIN";
                    cars_makeLbl.Text = " Make";
                    cars_modelLbl.Text = " Model";

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

        private void emp_Button_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = null;
                MySqlDataAdapter sda = null;
                conn = new MySqlConnection(connString);
                DataSet ds = new DataSet();
                conn.Open();

                string ID = emp_IDTxtB.Text.ToString();
                string FirstName = emp_FirstNameTxtB.Text.ToString();
                string MiddleName = emp_MiddleNameTxtB.Text.ToString();
                string LastName = emp_LastNameTxtB.Text.ToString();
                string PhoneNumber = emp_PhoneTxtB.Text.ToString();
                string SupervisorID = emp_SupervisorIDTxtB.Text.ToString();
                string Email = emp_EmailTxtB.Text.ToString();
                string Title = emp_TitleTxtB.Text.ToString();
                string CmdString = "";

                switch (emp_comboBox.SelectedIndex)
                {
                    case 0:
                        CmdString = "SELECT FirstName, MiddleName, LastName, SupervisorID, Number, Email, Title " +
                            "FROM Employee JOIN PhoneInfo ON(Employee.ID = PhoneInfo.EmployeeID)";
                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        emp_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;

                    case 1:
                        CmdString = "SELECT FirstName, MiddleName, LastName, SupervisorID, Number, Email, Title" +
                            " FROM Employee JOIN PhoneInfo ON (Employee.ID = PhoneInfo.EmployeeID)";
                        if (ID != "")
                        {
                            CmdString += "WHERE Employee.ID = " + ID;
                        }
                        if (FirstName != "")
                        {
                            if (ID != "")
                                CmdString += " AND FirstName LIKE '" + FirstName + "'";
                            else
                                CmdString += "WHERE FirstName LIKE '" + FirstName + "'";
                        }
                        if (MiddleName != "")
                        {
                            if (FirstName != "" || ID != "")
                                CmdString += " AND MiddleName LIKE '" + MiddleName + "'";
                            else
                                CmdString += "WHERE MiddleName LIKE " + MiddleName + "'";
                        }
                        if (LastName != "")
                        {
                            if (FirstName != "" || MiddleName != "" || ID != "")
                                CmdString += " AND LastName LIKE '" + LastName + "'";
                            else
                                CmdString += "WHERE LastName LIKE '" + LastName + "'";
                        }
                        if (SupervisorID != "")
                        {
                            if (FirstName != "" || MiddleName != "" || LastName != "" || ID != "")
                                CmdString += " AND SupervisorID LIKE " + SupervisorID;
                            else
                                CmdString += "WHERE SupervisorID LIKE " + SupervisorID;
                        }

                        if (PhoneNumber != "")
                        {
                            if (FirstName != "" || MiddleName != "" || LastName != "" || ID != "" || SupervisorID != "")
                            {
                                CmdString += " AND Number = '" + PhoneNumber + "'";
                            }
                            else                            
                                CmdString += "WHERE Number = '" + PhoneNumber + "'";                       
                        }
                        if (Email != "")
                        {
                            if (FirstName != "" || MiddleName != "" || LastName != "" || SupervisorID != "" || ID != "" || PhoneNumber != "")
                                CmdString += " AND Email = '" + Email + "'";
                            else
                                CmdString += "WHERE Email = '" + Email + "'";
                        }
                        if (Title != "")
                        {
                            if (FirstName != "" || MiddleName != "" || LastName != "" || SupervisorID != "" || Email != "" || ID != "" || PhoneNumber != "")

                                CmdString += " AND Title = '" + Title + "'";
                            else
                                CmdString += "WHERE Title = '" + Title + "'";
                        }

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        emp_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;

                    case 2:
                        CmdString = "INSERT INTO PhoneInfo (Number, TypeID) VALUES ('" + PhoneNumber + "' , 'C')";// make a separate box for type

                        cmd = new MySqlCommand(CmdString, conn);
                        cmd.ExecuteNonQuery();

                        CmdString = "INSERT INTO Employee (FirstName, MiddleName, LastName, SupervisorID, PhoneID, Email, Title) VALUES" +
                            " ('" + FirstName + "'";
                        if (MiddleName != "")
                        {
                            CmdString += ",'" + MiddleName + "'";
                        }
                        else
                        {
                            CmdString += ", NULL";
                        }

                        CmdString += ", '" + LastName + "'";

                        if (SupervisorID != "")
                        {
                            CmdString += ", " + SupervisorID;
                        }
                        else
                        {
                            CmdString += ", NULL";
                        }

                        CmdString += ", last_insert_id() "
                        + ",'" + Email + "'"
                        + ", '" + Title + "')";

                        cmd = new MySqlCommand(CmdString, conn);
                        cmd.ExecuteNonQuery();


                        CmdString = "SELECT FirstName, MiddleName, LastName, SupervisorID, Number, Email, Title " +
                        "FROM Employee JOIN PhoneInfo ON(Employee.PhoneID = PhoneInfo.ID)";

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        emp_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;

                    case 3:
                        CmdString = "UPDATE Employee SET ";

                        if (FirstName != "")
                        {
                            CmdString += "FirstName = '" + FirstName + "'";
                        }
                        if (MiddleName != "")
                        {
                            if (FirstName != "")
                                CmdString += ", MiddleName = '" + MiddleName + "'";
                            else
                                CmdString += "MiddleName = " + MiddleName + "'";
                        }
                        if (LastName != "")
                        {
                            if (FirstName != "" || MiddleName != "")
                                CmdString += ", LastName = '" + LastName + "'";
                            else
                                CmdString += "LastName = '" + LastName + "'";
                        }
                        if (SupervisorID != "")
                        {
                            if (FirstName != "" || MiddleName != "" || LastName != "")
                                CmdString += ", SupervisorID = " + SupervisorID;
                            else
                                CmdString += "SupervisorID = " + SupervisorID;
                        }
                        if (Email != "")
                        {
                            if (FirstName != "" || MiddleName != "" || LastName != "" || SupervisorID != "")
                                CmdString += ", Email = '" + Email + "'";
                            else
                                CmdString += "Email = '" + Email + "'";
                        }
                        if (Title != "")
                        {
                            if (FirstName != "" || MiddleName != "" || LastName != "" || SupervisorID != "" || Email != "")
                                CmdString += ", Title = '" + Title + "'";
                            else
                                CmdString += "Title = '" + Title + "'";
                        }
                        CmdString += "WHERE ID = " + ID;

                        if (PhoneNumber != "")
                        {
                            CmdString = "UPDATE PhoneInfo SET Number = '" + PhoneNumber + "' WHERE ID = (SELECT PhoneID FROM Employee WHERE ID = " + ID + ")";
                        }


                        cmd = new MySqlCommand(CmdString, conn);
                        cmd.ExecuteNonQuery();

                        CmdString = "SELECT FirstName, MiddleName, LastName, SupervisorID, Number, Email, Title " +
                            "FROM Employee JOIN PhoneInfo ON(Employee.PhoneID = PhoneInfo.ID)";

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        emp_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;

                    case 4:
                        CmdString = "UPDATE Employee SET Title = 'Terminated' WHERE Employee.id = '" + ID + "'";

                        cmd = new MySqlCommand(CmdString, conn);
                        cmd.ExecuteNonQuery();

                        CmdString = "SELECT FirstName, MiddleName, LastName, SupervisorID, Number, Email, Title " +
                            "FROM Employee JOIN PhoneInfo ON(Employee.PhoneID = PhoneInfo.ID)";

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        emp_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
