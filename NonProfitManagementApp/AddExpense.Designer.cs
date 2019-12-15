namespace NonProfitManagementApp
{
    partial class AddExpense
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbServiceList = new System.Windows.Forms.ComboBox();
            this.cbbOrganizationList = new System.Windows.Forms.ComboBox();
            this.txtExpenseID = new System.Windows.Forms.TextBox();
            this.txtExpenseTitle = new System.Windows.Forms.TextBox();
            this.txtExpenseSubcategory = new System.Windows.Forms.TextBox();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Service:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Organization:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Expense ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Expense Title:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Expense Subcategory:";
            // 
            // cbbServiceList
            // 
            this.cbbServiceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbServiceList.FormattingEnabled = true;
            this.cbbServiceList.Location = new System.Drawing.Point(138, 35);
            this.cbbServiceList.Name = "cbbServiceList";
            this.cbbServiceList.Size = new System.Drawing.Size(268, 21);
            this.cbbServiceList.TabIndex = 1;
            // 
            // cbbOrganizationList
            // 
            this.cbbOrganizationList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbOrganizationList.FormattingEnabled = true;
            this.cbbOrganizationList.Location = new System.Drawing.Point(138, 6);
            this.cbbOrganizationList.Name = "cbbOrganizationList";
            this.cbbOrganizationList.Size = new System.Drawing.Size(268, 21);
            this.cbbOrganizationList.TabIndex = 0;
            // 
            // txtExpenseID
            // 
            this.txtExpenseID.Location = new System.Drawing.Point(138, 84);
            this.txtExpenseID.MaxLength = 10;
            this.txtExpenseID.Name = "txtExpenseID";
            this.txtExpenseID.Size = new System.Drawing.Size(80, 20);
            this.txtExpenseID.TabIndex = 2;
            // 
            // txtExpenseTitle
            // 
            this.txtExpenseTitle.Location = new System.Drawing.Point(138, 122);
            this.txtExpenseTitle.MaxLength = 50;
            this.txtExpenseTitle.Name = "txtExpenseTitle";
            this.txtExpenseTitle.Size = new System.Drawing.Size(188, 20);
            this.txtExpenseTitle.TabIndex = 3;
            // 
            // txtExpenseSubcategory
            // 
            this.txtExpenseSubcategory.Location = new System.Drawing.Point(138, 161);
            this.txtExpenseSubcategory.MaxLength = 50;
            this.txtExpenseSubcategory.Name = "txtExpenseSubcategory";
            this.txtExpenseSubcategory.Size = new System.Drawing.Size(188, 20);
            this.txtExpenseSubcategory.TabIndex = 4;
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(139, 289);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(75, 23);
            this.btnAddExpense.TabIndex = 6;
            this.btnAddExpense.Text = "Add";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(332, 289);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Expense Amount:";
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.Location = new System.Drawing.Point(138, 201);
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(100, 20);
            this.txtExpenseAmount.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(220, 289);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Percentage Limit:";
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(138, 239);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(38, 20);
            this.txtPercentage.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(183, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "%";
            // 
            // AddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 324);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtExpenseAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.txtExpenseSubcategory);
            this.Controls.Add(this.txtExpenseTitle);
            this.Controls.Add(this.txtExpenseID);
            this.Controls.Add(this.cbbOrganizationList);
            this.Controls.Add(this.cbbServiceList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddExpense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Expense";
            this.Load += new System.EventHandler(this.AddExpense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbServiceList;
        private System.Windows.Forms.ComboBox cbbOrganizationList;
        private System.Windows.Forms.TextBox txtExpenseID;
        private System.Windows.Forms.TextBox txtExpenseTitle;
        private System.Windows.Forms.TextBox txtExpenseSubcategory;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.Label label8;
    }
}