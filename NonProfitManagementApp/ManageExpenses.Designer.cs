namespace NonProfitManagementApp
{
    partial class ManageExpenses
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnJustification = new System.Windows.Forms.Button();
            this.btnUpdateJustification = new System.Windows.Forms.Button();
            this.btnJustifications = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 37);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 55);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 37);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 37);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Location = new System.Drawing.Point(134, 12);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.Size = new System.Drawing.Size(766, 426);
            this.dgvExpenses.TabIndex = 13;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 98);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 37);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnJustification
            // 
            this.btnJustification.Location = new System.Drawing.Point(12, 250);
            this.btnJustification.Name = "btnJustification";
            this.btnJustification.Size = new System.Drawing.Size(116, 37);
            this.btnJustification.TabIndex = 16;
            this.btnJustification.Text = "Add Justification";
            this.btnJustification.UseVisualStyleBackColor = true;
            this.btnJustification.Click += new System.EventHandler(this.btnJustification_Click);
            // 
            // btnUpdateJustification
            // 
            this.btnUpdateJustification.Location = new System.Drawing.Point(12, 293);
            this.btnUpdateJustification.Name = "btnUpdateJustification";
            this.btnUpdateJustification.Size = new System.Drawing.Size(116, 37);
            this.btnUpdateJustification.TabIndex = 17;
            this.btnUpdateJustification.Text = "Update Justification";
            this.btnUpdateJustification.UseVisualStyleBackColor = true;
            this.btnUpdateJustification.Click += new System.EventHandler(this.btnUpdateJustification_Click);
            // 
            // btnJustifications
            // 
            this.btnJustifications.Location = new System.Drawing.Point(12, 159);
            this.btnJustifications.Name = "btnJustifications";
            this.btnJustifications.Size = new System.Drawing.Size(116, 37);
            this.btnJustifications.TabIndex = 18;
            this.btnJustifications.Text = "Manage Justifications";
            this.btnJustifications.UseVisualStyleBackColor = true;
            this.btnJustifications.Click += new System.EventHandler(this.btnJustifications_Click);
            // 
            // ManageExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.btnJustifications);
            this.Controls.Add(this.btnUpdateJustification);
            this.Controls.Add(this.btnJustification);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvExpenses);
            this.Name = "ManageExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageExpenses";
            this.Load += new System.EventHandler(this.ManageExpenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnJustification;
        private System.Windows.Forms.Button btnUpdateJustification;
        private System.Windows.Forms.Button btnJustifications;
    }
}