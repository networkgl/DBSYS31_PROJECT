namespace HMS.Forms
{
    partial class Frm_BookingDetails
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
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_roomdetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnl_Main1 = new Guna.UI2.WinForms.Guna2Panel();
            this.chkBox_showCurrentlyCheck_In = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkBox_showOngoingCheck_In = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkBox_showOverAll = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roomdetails)).BeginInit();
            this.pnl_Main1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 33);
            this.label7.TabIndex = 15;
            this.label7.Text = "Booking Details";
            // 
            // dgv_roomdetails
            // 
            this.dgv_roomdetails.AllowUserToAddRows = false;
            this.dgv_roomdetails.AllowUserToDeleteRows = false;
            this.dgv_roomdetails.AllowUserToOrderColumns = true;
            this.dgv_roomdetails.AllowUserToResizeColumns = false;
            this.dgv_roomdetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_roomdetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_roomdetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_roomdetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_roomdetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_roomdetails.ColumnHeadersHeight = 25;
            this.dgv_roomdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_roomdetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_roomdetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_roomdetails.Location = new System.Drawing.Point(14, 23);
            this.dgv_roomdetails.Name = "dgv_roomdetails";
            this.dgv_roomdetails.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_roomdetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_roomdetails.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_roomdetails.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_roomdetails.RowTemplate.Height = 25;
            this.dgv_roomdetails.Size = new System.Drawing.Size(1023, 466);
            this.dgv_roomdetails.TabIndex = 159;
            this.dgv_roomdetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_roomdetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_roomdetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_roomdetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_roomdetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_roomdetails.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgv_roomdetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_roomdetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_roomdetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_roomdetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_roomdetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_roomdetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_roomdetails.ThemeStyle.HeaderStyle.Height = 25;
            this.dgv_roomdetails.ThemeStyle.ReadOnly = true;
            this.dgv_roomdetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_roomdetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_roomdetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_roomdetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_roomdetails.ThemeStyle.RowsStyle.Height = 25;
            this.dgv_roomdetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_roomdetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnl_Main1
            // 
            this.pnl_Main1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnl_Main1.BorderRadius = 10;
            this.pnl_Main1.Controls.Add(this.dgv_roomdetails);
            this.pnl_Main1.FillColor = System.Drawing.Color.White;
            this.pnl_Main1.Location = new System.Drawing.Point(12, 70);
            this.pnl_Main1.Name = "pnl_Main1";
            this.pnl_Main1.Size = new System.Drawing.Size(1054, 503);
            this.pnl_Main1.TabIndex = 160;
            // 
            // chkBox_showCurrentlyCheck_In
            // 
            this.chkBox_showCurrentlyCheck_In.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBox_showCurrentlyCheck_In.CheckedState.BorderRadius = 2;
            this.chkBox_showCurrentlyCheck_In.CheckedState.BorderThickness = 0;
            this.chkBox_showCurrentlyCheck_In.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBox_showCurrentlyCheck_In.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBox_showCurrentlyCheck_In.Location = new System.Drawing.Point(1025, 37);
            this.chkBox_showCurrentlyCheck_In.Name = "chkBox_showCurrentlyCheck_In";
            this.chkBox_showCurrentlyCheck_In.Size = new System.Drawing.Size(20, 20);
            this.chkBox_showCurrentlyCheck_In.TabIndex = 170;
            this.chkBox_showCurrentlyCheck_In.Text = "guna2CustomCheckBox3";
            this.chkBox_showCurrentlyCheck_In.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBox_showCurrentlyCheck_In.UncheckedState.BorderRadius = 2;
            this.chkBox_showCurrentlyCheck_In.UncheckedState.BorderThickness = 0;
            this.chkBox_showCurrentlyCheck_In.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBox_showCurrentlyCheck_In.CheckedChanged += new System.EventHandler(this.chkBox_showCurrentlyCheck_In_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(897, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 169;
            this.label4.Text = "Currently Check-In";
            // 
            // chkBox_showOngoingCheck_In
            // 
            this.chkBox_showOngoingCheck_In.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBox_showOngoingCheck_In.CheckedState.BorderRadius = 2;
            this.chkBox_showOngoingCheck_In.CheckedState.BorderThickness = 0;
            this.chkBox_showOngoingCheck_In.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBox_showOngoingCheck_In.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBox_showOngoingCheck_In.Location = new System.Drawing.Point(871, 37);
            this.chkBox_showOngoingCheck_In.Name = "chkBox_showOngoingCheck_In";
            this.chkBox_showOngoingCheck_In.Size = new System.Drawing.Size(20, 20);
            this.chkBox_showOngoingCheck_In.TabIndex = 172;
            this.chkBox_showOngoingCheck_In.Text = "guna2CustomCheckBox3";
            this.chkBox_showOngoingCheck_In.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBox_showOngoingCheck_In.UncheckedState.BorderRadius = 2;
            this.chkBox_showOngoingCheck_In.UncheckedState.BorderThickness = 0;
            this.chkBox_showOngoingCheck_In.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBox_showOngoingCheck_In.CheckedChanged += new System.EventHandler(this.chkBox_showOngoingCheck_In_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(743, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 171;
            this.label1.Text = "Ongoing Check-In";
            // 
            // chkBox_showOverAll
            // 
            this.chkBox_showOverAll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBox_showOverAll.CheckedState.BorderRadius = 2;
            this.chkBox_showOverAll.CheckedState.BorderThickness = 0;
            this.chkBox_showOverAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBox_showOverAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBox_showOverAll.Location = new System.Drawing.Point(717, 37);
            this.chkBox_showOverAll.Name = "chkBox_showOverAll";
            this.chkBox_showOverAll.Size = new System.Drawing.Size(20, 20);
            this.chkBox_showOverAll.TabIndex = 174;
            this.chkBox_showOverAll.Text = "guna2CustomCheckBox3";
            this.chkBox_showOverAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBox_showOverAll.UncheckedState.BorderRadius = 2;
            this.chkBox_showOverAll.UncheckedState.BorderThickness = 0;
            this.chkBox_showOverAll.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBox_showOverAll.CheckedChanged += new System.EventHandler(this.chkBox_showOverAll_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(649, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 173;
            this.label2.Text = "Show All";
            // 
            // Frm_BookingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1078, 619);
            this.Controls.Add(this.chkBox_showOverAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkBox_showOngoingCheck_In);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkBox_showCurrentlyCheck_In);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnl_Main1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_BookingDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Client";
            this.Load += new System.EventHandler(this.Frm_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roomdetails)).EndInit();
            this.pnl_Main1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        public Guna.UI2.WinForms.Guna2DataGridView dgv_roomdetails;
        private Guna.UI2.WinForms.Guna2Panel pnl_Main1;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkBox_showCurrentlyCheck_In;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkBox_showOngoingCheck_In;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkBox_showOverAll;
        private System.Windows.Forms.Label label2;
    }
}