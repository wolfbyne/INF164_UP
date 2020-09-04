namespace INF164Prac04_u20447613_
{
    partial class frmBookReg
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
            this.dgBooks = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbBookReg = new System.Windows.Forms.GroupBox();
            this.dtpPubDate = new System.Windows.Forms.DateTimePicker();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblRatings = new System.Windows.Forms.Label();
            this.lblPublishedDate = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRegBook = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRatings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBooks)).BeginInit();
            this.gbBookReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBooks
            // 
            this.dgBooks.AllowUserToAddRows = false;
            this.dgBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5,
            this.col6});
            this.dgBooks.Location = new System.Drawing.Point(15, 243);
            this.dgBooks.Name = "dgBooks";
            this.dgBooks.ReadOnly = true;
            this.dgBooks.Size = new System.Drawing.Size(643, 195);
            this.dgBooks.TabIndex = 4;
            // 
            // col1
            // 
            this.col1.HeaderText = "Title";
            this.col1.Name = "col1";
            // 
            // col2
            // 
            this.col2.HeaderText = "Author";
            this.col2.Name = "col2";
            // 
            // col3
            // 
            this.col3.HeaderText = "Published Date";
            this.col3.Name = "col3";
            // 
            // col4
            // 
            this.col4.HeaderText = "Book Genre";
            this.col4.Name = "col4";
            // 
            // col5
            // 
            this.col5.HeaderText = "Book Rating Out of 5";
            this.col5.Name = "col5";
            // 
            // col6
            // 
            this.col6.HeaderText = "E-Book Available?";
            this.col6.Name = "col6";
            this.col6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // gbBookReg
            // 
            this.gbBookReg.Controls.Add(this.dtpPubDate);
            this.gbBookReg.Controls.Add(this.cbGenre);
            this.gbBookReg.Controls.Add(this.lblGenre);
            this.gbBookReg.Controls.Add(this.nudRating);
            this.gbBookReg.Controls.Add(this.txtAuthor);
            this.gbBookReg.Controls.Add(this.txtTitle);
            this.gbBookReg.Controls.Add(this.lblRatings);
            this.gbBookReg.Controls.Add(this.lblPublishedDate);
            this.gbBookReg.Controls.Add(this.lblAuthor);
            this.gbBookReg.Controls.Add(this.lblTitle);
            this.gbBookReg.Location = new System.Drawing.Point(50, 27);
            this.gbBookReg.Name = "gbBookReg";
            this.gbBookReg.Size = new System.Drawing.Size(276, 192);
            this.gbBookReg.TabIndex = 3;
            this.gbBookReg.TabStop = false;
            this.gbBookReg.Text = "Book Registration";
            // 
            // dtpPubDate
            // 
            this.dtpPubDate.Location = new System.Drawing.Point(139, 98);
            this.dtpPubDate.Name = "dtpPubDate";
            this.dtpPubDate.Size = new System.Drawing.Size(121, 20);
            this.dtpPubDate.TabIndex = 10;
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Items.AddRange(new object[] {
            "Classic",
            "Mystery",
            "Science fiction",
            "Murder",
            "Thriller",
            "Biography"});
            this.cbGenre.Location = new System.Drawing.Point(139, 131);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(121, 21);
            this.cbGenre.TabIndex = 9;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(22, 139);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(39, 13);
            this.lblGenre.TabIndex = 8;
            this.lblGenre.Text = "Genre:";
            // 
            // nudRating
            // 
            this.nudRating.DecimalPlaces = 1;
            this.nudRating.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudRating.Location = new System.Drawing.Point(139, 161);
            this.nudRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRating.Name = "nudRating";
            this.nudRating.Size = new System.Drawing.Size(58, 20);
            this.nudRating.TabIndex = 7;
            this.nudRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(139, 67);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(121, 20);
            this.txtAuthor.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(139, 34);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(121, 20);
            this.txtTitle.TabIndex = 4;
            // 
            // lblRatings
            // 
            this.lblRatings.AutoSize = true;
            this.lblRatings.Location = new System.Drawing.Point(22, 168);
            this.lblRatings.Name = "lblRatings";
            this.lblRatings.Size = new System.Drawing.Size(82, 13);
            this.lblRatings.TabIndex = 3;
            this.lblRatings.Text = "Rating Out of 5:";
            // 
            // lblPublishedDate
            // 
            this.lblPublishedDate.AutoSize = true;
            this.lblPublishedDate.Location = new System.Drawing.Point(22, 106);
            this.lblPublishedDate.Name = "lblPublishedDate";
            this.lblPublishedDate.Size = new System.Drawing.Size(82, 13);
            this.lblPublishedDate.TabIndex = 2;
            this.lblPublishedDate.Text = "Published Date:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(22, 74);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(22, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // btnRegBook
            // 
            this.btnRegBook.Location = new System.Drawing.Point(342, 94);
            this.btnRegBook.Name = "btnRegBook";
            this.btnRegBook.Size = new System.Drawing.Size(138, 42);
            this.btnRegBook.TabIndex = 8;
            this.btnRegBook.Text = "Register Book";
            this.btnRegBook.UseVisualStyleBackColor = true;
            this.btnRegBook.Click += new System.EventHandler(this.btnRegBook_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::INF164Prac04_u20447613_.Properties.Resources.book_symbol_tool_book_author_reading_lost_man_chapter_logo_library_png_clipart;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(512, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 188);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnRatings
            // 
            this.btnRatings.Location = new System.Drawing.Point(342, 161);
            this.btnRatings.Name = "btnRatings";
            this.btnRatings.Size = new System.Drawing.Size(138, 42);
            this.btnRatings.TabIndex = 9;
            this.btnRatings.Text = "Ratings";
            this.btnRatings.UseVisualStyleBackColor = true;
            this.btnRatings.Click += new System.EventHandler(this.btnRatings_Click);
            // 
            // frmBookReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.btnRatings);
            this.Controls.Add(this.btnRegBook);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgBooks);
            this.Controls.Add(this.gbBookReg);
            this.Name = "frmBookReg";
            this.Text = "Book Registration";
            ((System.ComponentModel.ISupportInitialize)(this.dgBooks)).EndInit();
            this.gbBookReg.ResumeLayout(false);
            this.gbBookReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgBooks;
        private System.Windows.Forms.GroupBox gbBookReg;
        private System.Windows.Forms.Button btnRegBook;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblRatings;
        private System.Windows.Forms.Label lblPublishedDate;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRatings;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col6;
        private System.Windows.Forms.DateTimePicker dtpPubDate;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Label lblGenre;
    }
}