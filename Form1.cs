using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
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

            cust_comboBox.Items.Add("All Customers");
            cust_comboBox.Items.Add("Search Customers");
            cust_comboBox.Items.Add("Add Customer");
            cust_comboBox.Items.Add("Update Customer");
            cust_comboBox.Items.Add("Delete Customer");

            cars_comboBox.Items.Add("All Inventory");
            cars_comboBox.Items.Add("Search Car");
            cars_comboBox.Items.Add("Add Car");
            cars_comboBox.Items.Add("Update Car");
            cars_comboBox.Items.Add("Delete Car");

            cars_StatusComboBox.Items.Add("");
            cars_StatusComboBox.Items.Add("Available");
            cars_StatusComboBox.Items.Add("Sold");
            cars_StatusComboBox.Items.Add("Incoming Shipment");

            emp_comboBox.Items.Add("All Employees");
            emp_comboBox.Items.Add("Search Employee");
            emp_comboBox.Items.Add("Add New Employee");
            emp_comboBox.Items.Add("Update Employee");
            emp_comboBox.Items.Add("Delete Employee");

            sales_comboBox.Items.Add("All Sales");
            sales_comboBox.Items.Add("Show Sale Count");
            sales_comboBox.Items.Add("Search Sales");
            sales_comboBox.Items.Add("Create Sale");
            sales_comboBox.Items.Add("Update A Sale");
            sales_comboBox.Items.Add("Delete A Sale");

            cust_comboBox.SelectedIndex = 0;
            emp_comboBox.SelectedIndex = 0;
            sales_comboBox.SelectedIndex = 0;
            cars_comboBox.SelectedIndex = 0;
            cars_StatusComboBox.SelectedIndex = 0;
        }
        private void cust_Button_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = null;
                MySqlDataAdapter sda = null;
                conn = new MySqlConnection(connString);
                DataSet ds = new DataSet();
                conn.Open();

                string FirstName = cust_firstNMTxtB.Text.ToString();
                string MiddleName = cust_middleNMTxtB.Text.ToString();
                string LastName = cust_lastNMTxtB.Text.ToString();
                string PhoneNumber = cust_PhoneNbrTxtB.Text.ToString();
                string Status = cust_StatusTxtB.Text.ToString();
                string Email = cust_emailTxtB.Text.ToString();
                string CmdString = "";

                switch (cust_comboBox.SelectedIndex)
                {
                    case 0:
                        //Show All
                        CmdString = "SELECT FirstName, MiddleName, LastName, Number, Email, Status " +
                            "FROM Customer JOIN PhoneInfo ON(Customer.ID = PhoneInfo.CustomerID)";

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        cust_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;

                    case 1:
                        //Search
                        CmdString = "SELECT FirstName, MiddleName, LastName, Number, Email, Status " +
                            "FROM Customer JOIN PhoneInfo ON(Customer.ID = PhoneInfo.CustomerID)";

                        if (FirstName != "")
                        {
                            CmdString += "WHERE FirstName LIKE '" + FirstName + "%'";
                        }

                        if (MiddleName != "")
                        {
                            if (FirstName != "")
                                CmdString += " AND MiddleName LIKE '" + MiddleName + "%'";
                            else
                                CmdString += "WHERE MiddleName LIKE '" + MiddleName + "%'";
                        }
                        if (LastName != "")
                        {
                            if (FirstName != "" || MiddleName != "")
                                CmdString += " AND LastName LIKE '" + LastName + "%'";
                            else
                                CmdString += "WHERE LastName LIKE '" + LastName + "%'";
                        }
                        if (PhoneNumber != "")
                        {
                            if (FirstName != "" || MiddleName != "" || LastName != "")
                                CmdString += " AND Number LIKE '" + PhoneNumber + "%'";
                            else
                                CmdString += "WHERE Number LIKE '" + PhoneNumber + "%'";
                        }
                        if (Email != "")
                        {
                            if (FirstName != "" || MiddleName != "" || LastName != "" || PhoneNumber != "")
                                CmdString += " AND Email LIKE '" + Email + "%'";
                            else
                                CmdString += "WHERE Email LIKE '" + Email + "%'";
                        }
                        if (Status != "")
                        {
                            if (FirstName != "" || MiddleName != "" || LastName != "" || PhoneNumber != "" || Email != "")
                                CmdString += " AND Status LIKE '" + Status + "%'";
                            else
                                CmdString += "WHERE Status LIKE '" + Status + "%'";
                        }

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        cust_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;

                    case 2:
                        //Add
                        CmdString = "INSERT INTO Customer (FirstName, MiddleName, LastName, Status, Email) VALUES ("
                        + "'" + FirstName + "'";
                        if (MiddleName != "")
                            CmdString += ",'" + MiddleName + "'";
                        else
                            CmdString += ", NULL";
                        CmdString += ", '" + LastName + "'"
                        + ",'" + Status + "'"
                        + ",'" + Email + "')";

                        cmd = new MySqlCommand(CmdString, conn);
                        cmd.ExecuteNonQuery();

                        CmdString = "INSERT INTO PhoneInfo (TypeID, Number, CustomerID) VALUES ( 'C', '" + PhoneNumber + "', last_insert_id())";

                        cmd = new MySqlCommand(CmdString, conn);
                        cmd.ExecuteNonQuery();


                        CmdString = "SELECT FirstName, MiddleName, LastName, Number, Email " +
                            "FROM Customer JOIN PhoneInfo ON (Customer.ID = PhoneInfo.CustomerID)";

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        cust_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;

                    case 3:
                        //Update
                        CmdString = "UPDATE Customer SET ";
                        if (FirstName != "")
                        {
                            CmdString += "FirstName = '" + FirstName + "'";
                        }
                        if (MiddleName != "")
                        {
                            if (FirstName != "")
                                CmdString += ", MiddleName = '" + MiddleName + "'";
                            else
                                CmdString += "MiddleName = '" + MiddleName + "'";
                        }
                        if (LastName != "")
                        {
                            if (FirstName != "" || MiddleName != "")
                                CmdString += ", LastName = '" + LastName + "'";
                            else
                                CmdString += "LastName = '" + LastName + "'";
                        }
                        if (Status != "")
                        {
                            if (FirstName != "" || MiddleName != "")
                                CmdString += ", Status = '" + Status + "'";
                            else
                                CmdString += "Status = '" + Status + "'";
                        }
                        CmdString += "WHERE Email = '" + Email + "'";

                        if (PhoneNumber != "")
                        {
                            CmdString = "UPDATE PhoneInfo SET Number = '" + PhoneNumber +
                            "' WHERE EmployeeID = (SELECT ID FROM Employee WHERE Email = '" + Email + "')";
                        }

                        cmd = new MySqlCommand(CmdString, conn);
                        cmd.ExecuteNonQuery();

                        CmdString = "SELECT FirstName, MiddleName, LastName, Number, Email, Status " +
                            "FROM Customer JOIN PhoneInfo ON (Customer.ID = PhoneInfo.CustomerID)";

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        cust_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;

                    case 4:
                        //Delete
                        CmdString = "UPDATE Customer SET Status = 'Non Member' WHERE Email = '" + Email + "'";

                        cmd = new MySqlCommand(CmdString, conn);
                        cmd.ExecuteNonQuery();

                        CmdString = "SELECT FirstName, MiddleName, LastName, Number, Email " +
                            "FROM Customer JOIN PhoneInfo ON(Customer.ID = PhoneInfo.CustomerID)";

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        cust_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message, "MySQL Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string Status = cars_StatusComboBox.SelectedItem.ToString();
                string CmdString = "";

                switch (cars_comboBox.SelectedIndex)
                {
                    case 0:
                        //Show Inventory
                        CmdString = "SELECT VIN, Make, Model, Year, Color, COALESCE(Mileage, 'Unknown') AS Mileage, Used, Status FROM Car ORDER BY Make ASC";
                        sda = new MySqlDataAdapter(CmdString, conn);

                        sda.Fill(ds);
                        cars_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;
                    case 1:
                        //Search
                        CmdString = "SELECT VIN, Make, Model, Year, Color, COALESCE(Mileage, 'Unknown') AS Mileage, Used, Status FROM Car ";
                        if (VIN != "")
                        {
                            CmdString += "WHERE VIN LIKE '" + VIN + "%'";
                        }
                        if (Make != "")
                        {
                            if (VIN != "")
                                CmdString += "AND Make LIKE '" + Make + "%'";
                            else
                                CmdString += "WHERE Make LIKE '" + Make + "%'";
                        }
                        if (Model != "")
                        {
                            if (VIN != "" || Make != "")
                                CmdString += " AND Model LIKE '" + Model + "%'";
                            else
                                CmdString += "WHERE Model LIKE '" + Model + "%'";
                        }
                        if (Year != "")
                        {
                            if (VIN != "" || Make != "" || Model != "")
                                CmdString += " AND Year LIKE " + Year;
                            else
                                CmdString += "WHERE Year LIKE " + Year;
                        }
                        if (Color != "")
                        {
                            if (VIN != "" || Make != "" || Model != "" || Year != "")
                                CmdString += " AND Color LIKE '" + Color + "%'";
                            else
                                CmdString += "WHERE Color LIKE '" + Color + "%'";
                        }
                        if (Mileage != "")
                        {
                            if (VIN != "" || Make != "" || Model != "" || Year != "" || Color != "")
                                CmdString += " AND Mileage <= " + Mileage;
                            else
                                CmdString += "WHERE Mileage <= " + Mileage;
                        }
                        if (cars_YesCheckBox.Checked == true || cars_NoCheckBox.Checked == true)
                        {
                            if (VIN != "" || Make != "" || Model != "" || Year != "" || Color != "" || Mileage != "")
                                CmdString += " AND Used = " + Used;
                            else
                                CmdString += "WHERE Used = " + Used;
                        }
                        else if (cars_YesCheckBox.Checked == false && cars_NoCheckBox.Checked == true)
                        {
                            if (VIN != "" || Make != "" || Model != "" || Year != "" || Color != "" || Mileage != "")
                                CmdString += " AND Used IS NOT NULL";
                            else
                                CmdString += "WHERE Used IS NOT NULL";
                        }
                        if (Status != "")
                        {
                            if (VIN != "" || Make != "" || Model != "" || Year != "" || Color != "" || Mileage != "" || cars_YesCheckBox.Checked == true || cars_NoCheckBox.Checked == true)
                                CmdString += " AND Status = Like '" + Status + "'";
                            else
                                CmdString += "WHERE Status  Like  '" + Status + "'";
                        }

                        CmdString += " ORDER BY Make, Model ASC";

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        cars_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;
                    case 2:
                        //Add

                        if (VinLength < 17 || VinLength > 17)
                        {
                            MessageBox.Show("Invalid VIN length\nVIN length was: " + VinLength + "\nVIN must be 17 digits", "VIN Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        CmdString = "INSERT INTO Car (VIN, Make, Model, Year, Color, Mileage, Used, Status ) VALUES ("
                                               + "'" + VIN + "'"
                                               + ",'" + Make + "'"
                                               + ",'" + Model + "'"
                                               + ",'" + Year + "'";
                        if (Color != "")
                            CmdString += ",'" + Color + "'";
                        else
                            CmdString += ", NULL";
                        if (Mileage != "")
                            CmdString += ", " + Mileage;
                        else
                            CmdString += ", NULL";
                        CmdString += "," + Used + ""
                       + ", '" + Status + "')";

                        cmd = new MySqlCommand(CmdString, conn);
                        cmd.ExecuteNonQuery();

                        CmdString = "SELECT VIN, Make, Model, Year, Color, COALESCE(Mileage, 'Unknown') AS Mileage, Used, Status FROM Car ORDER BY Make, Model ASC";
                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        cars_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;

                    case 3:
                        //Update
                        CmdString = "UPDATE Car SET ";
                        if (Make != "")
                        {
                            CmdString += "Make = '" + Make + "'";
                        }
                        if (Model != "")
                        {
                            if (Make != "")
                                CmdString += ", Model = '" + Model + "'";
                            else
                                CmdString += "Model = '" + Model + "'";
                        }
                        if (Year != "")
                        {
                            if (Make != "" || Model != "")
                                CmdString += ", Year " + Year;
                            else
                                CmdString += "Year = " + Year;
                        }
                        if (Color != "")
                        {
                            if (Make != "" || Model != "" || Year != "")
                                CmdString += ", Color = '" + Color + "'";
                            else
                                CmdString += "Color = '" + Color + "'";
                        }
                        if (Mileage != "")
                        {
                            if (Make != "" || Model != "" || Year != "")
                                CmdString += ", Milage = " + Mileage;
                            else
                                CmdString += "Milage = " + Mileage;
                        }
                        CmdString += " WHERE VIN = '" + VIN + "'";

                        cmd = new MySqlCommand(CmdString, conn);
                        cmd.ExecuteNonQuery();

                        CmdString = "SELECT VIN, Make, Model, Year, Color, COALESCE(Mileage, 'Unknown') AS Mileage, Used, Status FROM Car ORDER BY Make, Model ASC";
                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        cars_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;

                    case 4:
                        //Delete
                        CmdString = "UPDATE Car SET Status = 'Removed' WHERE VIN = '" + VIN + "'";

                        cmd = new MySqlCommand(CmdString, conn);
                        cmd.ExecuteNonQuery();

                        CmdString = "SELECT VIN, Make, Model, Year, Color, COALESCE(Mileage, 'Unknown') AS Mileage, Used, Status FROM Car ORDER BY Make, Model ASC";
                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        cars_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message, "MySQL Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                string FirstName = emp_FirstNameTxtB.Text.ToString();
                string MiddleName = emp_MiddleNameTxtB.Text.ToString();
                string LastName = emp_LastNameTxtB.Text.ToString();
                string PhoneNumber = emp_PhoneTxtB.Text.ToString();
                string Supervisor = emp_SupervisorTxtB.Text.ToString();
                string Email = emp_EmailTxtB.Text.ToString();
                string Title = emp_TitleTxtB.Text.ToString();
                string CmdString = "";

                switch (emp_comboBox.SelectedIndex)
                {
                    case 0:
                        CmdString = "SELECT Employee.FirstName, Employee.MiddleName, Employee.LastName, CONCAT(S.FirstName, ' ', S.LastName) AS Supervisor, Number, Employee.Email, Employee.Title " +
                             "FROM Employee JOIN PhoneInfo ON(Employee.ID = PhoneInfo.EmployeeID)" +
                             " LEFT JOIN Employee S ON(Employee.SupervisorID = S.ID) ";

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        emp_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;

                    case 1:
                        //Search
                        CmdString = "SELECT Employee.FirstName, Employee.MiddleName, Employee.LastName, CONCAT(S.FirstName, ' ', S.LastName) AS Supervisor, Number, Employee.Email, Employee.Title, COUNT(*) AS 'Number of Sales'" +
                             " FROM Employee JOIN PhoneInfo ON(Employee.ID = PhoneInfo.EmployeeID)" +
                             " LEFT JOIN Employee S ON(Employee.SupervisorID = S.ID)";
                        if (FirstName != "")
                        {
                            CmdString += "WHERE Employee.FirstName LIKE '" + FirstName + "%'";
                        }

                        if (MiddleName != "")
                        {
                            if (FirstName != "")
                                CmdString += " AND Employee.MiddleName LIKE '" + MiddleName + "%'";
                            else
                                CmdString += "WHERE Employee.MiddleName LIKE '" + MiddleName + "%'";
                        }
                        if (LastName != "")
                        {
                            if (FirstName != "" || MiddleName != "")
                                CmdString += " AND Employee.LastName LIKE '" + LastName + "%'";
                            else
                                CmdString += "WHERE Employee.LastName LIKE '" + LastName + "%'";
                        }
                        if (Supervisor != "")
                        {

                            if (FirstName != "" || MiddleName != "" || LastName != "")
                                CmdString += " AND Employee.SupervisorID = (SELECT ID FROM Employee WHERE FirstName LIKE '" + Supervisor + "%' OR LastName LIKE '" + Supervisor + "%' OR CONCAT(FirstName, ' ', LastName) LIKE '" + Supervisor + "')";

                            else
                                CmdString += "WHERE Employee.SupervisorID = (SELECT ID FROM Employee WHERE FirstName LIKE '" + Supervisor + "%' OR LastName LIKE '" + Supervisor + "%'  OR CONCAT(FirstName, ' ', LastName) LIKE '" + Supervisor + "')";
                        }

                        if (PhoneNumber != "")
                        {
                            if (FirstName != "" || MiddleName != "" || LastName != "" || Supervisor != "")
                                CmdString += " AND Number LIKE '" + PhoneNumber + "%'";
                            else
                                CmdString += "WHERE Number LIKE '" + PhoneNumber + "%'";
                        }
                        if (Email != "")
                        {
                            if (FirstName != "" || MiddleName != "" || LastName != "" || Supervisor != "" || PhoneNumber != "")
                                CmdString += " AND Employee.Email LIKE '" + Email + "%'";
                            else
                                CmdString += "WHERE Employee.Email LIKE '" + Email + "%'";
                        }
                        if (Title != "")
                        {
                            if (FirstName != "" || MiddleName != "" || LastName != "" || Supervisor != "" || Email != "" || PhoneNumber != "")

                                CmdString += " AND Employee.Title LIKE '" + Title + "%'";
                            else
                                CmdString += "WHERE Employee.Title LIKE '" + Title + "%'";
                        }

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        emp_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;

                    case 2:
                        //Add
                        CmdString = "INSERT INTO Employee (FirstName, MiddleName, LastName, SupervisorID, Email, Title) VALUES ("
                        + "'" + FirstName + "'";
                        if (MiddleName != "")
                            CmdString += ",'" + MiddleName + "'";
                        else
                            CmdString += ", NULL";
                        CmdString += ", '" + LastName + "'";
                        if (Supervisor != "")
                            CmdString += ", (SELECT ID FROM Employee WHERE CONCAT(FirstName, ' ', LastName) LIKE '" + Supervisor + "')";
                        else
                            CmdString += ", NULL";
                        CmdString += ",'" + Email + "'"
                        + ", '" + Title + "')";

                        cmd = new MySqlCommand(CmdString, conn);
                        cmd.ExecuteNonQuery();

                        CmdString = "INSERT INTO PhoneInfo (TypeID, Number, EmployeeID) VALUES ( 'C', '" + PhoneNumber + "', last_insert_id())";

                        cmd = new MySqlCommand(CmdString, conn);
                        cmd.ExecuteNonQuery();


                        CmdString = "SELECT Employee.FirstName, Employee.MiddleName, Employee.LastName, CONCAT(S.FirstName, ' ', S.LastName) AS Supervisor, Number, Employee.Email, Employee.Title, COUNT(*) AS 'Number of Sales'" +
                            "FROM Employee JOIN PhoneInfo ON(Employee.ID = PhoneInfo.EmployeeID)" +
                            "LEFT JOIN Employee S ON(Employee.SupervisorID = S.ID) GROUP BY Employee.ID";

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        emp_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;

                    case 3:
                        //Update
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
                        if (Supervisor != "")
                        {
                            if (FirstName != "" || MiddleName != "" || LastName != "")
                                CmdString += ", (SELECT SupervisorID FROM Employee WHERE CONCAT(FirstName, ' ', LastName) LIKE '" + Supervisor + "')";
                            else
                                CmdString += ", (SELECT SupervisorID FROM Employee WHERE CONCAT(FirstName, ' ', LastName) LIKE '" + Supervisor + "')";
                        }
                        if (Title != "")
                        {
                            if (FirstName != "" || MiddleName != "" || LastName != "" || Supervisor != "")
                                CmdString += ", Title = '" + Title + "'";
                            else
                                CmdString += "Title = '" + Title + "'";
                        }

                        CmdString += " WHERE Email = '" + Email + "'";

                        if (PhoneNumber != "")
                        {
                            CmdString = "UPDATE PhoneInfo SET Number = '" + PhoneNumber +
                            "' WHERE EmployeeID = (SELECT ID FROM Employee WHERE Email = '" + Email + "')";
                        }

                        cmd = new MySqlCommand(CmdString, conn);
                        cmd.ExecuteNonQuery();

                        CmdString = "SELECT Employee.FirstName, Employee.MiddleName, Employee.LastName, CONCAT(S.FirstName, ' ', S.LastName) AS Supervisor, Number, Employee.Email, Employee.Title, COUNT(*) AS 'Number of Sales'" +
                            "FROM Employee JOIN PhoneInfo ON(Employee.ID = PhoneInfo.EmployeeID)" +
                            "LEFT JOIN Employee S ON(S.SupervisorID = S.ID) GROUP BY Employee.ID";

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        emp_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;

                    case 4:
                        //Delete
                        CmdString = "UPDATE Employee SET Title = 'Terminated' WHERE Email = '" + Email + "'";

                        cmd = new MySqlCommand(CmdString, conn);
                        cmd.ExecuteNonQuery();

                        CmdString = "SELECT Employee.FirstName, Employee.MiddleName, Employee.LastName, CONCAT(S.FirstName, ' ', S.LastName) AS Supervisor, Number, Employee.Email, Employee.Title, COUNT(*) AS 'Number of Sales'" +
                            "FROM Employee JOIN PhoneInfo ON(Employee.ID = PhoneInfo.EmployeeID)" +
                            "LEFT JOIN Employee S ON(Employee.SupervisorID = S.ID) GROUP BY Employee.ID";

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        emp_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message, "MySQL Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void sales_Button_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter sda = null;
                MySqlCommand cmd = null;
                conn = new MySqlConnection(connString);
                DataSet ds = new DataSet();
                conn.Open();

                string VIN = sales_VINTxtB.Text.ToString();
                int VinLength = VIN.Length;
                string CustEmail = sales_CustTxtB.Text.ToString();
                string EmpEmail = sales_EmpTxtB.Text.ToString();
                string Price = sales_PriceTxtB.Text.ToString();
                string CmdString = "";

                //to do for sales:
                //Implement date option potentially?
                switch (sales_comboBox.SelectedIndex)
                {
                    case 0:
                        //Show
                        CmdString = "SELECT Price AS '$Price', CONCAT(Customer.FirstName, ' ', Customer.LastName) AS Customer," +
                            " CONCAT(Employee.FirstName, ' ', Employee.LastName) AS Employee, Date, VIN FROM Sale JOIN Car ON(CarID = Car.ID) JOIN Employee ON(Employeeid = Employee.id) JOIN Customer ON(Customer.id = CustomerID) " +
                            "ORDER BY Date";

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        sales_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;
                    case 1:
                        //Show Sales Count
                        //for looking at specific employee counts
                        if(EmpEmail != "")
                        {
                            CmdString = "SELECT MONTH(Date) AS Month, YEAR(Date) AS Year, COUNT(*) AS 'Number Of Sales' " +
                                "FROM Sale " +
                                "WHERE EmployeeID = (SELECT ID FROM Employee WHERE Email LIKE '" + EmpEmail + "%')  " +
                                "GROUP BY MONTH(Date)";
                        }
                        //for looking at cars sold
                        else
                        {
                            CmdString = "SELECT * " +
                                         "FROM(" +
                                            "SELECT Make, Model, Year AS 'Model Year', MONTH(Date) AS Month, YEAR(Date) AS Year, COUNT(*) AS 'NumSales'" +
                                            "FROM Sale " +
                                            "JOIN Car ON(CarID = Car.ID) " +
                                            "GROUP BY Make, Model, Car.Year " +

                                            "UNION \n" +

                                            "SELECT IF(Make != '', 'Total', '') AS Make, IF(Model != '', '-------', '') AS Model, IF(Car.Year != '', '-------->', '') AS 'Model Year',  " +
                                            "MONTH(Date) AS Month, YEAR(Date) AS Year, COUNT(*) AS 'NumSales' " +
                                            "FROM Sale " +
                                            "JOIN Car ON(CarID = Car.ID) " +
                                            "GROUP BY MONTH(Date) " +
                                            ") temp ORDER BY temp.Month, temp.Year";
                        }
                        

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        sales_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;
                    case 2:
                        //Search
                        CmdString = "";

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        sales_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;
                    case 3:
                        //Create

                        if (VinLength < 17 || VinLength > 17)
                        {
                            MessageBox.Show("Invalid VIN length\nVIN length was: " + VinLength + "\nVIN must be 17 digits", "VIN Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        if (Price != "")
                        {
                            CmdString = "INSERT INTO Sale(Price, CustomerID, EmployeeID, CarID)" +
                                    "Values(" + Price + ", " +
                                    "(SELECT ID FROM Customer WHERE Email LIKE '" + CustEmail + "'), " +
                                    "(SELECT ID FROM Employee WHERE Email LIKE '" + EmpEmail + "'), " +
                                    "(SELECT ID FROM Car WHERE VIN = '" + VIN + "')); " +
                                    "UPDATE Car SET Status = 'Sold' WHERE VIN = '" + VIN + "'";
                        }
                        else
                        {
                            CmdString = "INSERT INTO Sale(CustomerID, EmployeeID, CarID)" +
                                   "Values("+
                                   "(SELECT ID FROM Customer WHERE Email LIKE '" + CustEmail + "'), " +
                                   "(SELECT ID FROM Employee WHERE Email LIKE '" + EmpEmail + "'), " +
                                   "(SELECT ID FROM Car WHERE VIN = '" + VIN + "')); " +
                                   "UPDATE Car SET Status = 'Sold' WHERE VIN = '" + VIN + "'";
                        }

                        cmd = new MySqlCommand(CmdString, conn);
                        cmd.ExecuteNonQuery();

                        CmdString = "SELECT Price AS '$Price', CONCAT(Customer.FirstName, ' ', Customer.LastName) AS Customer," +
                            " CONCAT(Employee.FirstName, ' ', Employee.LastName) AS Employee, Date, VIN FROM Sale JOIN Car ON(CarID = Car.ID) JOIN Employee ON(Employeeid = Employee.id) JOIN Customer ON(Customer.id = CustomerID) " +
                            "ORDER BY Date";

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        sales_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;
                    case 4:
                        //Update
                        CmdString = "UPDATE Sale SET ";
                        //for if customer email is being update
                        if (CustEmail != "")
                        {
                            CmdString += "CustomerID = (SELECT ID FROM Customer WHERE Email LIKE '" + CustEmail + "') ";
                        }

                        //if customer and emp are being updated, else just employee being updated
                        if (EmpEmail != "")
                        {
                            if (EmpEmail != "" && CustEmail != "")
                            {
                                CmdString += ", EmployeeID = (SELECT ID FROM Employee WHERE Email LIKE '" + EmpEmail + "') ";
                            }
                            else
                            {
                                CmdString += "EmployeeID = (SELECT ID FROM Employee WHERE Email LIKE '" + EmpEmail + "') ";
                            }
                        }

                        //if either of prior are update else just price being updated
                        if (Price != "")
                        {
                            if (EmpEmail != "" || CustEmail != "")
                            {
                                CmdString += ", Price = " + Price + " ";
                            }
                            else
                            {
                                CmdString += "Price = " + Price + " ";
                            }
                        }

                        CmdString += "WHERE CarID = (SELECT ID FROM Car WHERE VIN = '" + VIN + "')";

                        cmd = new MySqlCommand(CmdString, conn);
                        cmd.ExecuteNonQuery();

                        CmdString = "SELECT Price AS '$Price', CONCAT(Customer.FirstName, ' ', Customer.LastName) AS Customer," +
                            " CONCAT(Employee.FirstName, ' ', Employee.LastName) AS Employee, Date, VIN FROM Sale JOIN Car ON(CarID = Car.ID) JOIN Employee ON(Employeeid = Employee.id) JOIN Customer ON(Customer.id = CustomerID) " +
                            "ORDER BY Date";

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        sales_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;
                    case 5:
                        //Delete
                        CmdString = "DELETE FROM Sale WHERE CarID = (SELECT ID FROM Car WHERE VIN = '" + VIN + "')";

                        cmd = new MySqlCommand(CmdString, conn);
                        cmd.ExecuteNonQuery();

                        CmdString = "SELECT Price AS '$Price', CONCAT(Customer.FirstName, ' ', Customer.LastName) AS Customer," +
                            " CONCAT(Employee.FirstName, ' ', Employee.LastName) AS Employee, Date, VIN FROM Sale JOIN Car ON(CarID = Car.ID) JOIN Employee ON(Employeeid = Employee.id) JOIN Customer ON(Customer.id = CustomerID) " +
                            "ORDER BY Date";

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        sales_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message, "MySQL Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void custUI(bool first, bool middle, bool last, bool number, bool status, bool email)
        {
            cust_firstNMLbl.Visible = first;
            cust_firstNMTxtB.Visible = first;
            cust_middleNMLbl.Visible = middle;
            cust_middleNMTxtB.Visible = middle;
            cust_lastNMLbl.Visible = last;
            cust_lastNMTxtB.Visible = last;
            cust_PhoneNbrLbl.Visible = number;
            cust_PhoneNbrTxtB.Visible = number;
            cust_StatusLbl.Visible = status;
            cust_StatusTxtB.Visible = status;
            cust_emailLbl.Visible = email;
            cust_emailTxtB.Visible = email;
        }
        private void cust_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cust_comboBox.SelectedIndex)
            {
                case 0:
                    cust_Button.Text = "Show Customers";
                    cust_emailLbl.Text = "Email";
                    custUI(false, false, false, false, false, false);
                    break;
                case 1:
                    cust_Button.Text = "Search Customers";
                    cust_emailLbl.Text = "Email";
                    custUI(true, true, true, true, true, true);
                    break;
                case 2:
                    cust_Button.Text = "Add Customer";
                    cust_emailLbl.Text = "Email";
                    custUI(true, true, true, true, true, true);
                    break;
                case 3:
                    cust_Button.Text = "Update Customer";
                    cust_emailLbl.Text = "*Email";
                    custUI(true, true, true, true, true, true);
                    break;

                case 4:
                    cust_Button.Text = "Delete Customer";
                    cust_emailLbl.Text = "Email";
                    custUI(true, true, true, true, true, true);
                    break;
            }
        }
        public void carsUI(bool VIN, bool make, bool model, bool year, bool color, bool mileage, bool status, bool used_CheckBoxs)
        {
            cars_VINLbl.Visible = VIN;
            cars_VINTxtB.Visible = VIN;
            cars_makeLbl.Visible = make;
            cars_makeTxtB.Visible = make;
            cars_modelLbl.Visible = model;
            cars_modelTxtB.Visible = model;
            cars_YearLbl.Visible = year;
            cars_YearTxtB.Visible = year;
            cars_YearTxtB.Visible = year;
            cars_ColorLbl.Visible = color;
            cars_ColorTxtB.Visible = color;
            cars_MilageLbl.Visible = mileage;
            cars_MileageTxtB.Visible = mileage;
            cars_StatusLbl.Visible = status;
            cars_StatusComboBox.Visible = status;
            cars_usedLbl.Visible = used_CheckBoxs;
            cars_YesCheckBox.Visible = used_CheckBoxs;
            cars_NoCheckBox.Visible = used_CheckBoxs;
        }
        private void cars_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cars_comboBox.SelectedIndex)
            {
                case 0:
                    car_SearchBtn.Text = "Show Inventory";
                    carsUI(false, false, false, false, false, false, false, false);
                    break;
                case 1:
                    car_SearchBtn.Text = "Search Cars";
                    carsUI(true, true, true, true, true, true, true, true);
                    break;
                case 2:
                    car_SearchBtn.Text = "Add Car";
                    carsUI(true, true, true, true, true, true, true, true);
                    break;
                case 3:
                    car_SearchBtn.Text = "Update Car";
                    cars_VINLbl.Text = "*VIN Number";
                    carsUI(true, true, true, true, true, true, true, true);
                    break;
                case 4:
                    car_SearchBtn.Text = "Delete Car";
                    carsUI(true, false, false, false, false, false, false, false);
                    break;
            }
        }
        void empUI(bool email, bool first, bool middle, bool last, bool number, bool supervisor, bool title)
        {
            emp_EmailLbl.Visible = email;
            emp_EmailTxtB.Visible = email;
            emp_FirstNameLbl.Visible = first;
            emp_FirstNameTxtB.Visible = first;
            emp_MiddleNameLbl.Visible = middle;
            emp_MiddleNameTxtB.Visible = middle;
            emp_LastNameLbl.Visible = last;
            emp_LastNameTxtB.Visible = last;
            emp_PhoneLbl.Visible = number;
            emp_PhoneTxtB.Visible = number;
            emp_SupervisorLbl.Visible = supervisor;
            emp_SupervisorTxtB.Visible = supervisor;
            emp_TitleLbl.Visible = title;
            emp_TitleTxtB.Visible = title;
        }
        private void emp_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (emp_comboBox.SelectedIndex)
            {
                case 0:
                    emp_Button.Text = "Show All";
                    emp_EmailLbl.Text = "Email";
                    empUI(false, false, false, false, false, false, false);
                    break;
                case 1:
                    emp_Button.Text = "Search";
                    emp_EmailLbl.Text = "Email";
                    empUI(true, true, true, true, true, true, true);
                    break;
                case 2:
                    emp_Button.Text = "Add Employee";
                    emp_EmailLbl.Text = "Email";
                    empUI(true, true, true, true, true, true, true);
                    break;
                case 3:
                    emp_Button.Text = "Update Employee";
                    emp_EmailLbl.Text = "*Email";
                    empUI(true, true, true, true, true, true, true);
                    break;
                case 4:
                    emp_Button.Text = "Delete Employee";
                    emp_EmailLbl.Text = "Email";
                    empUI(true, true, true, true, true, true, true);
                    break;
            }
        }
        public void saleUI(bool VIN, bool CEmail, bool EmpEmail, bool EmpName, bool CName, bool Price)
        {
            sales_VINLbl.Visible = VIN;
            sales_VINTxtB.Visible = VIN;
            sales_CustLbl.Visible = CEmail;
            sales_CustTxtB.Visible = CEmail;
            sales_EmpLbl.Visible = EmpEmail;
            sales_EmpTxtB.Visible = EmpEmail;
            sales_EmpNameLbl.Visible = EmpName;
            sales_EmpNameTxtB.Visible = EmpName;
            sales_CustNameLbl.Visible = CName;
            sales_CustNameTxtB.Visible = CName;
            sales_PriceLbl.Visible = Price;
            sales_PriceTxtB.Visible = Price;
        }
        private void sales_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sales_comboBox.SelectedIndex)
            {
                case 0:
                    //Show
                    sales_Button.Text = "Show All";
                    saleUI(false, false, false, false, false, false);
                    break;
                case 1:
                    //Show Sale Count
                    sales_EmpLbl.Text = "Employee Email";
                    sales_Button.Text = "Show Totals";
                    saleUI(false, false, true, false, false, false);
                    break;
                case 2:
                    //Search
                    sales_Button.Text = "Search Sales";
                    sales_VINLbl.Text = "VIN Number";
                    sales_CustLbl.Text = "Customer Email";
                    sales_EmpLbl.Text = "Employee Email";
                    saleUI(true, true, true, true, true, true);
                    break;
                case 3:
                    //Create
                    sales_Button.Text = "Complete Sale";
                    sales_VINLbl.Text = "*VIN Number";
                    sales_CustLbl.Text = "*Customer Email";
                    sales_EmpLbl.Text = "*Employee Email";
                    saleUI(true, true, true, false, false, true);
                    break;
                case 4:
                    //Update
                    sales_Button.Text = "Update Sale";
                    sales_VINLbl.Text = "*VIN Number";
                    sales_CustLbl.Text = "Customer Email";
                    sales_EmpLbl.Text = "Employee Email";
                    saleUI(true, true, true, false, false, true);
                    break;
                case 5:
                    //Delete
                    sales_Button.Text = "Delete Sale";
                    sales_VINLbl.Text = "*VIN Number";
                    saleUI(true, false, false, false, false, false);
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
                    cars_NoCheckBox.Checked = true;
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
                    cars_YesCheckBox.Checked = true;
                }
            }
        }
        private void sales_dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            sales_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = new DataGridViewCellStyle { ForeColor = Color.White, BackColor = Color.FromArgb(41, 44, 51) };
            sales_dataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            sales_dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
        }
        private void emp_dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            emp_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = new DataGridViewCellStyle { ForeColor = Color.White, BackColor = Color.FromArgb(41, 44, 51) };
            emp_dataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            emp_dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
        }
        private void cars_dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            cars_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = new DataGridViewCellStyle { ForeColor = Color.White, BackColor = Color.FromArgb(41, 44, 51) };
            cars_dataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            cars_dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
        }
        private void cust_dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            cust_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = new DataGridViewCellStyle { ForeColor = Color.White, BackColor = Color.FromArgb(41, 44, 51) };
            cust_dataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            cust_dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
        }
    }
}
