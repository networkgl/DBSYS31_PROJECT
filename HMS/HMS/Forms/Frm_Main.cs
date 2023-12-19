using Guna.UI2.WinForms;
using HMS.Forms;
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

namespace HMS
{
    public partial class Frm_Main : Form
    {
        private static Frm_Main main;
        private int toggleNotif = 0;
        private byte fontSize = 12;
        private static Frm_Main _instance;
        private UserRepository userRepo;
        public static string LastActivity { get; set; }

        static DateTime timeLogin = DateTime.Now;
        // Extract the time component
        TimeSpan timeOfDay = timeLogin.TimeOfDay;

        private DateTime dateLogin = DateTime.Now.Date;

        private bool activeBookingDetails, activeReservation, activeManageRoom;


        private Frm_Dashboard dashboard;
        public Frm_Main()
        {
            InitializeComponent();
            dashboard = new Frm_Dashboard();
            userRepo = new UserRepository();
            //activeBookingDetails = true;
        }
        public static Frm_Main GetInstanceClass
        {
            get { return _instance; }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }

        public bool ActiveBookingDetails { get => activeBookingDetails; set => activeBookingDetails = value; }
        public bool ActiveReservation { get => activeReservation; set => activeReservation = value; }
        public bool ActiveManageRoom { get => activeManageRoom; set => activeManageRoom = value; }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

            if (Frm_Login.UserType.Equals("Admin"))
            {
                btnManageSystem.Visible = true;
                lbl_userAccount.Text = "Administrator";
            }
            else
            {
                btnManageSystem.Visible = false;
                lbl_userAccount.Text = "Staff";
                lbl_userAccount.Location = new Point(90, 151);
            }

            var Size_x = 39;
            var Size_y = 37;
            var Loc_x = 785;
            var Loc_y = 16;
            if (toggleNotif == 0)
            {
                btn_Notificationss.Size = new Size(Size_x, Size_y);
                btn_Notificationss.BackgroundImage = Properties.Resources.icons8_notification_50__1_;
                btn_Notificationss.BackgroundImageLayout = ImageLayout.Stretch;
                btn_Notificationss.Location = new Point(Loc_x, Loc_y);
            }
            dashboard = new Frm_Dashboard();

            pnl_main.Controls.Clear();
            dashboard.TopLevel = false;
            dashboard.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(dashboard);
            dashboard.Show();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboard = new Frm_Dashboard();

            pnl_main.Controls.Clear();
            dashboard.TopLevel = false;
            dashboard.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(dashboard);
            dashboard.Show();
        }
        private void btnClient_Click(object sender, EventArgs e)
        {
            activeReservation = false;
            activeManageRoom = false;
            activeBookingDetails = true;

            Frm_BookingDetails client = new Frm_BookingDetails();
            pnl_main.Controls.Clear();
            client.TopLevel = false;
            client.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(client);
            client.Show();

            LastActivity = "Viewing Booking Details";

        }

        private void btnRoom_Click(object sender, EventArgs e)
        {


            pnl_main.Controls.Clear();
            Frm_Room room = new Frm_Room();
            room.TopLevel = false;
            room.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(room);
            room.Show();

            LastActivity = "Viewing Room Details";

        }
        private void btnReservation_Click(object sender, EventArgs e)
        {
            activeManageRoom = false;
            activeBookingDetails = false;
            activeReservation = true;


            Frm_Reservation rsrv = new Frm_Reservation();
            pnl_main.Controls.Clear();
            rsrv.TopLevel = false;
            rsrv.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(rsrv);
            rsrv.Show();
            Frm_Main.LastActivity = "Viewing Reservation";
        }
        private void btnManageRoomType_Click(object sender, EventArgs e)
        {

            activeManageRoom = true;

            Frm_ViewRoomAvailable ar = new Frm_ViewRoomAvailable();
            pnl_main.Controls.Clear();
            ar.TopLevel = false;
            ar.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(ar);
            ar.Show();

            _instance = this;

            LastActivity = "Viewing Manage Room";

        }
        private void btnManageSystem_Click(object sender, EventArgs e)
        {
            Frm_ManageSystem ar = new Frm_ManageSystem();
            pnl_main.Controls.Clear();
            ar.TopLevel = false;
            ar.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(ar);
            ar.Show();

            _instance = this;

            LastActivity = "Viewing Manage System";

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            var msg = "Are you sure you want to logout ?";
            bool logout = MessageDialog.Show(msg, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Question, MessageDialogStyle.Dark) == DialogResult.Yes;
            if(logout)
            {
                string message = string.Empty;
                userRepo.InsertSystemLogs(Frm_Login.UserType, dateLogin, timeOfDay, LastActivity, ref message);


                this.Hide();
                Frm_HomePage home = new Frm_HomePage();
                home.Show();
                //Frm_Login.GetInstance().HasLogin = false;
                Frm_Login login = new Frm_Login();
                login.HasLogin = false;
            }
        }

