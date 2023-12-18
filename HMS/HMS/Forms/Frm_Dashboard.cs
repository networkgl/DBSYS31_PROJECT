using Guna.UI2.WinForms;
using HMS.AppData;
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
    public partial class Frm_Dashboard : Form
    {
        private static Frm_Dashboard dashboard;
        private UserRepository userRepo;


        public Frm_Dashboard()
        {
            InitializeComponent();
            userRepo = new UserRepository();
            Frm_Main.LastActivity = "Viewing Dashboard";
        }
        //public static Frm_Dashboard GetInstance()
        //{
        //    //if (dashboard == null)
        //    //    dashboard = new Frm_Dashboard();
        //    return dashboard = new Frm_Dashboard();
        //}
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Dashboard_Load(object sender, EventArgs e)
        {
            DisplayTotalGuest();
            DisplayTotalGuest_Adult();
            DisplayTotalGuest_Children();
            DisplayTotalGuest_SeniorCitizen();
            DisplayTotalRoom_Occupied();
            DisplayTotalRoom_Available();
            DisplayTotalRoom_Reserved();
        }
        private void DisplayTotalGuest()
        {
            string message = string.Empty;
            var getTotalGuest = userRepo.GetRoomTotalGuest_Individually(ref message);
            int total = 0;
            foreach(var guest in getTotalGuest)
            {
                total += (int)guest.TotalGuest;
            }
            lbl_TotalGuest.Text = total.ToString();
        }
        private void DisplayTotalGuest_Adult()
        {
            string message = string.Empty;
            var getTotalGuest = userRepo.GetRoomTotalGuest_Individually(ref message);
            int total = 0;
            foreach (var guest in getTotalGuest)
            {
                total += (int)guest.TotalAdult;
            }
            lbl_totalAdult.Text = total.ToString();
        }
        private void DisplayTotalGuest_Children()
        {
            string message = string.Empty;
            var getTotalGuest = userRepo.GetRoomTotalGuest_Individually(ref message);
            int total = 0;
            foreach (var guest in getTotalGuest)
            {
                total += (int)guest.TotalChildren;
            }
            lbl_totalChildren.Text = total.ToString();
        }
        private void DisplayTotalGuest_SeniorCitizen()
        {
            string message = string.Empty;
            var getTotalGuest = userRepo.GetRoomTotalGuest_Individually(ref message);
            int total = 0;
            foreach (var guest in getTotalGuest)
            {
                total += (int)guest.TotalSeniorCitizen;
            }
            lbl_totalSenior .Text = total.ToString();
        }
        private void DisplayTotalRoom_Occupied()
        {
            string message = string.Empty;
            var getTotalRoom = userRepo.GetRoomTotal_Occupied(ref message);
            int total = 0;
            foreach (var room in getTotalRoom)
            {
                total += (int)room.RoomOccupied;
            }
            lbl_totalRoomOccupied.Text = total.ToString();
        }
        private void DisplayTotalRoom_Available()
        {
            string message = string.Empty;
            var getTotalRoom = userRepo.GetRoomTotal_Occupied(ref message);
            int total = 0;
            foreach (var room in getTotalRoom)
            {
                total += (int)room.RoomOccupied;
            }

            try
            {
                HMSEntities db;
                using (db  = new HMSEntities())
                {
                    var available = ((int)RoomAvailable.MAX * db.ROOM_DETAILS.Count()) - total;//Get max roomtype available then use it to calculate and multiple max room doors in every room type in this case  = 9
                    lbl_totalRoomAvailable.Text = available.ToString();
                }
            }
            catch (Exception e)
            {
                MessageDialog.Show(e.Message, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
            }
        }
        private void DisplayTotalRoom_Reserved()
        {
            string message = string.Empty;
            var getTotalRoom = userRepo.GetRoomTotal_Reserve(ref message);
            int total = 0;
            foreach (var room in getTotalRoom)
            {
                total += (int)room.RoomReserved;
            }
            lbl_totalRoomReserve.Text = total.ToString();
        }
    }
}
