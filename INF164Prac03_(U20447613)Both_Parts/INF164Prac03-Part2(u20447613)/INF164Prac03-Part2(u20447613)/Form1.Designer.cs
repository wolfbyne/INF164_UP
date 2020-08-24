namespace INF164Prac03_Part2_u20447613_
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
            this.dgGuess = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDescription = new System.Windows.Forms.Label();
            this.nudCol = new System.Windows.Forms.NumericUpDown();
            this.btnGuess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgGuess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCol)).BeginInit();
            this.SuspendLayout();
            // 
            // dgGuess
            // 
            this.dgGuess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGuess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3});
            this.dgGuess.Location = new System.Drawing.Point(12, 12);
            this.dgGuess.Name = "dgGuess";
            this.dgGuess.ReadOnly = true;
            this.dgGuess.Size = new System.Drawing.Size(405, 150);
            this.dgGuess.TabIndex = 0;
            // 
            // col1
            // 
            this.col1.HeaderText = "Column 1";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            // 
            // col2
            // 
            this.col2.HeaderText = "Column 2";
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            // 
            // col3
            // 
            this.col3.HeaderText = "Column 3";
            this.col3.Name = "col3";
            this.col3.ReadOnly = true;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(40, 220);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(203, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Which column will have the highest total?";
            // 
            // nudCol
            // 
            this.nudCol.Location = new System.Drawing.Point(346, 213);
            this.nudCol.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudCol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCol.Name = "nudCol";
            this.nudCol.Size = new System.Drawing.Size(47, 20);
            this.nudCol.TabIndex = 2;
            this.nudCol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(168, 288);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 3;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 366);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.nudCol);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.dgGuess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGuess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgGuess;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.NumericUpDown nudCol;
        private System.Windows.Forms.Button btnGuess;
    }
}

