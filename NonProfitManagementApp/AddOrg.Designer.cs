namespace NonProfitManagementApp
{
    partial class AddOrg
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
            this.txtOrgId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtOrgEmail = new System.Windows.Forms.TextBox();
            this.txtOrgNumber = new System.Windows.Forms.TextBox();
            this.txtOrgAddress = new System.Windows.Forms.TextBox();
            this.txtAcronym = new System.Windows.Forms.TextBox();
            this.txtOrgName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOrgId
            // 
            this.txtOrgId.Location = new System.Drawing.Point(134, 11);
            this.txtOrgId.MaxLength = 5;
            this.txtOrgId.Name = "txtOrgId";
            this.txtOrgId.Size = new System.Drawing.Size(54, 20);
            this.txtOrgId.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Organization ID:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(324, 242);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(134, 242);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtOrgEmail
            // 
            this.txtOrgEmail.Location = new System.Drawing.Point(134, 187);
            this.txtOrgEmail.MaxLength = 50;
            this.txtOrgEmail.Name = "txtOrgEmail";
            this.txtOrgEmail.Size = new System.Drawing.Size(265, 20);
            this.txtOrgEmail.TabIndex = 5;
            // 
            // txtOrgNumber
            // 
            this.txtOrgNumber.Location = new System.Drawing.Point(134, 150);
            this.txtOrgNumber.MaxLength = 12;
            this.txtOrgNumber.Name = "txtOrgNumber";
            this.txtOrgNumber.Size = new System.Drawing.Size(112, 20);
            this.txtOrgNumber.TabIndex = 4;
            // 
            // txtOrgAddress
            // 
            this.txtOrgAddress.Location = new System.Drawing.Point(134, 117);
            this.txtOrgAddress.MaxLength = 50;
            this.txtOrgAddress.Name = "txtOrgAddress";
            this.txtOrgAddress.Size = new System.Drawing.Size(265, 20);
            this.txtOrgAddress.TabIndex = 3;
            // 
            // txtAcronym
            // 
            this.txtAcronym.Location = new System.Drawing.Point(134, 82);
            this.txtAcronym.MaxLength = 5;
            this.txtAcronym.Name = "txtAcronym";
            this.txtAcronym.Size = new System.Drawing.Size(54, 20);
            this.txtAcronym.TabIndex = 2;
            // 
            // txtOrgName
            // 
            this.txtOrgName.Location = new System.Drawing.Point(134, 47);
            this.txtOrgName.MaxLength = 50;
            this.txtOrgName.Name = "txtOrgName";
            this.txtOrgName.Size = new System.Drawing.Size(265, 20);
            this.txtOrgName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Email Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Acronym:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Organization Name:";
            // 
            // AddOrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 277);
            this.Controls.Add(this.txtOrgId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtOrgEmail);
            this.Controls.Add(this.txtOrgNumber);
            this.Controls.Add(this.txtOrgAddress);
            this.Controls.Add(this.txtAcronym);
            this.Controls.Add(this.txtOrgName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddOrg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrg";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddOrg_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrgId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtOrgEmail;
        private System.Windows.Forms.TextBox txtOrgNumber;
        private System.Windows.Forms.TextBox txtOrgAddress;
        private System.Windows.Forms.TextBox txtAcronym;
        private System.Windows.Forms.TextBox txtOrgName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}