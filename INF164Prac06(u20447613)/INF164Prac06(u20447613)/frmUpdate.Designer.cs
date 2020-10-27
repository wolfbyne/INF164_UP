namespace INF164Prac06_u20447613_
{
    partial class frmUpdate
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
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.lblBookingSesh = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbBookingSesh = new System.Windows.Forms.ComboBox();
            this.cbPaymentType = new System.Windows.Forms.ComboBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Location = new System.Drawing.Point(63, 283);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(78, 13);
            this.lblPaymentType.TabIndex = 25;
            this.lblPaymentType.Text = "Payment Type:";
            // 
            // lblBookingSesh
            // 
            this.lblBookingSesh.AutoSize = true;
            this.lblBookingSesh.Location = new System.Drawing.Point(66, 234);
            this.lblBookingSesh.Name = "lblBookingSesh";
            this.lblBookingSesh.Size = new System.Drawing.Size(89, 13);
            this.lblBookingSesh.TabIndex = 24;
            this.lblBookingSesh.Text = "Booking Session:";
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Location = new System.Drawing.Point(63, 179);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(75, 13);
            this.lblBookingDate.TabIndex = 23;
            this.lblBookingDate.Text = "Booking Date:";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Location = new System.Drawing.Point(63, 127);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNum.TabIndex = 22;
            this.lblPhoneNum.Text = "Phone Number:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(63, 80);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 21;
            this.lblSurname.Text = "Surname:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(60, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Name:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(125, 333);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 23);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update Booking";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(197, 173);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(121, 20);
            this.dtpDate.TabIndex = 18;
            // 
            // cbBookingSesh
            // 
            this.cbBookingSesh.FormattingEnabled = true;
            this.cbBookingSesh.Items.AddRange(new object[] {
            "Morning Session",
            "Afternoon Session",
            "Evening Session"});
            this.cbBookingSesh.Location = new System.Drawing.Point(197, 227);
            this.cbBookingSesh.Name = "cbBookingSesh";
            this.cbBookingSesh.Size = new System.Drawing.Size(121, 21);
            this.cbBookingSesh.TabIndex = 17;
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.FormattingEnabled = true;
            this.cbPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "EFT",
            "BTC"});
            this.cbPaymentType.Location = new System.Drawing.Point(197, 276);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.Size = new System.Drawing.Size(121, 21);
            this.cbPaymentType.TabIndex = 16;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(197, 121);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNum.TabIndex = 15;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(197, 74);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(197, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 13;
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 385);
            this.Controls.Add(this.lblPaymentType);
            this.Controls.Add(this.lblBookingSesh);
            this.Controls.Add(this.lblBookingDate);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbBookingSesh);
            this.Controls.Add(this.cbPaymentType);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Name = "frmUpdate";
            this.Text = "frmUpdate";
            this.Load += new System.EventHandler(this.frmUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Label lblBookingSesh;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbBookingSesh;
        private System.Windows.Forms.ComboBox cbPaymentType;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
    }
}