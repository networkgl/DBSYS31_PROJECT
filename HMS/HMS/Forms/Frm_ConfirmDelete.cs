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
    public partial class Frm_ConfirmDelete : Form //Re-use this form in every part of the system that requires to enter password.
    {
        private AdminRepository adminRepo;
        private UserRepository userRepo;
        private static bool rooomAvail_confirmDelete;
        private static bool reservation_confirmDelete;
        private static bool toggle_rooomAvail_confirmDelete;
        private static bool toggle_reservation_confirmDelete;


        public static bool RoomAvailable_ConfirmDelete { get => rooomAvail_confirmDelete; set => rooomAvail_confirmDelete = value; }
        public static bool Reservation_ConfirmDelete { get => reservation_confirmDelete; set => reservation_confirmDelete = value; }
        public static bool Toggle_rooomAvail_confirmDelete { get => toggle_rooomAvail_confirmDelete; set => toggle_rooomAvail_confirmDelete = value; }
        public static bool Toggle_reservation_confirmDelete { get => toggle_reservation_confirmDelete; set => toggle_reservation_confirmDelete = value; }

        public Frm_ConfirmDelete()
        {
            InitializeComponent();
            adminRepo = new AdminRepository();
            userRepo = new UserRepository();
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
            var msg = "Successfully Deleted";
            var response = String.Empty;

            if (Toggle_reservation_confirmDelete)
            {
                //Console.WriteLine("reservation");
                if (txtboxPassword.Text.Equals("12345"))
                {
                    var retVal = userRepo.DeniedReservation(Frm_Reservation.ID, ref response);

                    if (retVal == ErrorCode.Success)
                    {
                        MessageDialog.Show(msg, "Message", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Dark);
                        this.Close();

                        //Check inputted password.
                        reservation_confirmDelete = true;
                        //Frm_Reservation.Frm.LoadDataGrid();
                        //reservation_confirmDelete = false;
                    }
                    else
                    {
                        //Display Message, pass the response string.
                        MessageDialog.Show(response, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
                    }
                }
                else
                {
                    response = "Wrong Global Password!";
                    MessageDialog.Show(response, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
                }


            }
            else if (Toggle_rooomAvail_confirmDelete)
            {
                Console.WriteLine("roomAvail");

                var retVal = adminRepo.DeleteRoomDetails(Frm_ViewRoomAvailable.RoomID, ref response);

                if (retVal == ErrorCode.Success)
                {
                    MessageDialog.Show(msg, "Message", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Dark);
                    this.Close();

                    rooomAvail_confirmDelete = true;
                    Frm_ViewRoomAvailable.Frm.LoadDataGrid();
                    rooomAvail_confirmDelete = false;//after successfull refreshes the datagrid set again to false.
                }
                else
                {
                    //Display Message, pass the response string.
                    MessageDialog.Show(response, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
                }
            }
        }
    }
}
