namespace HMS.Forms
{
    partial class Frm_Room
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
            this.label7 = new System.Windows.Forms.Label();
            this.pnl_RoomType = new System.Windows.Forms.Panel();
            this.lbl_RoomType = new System.Windows.Forms.Label();
            this.cbBox_RoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 33);
            this.label7.TabIndex = 15;
            this.label7.Text = "Room";
            // 
            // pnl_RoomType
            // 
            this.pnl_RoomType.Location = new System.Drawing.Point(1, 107);
            this.pnl_RoomType.Name = "pnl_RoomType";
            this.pnl_RoomType.Size = new System.Drawing.Size(1063, 473);
            this.pnl_RoomType.TabIndex = 16;
            // 
            // lbl_RoomType
            // 
            this.lbl_RoomType.AutoSize = true;
            this.lbl_RoomType.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RoomType.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_RoomType.Location = new System.Drawing.Point(21, 65);
            this.lbl_RoomType.Name = "lbl_RoomType";
            this.lbl_RoomType.Size = new System.Drawing.Size(78, 23);
            this.lbl_RoomType.TabIndex = 17;
            this.lbl_RoomType.Text = "Deluxe";
            // 
            // cbBox_RoomType
            // 
            this.cbBox_RoomType.BackColor = System.Drawing.Color.Transparent;
            this.cbBox_RoomType.BorderRadius = 10;
            this.cbBox_RoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBox_RoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_RoomType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBox_RoomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBox_RoomType.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBox_RoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbBox_RoomType.ItemHeight = 30;
            this.cbBox_RoomType.Items.AddRange(new object[] {
            "DELUXE",
            "PRIEMERE DELUXE",
            "FILI SUITE"});
            this.cbBox_RoomType.Location = new System.Drawing.Point(746, 52);
            this.cbBox_RoomType.Name = "cbBox_RoomType";
            this.cbBox_RoomType.Size = new System.Drawing.Size(292, 36);
            this.cbBox_RoomType.TabIndex = 18;
            this.cbBox_RoomType.SelectedIndexChanged += new System.EventHandler(this.cbBox_RoomType_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HMS.Properties.Resources.icons8_filter_64;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(706, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(34, 36);
            this.panel1.TabIndex = 20;
            // 
            // Frm_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1062, 580);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbBox_RoomType);
            this.Controls.Add(this.lbl_RoomType);
            this.Controls.Add(this.pnl_RoomType);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Room";
            this.Load += new System.EventHandler(this.Frm_Room_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnl_RoomType;
        private System.Windows.Forms.Label lbl_RoomType;
        private Guna.UI2.WinForms.Guna2ComboBox cbBox_RoomType;
        private System.Windows.Forms.Panel panel1;
    }
}