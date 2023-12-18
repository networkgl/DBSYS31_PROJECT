using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;

namespace HMS.Forms
{
    public partial class Frm_ManageSystem : Form
    {
        private UserRepository userRepo;
        private int ID;
        private string userName, userPassword;
        private int roleID;

        public Frm_ManageSystem()
        {
            InitializeComponent();
            userRepo = new UserRepository();
        }

        private void Frm_ManageSystem_Load(object sender, EventArgs e)
        {
            btnsSystemAccounts.Enabled = false;
            LoadDataGrid();
            btnDeleteSystemAccount.Enabled = false;
            btnUpdateSystemAccount.Enabled = false;
        }
        public void LoadDataGrid()
        {
            string message = string.Empty;
            cbBox_Role.SelectedIndex = 0;
            dgv_systemaccounts.DataSource = userRepo.GetSystemAccounts(ref message);
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            var retVal = userRepo.InsertSystemAccounts(txtboxUserName.Text, txtboxPassword.Text, (cbBox_Role.SelectedIndex)+1, ref message);//add 1 coz index start with zero

            if (retVal == ErrorCode.Success)
            {
                MessageDialog.Show(message, "Message", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Light);
                LoadDataGrid();

                txtboxUserName.Text = string.Empty;
                txtboxPassword.Text = string.Empty;
                cbBox_Role.SelectedIndex = 0;
            }
            else
            {
                MessageDialog.Show(message, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
            }
        }

        private void btnClearDetails_Click(object sender, EventArgs e)
        {          
            string message = string.Empty;
            var retVal = userRepo.DeleteSystemAccounts(ID , ref message);//add 1 coz index start with zero

            if (retVal == ErrorCode.Success)
            {
                MessageDialog.Show(message, "Message", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Light);
                LoadDataGrid();

                txtboxUserName.Text = string.Empty;
                txtboxPassword.Text = string.Empty;
                cbBox_Role.SelectedIndex = 0;
            }
            else
            {
                MessageDialog.Show(message, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
            }
        }

        private void btnUpdateSystemAccount_Click(object sender, EventArgs e)
        {
            string message = string.Empty;

            var retVal = userRepo.UpdateSystemAccounts(ID,txtboxUserName.Text, txtboxPassword.Text, (cbBox_Role.SelectedIndex) + 1, ref message);//add 1 coz index start with zero
           
            if (retVal == ErrorCode.Success)
            {
                MessageDialog.Show(message, "Message", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Light);
                LoadDataGrid();

                txtboxUserName.Text = string.Empty;
                txtboxPassword.Text = string.Empty;
                cbBox_Role.SelectedIndex = 0;

                btnCreateAccount.Enabled = true;
                btnDeleteSystemAccount.Enabled = false;
                btnUpdateSystemAccount.Enabled = false;
                //btnDeleteSystemAccount.Enabled = true;
            }
            else
            {
                MessageDialog.Show(message, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
            }
        }

        private void btnsSystemLogs_Click(object sender, EventArgs e)
        {
            Frm_Main.GetInstanceClass.pnl_main.Controls.Clear();
            Frm_SystemLogs sl = new Frm_SystemLogs();
            sl.TopLevel = false;
            sl.Dock = DockStyle.Fill;
            Frm_Main.GetInstanceClass.pnl_main.Controls.Add(sl);
            sl.Show();

        }

        private void dgv_systemaccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow clickedRow = dgv_systemaccounts.Rows[e.RowIndex];
            ID = Convert.ToInt32(clickedRow.Cells["ID"].Value); //Get ID first then pass to the stored procedure.
            userName = clickedRow.Cells["UserName"].Value.ToString(); //Get ID first then pass to the stored procedure.
            userPassword =clickedRow.Cells["UserPass"].Value.ToString(); //Get ID first then pass to the stored procedure.
            roleID = Convert.ToInt32(clickedRow.Cells["RoleID"].Value); //Get ID first then pass to the stored procedure.


            txtboxUserName.Text = userName;
            txtboxPassword.Text = userPassword;
            cbBox_Role.SelectedIndex = roleID - 1;
            btnDeleteSystemAccount.Enabled = true;
            btnUpdateSystemAccount.Enabled = true;
            btnCreateAccount.Enabled = false;
            //btnDeleteSystemAccount.Enabled = false;
        }
    }
}
