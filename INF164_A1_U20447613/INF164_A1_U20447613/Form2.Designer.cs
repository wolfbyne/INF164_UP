namespace INF164_A1_U20447613
{
    partial class frmCalc
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBal = new System.Windows.Forms.Label();
            this.lblDesBal = new System.Windows.Forms.Label();
            this.lblNumMon = new System.Windows.Forms.Label();
            this.nudBal = new System.Windows.Forms.NumericUpDown();
            this.nudDesBal = new System.Windows.Forms.NumericUpDown();
            this.nudNumMon = new System.Windows.Forms.NumericUpDown();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnSaveClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesBal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumMon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(116, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(232, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "How much does your investment need to grow?";
            // 
            // lblBal
            // 
            this.lblBal.AutoSize = true;
            this.lblBal.Location = new System.Drawing.Point(116, 135);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(103, 13);
            this.lblBal.TabIndex = 1;
            this.lblBal.Text = "Current Balance (R):";
            // 
            // lblDesBal
            // 
            this.lblDesBal.AutoSize = true;
            this.lblDesBal.Location = new System.Drawing.Point(116, 186);
            this.lblDesBal.Name = "lblDesBal";
            this.lblDesBal.Size = new System.Drawing.Size(138, 13);
            this.lblDesBal.TabIndex = 2;
            this.lblDesBal.Text = "Desired Future Balance (R):";
            // 
            // lblNumMon
            // 
            this.lblNumMon.AutoSize = true;
            this.lblNumMon.Location = new System.Drawing.Point(116, 232);
            this.lblNumMon.Name = "lblNumMon";
            this.lblNumMon.Size = new System.Drawing.Size(170, 13);
            this.lblNumMon.TabIndex = 3;
            this.lblNumMon.Text = "Number Of Months It should Take:";
            // 
            // nudBal
            // 
            this.nudBal.Location = new System.Drawing.Point(323, 128);
            this.nudBal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudBal.Name = "nudBal";
            this.nudBal.Size = new System.Drawing.Size(120, 20);
            this.nudBal.TabIndex = 4;
            // 
            // nudDesBal
            // 
            this.nudDesBal.Location = new System.Drawing.Point(323, 179);
            this.nudDesBal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDesBal.Name = "nudDesBal";
            this.nudDesBal.Size = new System.Drawing.Size(120, 20);
            this.nudDesBal.TabIndex = 5;
            // 
            // nudNumMon
            // 
            this.nudNumMon.Location = new System.Drawing.Point(323, 225);
            this.nudNumMon.Name = "nudNumMon";
            this.nudNumMon.Size = new System.Drawing.Size(120, 20);
            this.nudNumMon.TabIndex = 6;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(200, 293);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(172, 342);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(128, 23);
            this.btnSaveClose.TabIndex = 8;
            this.btnSaveClose.Text = "Save and Close";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 418);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.nudNumMon);
            this.Controls.Add(this.nudDesBal);
            this.Controls.Add(this.nudBal);
            this.Controls.Add(this.lblNumMon);
            this.Controls.Add(this.lblDesBal);
            this.Controls.Add(this.lblBal);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCalc";
            this.Text = "Calculate";
            this.Load += new System.EventHandler(this.frmCalc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesBal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.Label lblDesBal;
        private System.Windows.Forms.Label lblNumMon;
        private System.Windows.Forms.NumericUpDown nudBal;
        private System.Windows.Forms.NumericUpDown nudDesBal;
        private System.Windows.Forms.NumericUpDown nudNumMon;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnSaveClose;
    }
}