namespace prolab2
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
            this.companyPanel1 = new prolab2.CompanyPanel();
            this.login1 = new prolab2.Login();
            this.adminPanel1 = new prolab2.AdminPanel();
            this.SuspendLayout();
            // 
            // companyPanel1
            // 
            this.companyPanel1.Company = null;
            this.companyPanel1.Location = new System.Drawing.Point(0, 0);
            this.companyPanel1.Name = "companyPanel1";
            this.companyPanel1.Size = new System.Drawing.Size(1500, 506);
            this.companyPanel1.TabIndex = 2;
            this.companyPanel1.Visible = false;
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(0, 0);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(815, 448);
            this.login1.TabIndex = 1;
            // 
            // adminPanel1
            // 
            this.adminPanel1.Location = new System.Drawing.Point(0, 0);
            this.adminPanel1.Name = "adminPanel1";
            this.adminPanel1.Size = new System.Drawing.Size(806, 530);
            this.adminPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.companyPanel1);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.adminPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private AdminPanel adminPanel1;
        private Login login1;
        private CompanyPanel companyPanel1;
    }
}

