namespace Georgian2coptic
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
            this.label1 = new System.Windows.Forms.Label();
            this.la_georgian = new System.Windows.Forms.Label();
            this.la_coptic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(739, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "التاريخ الميلادى الى القبطى";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // la_georgian
            // 
            this.la_georgian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.la_georgian.Font = new System.Drawing.Font("Tahoma", 20F);
            this.la_georgian.ForeColor = System.Drawing.Color.Red;
            this.la_georgian.Location = new System.Drawing.Point(101, 82);
            this.la_georgian.Name = "la_georgian";
            this.la_georgian.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.la_georgian.Size = new System.Drawing.Size(499, 54);
            this.la_georgian.TabIndex = 0;
            this.la_georgian.Text = "التاريخ الميلادى الى القبطى";
            this.la_georgian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // la_coptic
            // 
            this.la_coptic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.la_coptic.Font = new System.Drawing.Font("Tahoma", 20F);
            this.la_coptic.ForeColor = System.Drawing.Color.Green;
            this.la_coptic.Location = new System.Drawing.Point(101, 138);
            this.la_coptic.Name = "la_coptic";
            this.la_coptic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.la_coptic.Size = new System.Drawing.Size(499, 54);
            this.la_coptic.TabIndex = 0;
            this.la_coptic.Text = "التاريخ الميلادى الى القبطى";
            this.la_coptic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 241);
            this.Controls.Add(this.la_coptic);
            this.Controls.Add(this.la_georgian);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label la_georgian;
        private System.Windows.Forms.Label la_coptic;
    }
}

