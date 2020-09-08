namespace u20447613ClassTest
{
    partial class frmGame
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.msGame = new System.Windows.Forms.MenuStrip();
            this.tsmiReturnToMain = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScore = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnCheckWord = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgWords = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWords)).BeginInit();
            this.SuspendLayout();
            // 
            // msGame
            // 
            this.msGame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReturnToMain,
            this.tsmiScore});
            this.msGame.Location = new System.Drawing.Point(0, 0);
            this.msGame.Name = "msGame";
            this.msGame.Size = new System.Drawing.Size(628, 24);
            this.msGame.TabIndex = 0;
            this.msGame.Text = "msGame";
            // 
            // tsmiReturnToMain
            // 
            this.tsmiReturnToMain.Name = "tsmiReturnToMain";
            this.tsmiReturnToMain.Size = new System.Drawing.Size(122, 20);
            this.tsmiReturnToMain.Text = "Back to main menu";
            this.tsmiReturnToMain.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tsmiScore
            // 
            this.tsmiScore.Enabled = false;
            this.tsmiScore.Name = "tsmiScore";
            this.tsmiScore.Size = new System.Drawing.Size(48, 20);
            this.tsmiScore.Text = "Score";
            this.tsmiScore.Click += new System.EventHandler(this.scoreToolStripMenuItem_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(85, 92);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(82, 201);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(65, 13);
            this.lblWord.TabIndex = 2;
            this.lblWord.Text = "The word is:";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(85, 228);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(100, 20);
            this.txtWord.TabIndex = 3;
            // 
            // btnCheckWord
            // 
            this.btnCheckWord.Enabled = false;
            this.btnCheckWord.Location = new System.Drawing.Point(85, 254);
            this.btnCheckWord.Name = "btnCheckWord";
            this.btnCheckWord.Size = new System.Drawing.Size(75, 23);
            this.btnCheckWord.TabIndex = 4;
            this.btnCheckWord.Text = "Check word";
            this.btnCheckWord.UseVisualStyleBackColor = true;
            this.btnCheckWord.Click += new System.EventHandler(this.btnCheckWord_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(85, 303);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgWords
            // 
            this.dgWords.AllowUserToAddRows = false;
            this.dgWords.AllowUserToResizeColumns = false;
            this.dgWords.AllowUserToResizeRows = false;
            this.dgWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWords.ColumnHeadersVisible = false;
            this.dgWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgWords.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgWords.Location = new System.Drawing.Point(317, 86);
            this.dgWords.Name = "dgWords";
            this.dgWords.RowHeadersVisible = false;
            this.dgWords.RowTemplate.Height = 79;
            this.dgWords.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgWords.Size = new System.Drawing.Size(243, 240);
            this.dgWords.TabIndex = 6;
            // 
            // col1
            // 
            this.col1.HeaderText = "Column1";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            this.col1.Width = 80;
            // 
            // col2
            // 
            this.col2.HeaderText = "Column2";
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            this.col2.Width = 80;
            // 
            // col3
            // 
            this.col3.HeaderText = "Column3";
            this.col3.Name = "col3";
            this.col3.ReadOnly = true;
            this.col3.Width = 80;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 378);
            this.Controls.Add(this.dgWords);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCheckWord);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.msGame);
            this.MainMenuStrip = this.msGame;
            this.Name = "frmGame";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.msGame.ResumeLayout(false);
            this.msGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msGame;
        private System.Windows.Forms.ToolStripMenuItem tsmiReturnToMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiScore;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnCheckWord;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
    }
}