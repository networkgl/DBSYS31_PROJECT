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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pnl_Filter = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roomreservation)).BeginInit();
            this.pnl_Main1.SuspendLayout();
            this.pnl_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_roomreservation
            // 
            this.dgv_roomreservation.AllowUserToAddRows = false;
            this.dgv_roomreservation.AllowUserToDeleteRows = false;
            this.dgv_roomreservation.AllowUserToOrderColumns = true;
            this.dgv_roomreservation.AllowUserToResizeColumns = false;
            this.dgv_roomreservation.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_roomreservation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_roomreservation.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_roomreservation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_roomreservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_roomreservation.ColumnHeadersHeight = 25;
            this.dgv_roomreservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_roomreservation.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_roomreservation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_roomreservation.Location = new System.Drawing.Point(14, 23);
            this.dgv_roomreservation.Name = "dgv_roomreservation";
            this.dgv_roomreservation.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_roomreservation.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_roomreservation.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_roomreservation.RowsDefaultCellStyle = dataGridViewCellStyle5;
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
            this.btnDeleteAllReservation.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.chkBox_showpPending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBox_showpPending.Location = new System.Drawing.Point(283, 0);
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
            this.label2.Location = new System.Drawing.Point(177, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 164;
            this.label2.Text = "Show Pending";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 27);
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
            this.chkBox_showpApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBox_showpApprove.Location = new System.Drawing.Point(113, 24);
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
            this.chkBox_showpAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBox_showpAll.Location = new System.Drawing.Point(113, 0);
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
            this.label4.Location = new System.Drawing.Point(45, 3);
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
            this.chkBox_showHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBox_showHistory.Location = new System.Drawing.Point(283, 24);
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
            this.label5.Location = new System.Drawing.Point(191, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 169;
            this.label5.Text = "Show History";
            // 
            // pnl_Filter
            // 
            this.pnl_Filter.Controls.Add(this.chkBox_showHistory);
            this.pnl_Filter.Controls.Add(this.label5);
            this.pnl_Filter.Controls.Add(this.chkBox_showpPending);
            this.pnl_Filter.Controls.Add(this.chkBox_showpAll);
            this.pnl_Filter.Controls.Add(this.label2);
            this.pnl_Filter.Controls.Add(this.label4);
            this.pnl_Filter.Controls.Add(this.label3);
            this.pnl_Filter.Controls.Add(this.chkBox_showpApprove);
            this.pnl_Filter.Location = new System.Drawing.Point(536, 12);
            this.pnl_Filter.Name = "pnl_Filter";
            this.pnl_Filter.Size = new System.Drawing.Size(318, 52);
            this.pnl_Filter.TabIndex = 160;
            // 
            // Frm_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 619);
            this.Controls.Add(this.pnl_Filter);
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
            this.pnl_Filter.ResumeLayout(false);
            this.pnl_Filter.PerformLayout();
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
        private System.Windows.Forms.Panel pnl_Filter;
    }
}