        private void btn_Notificationss_Click(object sender, EventArgs e)
        {
            toggleNotif++;

            //65, 77
            //770, -5
            var Size_x = 65;
            var Size_y = 77;
            var Loc_x = 770;
            var Loc_y = -5;
            if (toggleNotif >= 1)
            {
                lbl_NotifCounter.Visible = true;
                btn_Notificationss.Size = new Size(Size_x, Size_y);
                btn_Notificationss.BackgroundImage = Properties.Resources.notif1;
                btn_Notificationss.BackgroundImageLayout = ImageLayout.Zoom;
                btn_Notificationss.Location = new Point(Loc_x, Loc_y);
            }

            //810, 15
            var x = 810;
            var y = 15;
            if (toggleNotif >= 10)
            {
                lbl_NotifCounter.Font = new Font("Century Gothic", 6, FontStyle.Bold);
                lbl_NotifCounter.Location = new Point(x - 1, y);
                //lbl_NotifCounter.Text = "9+";
                lbl_NotifCounter.Text = toggleNotif.ToString();

            }
            else
            {
                lbl_NotifCounter.Text = toggleNotif.ToString();
            }
        }
        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Font = new Font("Century Gothic", fontSize, FontStyle.Bold);
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.Font = new Font("Century Gothic", fontSize, FontStyle.Regular);
        }

        private void btnClient_MouseEnter(object sender, EventArgs e)
        {
            btnClient.ForeColor = Color.White;
            btnClient.Font = new Font("Century Gothic", fontSize, FontStyle.Bold);
        }

        private void btnClient_MouseLeave(object sender, EventArgs e)
        {
            btnClient.ForeColor = Color.Black;
            btnClient.Font = new Font("Century Gothic", fontSize, FontStyle.Regular);
        }

        private void btnRoom_MouseEnter(object sender, EventArgs e)
        {
            btnRoom.ForeColor = Color.White;
            btnRoom.Font = new Font("Century Gothic", fontSize, FontStyle.Bold);
        }

        private void btnRoom_MouseLeave(object sender, EventArgs e)
        {
            btnRoom.ForeColor = Color.Black;
            btnRoom.Font = new Font("Century Gothic", fontSize, FontStyle.Regular);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtbox_SearchBar_Leave(object sender, EventArgs e)
        {
            txtbox_SearchBar.Text = string.Empty;
            LastActivity = "Searching Booking Details";
        }

        //private void txtbox_SearchBar_TextChanged(object sender, EventArgs e)
        //{
        //    string message = string.Empty;
        //    var retVal = userRepo.SearchReservationByName(txtbox_SearchBar.Text, ref message);
        //    if (ErrorCode.Error == retVal)
        //    {
        //       MessageDialog.Show(message, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
        //    }
        //    else
        //    {
        //        Frm_BookingDetails frm = new Frm_BookingDetails();
        //        frm.dgv_bookingdetails.Rows.Clear();
        //        frm.dgv_bookingdetails.DataSource = retVal;

        //    }
        //}
        private void txtbox_SearchBar_TextChanged(object sender, EventArgs e)
        {
            string searchName = txtbox_SearchBar.Text;

            try
            {
                if (ActiveBookingDetails)
                {
                    var result = userRepo.SearchBookingDetailsByName(searchName);
                    Frm_BookingDetails.Instance.dgv_roomdetails.DataSource = result;
                }
                else if(ActiveBookingDetails && searchName.Equals(string.Empty))
                {
                    Frm_BookingDetails.Instance.LoadDataGrid();
                }

                if (ActiveReservation)
                {
                    var result = userRepo.SearchReservationDetails(searchName);
                    Frm_Reservation.Instance.dgv_roomreservation.DataSource = result;
                }
                else if(ActiveReservation && searchName.Equals(string.Empty))
                {
                    Frm_Reservation.Instance.LoadDataGrid();
                }

                if (ActiveManageRoom)
                {
                    var result = userRepo.SearchRoomDetails(searchName);
                    Frm_ViewRoomAvailable.Instance.dgv_roomdetails.DataSource = result;
                }
                else if (ActiveManageRoom && searchName.Equals(string.Empty))
                {
                    Frm_ViewRoomAvailable.Instance.LoadDataGrid();
                }

            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }
        private void btnReservation_MouseEnter(object sender, EventArgs e)
        {
            btnReservation.ForeColor = Color.White;
            btnReservation.Font = new Font("Century Gothic", fontSize, FontStyle.Bold);
        }

        private void btnReservation_MouseLeave(object sender, EventArgs e)
        {
            btnReservation.ForeColor = Color.Black;
            btnReservation.Font = new Font("Century Gothic", fontSize, FontStyle.Regular);
        }



        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.ForeColor = Color.White;
            btnLogout.Font = new Font("Century Gothic", fontSize, FontStyle.Bold);
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.ForeColor = Color.Black;
            btnLogout.Font = new Font("Century Gothic", fontSize, FontStyle.Regular);
        }
    }
}
