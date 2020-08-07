namespace INF164Prac01_u20447613_
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblSubHeading = new System.Windows.Forms.Label();
            this.gbApply = new System.Windows.Forms.GroupBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblDegree = new System.Windows.Forms.Label();
            this.lblUnderOrPost = new System.Windows.Forms.Label();
            this.cbDegree = new System.Windows.Forms.ComboBox();
            this.cbUnderOrPost = new System.Windows.Forms.ComboBox();
            this.rtbApplicationLetter = new System.Windows.Forms.RichTextBox();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblComeback = new System.Windows.Forms.Label();
            this.gbApply.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(12, 25);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(754, 33);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Welcome to the University of Pretoria Application System";
            // 
            // lblSubHeading
            // 
            this.lblSubHeading.AutoSize = true;
            this.lblSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeading.Location = new System.Drawing.Point(161, 80);
            this.lblSubHeading.Name = "lblSubHeading";
            this.lblSubHeading.Size = new System.Drawing.Size(514, 24);
            this.lblSubHeading.TabIndex = 1;
            this.lblSubHeading.Text = "Use this program to apply for your choice of degree program";
            // 
            // gbApply
            // 
            this.gbApply.Controls.Add(this.btnContinue);
            this.gbApply.Controls.Add(this.lblDegree);
            this.gbApply.Controls.Add(this.lblUnderOrPost);
            this.gbApply.Controls.Add(this.cbDegree);
            this.gbApply.Controls.Add(this.cbUnderOrPost);
            this.gbApply.Location = new System.Drawing.Point(131, 168);
            this.gbApply.Name = "gbApply";
            this.gbApply.Size = new System.Drawing.Size(574, 231);
            this.gbApply.TabIndex = 2;
            this.gbApply.TabStop = false;
            this.gbApply.Text = "Apply Now!";
            // 
            // btnContinue
            // 
            this.btnContinue.Enabled = false;
            this.btnContinue.Location = new System.Drawing.Point(265, 186);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(85, 28);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Location = new System.Drawing.Point(58, 146);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(123, 13);
            this.lblDegree.TabIndex = 3;
            this.lblDegree.Text = "Select a degree program";
            // 
            // lblUnderOrPost
            // 
            this.lblUnderOrPost.AutoSize = true;
            this.lblUnderOrPost.Location = new System.Drawing.Point(58, 80);
            this.lblUnderOrPost.Name = "lblUnderOrPost";
            this.lblUnderOrPost.Size = new System.Drawing.Size(189, 13);
            this.lblUnderOrPost.TabIndex = 2;
            this.lblUnderOrPost.Text = "Select under graduate or postgraduate";
            // 
            // cbDegree
            // 
            this.cbDegree.Enabled = false;
            this.cbDegree.FormattingEnabled = true;
            this.cbDegree.Location = new System.Drawing.Point(411, 138);
            this.cbDegree.Name = "cbDegree";
            this.cbDegree.Size = new System.Drawing.Size(121, 21);
            this.cbDegree.TabIndex = 1;
            this.cbDegree.SelectedIndexChanged += new System.EventHandler(this.cbDegree_SelectedIndexChanged);
            // 
            // cbUnderOrPost
            // 
            this.cbUnderOrPost.FormattingEnabled = true;
            this.cbUnderOrPost.Items.AddRange(new object[] {
            "Undergraduate",
            "Postgraduate"});
            this.cbUnderOrPost.Location = new System.Drawing.Point(411, 72);
            this.cbUnderOrPost.Name = "cbUnderOrPost";
            this.cbUnderOrPost.Size = new System.Drawing.Size(121, 21);
            this.cbUnderOrPost.TabIndex = 0;
            this.cbUnderOrPost.SelectedIndexChanged += new System.EventHandler(this.cbUnderOrPost_SelectedIndexChanged);
            // 
            // rtbApplicationLetter
            // 
            this.rtbApplicationLetter.AcceptsTab = true;
            this.rtbApplicationLetter.Location = new System.Drawing.Point(12, 152);
            this.rtbApplicationLetter.Name = "rtbApplicationLetter";
            this.rtbApplicationLetter.Size = new System.Drawing.Size(776, 230);
            this.rtbApplicationLetter.TabIndex = 5;
            this.rtbApplicationLetter.Text = "";
            this.rtbApplicationLetter.Visible = false;
            // 
            // lblStep2
            // 
            this.lblStep2.AutoSize = true;
            this.lblStep2.Location = new System.Drawing.Point(286, 133);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(268, 13);
            this.lblStep2.TabIndex = 3;
            this.lblStep2.Text = "Continue your application by writing an application letter";
            this.lblStep2.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(396, 439);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(85, 33);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblComeback
            // 
            this.lblComeback.AutoSize = true;
            this.lblComeback.Location = new System.Drawing.Point(322, 411);
            this.lblComeback.Name = "lblComeback";
            this.lblComeback.Size = new System.Drawing.Size(241, 13);
            this.lblComeback.TabIndex = 5;
            this.lblComeback.Text = "You can come back to edit your letter at any time!";
            this.lblComeback.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.rtbApplicationLetter);
            this.Controls.Add(this.lblComeback);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblStep2);
            this.Controls.Add(this.gbApply);
            this.Controls.Add(this.lblSubHeading);
            this.Controls.Add(this.lblHeading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbApply.ResumeLayout(false);
            this.gbApply.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblSubHeading;
        private System.Windows.Forms.GroupBox gbApply;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.Label lblUnderOrPost;
        private System.Windows.Forms.ComboBox cbDegree;
        private System.Windows.Forms.ComboBox cbUnderOrPost;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RichTextBox rtbApplicationLetter;
        private System.Windows.Forms.Label lblComeback;
    }
}

