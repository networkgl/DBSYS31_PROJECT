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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_roomreservation = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnl_Main1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteAllReservation = new Guna.UI2.WinForms.Guna2Button();
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
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgv_roomreservation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_roomreservation.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_roomreservation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_roomreservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_roomreservation.ColumnHeadersHeight = 25;
            this.dgv_roomreservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_roomreservation.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_roomreservation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_roomreservation.Location = new System.Drawing.Point(14, 23);
            this.dgv_roomreservation.Name = "dgv_roomreservation";
            this.dgv_roomreservation.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_roomreservation.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_roomreservation.RowHeadersVisible = false;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_roomreservation.RowsDefaultCellStyle = dataGridViewCellStyle20;
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
            this.label1.Size = new System.Drawing.Size(286, 33);
            this.label1.TabIndex = 161;
            this.label1.Text = "Pending Reservation";
            // 
            // btnDeleteAllReservation
            // 
            this.btnDeleteAllReservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteAllReservation.BorderRadius = 10;
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
            // Frm_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 619);
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
    }
}