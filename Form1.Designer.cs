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
            this.panel1.SuspendLayout();
            this.metroTabControl.SuspendLayout();
            this.customerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cust_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.titleLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1266, 64);
            this.panel1.TabIndex = 0;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(0, 0);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(335, 54);
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
            this.metroTabControl.Location = new System.Drawing.Point(0, 64);
            this.metroTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(1266, 536);
            this.metroTabControl.TabIndex = 1;
            this.metroTabControl.UseSelectable = true;
            // 
            // customerTab
            // 
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
            this.customerTab.HorizontalScrollbarSize = 12;
            this.customerTab.Location = new System.Drawing.Point(4, 38);
            this.customerTab.Margin = new System.Windows.Forms.Padding(4);
            this.customerTab.Name = "customerTab";
            this.customerTab.Size = new System.Drawing.Size(1258, 494);
            this.customerTab.TabIndex = 0;
            this.customerTab.Text = "Customers";
            this.customerTab.VerticalScrollbarBarColor = true;
            this.customerTab.VerticalScrollbarHighlightOnWheel = false;
            this.customerTab.VerticalScrollbarSize = 13;
            // 
            // cust_dataGridView
            // 
            this.cust_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cust_dataGridView.Location = new System.Drawing.Point(514, 11);
            this.cust_dataGridView.Name = "cust_dataGridView";
            this.cust_dataGridView.RowHeadersWidth = 51;
            this.cust_dataGridView.RowTemplate.Height = 24;
            this.cust_dataGridView.Size = new System.Drawing.Size(736, 460);
            this.cust_dataGridView.TabIndex = 10;
            // 
            // cust_emailTxtB
            // 
            this.cust_emailTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_emailTxtB.Location = new System.Drawing.Point(238, 222);
            this.cust_emailTxtB.Name = "cust_emailTxtB";
            this.cust_emailTxtB.Size = new System.Drawing.Size(255, 41);
            this.cust_emailTxtB.TabIndex = 9;
            // 
            // cust_emailLbl
            // 
            this.cust_emailLbl.AutoSize = true;
            this.cust_emailLbl.BackColor = System.Drawing.Color.White;
            this.cust_emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_emailLbl.Location = new System.Drawing.Point(9, 227);
            this.cust_emailLbl.Name = "cust_emailLbl";
            this.cust_emailLbl.Size = new System.Drawing.Size(88, 36);
            this.cust_emailLbl.TabIndex = 8;
            this.cust_emailLbl.Text = "Email";
            // 
            // cust_lastNMLbl
            // 
            this.cust_lastNMLbl.AutoSize = true;
            this.cust_lastNMLbl.BackColor = System.Drawing.Color.White;
            this.cust_lastNMLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_lastNMLbl.Location = new System.Drawing.Point(9, 156);
            this.cust_lastNMLbl.Name = "cust_lastNMLbl";
            this.cust_lastNMLbl.Size = new System.Drawing.Size(156, 36);
            this.cust_lastNMLbl.TabIndex = 7;
            this.cust_lastNMLbl.Text = "Last Name";
            // 
            // cust_lastNMTxtB
            // 
            this.cust_lastNMTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_lastNMTxtB.Location = new System.Drawing.Point(238, 151);
            this.cust_lastNMTxtB.Name = "cust_lastNMTxtB";
            this.cust_lastNMTxtB.Size = new System.Drawing.Size(255, 41);
            this.cust_lastNMTxtB.TabIndex = 6;
            // 
            // cust_middleNMTxtB
            // 
            this.cust_middleNMTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_middleNMTxtB.Location = new System.Drawing.Point(238, 79);
            this.cust_middleNMTxtB.Name = "cust_middleNMTxtB";
            this.cust_middleNMTxtB.Size = new System.Drawing.Size(255, 41);
            this.cust_middleNMTxtB.TabIndex = 5;
            // 
            // cust_middleNMLbl
            // 
            this.cust_middleNMLbl.AutoEllipsis = true;
            this.cust_middleNMLbl.AutoSize = true;
            this.cust_middleNMLbl.BackColor = System.Drawing.Color.White;
            this.cust_middleNMLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_middleNMLbl.ForeColor = System.Drawing.Color.Black;
            this.cust_middleNMLbl.Location = new System.Drawing.Point(9, 82);
            this.cust_middleNMLbl.Name = "cust_middleNMLbl";
            this.cust_middleNMLbl.Size = new System.Drawing.Size(189, 36);
            this.cust_middleNMLbl.TabIndex = 4;
            this.cust_middleNMLbl.Text = "Middle Name";
            // 
            // cust_firstNMLbl
            // 
            this.cust_firstNMLbl.AutoSize = true;
            this.cust_firstNMLbl.BackColor = System.Drawing.Color.White;
            this.cust_firstNMLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_firstNMLbl.Location = new System.Drawing.Point(9, 11);
            this.cust_firstNMLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_firstNMLbl.Name = "cust_firstNMLbl";
            this.cust_firstNMLbl.Size = new System.Drawing.Size(158, 36);
            this.cust_firstNMLbl.TabIndex = 3;
            this.cust_firstNMLbl.Text = "First Name";
            // 
            // cust_firstNMTxtB
            // 
            this.cust_firstNMTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_firstNMTxtB.Location = new System.Drawing.Point(238, 11);
            this.cust_firstNMTxtB.Margin = new System.Windows.Forms.Padding(4);
            this.cust_firstNMTxtB.Name = "cust_firstNMTxtB";
            this.cust_firstNMTxtB.Size = new System.Drawing.Size(255, 41);
            this.cust_firstNMTxtB.TabIndex = 2;
            // 
            // saleTab
            // 
            this.saleTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleTab.HorizontalScrollbarBarColor = true;
            this.saleTab.HorizontalScrollbarHighlightOnWheel = false;
            this.saleTab.HorizontalScrollbarSize = 12;
            this.saleTab.Location = new System.Drawing.Point(4, 38);
            this.saleTab.Margin = new System.Windows.Forms.Padding(4);
            this.saleTab.Name = "saleTab";
            this.saleTab.Size = new System.Drawing.Size(1258, 494);
            this.saleTab.TabIndex = 1;
            this.saleTab.Text = "Sales";
            this.saleTab.VerticalScrollbarBarColor = true;
            this.saleTab.VerticalScrollbarHighlightOnWheel = false;
            this.saleTab.VerticalScrollbarSize = 13;
            // 
            // carTab
            // 
            this.carTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carTab.HorizontalScrollbarBarColor = true;
            this.carTab.HorizontalScrollbarHighlightOnWheel = false;
            this.carTab.HorizontalScrollbarSize = 12;
            this.carTab.Location = new System.Drawing.Point(4, 38);
            this.carTab.Margin = new System.Windows.Forms.Padding(4);
            this.carTab.Name = "carTab";
            this.carTab.Size = new System.Drawing.Size(1258, 494);
            this.carTab.TabIndex = 2;
            this.carTab.Text = "Cars";
            this.carTab.VerticalScrollbarBarColor = true;
            this.carTab.VerticalScrollbarHighlightOnWheel = false;
            this.carTab.VerticalScrollbarSize = 13;
            // 
            // employeeTab
            // 
            this.employeeTab.HorizontalScrollbarBarColor = true;
            this.employeeTab.HorizontalScrollbarHighlightOnWheel = false;
            this.employeeTab.HorizontalScrollbarSize = 12;
            this.employeeTab.Location = new System.Drawing.Point(4, 38);
            this.employeeTab.Margin = new System.Windows.Forms.Padding(4);
            this.employeeTab.Name = "employeeTab";
            this.employeeTab.Size = new System.Drawing.Size(1258, 494);
            this.employeeTab.TabIndex = 3;
            this.employeeTab.Text = "Employees";
            this.employeeTab.VerticalScrollbarBarColor = true;
            this.employeeTab.VerticalScrollbarHighlightOnWheel = false;
            this.employeeTab.VerticalScrollbarSize = 13;
            // 
            // Dealership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 600);
            this.Controls.Add(this.metroTabControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dealership";
            this.Text = "Car Dealership";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroTabControl.ResumeLayout(false);
            this.customerTab.ResumeLayout(false);
            this.customerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cust_dataGridView)).EndInit();
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
    }
}

