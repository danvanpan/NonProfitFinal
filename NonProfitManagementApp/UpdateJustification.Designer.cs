namespace NonProfitManagementApp
{
    partial class UpdateJustification
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.txtExpenseID = new System.Windows.Forms.TextBox();
            this.txtJustTitle = new System.Windows.Forms.TextBox();
            this.txtJustID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFetch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(232, 222);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(134, 222);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(136, 105);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.ReadOnly = true;
            this.rtxtDescription.Size = new System.Drawing.Size(171, 74);
            this.rtxtDescription.TabIndex = 10;
            this.rtxtDescription.Text = "";
            // 
            // txtExpenseID
            // 
            this.txtExpenseID.Location = new System.Drawing.Point(136, 185);
            this.txtExpenseID.Name = "txtExpenseID";
            this.txtExpenseID.ReadOnly = true;
            this.txtExpenseID.Size = new System.Drawing.Size(42, 20);
            this.txtExpenseID.TabIndex = 12;
            // 
            // txtJustTitle
            // 
            this.txtJustTitle.Location = new System.Drawing.Point(136, 61);
            this.txtJustTitle.Name = "txtJustTitle";
            this.txtJustTitle.ReadOnly = true;
            this.txtJustTitle.Size = new System.Drawing.Size(171, 20);
            this.txtJustTitle.TabIndex = 8;
            // 
            // txtJustID
            // 
            this.txtJustID.Location = new System.Drawing.Point(136, 18);
            this.txtJustID.Name = "txtJustID";
            this.txtJustID.Size = new System.Drawing.Size(42, 20);
            this.txtJustID.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Expense ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Justification Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Justification Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Justification ID:";
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(184, 16);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(75, 23);
            this.btnFetch.TabIndex = 16;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // UpdateJustification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 263);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.txtExpenseID);
            this.Controls.Add(this.txtJustTitle);
            this.Controls.Add(this.txtJustID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateJustification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateJustification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.TextBox txtExpenseID;
        private System.Windows.Forms.TextBox txtJustTitle;
        private System.Windows.Forms.TextBox txtJustID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFetch;
    }
}