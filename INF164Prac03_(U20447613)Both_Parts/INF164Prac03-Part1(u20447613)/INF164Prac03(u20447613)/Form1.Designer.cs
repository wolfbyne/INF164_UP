namespace INF164Prac03_u20447613_
{
    partial class frmSalesCore
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgSales = new System.Windows.Forms.DataGridView();
            this.btnCalcBestSeller = new System.Windows.Forms.Button();
            this.btnCalcWorstSeller = new System.Windows.Forms.Button();
            this.btnCalcSelectAverg = new System.Windows.Forms.Button();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSellerName = new System.Windows.Forms.TextBox();
            this.colJan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgSales)).BeginInit();
            this.gbUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Managin Sales Made Easy";
            // 
            // dgSales
            // 
            this.dgSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colJan,
            this.colFeb,
            this.colMar,
            this.colApr,
            this.colMay,
            this.colJun,
            this.colJul,
            this.colAug});
            this.dgSales.Location = new System.Drawing.Point(12, 117);
            this.dgSales.Name = "dgSales";
            this.dgSales.Size = new System.Drawing.Size(870, 201);
            this.dgSales.TabIndex = 1;
            // 
            // btnCalcBestSeller
            // 
            this.btnCalcBestSeller.Location = new System.Drawing.Point(75, 338);
            this.btnCalcBestSeller.Name = "btnCalcBestSeller";
            this.btnCalcBestSeller.Size = new System.Drawing.Size(184, 23);
            this.btnCalcBestSeller.TabIndex = 2;
            this.btnCalcBestSeller.Text = "Calculate Best Seller";
            this.btnCalcBestSeller.UseVisualStyleBackColor = true;
            this.btnCalcBestSeller.Click += new System.EventHandler(this.btnCalcBestSeller_Click);
            // 
            // btnCalcWorstSeller
            // 
            this.btnCalcWorstSeller.Location = new System.Drawing.Point(75, 383);
            this.btnCalcWorstSeller.Name = "btnCalcWorstSeller";
            this.btnCalcWorstSeller.Size = new System.Drawing.Size(184, 23);
            this.btnCalcWorstSeller.TabIndex = 3;
            this.btnCalcWorstSeller.Text = "Calculate Worst Seller";
            this.btnCalcWorstSeller.UseVisualStyleBackColor = true;
            this.btnCalcWorstSeller.Click += new System.EventHandler(this.btnCalcWorstSeller_Click);
            // 
            // btnCalcSelectAverg
            // 
            this.btnCalcSelectAverg.Location = new System.Drawing.Point(75, 431);
            this.btnCalcSelectAverg.Name = "btnCalcSelectAverg";
            this.btnCalcSelectAverg.Size = new System.Drawing.Size(184, 23);
            this.btnCalcSelectAverg.TabIndex = 4;
            this.btnCalcSelectAverg.Text = "Calculate Selected Average";
            this.btnCalcSelectAverg.UseVisualStyleBackColor = true;
            this.btnCalcSelectAverg.Click += new System.EventHandler(this.btnCalcSelectAverg_Click);
            // 
            // gbUpdate
            // 
            this.gbUpdate.Controls.Add(this.btnEdit);
            this.gbUpdate.Controls.Add(this.txtSellerName);
            this.gbUpdate.Location = new System.Drawing.Point(671, 338);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(211, 138);
            this.gbUpdate.TabIndex = 5;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "Update Current Seller Name";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(26, 93);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(137, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit Seller Name";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSellerName
            // 
            this.txtSellerName.Location = new System.Drawing.Point(42, 47);
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.Size = new System.Drawing.Size(100, 20);
            this.txtSellerName.TabIndex = 0;
            // 
            // colJan
            // 
            this.colJan.HeaderText = "January";
            this.colJan.Name = "colJan";
            // 
            // colFeb
            // 
            this.colFeb.HeaderText = "February";
            this.colFeb.Name = "colFeb";
            // 
            // colMar
            // 
            this.colMar.HeaderText = "March";
            this.colMar.Name = "colMar";
            // 
            // colApr
            // 
            this.colApr.HeaderText = "April";
            this.colApr.Name = "colApr";
            // 
            // colMay
            // 
            this.colMay.HeaderText = "May";
            this.colMay.Name = "colMay";
            // 
            // colJun
            // 
            this.colJun.HeaderText = "June";
            this.colJun.Name = "colJun";
            // 
            // colJul
            // 
            this.colJul.HeaderText = "July";
            this.colJul.Name = "colJul";
            // 
            // colAug
            // 
            this.colAug.HeaderText = "August";
            this.colAug.Name = "colAug";
            // 
            // frmSalesCore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 488);
            this.Controls.Add(this.gbUpdate);
            this.Controls.Add(this.btnCalcSelectAverg);
            this.Controls.Add(this.btnCalcWorstSeller);
            this.Controls.Add(this.btnCalcBestSeller);
            this.Controls.Add(this.dgSales);
            this.Controls.Add(this.label1);
            this.Name = "frmSalesCore";
            this.Text = "Sales Core";
            this.Load += new System.EventHandler(this.frmSalesCore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSales)).EndInit();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgSales;
        private System.Windows.Forms.Button btnCalcBestSeller;
        private System.Windows.Forms.Button btnCalcWorstSeller;
        private System.Windows.Forms.Button btnCalcSelectAverg;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtSellerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeb;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJun;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJul;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAug;
    }
}

