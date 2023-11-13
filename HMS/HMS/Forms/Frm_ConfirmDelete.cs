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
    public partial class Frm_ConfirmDelete : Form
    {
        private AdminRepository adminRepo;
        private static bool confirmDelete;

        public static bool ConfirmDelete { get => confirmDelete; set => confirmDelete = value; }

        public Frm_ConfirmDelete()
        {
            InitializeComponent();
            adminRepo = new AdminRepository();
        }

        private void Frm_ConfirmDelete_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            string response = String.Empty;

            var retVal = adminRepo.DeleteRoomDetails(Frm_ViewRoomAvailable.RoomID,ref response);
            Console.WriteLine(Frm_ViewRoomAvailable.RoomID);
            var msg = "Successfully Deleted";
            if (retVal == ErrorCode.Success)
            {
                MessageDialog.Show(msg, "Message", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Dark);
                this.Close();

                confirmDelete = true;
                Frm_ViewRoomAvailable.Frm.LoadDataGrid();
                confirmDelete = false;//after successfull refreshes the datagrid set again to false.
            }
            else
            {
                //Display Message, pass the response string.
                MessageDialog.Show(response, "Message", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Dark);

            }
        }
    }
}
