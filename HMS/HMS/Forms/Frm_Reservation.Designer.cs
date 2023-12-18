namespace HMS.Forms
{
    partial class Frm_Reservation
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
            this.dgv_roomreservation = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnl_Main1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteAllReservation = new Guna.UI2.WinForms.Guna2Button();
            this.chkBox_showpPending = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkBox_showpApprove = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.chkBox_showpAll = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkBox_showHistory = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roomreservation)).BeginInit();
            this.pnl_Main1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_roomreservation
            // 
            this.dgv_roomreservation.AllowUserToAddRows = false;
            this.dgv_roomreservation.AllowUserToDeleteRows = false;
            this.dgv_roomreservation.AllowUserToOrderColumns = true;
            this.dgv_roomreservation.AllowUserToResizeColumns = false;
            this.dgv_roomreservation.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.dgv_roomreservation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_roomreservation.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_roomreservation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_roomreservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_roomreservation.ColumnHeadersHeight = 25;
            this.dgv_roomreservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_roomreservation.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_roomreservation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_roomreservation.Location = new System.Drawing.Point(14, 23);
            this.dgv_roomreservation.Name = "dgv_roomreservation";
            this.dgv_roomreservation.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_roomreservation.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_roomreservation.RowHeadersVisible = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_roomreservation.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_roomreservation.RowTemplate.Height = 25;
            this.dgv_roomreservation.Size = new System.Drawing.Size(1023, 466);
            this.dgv_roomreservation.TabIndex = 159;
            this.dgv_roomreservation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_roomreservation.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_roomreservation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_roomreservation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_roomreservation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_roomreservation.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgv_roomreservation.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_roomreservation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_roomreservation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_roomreservation.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_roomreservation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_roomreservation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_roomreservation.ThemeStyle.HeaderStyle.Height = 25;
            this.dgv_roomreservation.ThemeStyle.ReadOnly = true;
            this.dgv_roomreservation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_roomreservation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_roomreservation.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_roomreservation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_roomreservation.ThemeStyle.RowsStyle.Height = 25;
            this.dgv_roomreservation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_roomreservation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_roomreservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_roomreservation_CellClick);
            this.dgv_roomreservation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_roomreservation_CellDoubleClick);
            this.dgv_roomreservation.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_roomreservation_CellFormatting);
            // 
            // pnl_Main1
            // 
            this.pnl_Main1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnl_Main1.BorderRadius = 10;
            this.pnl_Main1.Controls.Add(this.dgv_roomreservation);
            this.pnl_Main1.FillColor = System.Drawing.Color.White;
            this.pnl_Main1.Location = new System.Drawing.Point(12, 70);
            this.pnl_Main1.Name = "pnl_Main1";
            this.pnl_Main1.Size = new System.Drawing.Size(1054, 503);
            this.pnl_Main1.TabIndex = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 33);
            this.label1.TabIndex = 161;
            this.label1.Text = "Reservation";
            // 
            // btnDeleteAllReservation
            // 
            this.btnDeleteAllReservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteAllReservation.BorderRadius = 5;
            this.btnDeleteAllReservation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllReservation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllReservation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAllReservation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAllReservation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDeleteAllReservation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllReservation.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAllReservation.Location = new System.Drawing.Point(860, 15);
            this.btnDeleteAllReservation.Name = "btnDeleteAllReservation";
            this.btnDeleteAllReservation.Size = new System.Drawing.Size(189, 42);
            this.btnDeleteAllReservation.TabIndex = 162;
            this.btnDeleteAllReservation.Text = "DELETE ALL RESERVATION";
            this.btnDeleteAllReservation.Click += new System.EventHandler(this.btnDeleteAllReservation_Click);
            // 
            // chkBox_showpPending
            // 
            this.chkBox_showpPending.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBox_showpPending.CheckedState.BorderRadius = 2;
            this.chkBox_showpPending.CheckedState.BorderThickness = 0;
            this.chkBox_showpPending.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBox_showpPending.Location = new System.Drawing.Point(676, 37);
            this.chkBox_showpPending.Name = "chkBox_showpPending";
            this.chkBox_showpPending.Size = new System.Drawing.Size(20, 20);
            this.chkBox_showpPending.TabIndex = 163;
            this.chkBox_showpPending.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBox_showpPending.UncheckedState.BorderRadius = 2;
            this.chkBox_showpPending.UncheckedState.BorderThickness = 0;
            this.chkBox_showpPending.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBox_showpPending.CheckedChanged += new System.EventHandler(this.chkBox_showpPending_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(570, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 164;
            this.label2.Text = "Show Pending";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 165;
            this.label3.Text = "Show Approve";
            // 
            // chkBox_showpApprove
            // 
            this.chkBox_showpApprove.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBox_showpApprove.CheckedState.BorderRadius = 2;
            this.chkBox_showpApprove.CheckedState.BorderThickness = 0;
            this.chkBox_showpApprove.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBox_showpApprove.Location = new System.Drawing.Point(545, 37);
            this.chkBox_showpApprove.Name = "chkBox_showpApprove";
            this.chkBox_showpApprove.Size = new System.Drawing.Size(20, 20);
            this.chkBox_showpApprove.TabIndex = 166;
            this.chkBox_showpApprove.Text = "guna2CustomCheckBox2";
            this.chkBox_showpApprove.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBox_showpApprove.UncheckedState.BorderRadius = 2;
            this.chkBox_showpApprove.UncheckedState.BorderThickness = 0;
            this.chkBox_showpApprove.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBox_showpApprove.CheckedChanged += new System.EventHandler(this.chkBox_showpApprove_CheckedChanged);
            // 
            // chkBox_showpAll
            // 
            this.chkBox_showpAll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBox_showpAll.CheckedState.BorderRadius = 2;
            this.chkBox_showpAll.CheckedState.BorderThickness = 0;
            this.chkBox_showpAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBox_showpAll.Location = new System.Drawing.Point(412, 37);
            this.chkBox_showpAll.Name = "chkBox_showpAll";
            this.chkBox_showpAll.Size = new System.Drawing.Size(20, 20);
            this.chkBox_showpAll.TabIndex = 168;
            this.chkBox_showpAll.Text = "guna2CustomCheckBox3";
            this.chkBox_showpAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBox_showpAll.UncheckedState.BorderRadius = 2;
            this.chkBox_showpAll.UncheckedState.BorderThickness = 0;
            this.chkBox_showpAll.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBox_showpAll.CheckedChanged += new System.EventHandler(this.chkBox_showpAll_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 167;
            this.label4.Text = "Show All";
            // 
            // chkBox_showHistory
            // 
            this.chkBox_showHistory.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBox_showHistory.CheckedState.BorderRadius = 2;
            this.chkBox_showHistory.CheckedState.BorderThickness = 0;
            this.chkBox_showHistory.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBox_showHistory.Location = new System.Drawing.Point(793, 37);
            this.chkBox_showHistory.Name = "chkBox_showHistory";
            this.chkBox_showHistory.Size = new System.Drawing.Size(20, 20);
            this.chkBox_showHistory.TabIndex = 170;
            this.chkBox_showHistory.Text = "guna2CustomCheckBox3";
            this.chkBox_showHistory.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBox_showHistory.UncheckedState.BorderRadius = 2;
            this.chkBox_showHistory.UncheckedState.BorderThickness = 0;
            this.chkBox_showHistory.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBox_showHistory.CheckedChanged += new System.EventHandler(this.chkBox_showHistory_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(701, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 169;
            this.label5.Text = "View History";
            // 
            // Frm_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 619);
            this.Controls.Add(this.chkBox_showHistory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkBox_showpAll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkBox_showpApprove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkBox_showpPending);
            this.Controls.Add(this.btnDeleteAllReservation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_Main1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Reservation";
            this.Load += new System.EventHandler(this.Frm_Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roomreservation)).EndInit();
            this.pnl_Main1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2DataGridView dgv_roomreservation;
        private Guna.UI2.WinForms.Guna2Panel pnl_Main1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAllReservation;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkBox_showpPending;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkBox_showpApprove;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkBox_showpAll;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkBox_showHistory;
        private System.Windows.Forms.Label label5;
    }
}