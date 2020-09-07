namespace INF164_A2_U20447613
{
    partial class frmEditClient
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
            this.txtIDnum = new System.Windows.Forms.TextBox();
            this.txtClientLastName = new System.Windows.Forms.TextBox();
            this.txtClientFirstName = new System.Windows.Forms.TextBox();
            this.nudCredLim = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.lblCredLim = new System.Windows.Forms.Label();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCredLim)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDnum
            // 
            this.txtIDnum.Location = new System.Drawing.Point(151, 164);
            this.txtIDnum.Name = "txtIDnum";
            this.txtIDnum.Size = new System.Drawing.Size(100, 20);
            this.txtIDnum.TabIndex = 17;
            // 
            // txtClientLastName
            // 
            this.txtClientLastName.Location = new System.Drawing.Point(151, 108);
            this.txtClientLastName.Name = "txtClientLastName";
            this.txtClientLastName.Size = new System.Drawing.Size(100, 20);
            this.txtClientLastName.TabIndex = 16;
            // 
            // txtClientFirstName
            // 
            this.txtClientFirstName.Location = new System.Drawing.Point(151, 53);
            this.txtClientFirstName.Name = "txtClientFirstName";
            this.txtClientFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtClientFirstName.TabIndex = 15;
            // 
            // nudCredLim
            // 
            this.nudCredLim.Location = new System.Drawing.Point(151, 230);
            this.nudCredLim.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCredLim.Name = "nudCredLim";
            this.nudCredLim.Size = new System.Drawing.Size(56, 20);
            this.nudCredLim.TabIndex = 14;
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Location = new System.Drawing.Point(90, 293);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(117, 23);
            this.btnUpdateClient.TabIndex = 13;
            this.btnUpdateClient.Text = "Update Client";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // lblCredLim
            // 
            this.lblCredLim.AutoSize = true;
            this.lblCredLim.Location = new System.Drawing.Point(59, 232);
            this.lblCredLim.Name = "lblCredLim";
            this.lblCredLim.Size = new System.Drawing.Size(61, 13);
            this.lblCredLim.TabIndex = 12;
            this.lblCredLim.Text = "Credit Limit:";
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Location = new System.Drawing.Point(59, 167);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(61, 13);
            this.lblIDNumber.TabIndex = 11;
            this.lblIDNumber.Text = "ID Number:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(59, 111);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(59, 56);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name:";
            // 
            // frmEditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::INF164_A2_U20447613.Properties.Resources._1862828;
            this.ClientSize = new System.Drawing.Size(313, 360);
            this.Controls.Add(this.txtIDnum);
            this.Controls.Add(this.txtClientLastName);
            this.Controls.Add(this.txtClientFirstName);
            this.Controls.Add(this.nudCredLim);
            this.Controls.Add(this.btnUpdateClient);
            this.Controls.Add(this.lblCredLim);
            this.Controls.Add(this.lblIDNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "frmEditClient";
            this.Text = "Edit Client";
            ((System.ComponentModel.ISupportInitialize)(this.nudCredLim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDnum;
        private System.Windows.Forms.TextBox txtClientLastName;
        private System.Windows.Forms.TextBox txtClientFirstName;
        private System.Windows.Forms.NumericUpDown nudCredLim;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Label lblCredLim;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
    }
}