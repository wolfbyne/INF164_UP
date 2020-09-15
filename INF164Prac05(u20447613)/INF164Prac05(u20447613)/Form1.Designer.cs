namespace INF164Prac05_u20447613_
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
            this.dgInstument = new System.Windows.Forms.DataGridView();
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.btnMostVotes = new System.Windows.Forms.Button();
            this.btnVote = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgInstument)).BeginInit();
            this.gbSelect.SuspendLayout();
            this.gbAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgInstument
            // 
            this.dgInstument.AllowUserToAddRows = false;
            this.dgInstument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInstument.Location = new System.Drawing.Point(12, 12);
            this.dgInstument.Name = "dgInstument";
            this.dgInstument.ReadOnly = true;
            this.dgInstument.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInstument.Size = new System.Drawing.Size(349, 168);
            this.dgInstument.TabIndex = 0;
            // 
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.btnDelete);
            this.gbSelect.Controls.Add(this.btnEdit);
            this.gbSelect.Controls.Add(this.btnVote);
            this.gbSelect.Location = new System.Drawing.Point(386, 12);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Size = new System.Drawing.Size(215, 168);
            this.gbSelect.TabIndex = 1;
            this.gbSelect.TabStop = false;
            this.gbSelect.Text = "Select and Vote for your favourite Instrument!";
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.btnAdd);
            this.gbAdd.Location = new System.Drawing.Point(386, 207);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(215, 98);
            this.gbAdd.TabIndex = 2;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Don\'t See Your Favourite? Add it!";
            // 
            // btnMostVotes
            // 
            this.btnMostVotes.Location = new System.Drawing.Point(123, 218);
            this.btnMostVotes.Name = "btnMostVotes";
            this.btnMostVotes.Size = new System.Drawing.Size(104, 70);
            this.btnMostVotes.TabIndex = 3;
            this.btnMostVotes.Text = "What Instrument has the most Votes?";
            this.btnMostVotes.UseVisualStyleBackColor = true;
            this.btnMostVotes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVote
            // 
            this.btnVote.Location = new System.Drawing.Point(56, 38);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(75, 23);
            this.btnVote.TabIndex = 0;
            this.btnVote.Text = "Vote!";
            this.btnVote.UseVisualStyleBackColor = true;
            this.btnVote.Click += new System.EventHandler(this.btnVote_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(39, 82);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit Selection";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(39, 128);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Selection";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(66, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 319);
            this.Controls.Add(this.btnMostVotes);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.gbSelect);
            this.Controls.Add(this.dgInstument);
            this.Name = "frmMain";
            this.Text = "Which Instrument Is Best?";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInstument)).EndInit();
            this.gbSelect.ResumeLayout(false);
            this.gbAdd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgInstument;
        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMostVotes;
    }
}

