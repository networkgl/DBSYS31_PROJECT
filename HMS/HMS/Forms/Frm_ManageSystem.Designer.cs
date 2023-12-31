namespace HMS.Forms
{
    partial class Frm_ManageSystem
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
            this.pnl_Main1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUpdateSystemAccount = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteSystemAccount = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateAccount = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBox_Role = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtboxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv_systemaccounts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnsSystemAccounts = new Guna.UI2.WinForms.Guna2Button();
            this.btnsSystemLogs = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_Main1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_systemaccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 33);
            this.label7.TabIndex = 16;
            this.label7.Text = "Manage System";
            // 
            // pnl_Main1
            // 
            this.pnl_Main1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnl_Main1.BorderRadius = 10;
            this.pnl_Main1.Controls.Add(this.btnUpdateSystemAccount);
            this.pnl_Main1.Controls.Add(this.label4);
            this.pnl_Main1.Controls.Add(this.btnDeleteSystemAccount);
            this.pnl_Main1.Controls.Add(this.label3);
            this.pnl_Main1.Controls.Add(this.btnCreateAccount);
            this.pnl_Main1.Controls.Add(this.label2);
            this.pnl_Main1.Controls.Add(this.cbBox_Role);
            this.pnl_Main1.Controls.Add(this.txtboxPassword);
            this.pnl_Main1.Controls.Add(this.label1);
            this.pnl_Main1.Controls.Add(this.label6);
            this.pnl_Main1.Controls.Add(this.txtboxUserName);
            this.pnl_Main1.Controls.Add(this.dgv_systemaccounts);
            this.pnl_Main1.FillColor = System.Drawing.Color.White;
            this.pnl_Main1.Location = new System.Drawing.Point(12, 70);
            this.pnl_Main1.Name = "pnl_Main1";
            this.pnl_Main1.Size = new System.Drawing.Size(1054, 503);
            this.pnl_Main1.TabIndex = 161;
            // 
            // btnUpdateSystemAccount
            // 
            this.btnUpdateSystemAccount.BorderRadius = 5;
            this.btnUpdateSystemAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateSystemAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateSystemAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateSystemAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateSystemAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.btnUpdateSystemAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSystemAccount.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSystemAccount.Location = new System.Drawing.Point(223, 314);
            this.btnUpdateSystemAccount.Name = "btnUpdateSystemAccount";
            this.btnUpdateSystemAccount.Size = new System.Drawing.Size(144, 50);
            this.btnUpdateSystemAccount.TabIndex = 170;
            this.btnUpdateSystemAccount.Text = "Update Account";
            this.btnUpdateSystemAccount.Click += new System.EventHandler(this.btnUpdateSystemAccount_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(699, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 30);
            this.label4.TabIndex = 169;
            this.label4.Text = "LIST OF ACCOUNTS";
            // 
            // btnDeleteSystemAccount
            // 
            this.btnDeleteSystemAccount.BorderRadius = 5;
            this.btnDeleteSystemAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteSystemAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteSystemAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteSystemAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteSystemAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDeleteSystemAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSystemAccount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSystemAccount.Location = new System.Drawing.Point(412, 314);
            this.btnDeleteSystemAccount.Name = "btnDeleteSystemAccount";
            this.btnDeleteSystemAccount.Size = new System.Drawing.Size(144, 50);
            this.btnDeleteSystemAccount.TabIndex = 168;
            this.btnDeleteSystemAccount.Text = "Delete Account";
            this.btnDeleteSystemAccount.Click += new System.EventHandler(this.btnClearDetails_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 30);
            this.label3.TabIndex = 167;
            this.label3.Text = "GENERATE ACCOUNT";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BorderRadius = 5;
            this.btnCreateAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Location = new System.Drawing.Point(36, 314);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(144, 50);
            this.btnCreateAccount.TabIndex = 166;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 165;
            this.label2.Text = "Role";
            // 
            // cbBox_Role
            // 
            this.cbBox_Role.BackColor = System.Drawing.Color.White;
            this.cbBox_Role.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cbBox_Role.BorderRadius = 5;
            this.cbBox_Role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBox_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_Role.FillColor = System.Drawing.SystemColors.Control;
            this.cbBox_Role.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBox_Role.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBox_Role.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbBox_Role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbBox_Role.ItemHeight = 30;
            this.cbBox_Role.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.cbBox_Role.Location = new System.Drawing.Point(36, 251);
            this.cbBox_Role.MinimumSize = new System.Drawing.Size(520, 0);
            this.cbBox_Role.Name = "cbBox_Role";
            this.cbBox_Role.Size = new System.Drawing.Size(520, 36);
            this.cbBox_Role.TabIndex = 164;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.BackColor = System.Drawing.Color.White;
            this.txtboxPassword.BorderRadius = 5;
            this.txtboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxPassword.DefaultText = "";
            this.txtboxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxPassword.FillColor = System.Drawing.SystemColors.Control;
            this.txtboxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxPassword.Location = new System.Drawing.Point(36, 170);
            this.txtboxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '\0';
            this.txtboxPassword.PlaceholderText = "****************";
            this.txtboxPassword.SelectedText = "";
            this.txtboxPassword.Size = new System.Drawing.Size(520, 40);
            this.txtboxPassword.TabIndex = 163;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 162;
            this.label1.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 161;
            this.label6.Text = "Username";
            // 
            // txtboxUserName
            // 
            this.txtboxUserName.BackColor = System.Drawing.Color.White;
            this.txtboxUserName.BorderRadius = 5;
            this.txtboxUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxUserName.DefaultText = "";
            this.txtboxUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxUserName.FillColor = System.Drawing.SystemColors.Control;
            this.txtboxUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxUserName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxUserName.Location = new System.Drawing.Point(36, 93);
            this.txtboxUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxUserName.Name = "txtboxUserName";
            this.txtboxUserName.PasswordChar = '\0';
            this.txtboxUserName.PlaceholderText = "e.g gianlloyd123";
            this.txtboxUserName.SelectedText = "";
            this.txtboxUserName.Size = new System.Drawing.Size(520, 40);
            this.txtboxUserName.TabIndex = 160;
            // 
            // dgv_systemaccounts
            // 
            this.dgv_systemaccounts.AllowUserToAddRows = false;
            this.dgv_systemaccounts.AllowUserToDeleteRows = false;
            this.dgv_systemaccounts.AllowUserToOrderColumns = true;
            this.dgv_systemaccounts.AllowUserToResizeColumns = false;
            this.dgv_systemaccounts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_systemaccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_systemaccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_systemaccounts.ColumnHeadersHeight = 25;
            this.dgv_systemaccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_systemaccounts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_systemaccounts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_systemaccounts.Location = new System.Drawing.Point(577, 93);
            this.dgv_systemaccounts.Name = "dgv_systemaccounts";
            this.dgv_systemaccounts.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_systemaccounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_systemaccounts.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_systemaccounts.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_systemaccounts.RowTemplate.Height = 25;
            this.dgv_systemaccounts.Size = new System.Drawing.Size(460, 271);
            this.dgv_systemaccounts.TabIndex = 159;
            this.dgv_systemaccounts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_systemaccounts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_systemaccounts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_systemaccounts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_systemaccounts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_systemaccounts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_systemaccounts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_systemaccounts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_systemaccounts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_systemaccounts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_systemaccounts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_systemaccounts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_systemaccounts.ThemeStyle.HeaderStyle.Height = 25;
            this.dgv_systemaccounts.ThemeStyle.ReadOnly = true;
            this.dgv_systemaccounts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_systemaccounts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_systemaccounts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_systemaccounts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_systemaccounts.ThemeStyle.RowsStyle.Height = 25;
            this.dgv_systemaccounts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_systemaccounts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_systemaccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_systemaccounts_CellClick);
            // 
            // btnsSystemAccounts
            // 
            this.btnsSystemAccounts.BorderRadius = 5;
            this.btnsSystemAccounts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsSystemAccounts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsSystemAccounts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsSystemAccounts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsSystemAccounts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.btnsSystemAccounts.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsSystemAccounts.ForeColor = System.Drawing.Color.White;
            this.btnsSystemAccounts.Location = new System.Drawing.Point(684, 15);
            this.btnsSystemAccounts.Name = "btnsSystemAccounts";
            this.btnsSystemAccounts.Size = new System.Drawing.Size(175, 42);
            this.btnsSystemAccounts.TabIndex = 163;
            this.btnsSystemAccounts.Text = "System Accounts";
            // 
            // btnsSystemLogs
            // 
            this.btnsSystemLogs.BorderRadius = 5;
            this.btnsSystemLogs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsSystemLogs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsSystemLogs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsSystemLogs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsSystemLogs.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsSystemLogs.ForeColor = System.Drawing.Color.White;
            this.btnsSystemLogs.Location = new System.Drawing.Point(874, 15);
            this.btnsSystemLogs.Name = "btnsSystemLogs";
            this.btnsSystemLogs.Size = new System.Drawing.Size(175, 42);
            this.btnsSystemLogs.TabIndex = 162;
            this.btnsSystemLogs.Text = "System Logs";
            this.btnsSystemLogs.Click += new System.EventHandler(this.btnsSystemLogs_Click);
            // 
            // Frm_ManageSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 619);
            this.Controls.Add(this.btnsSystemAccounts);
            this.Controls.Add(this.btnsSystemLogs);
            this.Controls.Add(this.pnl_Main1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ManageSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ManageSystem";
            this.Load += new System.EventHandler(this.Frm_ManageSystem_Load);
            this.pnl_Main1.ResumeLayout(false);
            this.pnl_Main1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_systemaccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Panel pnl_Main1;
        public Guna.UI2.WinForms.Guna2DataGridView dgv_systemaccounts;
        private Guna.UI2.WinForms.Guna2Button btnsSystemAccounts;
        private Guna.UI2.WinForms.Guna2Button btnsSystemLogs;
        private Guna.UI2.WinForms.Guna2ComboBox cbBox_Role;
        private Guna.UI2.WinForms.Guna2TextBox txtboxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtboxUserName;
        private Guna.UI2.WinForms.Guna2Button btnDeleteSystemAccount;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnCreateAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnUpdateSystemAccount;
    }
}