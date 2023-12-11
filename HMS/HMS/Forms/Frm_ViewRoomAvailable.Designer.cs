namespace HMS.Forms
{
    partial class Frm_ViewRoomAvailable
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
            this.btnAddRooms = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRoomDisplay = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_Main1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_roomdetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnUpdateDeleteRooms = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_Main1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roomdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddRooms
            // 
            this.btnAddRooms.BorderRadius = 10;
            this.btnAddRooms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRooms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRooms.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.btnAddRooms.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRooms.ForeColor = System.Drawing.Color.White;
            this.btnAddRooms.Location = new System.Drawing.Point(684, 15);
            this.btnAddRooms.Name = "btnAddRooms";
            this.btnAddRooms.Size = new System.Drawing.Size(175, 42);
            this.btnAddRooms.TabIndex = 156;
            this.btnAddRooms.Text = "Add Rooms";
            this.btnAddRooms.Click += new System.EventHandler(this.btnAddRooms_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 33);
            this.label7.TabIndex = 154;
            this.label7.Text = "Manage Room";
            // 
            // btnRoomDisplay
            // 
            this.btnRoomDisplay.BorderRadius = 10;
            this.btnRoomDisplay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomDisplay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomDisplay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoomDisplay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoomDisplay.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomDisplay.ForeColor = System.Drawing.Color.White;
            this.btnRoomDisplay.Location = new System.Drawing.Point(874, 15);
            this.btnRoomDisplay.Name = "btnRoomDisplay";
            this.btnRoomDisplay.Size = new System.Drawing.Size(175, 42);
            this.btnRoomDisplay.TabIndex = 155;
            this.btnRoomDisplay.Text = "View Room Displayed";
            this.btnRoomDisplay.Click += new System.EventHandler(this.btnRoomDisplay_Click);
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
            this.pnl_Main1.TabIndex = 159;
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
            this.dgv_roomdetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_roomdetails_CellClick);
            this.dgv_roomdetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_roomdetails_CellContentClick);
            this.dgv_roomdetails.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_roomdetails_CellFormatting);
            // 
            // btnUpdateDeleteRooms
            // 
            this.btnUpdateDeleteRooms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateDeleteRooms.BorderRadius = 10;
            this.btnUpdateDeleteRooms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDeleteRooms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDeleteRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateDeleteRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateDeleteRooms.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnUpdateDeleteRooms.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDeleteRooms.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDeleteRooms.Location = new System.Drawing.Point(493, 15);
            this.btnUpdateDeleteRooms.Name = "btnUpdateDeleteRooms";
            this.btnUpdateDeleteRooms.Size = new System.Drawing.Size(175, 42);
            this.btnUpdateDeleteRooms.TabIndex = 157;
            this.btnUpdateDeleteRooms.Text = "View Room Availables";
            // 
            // Frm_ViewRoomAvailable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 619);
            this.Controls.Add(this.pnl_Main1);
            this.Controls.Add(this.btnUpdateDeleteRooms);
            this.Controls.Add(this.btnAddRooms);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRoomDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ViewRoomAvailable";
            this.Text = "Frm_UDRoom";
            this.Load += new System.EventHandler(this.Frm_UDRoom_Load);
            this.pnl_Main1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roomdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnUpdateDeleteRooms;
        private Guna.UI2.WinForms.Guna2Button btnAddRooms;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnRoomDisplay;
        private Guna.UI2.WinForms.Guna2Panel pnl_Main1;
        public Guna.UI2.WinForms.Guna2DataGridView dgv_roomdetails;
    }
}