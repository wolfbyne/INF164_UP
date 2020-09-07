namespace INF164_A2_U20447613
{
    partial class frmAddClient
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.lblCredLim = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.nudCredLim = new System.Windows.Forms.NumericUpDown();
            this.txtClientFirstName = new System.Windows.Forms.TextBox();
            this.txtClientLastName = new System.Windows.Forms.TextBox();
            this.txtIDnum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCredLim)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(38, 53);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(38, 108);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Location = new System.Drawing.Point(38, 164);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(61, 13);
            this.lblIDNumber.TabIndex = 2;
            this.lblIDNumber.Text = "ID Number:";
            // 
            // lblCredLim
            // 
            this.lblCredLim.AutoSize = true;
            this.lblCredLim.Location = new System.Drawing.Point(38, 229);
            this.lblCredLim.Name = "lblCredLim";
            this.lblCredLim.Size = new System.Drawing.Size(61, 13);
            this.lblCredLim.TabIndex = 3;
            this.lblCredLim.Text = "Credit Limit:";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(95, 293);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(75, 23);
            this.btnAddClient.TabIndex = 4;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // nudCredLim
            // 
            this.nudCredLim.Location = new System.Drawing.Point(130, 227);
            this.nudCredLim.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCredLim.Name = "nudCredLim";
            this.nudCredLim.Size = new System.Drawing.Size(56, 20);
            this.nudCredLim.TabIndex = 5;
            // 
            // txtClientFirstName
            // 
            this.txtClientFirstName.Location = new System.Drawing.Point(130, 50);
            this.txtClientFirstName.Name = "txtClientFirstName";
            this.txtClientFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtClientFirstName.TabIndex = 6;
            // 
            // txtClientLastName
            // 
            this.txtClientLastName.Location = new System.Drawing.Point(130, 105);
            this.txtClientLastName.Name = "txtClientLastName";
            this.txtClientLastName.Size = new System.Drawing.Size(100, 20);
            this.txtClientLastName.TabIndex = 7;
            // 
            // txtIDnum
            // 
            this.txtIDnum.Location = new System.Drawing.Point(130, 161);
            this.txtIDnum.Name = "txtIDnum";
            this.txtIDnum.Size = new System.Drawing.Size(100, 20);
            this.txtIDnum.TabIndex = 8;
            // 
            // frmAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::INF164_A2_U20447613.Properties.Resources._1862828;
            this.ClientSize = new System.Drawing.Size(280, 328);
            this.Controls.Add(this.txtIDnum);
            this.Controls.Add(this.txtClientLastName);
            this.Controls.Add(this.txtClientFirstName);
            this.Controls.Add(this.nudCredLim);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.lblCredLim);
            this.Controls.Add(this.lblIDNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "frmAddClient";
            this.Text = "Add Client";
            ((System.ComponentModel.ISupportInitialize)(this.nudCredLim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.Label lblCredLim;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.NumericUpDown nudCredLim;
        private System.Windows.Forms.TextBox txtClientFirstName;
        private System.Windows.Forms.TextBox txtClientLastName;
        private System.Windows.Forms.TextBox txtIDnum;
    }
}