namespace HMS
{
    partial class Frm_ProcessPayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxCardNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxCardExpiryDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtboxCardCVC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtboxCardHolderName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPayNow = new Guna.UI2.WinForms.Guna2Button();
            this.cbBox_Note = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_SubTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(47, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Method";
            // 
            // txtboxCardNumber
            // 
            this.txtboxCardNumber.BorderRadius = 10;
            this.txtboxCardNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxCardNumber.CustomizableEdges.BottomLeft = false;
            this.txtboxCardNumber.CustomizableEdges.BottomRight = false;
            this.txtboxCardNumber.DefaultText = "";
            this.txtboxCardNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxCardNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxCardNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxCardNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxCardNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxCardNumber.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCardNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxCardNumber.Location = new System.Drawing.Point(51, 137);
            this.txtboxCardNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxCardNumber.Name = "txtboxCardNumber";
            this.txtboxCardNumber.PasswordChar = '\0';
            this.txtboxCardNumber.PlaceholderText = "1234 1234 1234 1234";
            this.txtboxCardNumber.SelectedText = "";
            this.txtboxCardNumber.Size = new System.Drawing.Size(330, 36);
            this.txtboxCardNumber.TabIndex = 1;
            this.txtboxCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxCardNumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(50, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Card Information";
            // 
            // txtboxCardExpiryDate
            // 
            this.txtboxCardExpiryDate.BorderRadius = 10;
            this.txtboxCardExpiryDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxCardExpiryDate.CustomizableEdges.BottomRight = false;
            this.txtboxCardExpiryDate.CustomizableEdges.TopLeft = false;
            this.txtboxCardExpiryDate.CustomizableEdges.TopRight = false;
            this.txtboxCardExpiryDate.DefaultText = "";
            this.txtboxCardExpiryDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxCardExpiryDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxCardExpiryDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxCardExpiryDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxCardExpiryDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxCardExpiryDate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCardExpiryDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxCardExpiryDate.Location = new System.Drawing.Point(51, 173);
            this.txtboxCardExpiryDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxCardExpiryDate.Name = "txtboxCardExpiryDate";
            this.txtboxCardExpiryDate.PasswordChar = '\0';
            this.txtboxCardExpiryDate.PlaceholderText = "MM / YY";
            this.txtboxCardExpiryDate.SelectedText = "";
            this.txtboxCardExpiryDate.Size = new System.Drawing.Size(166, 36);
            this.txtboxCardExpiryDate.TabIndex = 4;
            // 
            // txtboxCardCVC
            // 
            this.txtboxCardCVC.BorderRadius = 10;
            this.txtboxCardCVC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxCardCVC.CustomizableEdges.BottomLeft = false;
            this.txtboxCardCVC.CustomizableEdges.TopLeft = false;
            this.txtboxCardCVC.CustomizableEdges.TopRight = false;
            this.txtboxCardCVC.DefaultText = "";
            this.txtboxCardCVC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxCardCVC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxCardCVC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxCardCVC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxCardCVC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxCardCVC.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCardCVC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxCardCVC.Location = new System.Drawing.Point(217, 173);
            this.txtboxCardCVC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxCardCVC.Name = "txtboxCardCVC";
            this.txtboxCardCVC.PasswordChar = '\0';
            this.txtboxCardCVC.PlaceholderText = "CVC";
            this.txtboxCardCVC.SelectedText = "";
            this.txtboxCardCVC.Size = new System.Drawing.Size(164, 36);
            this.txtboxCardCVC.TabIndex = 5;
            // 
            // txtboxCardHolderName
            // 
            this.txtboxCardHolderName.BorderRadius = 10;
            this.txtboxCardHolderName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxCardHolderName.DefaultText = "";
            this.txtboxCardHolderName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxCardHolderName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxCardHolderName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxCardHolderName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxCardHolderName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxCardHolderName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCardHolderName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxCardHolderName.Location = new System.Drawing.Point(53, 251);
            this.txtboxCardHolderName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxCardHolderName.Name = "txtboxCardHolderName";
            this.txtboxCardHolderName.PasswordChar = '\0';
            this.txtboxCardHolderName.PlaceholderText = "Full name on card";
            this.txtboxCardHolderName.SelectedText = "";
            this.txtboxCardHolderName.Size = new System.Drawing.Size(330, 36);
            this.txtboxCardHolderName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.label3.Location = new System.Drawing.Point(50, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cardholder Name";
            // 
            // btnPayNow
            // 
            this.btnPayNow.BorderRadius = 10;
            this.btnPayNow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPayNow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPayNow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPayNow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPayNow.Enabled = false;
            this.btnPayNow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(163)))), ((int)(((byte)(117)))));
            this.btnPayNow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayNow.ForeColor = System.Drawing.Color.White;
            this.btnPayNow.Location = new System.Drawing.Point(69, 521);
            this.btnPayNow.Name = "btnPayNow";
            this.btnPayNow.Size = new System.Drawing.Size(288, 40);
            this.btnPayNow.TabIndex = 8;
            this.btnPayNow.Text = "PAY NOW";
            this.btnPayNow.Click += new System.EventHandler(this.btnPayNow_Click);
            // 
            // cbBox_Note
            // 
            this.cbBox_Note.AutoSize = true;
            this.cbBox_Note.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBox_Note.CheckedState.BorderRadius = 0;
            this.cbBox_Note.CheckedState.BorderThickness = 0;
            this.cbBox_Note.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBox_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbBox_Note.Location = new System.Drawing.Point(45, 446);
            this.cbBox_Note.Name = "cbBox_Note";
            this.cbBox_Note.Size = new System.Drawing.Size(15, 14);
            this.cbBox_Note.TabIndex = 9;
            this.cbBox_Note.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbBox_Note.UncheckedState.BorderRadius = 0;
            this.cbBox_Note.UncheckedState.BorderThickness = 0;
            this.cbBox_Note.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbBox_Note.CheckedChanged += new System.EventHandler(this.cbBox_Note_CheckedChanged);
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.lbl_Note.Location = new System.Drawing.Point(66, 446);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Note.Size = new System.Drawing.Size(315, 45);
            this.lbl_Note.TabIndex = 10;
            this.lbl_Note.Text = "You will be charge the amount listed above. \r\nPlease preview and click pay now to" +
    " process\r\nyour booking. Thank you !";
            this.lbl_Note.Click += new System.EventHandler(this.lbl_Note_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.label5.Location = new System.Drawing.Point(48, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 28);
            this.label5.TabIndex = 75;
            this.label5.Text = "Subtotal";
            // 
            // lbl_SubTotal
            // 
            this.lbl_SubTotal.AutoSize = true;
            this.lbl_SubTotal.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lbl_SubTotal.Location = new System.Drawing.Point(238, 328);
            this.lbl_SubTotal.Name = "lbl_SubTotal";
            this.lbl_SubTotal.Size = new System.Drawing.Size(146, 28);
            this.lbl_SubTotal.TabIndex = 76;
            this.lbl_SubTotal.Text = "₱000,000.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.label7.Location = new System.Drawing.Point(48, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 77;
            this.label7.Text = "Tax Fee";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.label8.Location = new System.Drawing.Point(325, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 21);
            this.label8.TabIndex = 78;
            this.label8.Text = "₱ 0.00";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HMS.Properties.Resources.icons8_information_20;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(119, 372);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 15);
            this.panel1.TabIndex = 79;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BackgroundImage = global::HMS.Properties.Resources.icons8_american_express_squared_50;
            this.guna2Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel3.BorderRadius = 20;
            this.guna2Panel3.Location = new System.Drawing.Point(321, 60);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(33, 28);
            this.guna2Panel3.TabIndex = 13;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BackgroundImage = global::HMS.Properties.Resources.icons8_mastercard_50;
            this.guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.Location = new System.Drawing.Point(282, 60);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(33, 28);
            this.guna2Panel2.TabIndex = 12;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::HMS.Properties.Resources.icons8_back_26;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 31);
            this.btnBack.TabIndex = 74;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BackgroundImage = global::HMS.Properties.Resources.icons8_visa_50;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Location = new System.Drawing.Point(243, 60);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(33, 28);
            this.guna2Panel1.TabIndex = 11;
            // 
            // Frm_ProcessPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 594);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_SubTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.cbBox_Note);
            this.Controls.Add(this.btnPayNow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxCardHolderName);
            this.Controls.Add(this.txtboxCardCVC);
            this.Controls.Add(this.txtboxCardExpiryDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxCardNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ProcessPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ProcessPayment";
            this.Load += new System.EventHandler(this.Frm_ProcessPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtboxCardNumber;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtboxCardExpiryDate;
        private Guna.UI2.WinForms.Guna2TextBox txtboxCardCVC;
        private Guna.UI2.WinForms.Guna2TextBox txtboxCardHolderName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnPayNow;
        private Guna.UI2.WinForms.Guna2CheckBox cbBox_Note;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_SubTotal;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
    }
}