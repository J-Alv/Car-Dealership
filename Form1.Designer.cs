namespace Dealership
{
    partial class Dealership
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.customerTab = new MetroFramework.Controls.MetroTabPage();
            this.cust_dataGridView = new System.Windows.Forms.DataGridView();
            this.cust_emailTxtB = new System.Windows.Forms.TextBox();
            this.cust_emailLbl = new System.Windows.Forms.Label();
            this.cust_lastNMLbl = new System.Windows.Forms.Label();
            this.cust_lastNMTxtB = new System.Windows.Forms.TextBox();
            this.cust_middleNMTxtB = new System.Windows.Forms.TextBox();
            this.cust_middleNMLbl = new System.Windows.Forms.Label();
            this.cust_firstNMLbl = new System.Windows.Forms.Label();
            this.cust_firstNMTxtB = new System.Windows.Forms.TextBox();
            this.saleTab = new MetroFramework.Controls.MetroTabPage();
            this.carTab = new MetroFramework.Controls.MetroTabPage();
            this.employeeTab = new MetroFramework.Controls.MetroTabPage();
            this.cust_PhoneNbrTxtB = new System.Windows.Forms.TextBox();
            this.cust_PhoneNbrLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sales_FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sales_DateLbl = new System.Windows.Forms.Label();
            this.sales_ToDateTimePicker = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.sale_FirstNameLbl = new System.Windows.Forms.Label();
            this.sale_FirstNameTxtB = new System.Windows.Forms.TextBox();
            this.sale_LastNameLbl = new System.Windows.Forms.Label();
            this.sale_LastNameTxtB = new System.Windows.Forms.TextBox();
            this.sale_CustCheckBox = new System.Windows.Forms.CheckBox();
            this.sale_EmployeeCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.metroTabControl.SuspendLayout();
            this.customerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cust_dataGridView)).BeginInit();
            this.saleTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.titleLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 52);
            this.panel1.TabIndex = 0;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(0, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(273, 44);
            this.titleLbl.TabIndex = 2;
            this.titleLbl.Text = "Car Dealership";
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.customerTab);
            this.metroTabControl.Controls.Add(this.saleTab);
            this.metroTabControl.Controls.Add(this.carTab);
            this.metroTabControl.Controls.Add(this.employeeTab);
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl.Location = new System.Drawing.Point(0, 52);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 1;
            this.metroTabControl.Size = new System.Drawing.Size(950, 436);
            this.metroTabControl.TabIndex = 1;
            this.metroTabControl.UseSelectable = true;
            // 
            // customerTab
            // 
            this.customerTab.Controls.Add(this.cust_PhoneNbrTxtB);
            this.customerTab.Controls.Add(this.cust_PhoneNbrLbl);
            this.customerTab.Controls.Add(this.cust_dataGridView);
            this.customerTab.Controls.Add(this.cust_emailTxtB);
            this.customerTab.Controls.Add(this.cust_emailLbl);
            this.customerTab.Controls.Add(this.cust_lastNMLbl);
            this.customerTab.Controls.Add(this.cust_lastNMTxtB);
            this.customerTab.Controls.Add(this.cust_middleNMTxtB);
            this.customerTab.Controls.Add(this.cust_middleNMLbl);
            this.customerTab.Controls.Add(this.cust_firstNMLbl);
            this.customerTab.Controls.Add(this.cust_firstNMTxtB);
            this.customerTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTab.HorizontalScrollbarBarColor = true;
            this.customerTab.HorizontalScrollbarHighlightOnWheel = false;
            this.customerTab.HorizontalScrollbarSize = 10;
            this.customerTab.Location = new System.Drawing.Point(4, 38);
            this.customerTab.Name = "customerTab";
            this.customerTab.Size = new System.Drawing.Size(942, 394);
            this.customerTab.TabIndex = 0;
            this.customerTab.Text = "Customers";
            this.customerTab.VerticalScrollbarBarColor = true;
            this.customerTab.VerticalScrollbarHighlightOnWheel = false;
            this.customerTab.VerticalScrollbarSize = 10;
            // 
            // cust_dataGridView
            // 
            this.cust_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cust_dataGridView.Location = new System.Drawing.Point(386, 9);
            this.cust_dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cust_dataGridView.Name = "cust_dataGridView";
            this.cust_dataGridView.RowHeadersWidth = 51;
            this.cust_dataGridView.RowTemplate.Height = 24;
            this.cust_dataGridView.Size = new System.Drawing.Size(552, 374);
            this.cust_dataGridView.TabIndex = 10;
            // 
            // cust_emailTxtB
            // 
            this.cust_emailTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_emailTxtB.Location = new System.Drawing.Point(179, 234);
            this.cust_emailTxtB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cust_emailTxtB.Name = "cust_emailTxtB";
            this.cust_emailTxtB.Size = new System.Drawing.Size(192, 29);
            this.cust_emailTxtB.TabIndex = 9;
            // 
            // cust_emailLbl
            // 
            this.cust_emailLbl.AutoSize = true;
            this.cust_emailLbl.BackColor = System.Drawing.Color.White;
            this.cust_emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_emailLbl.Location = new System.Drawing.Point(8, 238);
            this.cust_emailLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cust_emailLbl.Name = "cust_emailLbl";
            this.cust_emailLbl.Size = new System.Drawing.Size(57, 24);
            this.cust_emailLbl.TabIndex = 8;
            this.cust_emailLbl.Text = "Email";
            // 
            // cust_lastNMLbl
            // 
            this.cust_lastNMLbl.AutoSize = true;
            this.cust_lastNMLbl.BackColor = System.Drawing.Color.White;
            this.cust_lastNMLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_lastNMLbl.Location = new System.Drawing.Point(8, 127);
            this.cust_lastNMLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cust_lastNMLbl.Name = "cust_lastNMLbl";
            this.cust_lastNMLbl.Size = new System.Drawing.Size(99, 24);
            this.cust_lastNMLbl.TabIndex = 7;
            this.cust_lastNMLbl.Text = "Last Name";
            // 
            // cust_lastNMTxtB
            // 
            this.cust_lastNMTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_lastNMTxtB.Location = new System.Drawing.Point(179, 123);
            this.cust_lastNMTxtB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cust_lastNMTxtB.Name = "cust_lastNMTxtB";
            this.cust_lastNMTxtB.Size = new System.Drawing.Size(192, 29);
            this.cust_lastNMTxtB.TabIndex = 6;
            // 
            // cust_middleNMTxtB
            // 
            this.cust_middleNMTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_middleNMTxtB.Location = new System.Drawing.Point(179, 66);
            this.cust_middleNMTxtB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cust_middleNMTxtB.Name = "cust_middleNMTxtB";
            this.cust_middleNMTxtB.Size = new System.Drawing.Size(192, 29);
            this.cust_middleNMTxtB.TabIndex = 5;
            // 
            // cust_middleNMLbl
            // 
            this.cust_middleNMLbl.AutoEllipsis = true;
            this.cust_middleNMLbl.AutoSize = true;
            this.cust_middleNMLbl.BackColor = System.Drawing.Color.White;
            this.cust_middleNMLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_middleNMLbl.ForeColor = System.Drawing.Color.Black;
            this.cust_middleNMLbl.Location = new System.Drawing.Point(8, 69);
            this.cust_middleNMLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cust_middleNMLbl.Name = "cust_middleNMLbl";
            this.cust_middleNMLbl.Size = new System.Drawing.Size(123, 24);
            this.cust_middleNMLbl.TabIndex = 4;
            this.cust_middleNMLbl.Text = "Middle Name";
            // 
            // cust_firstNMLbl
            // 
            this.cust_firstNMLbl.AutoSize = true;
            this.cust_firstNMLbl.BackColor = System.Drawing.Color.White;
            this.cust_firstNMLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_firstNMLbl.Location = new System.Drawing.Point(8, 9);
            this.cust_firstNMLbl.Name = "cust_firstNMLbl";
            this.cust_firstNMLbl.Size = new System.Drawing.Size(101, 24);
            this.cust_firstNMLbl.TabIndex = 3;
            this.cust_firstNMLbl.Text = "First Name";
            // 
            // cust_firstNMTxtB
            // 
            this.cust_firstNMTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_firstNMTxtB.Location = new System.Drawing.Point(179, 9);
            this.cust_firstNMTxtB.Name = "cust_firstNMTxtB";
            this.cust_firstNMTxtB.Size = new System.Drawing.Size(192, 29);
            this.cust_firstNMTxtB.TabIndex = 2;
            // 
            // saleTab
            // 
            this.saleTab.Controls.Add(this.sale_EmployeeCheckBox);
            this.saleTab.Controls.Add(this.sale_CustCheckBox);
            this.saleTab.Controls.Add(this.sale_LastNameLbl);
            this.saleTab.Controls.Add(this.sale_LastNameTxtB);
            this.saleTab.Controls.Add(this.sale_FirstNameLbl);
            this.saleTab.Controls.Add(this.sale_FirstNameTxtB);
            this.saleTab.Controls.Add(this.sales_ToDateTimePicker);
            this.saleTab.Controls.Add(this.dateTimePicker1);
            this.saleTab.Controls.Add(this.sales_DateLbl);
            this.saleTab.Controls.Add(this.sales_FromDateTimePicker);
            this.saleTab.Controls.Add(this.dataGridView1);
            this.saleTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleTab.HorizontalScrollbarBarColor = true;
            this.saleTab.HorizontalScrollbarHighlightOnWheel = false;
            this.saleTab.HorizontalScrollbarSize = 10;
            this.saleTab.Location = new System.Drawing.Point(4, 38);
            this.saleTab.Name = "saleTab";
            this.saleTab.Size = new System.Drawing.Size(942, 394);
            this.saleTab.TabIndex = 1;
            this.saleTab.Text = "Sales";
            this.saleTab.VerticalScrollbarBarColor = true;
            this.saleTab.VerticalScrollbarHighlightOnWheel = false;
            this.saleTab.VerticalScrollbarSize = 10;
            // 
            // carTab
            // 
            this.carTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carTab.HorizontalScrollbarBarColor = true;
            this.carTab.HorizontalScrollbarHighlightOnWheel = false;
            this.carTab.HorizontalScrollbarSize = 10;
            this.carTab.Location = new System.Drawing.Point(4, 38);
            this.carTab.Name = "carTab";
            this.carTab.Size = new System.Drawing.Size(942, 394);
            this.carTab.TabIndex = 2;
            this.carTab.Text = "Cars";
            this.carTab.VerticalScrollbarBarColor = true;
            this.carTab.VerticalScrollbarHighlightOnWheel = false;
            this.carTab.VerticalScrollbarSize = 10;
            // 
            // employeeTab
            // 
            this.employeeTab.HorizontalScrollbarBarColor = true;
            this.employeeTab.HorizontalScrollbarHighlightOnWheel = false;
            this.employeeTab.HorizontalScrollbarSize = 10;
            this.employeeTab.Location = new System.Drawing.Point(4, 38);
            this.employeeTab.Name = "employeeTab";
            this.employeeTab.Size = new System.Drawing.Size(942, 394);
            this.employeeTab.TabIndex = 3;
            this.employeeTab.Text = "Employees";
            this.employeeTab.VerticalScrollbarBarColor = true;
            this.employeeTab.VerticalScrollbarHighlightOnWheel = false;
            this.employeeTab.VerticalScrollbarSize = 10;
            // 
            // cust_PhoneNbrTxtB
            // 
            this.cust_PhoneNbrTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_PhoneNbrTxtB.Location = new System.Drawing.Point(179, 179);
            this.cust_PhoneNbrTxtB.Margin = new System.Windows.Forms.Padding(2);
            this.cust_PhoneNbrTxtB.Name = "cust_PhoneNbrTxtB";
            this.cust_PhoneNbrTxtB.Size = new System.Drawing.Size(192, 29);
            this.cust_PhoneNbrTxtB.TabIndex = 12;
            // 
            // cust_PhoneNbrLbl
            // 
            this.cust_PhoneNbrLbl.AutoSize = true;
            this.cust_PhoneNbrLbl.BackColor = System.Drawing.Color.White;
            this.cust_PhoneNbrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_PhoneNbrLbl.Location = new System.Drawing.Point(8, 183);
            this.cust_PhoneNbrLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cust_PhoneNbrLbl.Name = "cust_PhoneNbrLbl";
            this.cust_PhoneNbrLbl.Size = new System.Drawing.Size(140, 24);
            this.cust_PhoneNbrLbl.TabIndex = 11;
            this.cust_PhoneNbrLbl.Text = "Phone Number";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(385, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 374);
            this.dataGridView1.TabIndex = 21;
            // 
            // sales_FromDateTimePicker
            // 
            this.sales_FromDateTimePicker.Location = new System.Drawing.Point(72, 10);
            this.sales_FromDateTimePicker.Name = "sales_FromDateTimePicker";
            this.sales_FromDateTimePicker.Size = new System.Drawing.Size(308, 29);
            this.sales_FromDateTimePicker.TabIndex = 22;
            // 
            // sales_DateLbl
            // 
            this.sales_DateLbl.AutoSize = true;
            this.sales_DateLbl.BackColor = System.Drawing.Color.White;
            this.sales_DateLbl.Location = new System.Drawing.Point(8, 14);
            this.sales_DateLbl.Name = "sales_DateLbl";
            this.sales_DateLbl.Size = new System.Drawing.Size(55, 24);
            this.sales_DateLbl.TabIndex = 23;
            this.sales_DateLbl.Text = "From";
            // 
            // sales_ToDateTimePicker
            // 
            this.sales_ToDateTimePicker.AutoSize = true;
            this.sales_ToDateTimePicker.BackColor = System.Drawing.Color.White;
            this.sales_ToDateTimePicker.Location = new System.Drawing.Point(8, 73);
            this.sales_ToDateTimePicker.Name = "sales_ToDateTimePicker";
            this.sales_ToDateTimePicker.Size = new System.Drawing.Size(33, 24);
            this.sales_ToDateTimePicker.TabIndex = 25;
            this.sales_ToDateTimePicker.Text = "To";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(308, 29);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // sale_FirstNameLbl
            // 
            this.sale_FirstNameLbl.AutoSize = true;
            this.sale_FirstNameLbl.BackColor = System.Drawing.Color.White;
            this.sale_FirstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_FirstNameLbl.Location = new System.Drawing.Point(8, 200);
            this.sale_FirstNameLbl.Name = "sale_FirstNameLbl";
            this.sale_FirstNameLbl.Size = new System.Drawing.Size(101, 24);
            this.sale_FirstNameLbl.TabIndex = 27;
            this.sale_FirstNameLbl.Text = "First Name";
            // 
            // sale_FirstNameTxtB
            // 
            this.sale_FirstNameTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_FirstNameTxtB.Location = new System.Drawing.Point(12, 227);
            this.sale_FirstNameTxtB.Name = "sale_FirstNameTxtB";
            this.sale_FirstNameTxtB.Size = new System.Drawing.Size(201, 29);
            this.sale_FirstNameTxtB.TabIndex = 26;
            // 
            // sale_LastNameLbl
            // 
            this.sale_LastNameLbl.AutoSize = true;
            this.sale_LastNameLbl.BackColor = System.Drawing.Color.White;
            this.sale_LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_LastNameLbl.Location = new System.Drawing.Point(8, 264);
            this.sale_LastNameLbl.Name = "sale_LastNameLbl";
            this.sale_LastNameLbl.Size = new System.Drawing.Size(99, 24);
            this.sale_LastNameLbl.TabIndex = 29;
            this.sale_LastNameLbl.Text = "Last Name";
            // 
            // sale_LastNameTxtB
            // 
            this.sale_LastNameTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_LastNameTxtB.Location = new System.Drawing.Point(12, 291);
            this.sale_LastNameTxtB.Name = "sale_LastNameTxtB";
            this.sale_LastNameTxtB.Size = new System.Drawing.Size(201, 29);
            this.sale_LastNameTxtB.TabIndex = 28;
            // 
            // sale_CustCheckBox
            // 
            this.sale_CustCheckBox.AutoSize = true;
            this.sale_CustCheckBox.BackColor = System.Drawing.Color.White;
            this.sale_CustCheckBox.Location = new System.Drawing.Point(12, 135);
            this.sale_CustCheckBox.Name = "sale_CustCheckBox";
            this.sale_CustCheckBox.Size = new System.Drawing.Size(175, 28);
            this.sale_CustCheckBox.TabIndex = 30;
            this.sale_CustCheckBox.Text = "Customer Search";
            this.sale_CustCheckBox.UseVisualStyleBackColor = false;
            // 
            // sale_EmployeeCheckBox
            // 
            this.sale_EmployeeCheckBox.AutoSize = true;
            this.sale_EmployeeCheckBox.BackColor = System.Drawing.Color.White;
            this.sale_EmployeeCheckBox.Location = new System.Drawing.Point(193, 135);
            this.sale_EmployeeCheckBox.Name = "sale_EmployeeCheckBox";
            this.sale_EmployeeCheckBox.Size = new System.Drawing.Size(180, 28);
            this.sale_EmployeeCheckBox.TabIndex = 31;
            this.sale_EmployeeCheckBox.Text = "Employee Search";
            this.sale_EmployeeCheckBox.UseVisualStyleBackColor = false;
            // 
            // Dealership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 488);
            this.Controls.Add(this.metroTabControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Dealership";
            this.Text = "Car Dealership";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroTabControl.ResumeLayout(false);
            this.customerTab.ResumeLayout(false);
            this.customerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cust_dataGridView)).EndInit();
            this.saleTab.ResumeLayout(false);
            this.saleTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLbl;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage customerTab;
        private MetroFramework.Controls.MetroTabPage saleTab;
        private MetroFramework.Controls.MetroTabPage carTab;
        private MetroFramework.Controls.MetroTabPage employeeTab;
        private System.Windows.Forms.Label cust_firstNMLbl;
        private System.Windows.Forms.TextBox cust_firstNMTxtB;
        private System.Windows.Forms.Label cust_lastNMLbl;
        private System.Windows.Forms.TextBox cust_lastNMTxtB;
        private System.Windows.Forms.TextBox cust_middleNMTxtB;
        private System.Windows.Forms.Label cust_middleNMLbl;
        private System.Windows.Forms.Label cust_emailLbl;
        private System.Windows.Forms.TextBox cust_emailTxtB;
        private System.Windows.Forms.DataGridView cust_dataGridView;
        private System.Windows.Forms.TextBox cust_PhoneNbrTxtB;
        private System.Windows.Forms.Label cust_PhoneNbrLbl;
        private System.Windows.Forms.DateTimePicker sales_FromDateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label sales_DateLbl;
        private System.Windows.Forms.CheckBox sale_EmployeeCheckBox;
        private System.Windows.Forms.CheckBox sale_CustCheckBox;
        private System.Windows.Forms.Label sale_LastNameLbl;
        private System.Windows.Forms.TextBox sale_LastNameTxtB;
        private System.Windows.Forms.Label sale_FirstNameLbl;
        private System.Windows.Forms.TextBox sale_FirstNameTxtB;
        private System.Windows.Forms.Label sales_ToDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

