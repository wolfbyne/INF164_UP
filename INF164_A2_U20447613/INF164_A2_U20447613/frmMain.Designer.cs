namespace INF164_A2_U20447613
{
    partial class frmPetsRUs
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.gbCapturePayment = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblPayAmount = new System.Windows.Forms.Label();
            this.nudPaymentAmount = new System.Windows.Forms.NumericUpDown();
            this.lblDataGridDescription = new System.Windows.Forms.Label();
            this.lblClickDescrip = new System.Windows.Forms.Label();
            this.dgClients = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCaptureClientPurchase = new System.Windows.Forms.GroupBox();
            this.btnMakePurchase = new System.Windows.Forms.Button();
            this.nudPurchaseAmount = new System.Windows.Forms.NumericUpDown();
            this.lblPurchaseAmount = new System.Windows.Forms.Label();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.tabPets = new System.Windows.Forms.TabPage();
            this.dgPets = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOwnerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeletePet = new System.Windows.Forms.Button();
            this.btnEditPet = new System.Windows.Forms.Button();
            this.btnAddPet = new System.Windows.Forms.Button();
            this.dgPetsMatched = new System.Windows.Forms.DataGridView();
            this.colPetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPetAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPetType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPetOwnerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabClients.SuspendLayout();
            this.gbCapturePayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaymentAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).BeginInit();
            this.gbCaptureClientPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchaseAmount)).BeginInit();
            this.tabPets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPetsMatched)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabClients);
            this.tabControl.Controls.Add(this.tabPets);
            this.tabControl.Location = new System.Drawing.Point(0, -1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(811, 451);
            this.tabControl.TabIndex = 0;
            // 
            // tabClients
            // 
            this.tabClients.BackgroundImage = global::INF164_A2_U20447613.Properties.Resources._1862828;
            this.tabClients.Controls.Add(this.dgPetsMatched);
            this.tabClients.Controls.Add(this.gbCapturePayment);
            this.tabClients.Controls.Add(this.lblDataGridDescription);
            this.tabClients.Controls.Add(this.lblClickDescrip);
            this.tabClients.Controls.Add(this.dgClients);
            this.tabClients.Controls.Add(this.gbCaptureClientPurchase);
            this.tabClients.Controls.Add(this.btnDeleteClient);
            this.tabClients.Controls.Add(this.btnEditClient);
            this.tabClients.Controls.Add(this.btnAddClient);
            this.tabClients.Location = new System.Drawing.Point(4, 22);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabClients.Size = new System.Drawing.Size(803, 425);
            this.tabClients.TabIndex = 0;
            this.tabClients.Text = "Clients";
            this.tabClients.UseVisualStyleBackColor = true;
            // 
            // gbCapturePayment
            // 
            this.gbCapturePayment.BackColor = System.Drawing.Color.White;
            this.gbCapturePayment.Controls.Add(this.btnUpdate);
            this.gbCapturePayment.Controls.Add(this.lblPayAmount);
            this.gbCapturePayment.Controls.Add(this.nudPaymentAmount);
            this.gbCapturePayment.Location = new System.Drawing.Point(535, 75);
            this.gbCapturePayment.Name = "gbCapturePayment";
            this.gbCapturePayment.Size = new System.Drawing.Size(251, 165);
            this.gbCapturePayment.TabIndex = 3;
            this.gbCapturePayment.TabStop = false;
            this.gbCapturePayment.Text = "Capture Client Payment";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(96, 101);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblPayAmount
            // 
            this.lblPayAmount.AutoSize = true;
            this.lblPayAmount.Location = new System.Drawing.Point(28, 54);
            this.lblPayAmount.Name = "lblPayAmount";
            this.lblPayAmount.Size = new System.Drawing.Size(87, 13);
            this.lblPayAmount.TabIndex = 1;
            this.lblPayAmount.Text = "Payment Amount";
            // 
            // nudPaymentAmount
            // 
            this.nudPaymentAmount.Location = new System.Drawing.Point(165, 48);
            this.nudPaymentAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPaymentAmount.Name = "nudPaymentAmount";
            this.nudPaymentAmount.Size = new System.Drawing.Size(80, 20);
            this.nudPaymentAmount.TabIndex = 0;
            // 
            // lblDataGridDescription
            // 
            this.lblDataGridDescription.AutoSize = true;
            this.lblDataGridDescription.BackColor = System.Drawing.Color.White;
            this.lblDataGridDescription.Location = new System.Drawing.Point(6, 251);
            this.lblDataGridDescription.Name = "lblDataGridDescription";
            this.lblDataGridDescription.Size = new System.Drawing.Size(165, 13);
            this.lblDataGridDescription.TabIndex = 7;
            this.lblDataGridDescription.Text = "Click on a client to view their pets";
            // 
            // lblClickDescrip
            // 
            this.lblClickDescrip.AutoSize = true;
            this.lblClickDescrip.Location = new System.Drawing.Point(6, 59);
            this.lblClickDescrip.Name = "lblClickDescrip";
            this.lblClickDescrip.Size = new System.Drawing.Size(165, 13);
            this.lblClickDescrip.TabIndex = 6;
            this.lblClickDescrip.Text = "Click on a client to view their pets";
            // 
            // dgClients
            // 
            this.dgClients.AllowUserToAddRows = false;
            this.dgClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5});
            this.dgClients.Location = new System.Drawing.Point(6, 75);
            this.dgClients.Name = "dgClients";
            this.dgClients.ReadOnly = true;
            this.dgClients.Size = new System.Drawing.Size(515, 165);
            this.dgClients.TabIndex = 5;
            this.dgClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClients_CellClick);
            // 
            // col1
            // 
            this.col1.HeaderText = "IDNumber";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            // 
            // col2
            // 
            this.col2.HeaderText = "FirstName";
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            // 
            // col3
            // 
            this.col3.HeaderText = "LastName";
            this.col3.Name = "col3";
            this.col3.ReadOnly = true;
            // 
            // col4
            // 
            this.col4.HeaderText = "CreditLimit";
            this.col4.Name = "col4";
            this.col4.ReadOnly = true;
            this.col4.Width = 60;
            // 
            // col5
            // 
            this.col5.HeaderText = "CurrentBalanceOwed";
            this.col5.Name = "col5";
            this.col5.ReadOnly = true;
            this.col5.Width = 110;
            // 
            // gbCaptureClientPurchase
            // 
            this.gbCaptureClientPurchase.BackColor = System.Drawing.Color.White;
            this.gbCaptureClientPurchase.Controls.Add(this.btnMakePurchase);
            this.gbCaptureClientPurchase.Controls.Add(this.nudPurchaseAmount);
            this.gbCaptureClientPurchase.Controls.Add(this.lblPurchaseAmount);
            this.gbCaptureClientPurchase.Location = new System.Drawing.Point(535, 251);
            this.gbCaptureClientPurchase.Name = "gbCaptureClientPurchase";
            this.gbCaptureClientPurchase.Size = new System.Drawing.Size(251, 155);
            this.gbCaptureClientPurchase.TabIndex = 4;
            this.gbCaptureClientPurchase.TabStop = false;
            this.gbCaptureClientPurchase.Text = "Capture Client Purchase";
            // 
            // btnMakePurchase
            // 
            this.btnMakePurchase.Location = new System.Drawing.Point(96, 92);
            this.btnMakePurchase.Name = "btnMakePurchase";
            this.btnMakePurchase.Size = new System.Drawing.Size(75, 42);
            this.btnMakePurchase.TabIndex = 3;
            this.btnMakePurchase.Text = "Make Purchase";
            this.btnMakePurchase.UseVisualStyleBackColor = true;
            this.btnMakePurchase.Click += new System.EventHandler(this.btnMakePurchase_Click);
            // 
            // nudPurchaseAmount
            // 
            this.nudPurchaseAmount.Location = new System.Drawing.Point(165, 41);
            this.nudPurchaseAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPurchaseAmount.Name = "nudPurchaseAmount";
            this.nudPurchaseAmount.Size = new System.Drawing.Size(80, 20);
            this.nudPurchaseAmount.TabIndex = 2;
            // 
            // lblPurchaseAmount
            // 
            this.lblPurchaseAmount.AutoSize = true;
            this.lblPurchaseAmount.Location = new System.Drawing.Point(18, 43);
            this.lblPurchaseAmount.Name = "lblPurchaseAmount";
            this.lblPurchaseAmount.Size = new System.Drawing.Size(91, 13);
            this.lblPurchaseAmount.TabIndex = 2;
            this.lblPurchaseAmount.Text = "Purchase Amount";
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(321, 28);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteClient.TabIndex = 2;
            this.btnDeleteClient.Text = "Delete Client";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Location = new System.Drawing.Point(180, 28);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(75, 23);
            this.btnEditClient.TabIndex = 1;
            this.btnEditClient.Text = "Edit Client";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(46, 28);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(75, 23);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.Text = "Add a Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // tabPets
            // 
            this.tabPets.BackgroundImage = global::INF164_A2_U20447613.Properties.Resources._1862828;
            this.tabPets.Controls.Add(this.dgPets);
            this.tabPets.Controls.Add(this.btnDeletePet);
            this.tabPets.Controls.Add(this.btnEditPet);
            this.tabPets.Controls.Add(this.btnAddPet);
            this.tabPets.Location = new System.Drawing.Point(4, 22);
            this.tabPets.Name = "tabPets";
            this.tabPets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPets.Size = new System.Drawing.Size(803, 425);
            this.tabPets.TabIndex = 1;
            this.tabPets.Text = "Pets";
            this.tabPets.UseVisualStyleBackColor = true;
            // 
            // dgPets
            // 
            this.dgPets.AllowUserToAddRows = false;
            this.dgPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colAge,
            this.colType,
            this.colOwnerID});
            this.dgPets.Location = new System.Drawing.Point(42, 87);
            this.dgPets.Name = "dgPets";
            this.dgPets.ReadOnly = true;
            this.dgPets.Size = new System.Drawing.Size(475, 200);
            this.dgPets.TabIndex = 3;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colAge
            // 
            this.colAge.HeaderText = "Age";
            this.colAge.Name = "colAge";
            this.colAge.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colOwnerID
            // 
            this.colOwnerID.HeaderText = "OwnerID";
            this.colOwnerID.Name = "colOwnerID";
            this.colOwnerID.ReadOnly = true;
            // 
            // btnDeletePet
            // 
            this.btnDeletePet.Location = new System.Drawing.Point(291, 33);
            this.btnDeletePet.Name = "btnDeletePet";
            this.btnDeletePet.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePet.TabIndex = 2;
            this.btnDeletePet.Text = "DeletePet";
            this.btnDeletePet.UseVisualStyleBackColor = true;
            this.btnDeletePet.Click += new System.EventHandler(this.btnDeletePet_Click);
            // 
            // btnEditPet
            // 
            this.btnEditPet.Location = new System.Drawing.Point(166, 33);
            this.btnEditPet.Name = "btnEditPet";
            this.btnEditPet.Size = new System.Drawing.Size(75, 23);
            this.btnEditPet.TabIndex = 1;
            this.btnEditPet.Text = "Edit Pet";
            this.btnEditPet.UseVisualStyleBackColor = true;
            this.btnEditPet.Click += new System.EventHandler(this.btnEditPet_Click);
            // 
            // btnAddPet
            // 
            this.btnAddPet.Location = new System.Drawing.Point(42, 33);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(75, 23);
            this.btnAddPet.TabIndex = 0;
            this.btnAddPet.Text = "Add A Pet";
            this.btnAddPet.UseVisualStyleBackColor = true;
            this.btnAddPet.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // dgPetsMatched
            // 
            this.dgPetsMatched.AllowUserToAddRows = false;
            this.dgPetsMatched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPetsMatched.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPetName,
            this.colPetAge,
            this.colPetType,
            this.colPetOwnerID});
            this.dgPetsMatched.Location = new System.Drawing.Point(6, 267);
            this.dgPetsMatched.Name = "dgPetsMatched";
            this.dgPetsMatched.ReadOnly = true;
            this.dgPetsMatched.Size = new System.Drawing.Size(431, 150);
            this.dgPetsMatched.TabIndex = 8;
            this.dgPetsMatched.Visible = false;
            // 
            // colPetName
            // 
            this.colPetName.HeaderText = "Name";
            this.colPetName.Name = "colPetName";
            // 
            // colPetAge
            // 
            this.colPetAge.HeaderText = "Age";
            this.colPetAge.Name = "colPetAge";
            // 
            // colPetType
            // 
            this.colPetType.HeaderText = "Type";
            this.colPetType.Name = "colPetType";
            // 
            // colPetOwnerID
            // 
            this.colPetOwnerID.HeaderText = "OwnerID";
            this.colPetOwnerID.Name = "colPetOwnerID";
            // 
            // frmPetsRUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 451);
            this.Controls.Add(this.tabControl);
            this.Name = "frmPetsRUs";
            this.Text = "Pets R Us";
            this.tabControl.ResumeLayout(false);
            this.tabClients.ResumeLayout(false);
            this.tabClients.PerformLayout();
            this.gbCapturePayment.ResumeLayout(false);
            this.gbCapturePayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaymentAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).EndInit();
            this.gbCaptureClientPurchase.ResumeLayout(false);
            this.gbCaptureClientPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchaseAmount)).EndInit();
            this.tabPets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPetsMatched)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.TabPage tabPets;
        public System.Windows.Forms.GroupBox gbCaptureClientPurchase;
        private System.Windows.Forms.Button btnMakePurchase;
        public System.Windows.Forms.NumericUpDown nudPurchaseAmount;
        private System.Windows.Forms.Label lblPurchaseAmount;
        public System.Windows.Forms.GroupBox gbCapturePayment;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblPayAmount;
        public System.Windows.Forms.NumericUpDown nudPaymentAmount;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnAddClient;
        public System.Windows.Forms.DataGridView dgClients;
        private System.Windows.Forms.Label lblDataGridDescription;
        private System.Windows.Forms.Label lblClickDescrip;
        private System.Windows.Forms.Button btnDeletePet;
        private System.Windows.Forms.Button btnEditPet;
        private System.Windows.Forms.Button btnAddPet;
        public System.Windows.Forms.DataGridView dgPets;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOwnerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col5;
        private System.Windows.Forms.DataGridView dgPetsMatched;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPetAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPetType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPetOwnerID;
    }
}

