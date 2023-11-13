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

namespace HMS
{
    public partial class Frm_Main : Form
    {
        private static Frm_Main main;
        private int toggleNotif = 0;
        private byte fontSize = 12;
        private bool ToggleDash, ToggleClient, ToggleRoom, ToggleReserve,ToggleLogout;
        private static Frm_Main _instance;
        public Frm_Main()
        {
            InitializeComponent();
        }
        public static Frm_Main GetInstance()
        {
            if(main == null)
                main = new Frm_Main();
            return main;
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
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            ToggleDash = true;

            if (ToggleDash)
                pnl_ToggleDash.Visible = ToggleDash;

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


            pnl_main.Controls.Clear();
            Frm_Dashboard.GetInstance().TopLevel = false;
            Frm_Dashboard.GetInstance().Dock = DockStyle.Fill;
            pnl_main.Controls.Add(Frm_Dashboard.GetInstance());
            Frm_Dashboard.GetInstance().Show();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnl_ToggleClient.Visible = false;
            pnl_ToggleRoom.Visible = false;
            pnl_ToggleReserve.Visible = false;
            pnl_ToggleLogout.Visible = false;

            ToggleDash = true;

            if (ToggleDash)
                pnl_ToggleDash.Visible = ToggleDash;


            pnl_main.Controls.Clear();
            Frm_Dashboard.GetInstance().TopLevel = false;
            Frm_Dashboard.GetInstance().Dock = DockStyle.Fill;
            pnl_main.Controls.Add(Frm_Dashboard.GetInstance());
            Frm_Dashboard.GetInstance().Show();
        }
        private void btnClient_Click(object sender, EventArgs e)
        {
            pnl_ToggleDash.Visible = false;
            pnl_ToggleRoom.Visible = false;
            pnl_ToggleReserve.Visible = false;
            pnl_ToggleLogout.Visible = false;

            ToggleClient = true;

            if (ToggleClient)
                pnl_ToggleClient.Visible = ToggleClient;


            Frm_Client client = new Frm_Client();
            pnl_main.Controls.Clear();
            client.TopLevel = false;
            client.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(client);
            client.Show();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            pnl_ToggleDash.Visible = false;
            pnl_ToggleClient.Visible = false;
            pnl_ToggleReserve.Visible = false;
            pnl_ToggleLogout.Visible = false;

            ToggleRoom = true;

            if (ToggleRoom)
                pnl_ToggleRoom.Visible = ToggleRoom;

            pnl_main.Controls.Clear();
            Frm_Room room = new Frm_Room();
            room.TopLevel = false;
            room.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(room);
            room.Show();
        }
        private void btnReservation_Click(object sender, EventArgs e)
        {
            pnl_ToggleDash.Visible = false;
            pnl_ToggleClient.Visible = false;
            pnl_ToggleRoom.Visible = false;
            pnl_ToggleLogout.Visible = false;

            ToggleReserve = true;

            if (ToggleReserve)
                pnl_ToggleReserve.Visible = ToggleReserve;
        }
        private void btnManageRoomType_Click(object sender, EventArgs e)
        {
            //pnl_main.Controls.Clear();
            //Frm_ManageRoomType mgt = new Frm_ManageRoomType();
            //mgt.TopLevel = false;
            //mgt.Dock = DockStyle.Fill;
            //pnl_main.Controls.Add(mgt);
            //mgt.Show();

            Frm_ViewRoomAvailable ar = new Frm_ViewRoomAvailable();
            pnl_main.Controls.Clear();
            ar.TopLevel = false;
            ar.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(ar);
            ar.Show();

            _instance = this;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            pnl_ToggleDash.Visible = false;
            pnl_ToggleClient.Visible = false;
            pnl_ToggleRoom.Visible = false;
            pnl_ToggleReserve.Visible = false;

            ToggleLogout = true;
            if (ToggleLogout)
                pnl_ToggleLogout.Visible = ToggleLogout;

            var msg = "Are you sure you want to logout ?";
            bool logout = MessageDialog.Show(msg, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Question, MessageDialogStyle.Dark) == DialogResult.Yes;
            if(logout) {
                this.Hide();
                Frm_HomePage home = new Frm_HomePage();
                home.Show();
                Frm_Login.GetInstance().HasLogin = false;
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
