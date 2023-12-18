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
            this.dgv_bookingdetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnl_Main1 = new Guna.UI2.WinForms.Guna2Panel();
            this.chkBox_showCurrentlyCheck_In = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookingdetails)).BeginInit();
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
            // dgv_bookingdetails
            // 
            this.dgv_bookingdetails.AllowUserToAddRows = false;
            this.dgv_bookingdetails.AllowUserToDeleteRows = false;
            this.dgv_bookingdetails.AllowUserToOrderColumns = true;
            this.dgv_bookingdetails.AllowUserToResizeColumns = false;
            this.dgv_bookingdetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_bookingdetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_bookingdetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_bookingdetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_bookingdetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_bookingdetails.ColumnHeadersHeight = 25;
            this.dgv_bookingdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_bookingdetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_bookingdetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_bookingdetails.Location = new System.Drawing.Point(14, 23);
            this.dgv_bookingdetails.Name = "dgv_bookingdetails";
            this.dgv_bookingdetails.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_bookingdetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_bookingdetails.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_bookingdetails.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_bookingdetails.RowTemplate.Height = 25;
            this.dgv_bookingdetails.Size = new System.Drawing.Size(1023, 466);
            this.dgv_bookingdetails.TabIndex = 159;
            this.dgv_bookingdetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_bookingdetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_bookingdetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_bookingdetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_bookingdetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_bookingdetails.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgv_bookingdetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_bookingdetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_bookingdetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_bookingdetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_bookingdetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_bookingdetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_bookingdetails.ThemeStyle.HeaderStyle.Height = 25;
            this.dgv_bookingdetails.ThemeStyle.ReadOnly = true;
            this.dgv_bookingdetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_bookingdetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_bookingdetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_bookingdetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_bookingdetails.ThemeStyle.RowsStyle.Height = 25;
            this.dgv_bookingdetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_bookingdetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnl_Main1
            // 
            this.pnl_Main1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnl_Main1.BorderRadius = 10;
            this.pnl_Main1.Controls.Add(this.dgv_bookingdetails);
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
            this.chkBox_showCurrentlyCheck_In.Location = new System.Drawing.Point(1029, 28);
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
            this.label4.Location = new System.Drawing.Point(901, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 169;
            this.label4.Text = "Currently Check-In";
            // 
            // Frm_BookingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1078, 619);
            this.Controls.Add(this.chkBox_showCurrentlyCheck_In);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnl_Main1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_BookingDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Client";
            this.Load += new System.EventHandler(this.Frm_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookingdetails)).EndInit();
            this.pnl_Main1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        public Guna.UI2.WinForms.Guna2DataGridView dgv_bookingdetails;
        private Guna.UI2.WinForms.Guna2Panel pnl_Main1;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkBox_showCurrentlyCheck_In;
        private System.Windows.Forms.Label label4;
    }
}