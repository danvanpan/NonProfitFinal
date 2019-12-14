namespace NonProfitManagementApp
{
    partial class AddService
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
            this.rtxtServiceDescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.txtServiceTitle = new System.Windows.Forms.TextBox();
            this.gpbServiceCat = new System.Windows.Forms.GroupBox();
            this.radSupport = new System.Windows.Forms.RadioButton();
            this.radMedular = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServId = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.gpbServiceCat.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtServiceDescription
            // 
            this.rtxtServiceDescription.Location = new System.Drawing.Point(163, 113);
            this.rtxtServiceDescription.Name = "rtxtServiceDescription";
            this.rtxtServiceDescription.Size = new System.Drawing.Size(252, 62);
            this.rtxtServiceDescription.TabIndex = 2;
            this.rtxtServiceDescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Service Description:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(339, 181);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(163, 181);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(75, 23);
            this.btnAddService.TabIndex = 3;
            this.btnAddService.Text = "Add";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // txtServiceTitle
            // 
            this.txtServiceTitle.Location = new System.Drawing.Point(164, 80);
            this.txtServiceTitle.Name = "txtServiceTitle";
            this.txtServiceTitle.Size = new System.Drawing.Size(251, 20);
            this.txtServiceTitle.TabIndex = 1;
            // 
            // gpbServiceCat
            // 
            this.gpbServiceCat.Controls.Add(this.radSupport);
            this.gpbServiceCat.Controls.Add(this.radMedular);
            this.gpbServiceCat.Location = new System.Drawing.Point(163, 13);
            this.gpbServiceCat.Name = "gpbServiceCat";
            this.gpbServiceCat.Size = new System.Drawing.Size(251, 34);
            this.gpbServiceCat.TabIndex = 26;
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Service Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Select Service Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Service ID:";
            // 
            // txtServId
            // 
            this.txtServId.Location = new System.Drawing.Point(163, 53);
            this.txtServId.Name = "txtServId";
            this.txtServId.Size = new System.Drawing.Size(48, 20);
            this.txtServId.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(251, 181);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 213);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtServId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtxtServiceDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.txtServiceTitle);
            this.Controls.Add(this.gpbServiceCat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddService";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddService_FormClosing);
            this.Load += new System.EventHandler(this.AddService_Load);
            this.gpbServiceCat.ResumeLayout(false);
            this.gpbServiceCat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtServiceDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.TextBox txtServiceTitle;
        private System.Windows.Forms.GroupBox gpbServiceCat;
        private System.Windows.Forms.RadioButton radSupport;
        private System.Windows.Forms.RadioButton radMedular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtServId;
        private System.Windows.Forms.Button btnClear;
    }
}