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
        private int getSelectedGuest, getSelectedTime_CheckIn, getSelectedTime_CheckOut, getSelected_CheckIn_AM_PM, getSelected_CheckOut_AM_PM;
        string checkIn,checkOut;
        private int roomType = 0;
        private string fname, lname, email, address;
        private long phone;
        public Frm_BookNow_S2()
        {
            InitializeComponent();
        }
        public Frm_BookNow_S2(int getSelectedGuest, string checkIn, string checkOut, int getSelectedTime_CheckIn, int getSelectedTime_CheckOut, int getSelected_CheckIn_AM_PM, int getSelected_CheckOut_AM_PM, int roomType,
                                string fname, string lname, string email, long phone, string address)
        {
            InitializeComponent();
            this.getSelectedGuest = getSelectedGuest;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.getSelectedTime_CheckIn = getSelectedTime_CheckIn;
            this.getSelectedTime_CheckOut = getSelectedTime_CheckOut;
            this.getSelected_CheckIn_AM_PM = getSelected_CheckIn_AM_PM;
            this.getSelected_CheckOut_AM_PM = getSelected_CheckOut_AM_PM;

            this.roomType = roomType;

            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.phone = phone;
            this.address = address;
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
        private void Frm_BookNow_S2_Load(object sender, EventArgs e)
        {
            Constant.RoomType(); // Call the method to set initial values

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
            var s1 = new Frm_BookNow_S1(getSelectedGuest,checkIn,checkOut, getSelectedTime_CheckIn, getSelectedTime_CheckOut, getSelected_CheckIn_AM_PM, getSelected_CheckOut_AM_PM, roomType, fname, lname, email, phone, address);
            s1.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            var s3 = new Frm_BookNow_S3(getSelectedGuest, checkIn, checkOut, getSelectedTime_CheckIn, getSelectedTime_CheckOut, getSelected_CheckIn_AM_PM, getSelected_CheckOut_AM_PM, roomType, fname, lname, email, phone, address);
            s3.Show();
        }
        private void DisplayRooms()
        {
            if (cbBox_roomType.SelectedIndex == 0)
            {
                Constant.selectedIndex = cbBox_roomType.SelectedIndex; // Set the selectedIndex immediately

                Constant.RoomType(); //Re initialize the Constant Class to Refresh Values

                pnl_roompicture.BackgroundImage = Constant.deluxeKing;
                lbl_roomType.Text = Constant.roomtype;
                lbl_roomDetails1.Text = Constant.roomDetails_1;
                lbl_roomPrice.Text = Constant.roomPrice;
                lbl_priceDetails.Text = Constant.priceDetails;
            }
            if (cbBox_roomType.SelectedIndex == 1)
            {
                Constant.selectedIndex = cbBox_roomType.SelectedIndex; // Set the selectedIndex immediately

                Constant.RoomType(); //Re initialize the Constant Class to Refresh Values

                pnl_roompicture.BackgroundImage = Constant.preimeireDeluxe;
                lbl_roomType.Text = Constant.roomtype;
                lbl_roomDetails1.Text = Constant.roomDetails_1;
                lbl_roomPrice.Text = Constant.roomPrice;
                lbl_priceDetails.Text = Constant.priceDetails;
            }
            if (cbBox_roomType.SelectedIndex == 2)
            {
                Constant.selectedIndex = cbBox_roomType.SelectedIndex; // Set the selectedIndex immediately

                Constant.RoomType(); //Re initialize the Constant Class to Refresh Values

                pnl_roompicture.BackgroundImage = Constant.filiSuite;
                lbl_roomType.Text = Constant.roomtype;
                lbl_roomDetails1.Text = Constant.roomDetails_1;
                lbl_roomPrice.Text = Constant.roomPrice;
                lbl_priceDetails.Text = Constant.priceDetails;
            }
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer_pbar_Tick(object sender, EventArgs e)
        {

        }
    }
}
