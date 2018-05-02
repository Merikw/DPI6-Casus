namespace Transport_Company_Application
{
    partial class Form1
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
            this.txtTransportCompanyName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblNameOfCompany = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddCompany = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddConnection = new MaterialSkin.Controls.MaterialLabel();
            this.lblFrom = new MaterialSkin.Controls.MaterialLabel();
            this.lblTo = new MaterialSkin.Controls.MaterialLabel();
            this.lblAvailableTickets = new MaterialSkin.Controls.MaterialLabel();
            this.lblPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblTypeOfCompany = new MaterialSkin.Controls.MaterialLabel();
            this.rbTypeBus = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbTypeTrain = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbTypePlane = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtAvailableTickets = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblConnections = new MaterialSkin.Controls.MaterialLabel();
            this.lvConnections = new MetroFramework.Controls.MetroListView();
            this.btnRemoveConnection = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbFromCity = new System.Windows.Forms.ComboBox();
            this.cbToCity = new System.Windows.Forms.ComboBox();
            this.btnAddConnection = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtTransportCompanyName
            // 
            this.txtTransportCompanyName.Depth = 0;
            this.txtTransportCompanyName.Hint = "";
            this.txtTransportCompanyName.Location = new System.Drawing.Point(213, 114);
            this.txtTransportCompanyName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTransportCompanyName.Name = "txtTransportCompanyName";
            this.txtTransportCompanyName.PasswordChar = '\0';
            this.txtTransportCompanyName.SelectedText = "";
            this.txtTransportCompanyName.SelectionLength = 0;
            this.txtTransportCompanyName.SelectionStart = 0;
            this.txtTransportCompanyName.Size = new System.Drawing.Size(634, 28);
            this.txtTransportCompanyName.TabIndex = 0;
            this.txtTransportCompanyName.UseSystemPasswordChar = false;
            // 
            // lblNameOfCompany
            // 
            this.lblNameOfCompany.AutoSize = true;
            this.lblNameOfCompany.Depth = 0;
            this.lblNameOfCompany.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNameOfCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNameOfCompany.Location = new System.Drawing.Point(12, 114);
            this.lblNameOfCompany.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNameOfCompany.Name = "lblNameOfCompany";
            this.lblNameOfCompany.Size = new System.Drawing.Size(172, 24);
            this.lblNameOfCompany.TabIndex = 1;
            this.lblNameOfCompany.Text = "Name of company:";
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Depth = 0;
            this.btnAddCompany.Location = new System.Drawing.Point(716, 113);
            this.btnAddCompany.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Primary = true;
            this.btnAddCompany.Size = new System.Drawing.Size(220, 28);
            this.btnAddCompany.TabIndex = 2;
            this.btnAddCompany.Text = "Add company";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-11, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(969, 2);
            this.label1.TabIndex = 10;
            // 
            // lblAddConnection
            // 
            this.lblAddConnection.AutoSize = true;
            this.lblAddConnection.Depth = 0;
            this.lblAddConnection.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAddConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddConnection.Location = new System.Drawing.Point(12, 238);
            this.lblAddConnection.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAddConnection.Name = "lblAddConnection";
            this.lblAddConnection.Size = new System.Drawing.Size(142, 24);
            this.lblAddConnection.TabIndex = 11;
            this.lblAddConnection.Text = "Add connection";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Depth = 0;
            this.lblFrom.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFrom.Location = new System.Drawing.Point(12, 336);
            this.lblFrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(60, 24);
            this.lblFrom.TabIndex = 12;
            this.lblFrom.Text = "From:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Depth = 0;
            this.lblTo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTo.Location = new System.Drawing.Point(12, 408);
            this.lblTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(37, 24);
            this.lblTo.TabIndex = 13;
            this.lblTo.Text = "To:";
            // 
            // lblAvailableTickets
            // 
            this.lblAvailableTickets.AutoSize = true;
            this.lblAvailableTickets.Depth = 0;
            this.lblAvailableTickets.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAvailableTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAvailableTickets.Location = new System.Drawing.Point(12, 481);
            this.lblAvailableTickets.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAvailableTickets.Name = "lblAvailableTickets";
            this.lblAvailableTickets.Size = new System.Drawing.Size(154, 24);
            this.lblAvailableTickets.TabIndex = 14;
            this.lblAvailableTickets.Text = "Available tickets:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Depth = 0;
            this.lblPrice.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrice.Location = new System.Drawing.Point(12, 559);
            this.lblPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 24);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price:";
            // 
            // lblTypeOfCompany
            // 
            this.lblTypeOfCompany.AutoSize = true;
            this.lblTypeOfCompany.Depth = 0;
            this.lblTypeOfCompany.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTypeOfCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTypeOfCompany.Location = new System.Drawing.Point(12, 168);
            this.lblTypeOfCompany.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTypeOfCompany.Name = "lblTypeOfCompany";
            this.lblTypeOfCompany.Size = new System.Drawing.Size(162, 24);
            this.lblTypeOfCompany.TabIndex = 16;
            this.lblTypeOfCompany.Text = "Type of company:";
            // 
            // rbTypeBus
            // 
            this.rbTypeBus.AutoSize = true;
            this.rbTypeBus.Depth = 0;
            this.rbTypeBus.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbTypeBus.Location = new System.Drawing.Point(213, 168);
            this.rbTypeBus.Margin = new System.Windows.Forms.Padding(0);
            this.rbTypeBus.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbTypeBus.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbTypeBus.Name = "rbTypeBus";
            this.rbTypeBus.Ripple = true;
            this.rbTypeBus.Size = new System.Drawing.Size(59, 30);
            this.rbTypeBus.TabIndex = 17;
            this.rbTypeBus.TabStop = true;
            this.rbTypeBus.Text = "Bus";
            this.rbTypeBus.UseVisualStyleBackColor = true;
            // 
            // rbTypeTrain
            // 
            this.rbTypeTrain.AutoSize = true;
            this.rbTypeTrain.Depth = 0;
            this.rbTypeTrain.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbTypeTrain.Location = new System.Drawing.Point(295, 168);
            this.rbTypeTrain.Margin = new System.Windows.Forms.Padding(0);
            this.rbTypeTrain.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbTypeTrain.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbTypeTrain.Name = "rbTypeTrain";
            this.rbTypeTrain.Ripple = true;
            this.rbTypeTrain.Size = new System.Drawing.Size(70, 30);
            this.rbTypeTrain.TabIndex = 18;
            this.rbTypeTrain.TabStop = true;
            this.rbTypeTrain.Text = "Train";
            this.rbTypeTrain.UseVisualStyleBackColor = true;
            // 
            // rbTypePlane
            // 
            this.rbTypePlane.AutoSize = true;
            this.rbTypePlane.Depth = 0;
            this.rbTypePlane.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbTypePlane.Location = new System.Drawing.Point(380, 168);
            this.rbTypePlane.Margin = new System.Windows.Forms.Padding(0);
            this.rbTypePlane.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbTypePlane.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbTypePlane.Name = "rbTypePlane";
            this.rbTypePlane.Ripple = true;
            this.rbTypePlane.Size = new System.Drawing.Size(73, 30);
            this.rbTypePlane.TabIndex = 19;
            this.rbTypePlane.TabStop = true;
            this.rbTypePlane.Text = "Plane";
            this.rbTypePlane.UseVisualStyleBackColor = true;
            // 
            // txtAvailableTickets
            // 
            this.txtAvailableTickets.Depth = 0;
            this.txtAvailableTickets.Hint = "";
            this.txtAvailableTickets.Location = new System.Drawing.Point(240, 477);
            this.txtAvailableTickets.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAvailableTickets.Name = "txtAvailableTickets";
            this.txtAvailableTickets.PasswordChar = '\0';
            this.txtAvailableTickets.SelectedText = "";
            this.txtAvailableTickets.SelectionLength = 0;
            this.txtAvailableTickets.SelectionStart = 0;
            this.txtAvailableTickets.Size = new System.Drawing.Size(389, 28);
            this.txtAvailableTickets.TabIndex = 22;
            this.txtAvailableTickets.UseSystemPasswordChar = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Depth = 0;
            this.txtPrice.Hint = "";
            this.txtPrice.Location = new System.Drawing.Point(240, 555);
            this.txtPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.Size = new System.Drawing.Size(389, 28);
            this.txtPrice.TabIndex = 23;
            this.txtPrice.UseSystemPasswordChar = false;
            // 
            // lblConnections
            // 
            this.lblConnections.AutoSize = true;
            this.lblConnections.Depth = 0;
            this.lblConnections.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblConnections.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblConnections.Location = new System.Drawing.Point(631, 238);
            this.lblConnections.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblConnections.Name = "lblConnections";
            this.lblConnections.Size = new System.Drawing.Size(115, 24);
            this.lblConnections.TabIndex = 24;
            this.lblConnections.Text = "Connections";
            // 
            // lvConnections
            // 
            this.lvConnections.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvConnections.FullRowSelect = true;
            this.lvConnections.Location = new System.Drawing.Point(635, 332);
            this.lvConnections.Name = "lvConnections";
            this.lvConnections.OwnerDraw = true;
            this.lvConnections.Size = new System.Drawing.Size(301, 251);
            this.lvConnections.TabIndex = 25;
            this.lvConnections.UseCompatibleStateImageBehavior = false;
            this.lvConnections.UseSelectable = true;
            // 
            // btnRemoveConnection
            // 
            this.btnRemoveConnection.Depth = 0;
            this.btnRemoveConnection.Location = new System.Drawing.Point(635, 598);
            this.btnRemoveConnection.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoveConnection.Name = "btnRemoveConnection";
            this.btnRemoveConnection.Primary = true;
            this.btnRemoveConnection.Size = new System.Drawing.Size(301, 57);
            this.btnRemoveConnection.TabIndex = 26;
            this.btnRemoveConnection.Text = "Remove connection";
            this.btnRemoveConnection.UseVisualStyleBackColor = true;
            // 
            // cbFromCity
            // 
            this.cbFromCity.FormattingEnabled = true;
            this.cbFromCity.Location = new System.Drawing.Point(240, 334);
            this.cbFromCity.Name = "cbFromCity";
            this.cbFromCity.Size = new System.Drawing.Size(367, 24);
            this.cbFromCity.TabIndex = 27;
            // 
            // cbToCity
            // 
            this.cbToCity.FormattingEnabled = true;
            this.cbToCity.Location = new System.Drawing.Point(240, 408);
            this.cbToCity.Name = "cbToCity";
            this.cbToCity.Size = new System.Drawing.Size(367, 24);
            this.cbToCity.TabIndex = 28;
            // 
            // btnAddConnection
            // 
            this.btnAddConnection.Depth = 0;
            this.btnAddConnection.Location = new System.Drawing.Point(16, 598);
            this.btnAddConnection.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddConnection.Name = "btnAddConnection";
            this.btnAddConnection.Primary = true;
            this.btnAddConnection.Size = new System.Drawing.Size(301, 57);
            this.btnAddConnection.TabIndex = 29;
            this.btnAddConnection.Text = "Add connection";
            this.btnAddConnection.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 667);
            this.Controls.Add(this.btnAddConnection);
            this.Controls.Add(this.cbToCity);
            this.Controls.Add(this.cbFromCity);
            this.Controls.Add(this.btnRemoveConnection);
            this.Controls.Add(this.lvConnections);
            this.Controls.Add(this.lblConnections);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAvailableTickets);
            this.Controls.Add(this.rbTypePlane);
            this.Controls.Add(this.rbTypeTrain);
            this.Controls.Add(this.rbTypeBus);
            this.Controls.Add(this.lblTypeOfCompany);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblAvailableTickets);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblAddConnection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddCompany);
            this.Controls.Add(this.lblNameOfCompany);
            this.Controls.Add(this.txtTransportCompanyName);
            this.Name = "Form1";
            this.Text = "Transport Company Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtTransportCompanyName;
        private MaterialSkin.Controls.MaterialLabel lblNameOfCompany;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddCompany;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel lblAddConnection;
        private MaterialSkin.Controls.MaterialLabel lblFrom;
        private MaterialSkin.Controls.MaterialLabel lblTo;
        private MaterialSkin.Controls.MaterialLabel lblAvailableTickets;
        private MaterialSkin.Controls.MaterialLabel lblPrice;
        private MaterialSkin.Controls.MaterialLabel lblTypeOfCompany;
        private MaterialSkin.Controls.MaterialRadioButton rbTypeBus;
        private MaterialSkin.Controls.MaterialRadioButton rbTypeTrain;
        private MaterialSkin.Controls.MaterialRadioButton rbTypePlane;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAvailableTickets;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrice;
        private MaterialSkin.Controls.MaterialLabel lblConnections;
        private MetroFramework.Controls.MetroListView lvConnections;
        private MaterialSkin.Controls.MaterialRaisedButton btnRemoveConnection;
        private System.Windows.Forms.ComboBox cbFromCity;
        private System.Windows.Forms.ComboBox cbToCity;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddConnection;
    }
}

