namespace NonProfitManagementApp
{
    partial class Manage_Justifications
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
            this.btnUpdateJustification = new System.Windows.Forms.Button();
            this.btnJustification = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateJustification
            // 
            this.btnUpdateJustification.Location = new System.Drawing.Point(12, 55);
            this.btnUpdateJustification.Name = "btnUpdateJustification";
            this.btnUpdateJustification.Size = new System.Drawing.Size(116, 37);
            this.btnUpdateJustification.TabIndex = 22;
            this.btnUpdateJustification.Text = "Update Justification";
            this.btnUpdateJustification.UseVisualStyleBackColor = true;
            this.btnUpdateJustification.Click += new System.EventHandler(this.btnUpdateJustification_Click);
            // 
            // btnJustification
            // 
            this.btnJustification.Location = new System.Drawing.Point(12, 12);
            this.btnJustification.Name = "btnJustification";
            this.btnJustification.Size = new System.Drawing.Size(116, 37);
            this.btnJustification.TabIndex = 21;
            this.btnJustification.Text = "Add Justification";
            this.btnJustification.UseVisualStyleBackColor = true;
            this.btnJustification.Click += new System.EventHandler(this.btnJustification_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 98);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 37);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 395);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 37);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Location = new System.Drawing.Point(134, 6);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.Size = new System.Drawing.Size(766, 426);
            this.dgvExpenses.TabIndex = 18;
            // 
            // Manage_Justifications
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.btnUpdateJustification);
            this.Controls.Add(this.btnJustification);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvExpenses);
            this.Name = "Manage_Justifications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Justifications";
            this.Load += new System.EventHandler(this.Manage_Justifications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateJustification;
        private System.Windows.Forms.Button btnJustification;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvExpenses;
    }
}