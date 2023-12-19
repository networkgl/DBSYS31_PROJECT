namespace HMS.Forms
{
    partial class Frm_SystemLogs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.btnsSystemAccounts = new Guna.UI2.WinForms.Guna2Button();
            this.btnsSystemLogs = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_systemlogs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnl_Main1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClearLogs = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_systemlogs)).BeginInit();
            this.pnl_Main1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 33);
            this.label7.TabIndex = 164;
            this.label7.Text = "Manage System";
            // 
            // btnsSystemAccounts
            // 
            this.btnsSystemAccounts.BorderRadius = 5;
            this.btnsSystemAccounts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsSystemAccounts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsSystemAccounts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsSystemAccounts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsSystemAccounts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.btnsSystemAccounts.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsSystemAccounts.ForeColor = System.Drawing.Color.White;
            this.btnsSystemAccounts.Location = new System.Drawing.Point(684, 15);
            this.btnsSystemAccounts.Name = "btnsSystemAccounts";
            this.btnsSystemAccounts.Size = new System.Drawing.Size(175, 42);
            this.btnsSystemAccounts.TabIndex = 167;
            this.btnsSystemAccounts.Text = "System Accounts";
            this.btnsSystemAccounts.Click += new System.EventHandler(this.btnsSystemAccounts_Click);
            // 
            // btnsSystemLogs
            // 
            this.btnsSystemLogs.BorderRadius = 5;
            this.btnsSystemLogs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsSystemLogs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsSystemLogs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsSystemLogs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsSystemLogs.Enabled = false;
            this.btnsSystemLogs.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsSystemLogs.ForeColor = System.Drawing.Color.White;
            this.btnsSystemLogs.Location = new System.Drawing.Point(874, 15);
            this.btnsSystemLogs.Name = "btnsSystemLogs";
            this.btnsSystemLogs.Size = new System.Drawing.Size(175, 42);
            this.btnsSystemLogs.TabIndex = 166;
            this.btnsSystemLogs.Text = "System Logs";
            // 
            // dgv_systemlogs
            // 
            this.dgv_systemlogs.AllowUserToAddRows = false;
            this.dgv_systemlogs.AllowUserToDeleteRows = false;
            this.dgv_systemlogs.AllowUserToOrderColumns = true;
            this.dgv_systemlogs.AllowUserToResizeColumns = false;
            this.dgv_systemlogs.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.dgv_systemlogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_systemlogs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_systemlogs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_systemlogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_systemlogs.ColumnHeadersHeight = 25;
            this.dgv_systemlogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_systemlogs.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_systemlogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_systemlogs.Location = new System.Drawing.Point(14, 23);
            this.dgv_systemlogs.Name = "dgv_systemlogs";
            this.dgv_systemlogs.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_systemlogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_systemlogs.RowHeadersVisible = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_systemlogs.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_systemlogs.RowTemplate.Height = 25;
            this.dgv_systemlogs.Size = new System.Drawing.Size(1023, 409);
            this.dgv_systemlogs.TabIndex = 159;
            this.dgv_systemlogs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_systemlogs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_systemlogs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_systemlogs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_systemlogs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_systemlogs.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgv_systemlogs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_systemlogs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_systemlogs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_systemlogs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_systemlogs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_systemlogs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_systemlogs.ThemeStyle.HeaderStyle.Height = 25;
            this.dgv_systemlogs.ThemeStyle.ReadOnly = true;
            this.dgv_systemlogs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_systemlogs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_systemlogs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_systemlogs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_systemlogs.ThemeStyle.RowsStyle.Height = 25;
            this.dgv_systemlogs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_systemlogs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_systemlogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_systemlogs_CellContentClick);
            // 
            // pnl_Main1
            // 
            this.pnl_Main1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnl_Main1.BorderRadius = 10;
            this.pnl_Main1.Controls.Add(this.btnClearLogs);
            this.pnl_Main1.Controls.Add(this.dgv_systemlogs);
            this.pnl_Main1.FillColor = System.Drawing.Color.White;
            this.pnl_Main1.Location = new System.Drawing.Point(12, 70);
            this.pnl_Main1.Name = "pnl_Main1";
            this.pnl_Main1.Size = new System.Drawing.Size(1054, 503);
            this.pnl_Main1.TabIndex = 168;
            // 
            // btnClearLogs
            // 
            this.btnClearLogs.BorderRadius = 5;
            this.btnClearLogs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearLogs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearLogs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearLogs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearLogs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClearLogs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLogs.ForeColor = System.Drawing.Color.White;
            this.btnClearLogs.Location = new System.Drawing.Point(862, 447);
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new System.Drawing.Size(175, 42);
            this.btnClearLogs.TabIndex = 167;
            this.btnClearLogs.Text = "CLEAR LOGS";
            this.btnClearLogs.Click += new System.EventHandler(this.btnClearLogs_Click);
            // 
            // Frm_SystemLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 619);
            this.Controls.Add(this.pnl_Main1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnsSystemAccounts);
            this.Controls.Add(this.btnsSystemLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_SystemLogs";
            this.Text = "Frm_SystemLogs";
            this.Load += new System.EventHandler(this.Frm_SystemLogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_systemlogs)).EndInit();
            this.pnl_Main1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnsSystemAccounts;
        private Guna.UI2.WinForms.Guna2Button btnsSystemLogs;
        public Guna.UI2.WinForms.Guna2DataGridView dgv_systemlogs;
        private Guna.UI2.WinForms.Guna2Panel pnl_Main1;
        private Guna.UI2.WinForms.Guna2Button btnClearLogs;
    }
}