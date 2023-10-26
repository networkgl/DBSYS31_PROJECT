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
        public static int RoomType { get; set; }
        public static int RoomPrice { get; set; }
        private static Frm_BookNow_S2 s2;
        private Frm_BookNow_S2()
        {
            InitializeComponent();
        }

        private void llb_moreInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MoreInfo_S1 s1 = new MoreInfo_S1();
            s1.ShowDialog();
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
        public static Frm_BookNow_S2 GetInstance()
        {
            if (s2 == null)
                s2 = new Frm_BookNow_S2();
            return s2;
        }
        private void Frm_BookNow_S2_Load(object sender, EventArgs e)
        {
            CurrentDate.Start();
            UpdateDateTime();

            Constant.GetRoomType();

            cbBox_roomType.SelectedIndex = RoomType;
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
            Frm_BookNow_S1.GetInstance().Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Frm_Confirmation.GetInstance().price = RoomPrice.ToString();
            //Frm_Confirmation fc = new Frm_Confirmation();
            //fc.price = RoomPrice.ToString();

            this.Hide();
            Frm_BookNow_S3.GetInstance().Show();
        }
        private void DisplayRooms()
        {
            Constant.RoomType_selectedIndex = cbBox_roomType.SelectedIndex; // Set the selectedIndex immediately.
            Constant.GetRoomType(); //Call this function to re-initialize the new values.

            if (cbBox_roomType.SelectedIndex == 0)
            {
                pnl_roompicture.BackgroundImage = Constant.DeluxeKing;
                lbl_roomType.Text = Constant.RoomType;
                lbl_roomDetails1.Text = Constant.RoomDetails;
                lbl_roomPrice.Text = Constant.RoomPrice;
                lbl_priceDetails.Text = Constant.PriceDetails;
            }
            if (cbBox_roomType.SelectedIndex == 1)
            {
                pnl_roompicture.BackgroundImage = Constant.PreimeireDeluxe;
                lbl_roomType.Text = Constant.RoomType;
                lbl_roomDetails1.Text = Constant.RoomDetails;
                lbl_roomPrice.Text = Constant.RoomPrice;
                lbl_priceDetails.Text = Constant.PriceDetails;
            }
            if (cbBox_roomType.SelectedIndex == 2)
            {   
                pnl_roompicture.BackgroundImage = Constant.FiliSuite;
                lbl_roomType.Text = Constant.RoomType;
                lbl_roomDetails1.Text = Constant.RoomDetails;
                lbl_roomPrice.Text = Constant.RoomPrice;
                lbl_priceDetails.Text = Constant.PriceDetails;
            }
        }
        //private void DisplayRooms()
        //{
        //    if (cbBox_roomType.SelectedIndex == 0)
        //    {
        //        Constant.GetInstance().selectedIndex = cbBox_roomType.SelectedIndex; // Set the selectedIndex immediately

        //        Constant.GetInstance().RoomType(); // Call the method to set initial values

        //        pnl_roompicture.BackgroundImage = Constant.GetInstance().deluxeKing;
        //        lbl_roomType.Text = Constant.GetInstance().roomtype;
        //        lbl_roomDetails1.Text = Constant.GetInstance().roomDetails_1;
        //        lbl_roomPrice.Text = Constant.GetInstance().roomPrice;
        //        lbl_priceDetails.Text = Constant.GetInstance().priceDetails;
        //    }
        //    if (cbBox_roomType.SelectedIndex == 1)
        //    {
        //        Constant.GetInstance().selectedIndex = cbBox_roomType.SelectedIndex; // Set the selectedIndex immediately

        //        Constant.GetInstance().RoomType(); // Call the method to set initial values

        //        pnl_roompicture.BackgroundImage = Constant.GetInstance().preimeireDeluxe;
        //        lbl_roomType.Text = Constant.GetInstance().roomtype;
        //        lbl_roomDetails1.Text = Constant.GetInstance().roomDetails_1;
        //        lbl_roomPrice.Text = Constant.GetInstance().roomPrice;
        //        lbl_priceDetails.Text = Constant.GetInstance().priceDetails;
        //    }
        //    if (cbBox_roomType.SelectedIndex == 2)
        //    {
        //        Constant.GetInstance().selectedIndex = cbBox_roomType.SelectedIndex; // Set the selectedIndex immediately

        //        Constant.GetInstance().RoomType(); // Call the method to set initial values

        //        pnl_roompicture.BackgroundImage = Constant.GetInstance().filiSuite;
        //        lbl_roomType.Text = Constant.GetInstance().roomtype;
        //        lbl_roomDetails1.Text = Constant.GetInstance().roomDetails_1;
        //        lbl_roomPrice.Text = Constant.GetInstance().roomPrice;
        //        lbl_priceDetails.Text = Constant.GetInstance().priceDetails;
        //    }
        //}
    }
}
