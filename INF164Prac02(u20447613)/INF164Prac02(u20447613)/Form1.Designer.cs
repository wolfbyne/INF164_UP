namespace INF164Prac02_u20447613_
{
    partial class frmMain
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
            System.Windows.Forms.GroupBox gbPersonalDetails;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gbBMI = new System.Windows.Forms.GroupBox();
            this.lblYourBMI = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            gbPersonalDetails = new System.Windows.Forms.GroupBox();
            gbPersonalDetails.SuspendLayout();
            this.gbBMI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPersonalDetails
            // 
            gbPersonalDetails.Controls.Add(this.btnContinue);
            gbPersonalDetails.Controls.Add(this.lblID);
            gbPersonalDetails.Controls.Add(this.lblSurname);
            gbPersonalDetails.Controls.Add(this.lblName);
            gbPersonalDetails.Controls.Add(this.txtID);
            gbPersonalDetails.Controls.Add(this.txtSurname);
            gbPersonalDetails.Controls.Add(this.txtName);
            gbPersonalDetails.Location = new System.Drawing.Point(12, 153);
            gbPersonalDetails.Name = "gbPersonalDetails";
            gbPersonalDetails.Size = new System.Drawing.Size(362, 249);
            gbPersonalDetails.TabIndex = 0;
            gbPersonalDetails.TabStop = false;
            gbPersonalDetails.Text = "Personal Details";
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(136, 197);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(96, 30);
            this.btnContinue.TabIndex = 6;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(33, 158);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(79, 17);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID Number:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(33, 106);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(69, 17);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Surname:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(238, 154);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(238, 101);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 22);
            this.txtSurname.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(238, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 0;
            // 
            // gbBMI
            // 
            this.gbBMI.Controls.Add(this.lblYourBMI);
            this.gbBMI.Controls.Add(this.btnCalc);
            this.gbBMI.Controls.Add(this.lblWeight);
            this.gbBMI.Controls.Add(this.lblHeight);
            this.gbBMI.Controls.Add(this.txtWeight);
            this.gbBMI.Controls.Add(this.txtHeight);
            this.gbBMI.Enabled = false;
            this.gbBMI.Location = new System.Drawing.Point(12, 408);
            this.gbBMI.Name = "gbBMI";
            this.gbBMI.Size = new System.Drawing.Size(616, 185);
            this.gbBMI.TabIndex = 1;
            this.gbBMI.TabStop = false;
            this.gbBMI.Text = "BMI Eligibility";
            // 
            // lblYourBMI
            // 
            this.lblYourBMI.AutoSize = true;
            this.lblYourBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourBMI.Location = new System.Drawing.Point(397, 31);
            this.lblYourBMI.Name = "lblYourBMI";
            this.lblYourBMI.Size = new System.Drawing.Size(167, 32);
            this.lblYourBMI.TabIndex = 5;
            this.lblYourBMI.Text = "Your BMI is:";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(136, 145);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(122, 34);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate BMI";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(47, 95);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(83, 17);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "Weight (Kg)";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(47, 49);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(78, 17);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height (M):";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(238, 92);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 22);
            this.txtWeight.TabIndex = 1;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(238, 44);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 22);
            this.txtHeight.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::INF164Prac02_u20447613_.Properties.Resources.become_a_certified_skydiver1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(643, 136);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 605);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbBMI);
            this.Controls.Add(gbPersonalDetails);
            this.Name = "frmMain";
            this.Text = "Skydiver";
            gbPersonalDetails.ResumeLayout(false);
            gbPersonalDetails.PerformLayout();
            this.gbBMI.ResumeLayout(false);
            this.gbBMI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox gbBMI;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblYourBMI;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

