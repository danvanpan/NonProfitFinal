namespace NonProfitManagementApp
{
    partial class UpdateServices
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
            this.txtServId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxtServiceDescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtServiceTitle = new System.Windows.Forms.TextBox();
            this.gpbServiceCat = new System.Windows.Forms.GroupBox();
            this.radSupport = new System.Windows.Forms.RadioButton();
            this.radMedular = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFetch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gpbServiceCat.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtServId
            // 
            this.txtServId.Location = new System.Drawing.Point(163, 15);
            this.txtServId.Name = "txtServId";
            this.txtServId.Size = new System.Drawing.Size(48, 20);
            this.txtServId.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Service ID:";
            // 
            // rtxtServiceDescription
            // 
            this.rtxtServiceDescription.Location = new System.Drawing.Point(163, 114);
            this.rtxtServiceDescription.Name = "rtxtServiceDescription";
            this.rtxtServiceDescription.ReadOnly = true;
            this.rtxtServiceDescription.Size = new System.Drawing.Size(252, 62);
            this.rtxtServiceDescription.TabIndex = 4;
            this.rtxtServiceDescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Service Description:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(338, 220);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(162, 220);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtServiceTitle
            // 
            this.txtServiceTitle.Location = new System.Drawing.Point(164, 80);
            this.txtServiceTitle.Name = "txtServiceTitle";
            this.txtServiceTitle.ReadOnly = true;
            this.txtServiceTitle.Size = new System.Drawing.Size(251, 20);
            this.txtServiceTitle.TabIndex = 3;
            // 
            // gpbServiceCat
            // 
            this.gpbServiceCat.Controls.Add(this.radSupport);
            this.gpbServiceCat.Controls.Add(this.radMedular);
            this.gpbServiceCat.Location = new System.Drawing.Point(164, 38);
            this.gpbServiceCat.Name = "gpbServiceCat";
            this.gpbServiceCat.Size = new System.Drawing.Size(251, 34);
            this.gpbServiceCat.TabIndex = 39;
            this.gpbServiceCat.TabStop = false;
            // 
            // radSupport
            // 
            this.radSupport.AutoSize = true;
            this.radSupport.Location = new System.Drawing.Point(142, 9);
            this.radSupport.Name = "radSupport";
            this.radSupport.Size = new System.Drawing.Size(101, 17);
            this.radSupport.TabIndex = 1;
            this.radSupport.Text = "Support Service";
            this.radSupport.UseVisualStyleBackColor = true;
            this.radSupport.Visible = false;
            // 
            // radMedular
            // 
            this.radMedular.AutoSize = true;
            this.radMedular.Checked = true;
            this.radMedular.Location = new System.Drawing.Point(6, 9);
            this.radMedular.Name = "radMedular";
            this.radMedular.Size = new System.Drawing.Size(102, 17);
            this.radMedular.TabIndex = 0;
            this.radMedular.TabStop = true;
            this.radMedular.Text = "Medular Service";
            this.radMedular.UseVisualStyleBackColor = true;
            this.radMedular.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Service Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Select Service Category";
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(235, 13);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(75, 23);
            this.btnFetch.TabIndex = 1;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(332, 13);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Service Percentage:";
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(162, 190);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.ReadOnly = true;
            this.txtPercent.Size = new System.Drawing.Size(49, 20);
            this.txtPercent.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "%";
            // 
            // UpdateServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 255);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.txtServId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtxtServiceDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtServiceTitle);
            this.Controls.Add(this.gpbServiceCat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateServices";
            this.gpbServiceCat.ResumeLayout(false);
            this.gpbServiceCat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxtServiceDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtServiceTitle;
        private System.Windows.Forms.GroupBox gpbServiceCat;
        private System.Windows.Forms.RadioButton radSupport;
        private System.Windows.Forms.RadioButton radMedular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.Label label6;
    }
}