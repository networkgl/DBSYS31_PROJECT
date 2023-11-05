using Guna.UI2.WinForms;
using HMS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace HMS
{
    public partial class Frm_BookNow_S2 : Form
    {
        private Frm_BookNow_S1 s1;

        public int RoomType { get; set; }
        public static int RoomPrice { get; set; }
        public Frm_BookNow_S2()
        {
            InitializeComponent();
        }
        public Frm_BookNow_S2(Frm_BookNow_S1 s1)
        {
            InitializeComponent();
            this.s1 = s1;
            //this.s2 = s2;
        }
        private void llb_moreInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //MoreInfo_S1 s1 = new MoreInfo_S1();
            //s1.ShowDialog();
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
        //public static Frm_BookNow_S2 GetInstance()
        //{
        //    if (s2 == null)
        //        s2 = new Frm_BookNow_S2();
        //    return s2;
        //}
        private void Frm_BookNow_S2_Load(object sender, EventArgs e)
        {
            CurrentDate.Start();
            UpdateDateTime();

            Room.GetRoomType();

            cbBox_roomType.SelectedIndex = RoomType;

            //frmS1 = Frm_BookNow_S1.GetInstance();
            //Console.WriteLine(frmS1.Guest);
            //Console.WriteLine(frmS1.CheckIn);
            //Console.WriteLine(frmS1.CheckOut);   
            //Console.WriteLine();
            //Console.WriteLine("S2: " + Frm_BookNow_S1.GetInstance().CheckIn);
            //Console.WriteLine("S2: " +Frm_BookNow_S1.GetInstance().CheckOut);
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
        private void cbBox_roomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayRooms();

            switch (cbBox_roomType.SelectedIndex)
            {
                case 0:
                        RoomType = cbBox_roomType.SelectedIndex;
                    break;
                case 1:
                        RoomType = cbBox_roomType.SelectedIndex;
                    break;
                case 2:
                        RoomType = cbBox_roomType.SelectedIndex;
                    break;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            s1.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_BookNow_S3 s3 = new Frm_BookNow_S3(s1, this);
            s3.Show();
        }
        private void DisplayRooms()
        {
            Room.RoomType_selectedIndex = cbBox_roomType.SelectedIndex; // Set the selectedIndex immediately.
            Room.GetRoomType(); //Call this function to re-initialize the new values.

            switch (cbBox_roomType.SelectedIndex)
            {
                case 0:
                    pnl_roompicture.BackgroundImage = Room.DeluxeKing;
                    break;
                case 1:
                    pnl_roompicture.BackgroundImage = Room.PreimeireDeluxe;
                    break;
                case 2:
                    pnl_roompicture.BackgroundImage = Room.FiliSuite;
                    break;
            }
            lbl_roomType.Text = Room.RoomType;
            lbl_roomDetails1.Text = Room.RoomDetails;
            lbl_roomPrice.Text = Room.RoomPrice;
            lbl_priceDetails.Text = Room.PriceDetails;

        }
    }
}
