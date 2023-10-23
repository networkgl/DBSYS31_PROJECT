using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Forms
{
    public partial class Frm_MainPage : Form
    {
        int toggleNotif = 0;
        private static Frm_MainPage mainPage;
        int toggleSideBar = 1;
        private Frm_MainPage()
        {
            InitializeComponent();
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
        public static Frm_MainPage GetInstance()
        {
            if (mainPage == null)
                mainPage = new Frm_MainPage();
            return mainPage;
        }
        private void Frm_MainPage_Load(object sender, EventArgs e)
        {
            CurrentDate.Start();
            UpdateDateTime();
        }

        private void CurrentDate_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }
        public void UpdateDateTime()
        {
            var currentDateTime = DateTime.Now;
            var culture = new CultureInfo("en-PH"); // Specify the desired culture
            lblSystemTime.Text = currentDateTime.ToString("yyyy-MM-dd  hh:mm:ss tt", culture);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var ask = MessageBox.Show("Are you sure you want to logout ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask == DialogResult.Yes)
            {
                this.Hide();
                Frm_HomePage.GetInstance().Show();
                Frm_Login.GetInstance().HasLogin = false;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //759, 8
            toggleNotif++;
            var x = 759;
            var y = 8;
            //if (toggleNotif >= 100)
            //{
            //    //lbl_NotifCounter.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            //    lbl_NotifCounter.Location = new Point(x, y);
            //    lbl_NotifCounter.Text = "99+";
            //}
            if (toggleNotif >= 10)
            {
                lbl_NotifCounter.Font = new Font("Century Gothic", 8, FontStyle.Bold);
                lbl_NotifCounter.Location = new Point(x-3, y);
                //lbl_NotifCounter.Text = "9+";
                lbl_NotifCounter.Text = toggleNotif.ToString();
            }
            else
            {
                lbl_NotifCounter.Text = toggleNotif.ToString();
            }

            Frm_Dashboard.GetInstance().TopLevel = false;
            Frm_Dashboard.GetInstance().Dock = DockStyle.Fill;
            mainPanel.Controls.Add(Frm_Dashboard.GetInstance());
            Frm_Dashboard.GetInstance().Show();
        }

        private void btn_SideBar_Click(object sender, EventArgs e)
        {
            toggleSideBar++;
            var adjust = 55;

            if (toggleSideBar % 2 == 0)
            {
                pnl_SideBar.Size = new System.Drawing.Size(adjust, 691);
            }
            else
                pnl_SideBar.Size = new System.Drawing.Size(250, 691);
        }

        private void lbl_NotificationCounter_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Notifications_Click(object sender, EventArgs e)
        {
            toggleNotif--;
            var x = 759;
            var y = 8;
            if (toggleNotif < 10)
            {
                lbl_NotifCounter.Font = new Font("Century Gothic", 10, FontStyle.Bold);
                lbl_NotifCounter.Location = new Point(x, y);
            }
            lbl_NotifCounter.Text = toggleNotif.ToString();
        }
    }
}
