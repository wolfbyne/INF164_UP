namespace INF164Prac04_u20447613_
{
    partial class frm164
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
            this.btnBookReg = new System.Windows.Forms.Button();
            this.btnPatReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBookReg
            // 
            this.btnBookReg.Location = new System.Drawing.Point(136, 247);
            this.btnBookReg.Name = "btnBookReg";
            this.btnBookReg.Size = new System.Drawing.Size(151, 47);
            this.btnBookReg.TabIndex = 1;
            this.btnBookReg.Text = "Book Registration";
            this.btnBookReg.UseVisualStyleBackColor = true;
            this.btnBookReg.Click += new System.EventHandler(this.btnBookReg_Click);
            // 
            // btnPatReg
            // 
            this.btnPatReg.Location = new System.Drawing.Point(136, 132);
            this.btnPatReg.Name = "btnPatReg";
            this.btnPatReg.Size = new System.Drawing.Size(151, 47);
            this.btnPatReg.TabIndex = 2;
            this.btnPatReg.Text = "Patron Registration";
            this.btnPatReg.UseVisualStyleBackColor = true;
            this.btnPatReg.Click += new System.EventHandler(this.btnPatReg_Click);
            // 
            // frm164
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::INF164Prac04_u20447613_.Properties.Resources.png_transparent_amazon_com_library_bookcase_business_cupboard_furniture_company_photography;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(413, 441);
            this.Controls.Add(this.btnPatReg);
            this.Controls.Add(this.btnBookReg);
            this.Name = "frm164";
            this.Text = "164 Library";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBookReg;
        private System.Windows.Forms.Button btnPatReg;
    }
}

