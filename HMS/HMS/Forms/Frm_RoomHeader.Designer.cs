namespace HMS.Forms
{
    partial class Frm_RoomHeader
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnUpdateDeleteRooms = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRooms = new Guna.UI2.WinForms.Guna2Button();
            this.btnRoomDisplay = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnUpdateDeleteRooms);
            this.panel7.Controls.Add(this.btnAddRooms);
            this.panel7.Controls.Add(this.btnRoomDisplay);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1078, 78);
            this.panel7.TabIndex = 20;
            // 
            // btnUpdateDeleteRooms
            // 
            this.btnUpdateDeleteRooms.BorderRadius = 10;
            this.btnUpdateDeleteRooms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDeleteRooms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDeleteRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateDeleteRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateDeleteRooms.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnUpdateDeleteRooms.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDeleteRooms.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDeleteRooms.Location = new System.Drawing.Point(498, 18);
            this.btnUpdateDeleteRooms.Name = "btnUpdateDeleteRooms";
            this.btnUpdateDeleteRooms.Size = new System.Drawing.Size(175, 42);
            this.btnUpdateDeleteRooms.TabIndex = 23;
            this.btnUpdateDeleteRooms.Text = "UPDATE | DELETE Rooms";
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
            this.btnAddRooms.Location = new System.Drawing.Point(689, 18);
            this.btnAddRooms.Name = "btnAddRooms";
            this.btnAddRooms.Size = new System.Drawing.Size(175, 42);
            this.btnAddRooms.TabIndex = 22;
            this.btnAddRooms.Text = "Add Rooms";
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
            this.btnRoomDisplay.Location = new System.Drawing.Point(879, 18);
            this.btnRoomDisplay.Name = "btnRoomDisplay";
            this.btnRoomDisplay.Size = new System.Drawing.Size(175, 42);
            this.btnRoomDisplay.TabIndex = 21;
            this.btnRoomDisplay.Text = "View Room Displayed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(346, 33);
            this.label7.TabIndex = 20;
            this.label7.Text = "Manage Available Room";
            // 
            // Frm_RoomHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 118);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_RoomHeader";
            this.Text = "Frm_RoomHeader";
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2Button btnUpdateDeleteRooms;
        private Guna.UI2.WinForms.Guna2Button btnAddRooms;
        private Guna.UI2.WinForms.Guna2Button btnRoomDisplay;
        private System.Windows.Forms.Label label7;
    }
}