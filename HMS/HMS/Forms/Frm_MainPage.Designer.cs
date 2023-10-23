namespace HMS.Forms
{
    partial class Frm_MainPage
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
            this.components = new System.ComponentModel.Container();
            this.CurrentDate = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnl_SideBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.pnl_SystemTime = new System.Windows.Forms.Panel();
            this.lblSystemTime = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_NotifCounter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Notifications = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAnalyticsReports = new System.Windows.Forms.Button();
            this.btnMaintenanceRequest = new System.Windows.Forms.Button();
            this.btnManagement = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btn_SideBar = new System.Windows.Forms.Button();
            this.pnl_SideBar.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            this.pnl_SystemTime.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentDate
            // 
            this.CurrentDate.Tick += new System.EventHandler(this.CurrentDate_Tick);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 660);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 31);
            this.panel4.TabIndex = 3;
            // 
            // pnl_SideBar
            // 
            this.pnl_SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(157)))));
            this.pnl_SideBar.Controls.Add(this.btnLogout);
            this.pnl_SideBar.Controls.Add(this.panel4);
            this.pnl_SideBar.Controls.Add(this.btnAnalyticsReports);
            this.pnl_SideBar.Controls.Add(this.btnMaintenanceRequest);
            this.pnl_SideBar.Controls.Add(this.btnManagement);
            this.pnl_SideBar.Controls.Add(this.btnDashboard);
            this.pnl_SideBar.Controls.Add(this.panel3);
            this.pnl_SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_SideBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_SideBar.Name = "pnl_SideBar";
            this.pnl_SideBar.Size = new System.Drawing.Size(250, 691);
            this.pnl_SideBar.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 33);
            this.panel1.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(240, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 33);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.pnl_Header);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(250, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1090, 691);
            this.mainPanel.TabIndex = 1;
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.White;
            this.pnl_Header.Controls.Add(this.lbl_NotifCounter);
            this.pnl_Header.Controls.Add(this.pnl_SystemTime);
            this.pnl_Header.Controls.Add(this.btn_Notifications);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1090, 58);
            this.pnl_Header.TabIndex = 0;
            // 
            // pnl_SystemTime
            // 
            this.pnl_SystemTime.Controls.Add(this.btnExit);
            this.pnl_SystemTime.Controls.Add(this.lblSystemTime);
            this.pnl_SystemTime.Controls.Add(this.pictureBox1);
            this.pnl_SystemTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_SystemTime.Location = new System.Drawing.Point(814, 0);
            this.pnl_SystemTime.Name = "pnl_SystemTime";
            this.pnl_SystemTime.Size = new System.Drawing.Size(276, 58);
            this.pnl_SystemTime.TabIndex = 2;
            // 
            // lblSystemTime
            // 
            this.lblSystemTime.AutoSize = true;
            this.lblSystemTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemTime.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSystemTime.Location = new System.Drawing.Point(33, 4);
            this.lblSystemTime.Name = "lblSystemTime";
            this.lblSystemTime.Size = new System.Drawing.Size(98, 21);
            this.lblSystemTime.TabIndex = 0;
            this.lblSystemTime.Text = "Sytem Time";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(157)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.btn_SideBar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 190);
            this.panel3.TabIndex = 3;
            // 
            // lbl_NotifCounter
            // 
            this.lbl_NotifCounter.AutoSize = true;
            this.lbl_NotifCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.lbl_NotifCounter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NotifCounter.ForeColor = System.Drawing.Color.White;
            this.lbl_NotifCounter.Location = new System.Drawing.Point(759, 8);
            this.lbl_NotifCounter.Name = "lbl_NotifCounter";
            this.lbl_NotifCounter.Size = new System.Drawing.Size(14, 16);
            this.lbl_NotifCounter.TabIndex = 1;
            this.lbl_NotifCounter.Text = "0";
            this.lbl_NotifCounter.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::HMS.Properties.Resources.icons8_calendar_26;
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 27);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Notifications
            // 
            this.btn_Notifications.BackColor = System.Drawing.Color.White;
            this.btn_Notifications.BackgroundImage = global::HMS.Properties.Resources.notif;
            this.btn_Notifications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Notifications.FlatAppearance.BorderSize = 0;
            this.btn_Notifications.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Notifications.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Notifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Notifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Notifications.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Notifications.Location = new System.Drawing.Point(719, 2);
            this.btn_Notifications.Name = "btn_Notifications";
            this.btn_Notifications.Size = new System.Drawing.Size(72, 50);
            this.btn_Notifications.TabIndex = 1;
            this.btn_Notifications.UseVisualStyleBackColor = false;
            this.btn_Notifications.Click += new System.EventHandler(this.btn_Notifications_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Image = global::HMS.Properties.Resources.icons8_logout_26;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 620);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(250, 40);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "          Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAnalyticsReports
            // 
            this.btnAnalyticsReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAnalyticsReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnalyticsReports.FlatAppearance.BorderSize = 0;
            this.btnAnalyticsReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAnalyticsReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalyticsReports.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyticsReports.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnalyticsReports.Image = global::HMS.Properties.Resources.icons8_reservation_26;
            this.btnAnalyticsReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalyticsReports.Location = new System.Drawing.Point(0, 310);
            this.btnAnalyticsReports.Name = "btnAnalyticsReports";
            this.btnAnalyticsReports.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAnalyticsReports.Size = new System.Drawing.Size(250, 40);
            this.btnAnalyticsReports.TabIndex = 11;
            this.btnAnalyticsReports.Text = "          Reservation";
            this.btnAnalyticsReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalyticsReports.UseVisualStyleBackColor = true;
            // 
            // btnMaintenanceRequest
            // 
            this.btnMaintenanceRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMaintenanceRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaintenanceRequest.FlatAppearance.BorderSize = 0;
            this.btnMaintenanceRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnMaintenanceRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenanceRequest.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenanceRequest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMaintenanceRequest.Image = global::HMS.Properties.Resources.icons8_room_26;
            this.btnMaintenanceRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaintenanceRequest.Location = new System.Drawing.Point(0, 270);
            this.btnMaintenanceRequest.Name = "btnMaintenanceRequest";
            this.btnMaintenanceRequest.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMaintenanceRequest.Size = new System.Drawing.Size(250, 40);
            this.btnMaintenanceRequest.TabIndex = 4;
            this.btnMaintenanceRequest.Text = "          Room";
            this.btnMaintenanceRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaintenanceRequest.UseVisualStyleBackColor = true;
            // 
            // btnManagement
            // 
            this.btnManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagement.FlatAppearance.BorderSize = 0;
            this.btnManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagement.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnManagement.Image = global::HMS.Properties.Resources.icons8_group_26;
            this.btnManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagement.Location = new System.Drawing.Point(0, 230);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManagement.Size = new System.Drawing.Size(250, 40);
            this.btnManagement.TabIndex = 5;
            this.btnManagement.Text = "          Clients Information";
            this.btnManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagement.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDashboard.Image = global::HMS.Properties.Resources.icons8_combo_chart_26;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 190);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(250, 40);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "          Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::HMS.Properties.Resources.icons8_admin_1002;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Controls.Add(this.lblAdmin);
            this.panel5.Location = new System.Drawing.Point(47, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(153, 144);
            this.panel5.TabIndex = 1;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAdmin.Location = new System.Drawing.Point(22, 124);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(111, 19);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Administrator";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_SideBar
            // 
            this.btn_SideBar.BackgroundImage = global::HMS.Properties.Resources.icons8_menu_30__1_;
            this.btn_SideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SideBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SideBar.FlatAppearance.BorderSize = 0;
            this.btn_SideBar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_SideBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SideBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SideBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_SideBar.Location = new System.Drawing.Point(12, 12);
            this.btn_SideBar.Name = "btn_SideBar";
            this.btn_SideBar.Size = new System.Drawing.Size(30, 30);
            this.btn_SideBar.TabIndex = 1;
            this.btn_SideBar.UseVisualStyleBackColor = true;
            this.btn_SideBar.Click += new System.EventHandler(this.btn_SideBar_Click);
            // 
            // Frm_MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 691);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.pnl_SideBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MainPage";
            this.Load += new System.EventHandler(this.Frm_MainPage_Load);
            this.pnl_SideBar.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_SystemTime.ResumeLayout(false);
            this.pnl_SystemTime.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer CurrentDate;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAnalyticsReports;
        private System.Windows.Forms.Button btnMaintenanceRequest;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl_SideBar;
        private System.Windows.Forms.Button btnManagement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Panel pnl_SystemTime;
        private System.Windows.Forms.Label lblSystemTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_SideBar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_Notifications;
        private System.Windows.Forms.Label lbl_NotifCounter;
    }
}