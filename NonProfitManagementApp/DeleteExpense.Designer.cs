namespace NonProfitManagementApp
{
    partial class DeleteExpense
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFetch = new System.Windows.Forms.Button();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtExpenseSubcategory = new System.Windows.Forms.TextBox();
            this.txtExpenseTitle = new System.Windows.Forms.TextBox();
            this.txtExpenseID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(285, 18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(48, 23);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(231, 18);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(48, 23);
            this.btnFetch.TabIndex = 32;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.Location = new System.Drawing.Point(145, 135);
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.ReadOnly = true;
            this.txtExpenseAmount.Size = new System.Drawing.Size(100, 20);
            this.txtExpenseAmount.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Expene Amount:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(258, 180);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(146, 179);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtExpenseSubcategory
            // 
            this.txtExpenseSubcategory.Location = new System.Drawing.Point(145, 95);
            this.txtExpenseSubcategory.MaxLength = 50;
            this.txtExpenseSubcategory.Name = "txtExpenseSubcategory";
            this.txtExpenseSubcategory.ReadOnly = true;
            this.txtExpenseSubcategory.Size = new System.Drawing.Size(188, 20);
            this.txtExpenseSubcategory.TabIndex = 35;
            // 
            // txtExpenseTitle
            // 
            this.txtExpenseTitle.Location = new System.Drawing.Point(145, 56);
            this.txtExpenseTitle.MaxLength = 50;
            this.txtExpenseTitle.Name = "txtExpenseTitle";
            this.txtExpenseTitle.ReadOnly = true;
            this.txtExpenseTitle.Size = new System.Drawing.Size(188, 20);
            this.txtExpenseTitle.TabIndex = 34;
            // 
            // txtExpenseID
            // 
            this.txtExpenseID.Location = new System.Drawing.Point(145, 18);
            this.txtExpenseID.MaxLength = 10;
            this.txtExpenseID.Name = "txtExpenseID";
            this.txtExpenseID.Size = new System.Drawing.Size(80, 20);
            this.txtExpenseID.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Expense Subcategory:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Expense Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Expense ID:";
            // 
            // DeleteExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 220);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.txtExpenseAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtExpenseSubcategory);
            this.Controls.Add(this.txtExpenseTitle);
            this.Controls.Add(this.txtExpenseID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "DeleteExpense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delete Expense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtExpenseSubcategory;
        private System.Windows.Forms.TextBox txtExpenseTitle;
        private System.Windows.Forms.TextBox txtExpenseID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}