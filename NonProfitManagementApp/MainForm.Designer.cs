namespace NonProfitManagementApp
{
    partial class MainForm
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
            this.btnCharts = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnOrgs = new System.Windows.Forms.Button();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(29, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 62);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCharts
            // 
            this.btnCharts.Location = new System.Drawing.Point(12, 242);
            this.btnCharts.Name = "btnCharts";
            this.btnCharts.Size = new System.Drawing.Size(207, 71);
            this.btnCharts.TabIndex = 13;
            this.btnCharts.Text = "Create Charts";
            this.btnCharts.UseVisualStyleBackColor = true;
            this.btnCharts.Click += new System.EventHandler(this.btnCharts_Click);
            // 
            // btnServices
            // 
            this.btnServices.Location = new System.Drawing.Point(12, 88);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(207, 71);
            this.btnServices.TabIndex = 11;
            this.btnServices.Text = "Manage Services";
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnOrgs
            // 
            this.btnOrgs.Location = new System.Drawing.Point(12, 11);
            this.btnOrgs.Name = "btnOrgs";
            this.btnOrgs.Size = new System.Drawing.Size(207, 71);
            this.btnOrgs.TabIndex = 10;
            this.btnOrgs.Text = "Manage Organizations";
            this.btnOrgs.UseVisualStyleBackColor = true;
            this.btnOrgs.Click += new System.EventHandler(this.btnOrgs_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.Location = new System.Drawing.Point(12, 165);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(207, 71);
            this.btnExpenses.TabIndex = 15;
            this.btnExpenses.Text = "Manage Expenses";
            this.btnExpenses.UseVisualStyleBackColor = true;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 429);
            this.Controls.Add(this.btnExpenses);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCharts);
            this.Controls.Add(this.btnServices);
            this.Controls.Add(this.btnOrgs);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCharts;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnOrgs;
        private System.Windows.Forms.Button btnExpenses;
    }
}