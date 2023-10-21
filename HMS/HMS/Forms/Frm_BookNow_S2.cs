using Guna.UI2.WinForms;
using HMS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public int roomType { get; set; }
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
            Constant.GetInstance().GetRoomType();

            cbBox_roomType.SelectedIndex = roomType;
        }

        private void cbBox_roomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayRooms();

            switch (cbBox_roomType.SelectedIndex)
            {
                case 0:
                        roomType = cbBox_roomType.SelectedIndex;
                    break;
                case 1:
                        roomType = cbBox_roomType.SelectedIndex;
                    break;
                case 2:
                        roomType = cbBox_roomType.SelectedIndex;
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
            this.Hide();
            Frm_BookNow_S3.GetInstance().Show();
        }
        private void DisplayRooms()
        {
            Constant.GetInstance().RoomType_selectedIndex = cbBox_roomType.SelectedIndex; // Set the selectedIndex immediately.
            Constant.GetInstance().GetRoomType(); //Call this function to re-initialize the new values.

            if (cbBox_roomType.SelectedIndex == 0)
            {
                pnl_roompicture.BackgroundImage = Constant.GetInstance().DeluxeKing;
                lbl_roomType.Text = Constant.GetInstance().RoomType;
                lbl_roomDetails1.Text = Constant.GetInstance().RoomDetails;
                lbl_roomPrice.Text = Constant.GetInstance().RoomPrice;
                lbl_priceDetails.Text = Constant.GetInstance().PriceDetails;
            }
            if (cbBox_roomType.SelectedIndex == 1)
            {
                pnl_roompicture.BackgroundImage = Constant.GetInstance().PreimeireDeluxe;
                lbl_roomType.Text = Constant.GetInstance().RoomType;
                lbl_roomDetails1.Text = Constant.GetInstance().RoomDetails;
                lbl_roomPrice.Text = Constant.GetInstance().RoomPrice;
                lbl_priceDetails.Text = Constant.GetInstance().PriceDetails;
            }
            if (cbBox_roomType.SelectedIndex == 2)
            {
                pnl_roompicture.BackgroundImage = Constant.GetInstance().FiliSuite;
                lbl_roomType.Text = Constant.GetInstance().RoomType;
                lbl_roomDetails1.Text = Constant.GetInstance().RoomDetails;
                lbl_roomPrice.Text = Constant.GetInstance().RoomPrice;
                lbl_priceDetails.Text = Constant.GetInstance().PriceDetails;
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

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer_pbar_Tick(object sender, EventArgs e)
        {

        }
    }
}
