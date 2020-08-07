namespace INF164_A1_U20447613
{
    partial class frmStocks
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
            this.dgStocks = new System.Windows.Forms.DataGridView();
            this.gbGrowthCalc = new System.Windows.Forms.GroupBox();
            this.btnCalculateChange = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.gbAddStock = new System.Windows.Forms.GroupBox();
            this.lbl2017 = new System.Windows.Forms.Label();
            this.lblStockName = new System.Windows.Forms.Label();
            this.lbl2018 = new System.Windows.Forms.Label();
            this.lbl2019 = new System.Windows.Forms.Label();
            this.txtStockName = new System.Windows.Forms.TextBox();
            this.nud2017 = new System.Windows.Forms.NumericUpDown();
            this.nud2018 = new System.Windows.Forms.NumericUpDown();
            this.nud2019 = new System.Windows.Forms.NumericUpDown();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgStocks)).BeginInit();
            this.gbGrowthCalc.SuspendLayout();
            this.gbAddStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud2017)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2018)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2019)).BeginInit();
            this.SuspendLayout();
            // 
            // dgStocks
            // 
            this.dgStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2,
            this.col3,
            this.col4});
            this.dgStocks.Location = new System.Drawing.Point(39, 38);
            this.dgStocks.Name = "dgStocks";
            this.dgStocks.ReadOnly = true;
            this.dgStocks.Size = new System.Drawing.Size(441, 367);
            this.dgStocks.TabIndex = 0;
            // 
            // gbGrowthCalc
            // 
            this.gbGrowthCalc.Controls.Add(this.btnCalculateChange);
            this.gbGrowthCalc.Controls.Add(this.lblDescription);
            this.gbGrowthCalc.Location = new System.Drawing.Point(498, 52);
            this.gbGrowthCalc.Name = "gbGrowthCalc";
            this.gbGrowthCalc.Size = new System.Drawing.Size(200, 102);
            this.gbGrowthCalc.TabIndex = 1;
            this.gbGrowthCalc.TabStop = false;
            this.gbGrowthCalc.Text = "Growth Calculator";
            // 
            // btnCalculateChange
            // 
            this.btnCalculateChange.Location = new System.Drawing.Point(43, 73);
            this.btnCalculateChange.Name = "btnCalculateChange";
            this.btnCalculateChange.Size = new System.Drawing.Size(111, 23);
            this.btnCalculateChange.TabIndex = 1;
            this.btnCalculateChange.Text = "Calculate Change";
            this.btnCalculateChange.UseVisualStyleBackColor = true;
            this.btnCalculateChange.Click += new System.EventHandler(this.btnCalculateChange_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 27);
            this.lblDescription.MaximumSize = new System.Drawing.Size(190, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(162, 26);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Select any item and calculate its growth from 2017 to 2019";
            // 
            // gbAddStock
            // 
            this.gbAddStock.Controls.Add(this.btnAddStock);
            this.gbAddStock.Controls.Add(this.nud2019);
            this.gbAddStock.Controls.Add(this.nud2018);
            this.gbAddStock.Controls.Add(this.nud2017);
            this.gbAddStock.Controls.Add(this.txtStockName);
            this.gbAddStock.Controls.Add(this.lbl2019);
            this.gbAddStock.Controls.Add(this.lbl2018);
            this.gbAddStock.Controls.Add(this.lbl2017);
            this.gbAddStock.Controls.Add(this.lblStockName);
            this.gbAddStock.Location = new System.Drawing.Point(498, 184);
            this.gbAddStock.Name = "gbAddStock";
            this.gbAddStock.Size = new System.Drawing.Size(200, 221);
            this.gbAddStock.TabIndex = 2;
            this.gbAddStock.TabStop = false;
            this.gbAddStock.Text = "Add A Stock";
            // 
            // lbl2017
            // 
            this.lbl2017.AutoSize = true;
            this.lbl2017.Location = new System.Drawing.Point(31, 93);
            this.lbl2017.Name = "lbl2017";
            this.lbl2017.Size = new System.Drawing.Size(64, 13);
            this.lbl2017.TabIndex = 1;
            this.lbl2017.Text = "2017 Value:";
            // 
            // lblStockName
            // 
            this.lblStockName.AutoSize = true;
            this.lblStockName.Location = new System.Drawing.Point(31, 48);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(69, 13);
            this.lblStockName.TabIndex = 0;
            this.lblStockName.Text = "Stock Name:";
            // 
            // lbl2018
            // 
            this.lbl2018.AutoSize = true;
            this.lbl2018.Location = new System.Drawing.Point(31, 125);
            this.lbl2018.Name = "lbl2018";
            this.lbl2018.Size = new System.Drawing.Size(64, 13);
            this.lbl2018.TabIndex = 2;
            this.lbl2018.Text = "2018 Value:";
            // 
            // lbl2019
            // 
            this.lbl2019.AutoSize = true;
            this.lbl2019.Location = new System.Drawing.Point(31, 159);
            this.lbl2019.Name = "lbl2019";
            this.lbl2019.Size = new System.Drawing.Size(64, 13);
            this.lbl2019.TabIndex = 3;
            this.lbl2019.Text = "2019 Value:";
            // 
            // txtStockName
            // 
            this.txtStockName.Location = new System.Drawing.Point(123, 40);
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.Size = new System.Drawing.Size(71, 20);
            this.txtStockName.TabIndex = 4;
            // 
            // nud2017
            // 
            this.nud2017.Location = new System.Drawing.Point(123, 85);
            this.nud2017.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud2017.Name = "nud2017";
            this.nud2017.Size = new System.Drawing.Size(71, 20);
            this.nud2017.TabIndex = 5;
            // 
            // nud2018
            // 
            this.nud2018.Location = new System.Drawing.Point(123, 118);
            this.nud2018.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud2018.Name = "nud2018";
            this.nud2018.Size = new System.Drawing.Size(71, 20);
            this.nud2018.TabIndex = 6;
            // 
            // nud2019
            // 
            this.nud2019.Location = new System.Drawing.Point(123, 152);
            this.nud2019.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud2019.Name = "nud2019";
            this.nud2019.Size = new System.Drawing.Size(71, 20);
            this.nud2019.TabIndex = 7;
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(68, 192);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(75, 23);
            this.btnAddStock.TabIndex = 8;
            this.btnAddStock.Text = "AddStock";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // Col1
            // 
            this.Col1.HeaderText = "Stock Name";
            this.Col1.Name = "Col1";
            // 
            // Col2
            // 
            this.Col2.HeaderText = "2017";
            this.Col2.Name = "Col2";
            // 
            // col3
            // 
            this.col3.HeaderText = "2018";
            this.col3.Name = "col3";
            // 
            // col4
            // 
            this.col4.HeaderText = "2019";
            this.col4.Name = "col4";
            // 
            // frmStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.gbAddStock);
            this.Controls.Add(this.gbGrowthCalc);
            this.Controls.Add(this.dgStocks);
            this.Name = "frmStocks";
            this.Text = "Stocks";
            this.Load += new System.EventHandler(this.frmStocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStocks)).EndInit();
            this.gbGrowthCalc.ResumeLayout(false);
            this.gbGrowthCalc.PerformLayout();
            this.gbAddStock.ResumeLayout(false);
            this.gbAddStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud2017)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2018)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2019)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgStocks;
        private System.Windows.Forms.GroupBox gbGrowthCalc;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.GroupBox gbAddStock;
        private System.Windows.Forms.Button btnCalculateChange;
        private System.Windows.Forms.Label lbl2017;
        private System.Windows.Forms.Label lblStockName;
        private System.Windows.Forms.Label lbl2019;
        private System.Windows.Forms.Label lbl2018;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.NumericUpDown nud2019;
        private System.Windows.Forms.NumericUpDown nud2018;
        private System.Windows.Forms.NumericUpDown nud2017;
        private System.Windows.Forms.TextBox txtStockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
    }
}