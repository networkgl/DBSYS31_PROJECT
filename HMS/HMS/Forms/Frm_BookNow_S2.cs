using Guna.UI2.WinForms;
using HMS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Interop;
namespace HMS
{
    public partial class Frm_BookNow_S2 : Form
    {
        private Frm_BookNow_S1 s1;
        private Frm_BookNow_S2 s2;
        private Frm_BookNow_S3 s3;
        private AdminRepository adminRepo;
        private int currentIndex;
        private int roomType = 0;
        private decimal roomPrice;
        private string finalRoomType;

        private UserRepository userRepo;
        public decimal RoomPrice
        {
            get { return roomPrice; }
            set { roomPrice = value; }
        }
        public int RoomType 
        {
            get { return roomType; } 
            set { roomType = value; }
        }
        public string FinalRoomType
        {
            get { return finalRoomType; }
            set { finalRoomType = value; }
        }
        public Frm_BookNow_S2()
        {
            InitializeComponent();
            adminRepo = new AdminRepository();
            userRepo = new UserRepository();
        }
        public Frm_BookNow_S2(Frm_BookNow_S1 s1, Frm_BookNow_S2 s2, Frm_BookNow_S3 s3)
        {
            InitializeComponent();
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
            //this.s4 = s4;

            adminRepo = new AdminRepository();
            userRepo = new UserRepository();

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

            InitialLoad();
            
            //Room.GetRoomType();

            if (s2 == null)
            {
                cbBox_roomType.SelectedIndex = roomType;
            }
            else
            {
                cbBox_roomType.SelectedIndex = s2.RoomType;
            }
        }

        private void CurrentDate_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        public void UpdateDateTime()
        {
            var currentDateTime = DateTime.Now;
            var culture = new CultureInfo("en-PH"); // Specify the desired culture
            lbl_SystemTime.Text = currentDateTime.ToString("yyyy-MM-dd  hh:mm:ss tt", culture);

        }
        private void InitialLoad()
        {
            String response = String.Empty;
            var retValRows = adminRepo.GetRoomTypeByID(ref response);

            if (retValRows == ErrorCode.Success)
            {
                cbBox_roomType.Items.Clear();
                foreach (var i in adminRepo.RoomType)
                {
                    cbBox_roomType.Items.Add(i);
                }

                cbBox_roomType.SelectedIndex = 0;

                if (AdminRepository._RoomDiscount > 0)
                {
                    //Meaning there is a possible disount percentage.
                    lbl_percentSale.Text = AdminRepository._RoomDiscount.ToString() + "% OFF";
                    lbl_OrigPrice.Text = AdminRepository._RoomPrice.ToString("C2");
                    //Set to visible
                    pnl_saleDetails.Visible = true;
                    pnl_saleLogo.Visible = true;
                }
                else
                {
                    pnl_saleDetails.Visible = false;
                    pnl_saleLogo.Visible = false;
                }
                cbBox_roomType.SelectedIndex = roomType;

            }
            else
            {
                //MessageDialog.Show(response, "Message", MessageDialogButtons.OK, MessageDialogIcon.Question, MessageDialogStyle.Light);
            }

            pnl_roompicture.BackgroundImage = adminRepo.Image;
            lbl_roomType.Text = adminRepo._RoomType;
            lbl_roomDetails1.Text = adminRepo._RoomDetails;
            lbl_roomPrice.Text = adminRepo._DiscountedPrice.ToString("C2");


            //Store this values and use it later for storing into the database.
            roomPrice = adminRepo._DiscountedPrice;
            finalRoomType = adminRepo._RoomType;


            var message = String.Empty;
            RoomAvailable currentTotalRoom = RoomAvailable.MIN;//this is equivalent assigning zero to this variable
            var retVal = userRepo.GetRoomStatus(FinalRoomType, ref currentTotalRoom, ref message);

            if (currentTotalRoom == RoomAvailable.MAX)
            {
                lbl_roomLeft.Text = "FULLY BOOKED";
                btnNext.BackColor = Color.Gray;
                btnNext.Enabled = false;
            }
            else
            {
                lbl_roomLeft.Text = "Vacant Room: " + ((int)(RoomAvailable.MAX - currentTotalRoom)).ToString();
                btnNext.Enabled = true;
                btnNext.BackColor = Color.FromArgb(46, 134, 222);
                lbl_roomLeft.ForeColor = Color.RoyalBlue;
            }
        }
        private void cbBox_roomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < adminRepo.LastPrimaryKeyValue; i++)
            {
                if (cbBox_roomType.SelectedIndex == i)
                {
                    currentIndex = i;
                    break;
                }
            }
            roomType = currentIndex;

            String response = String.Empty;
            var retVal = adminRepo.GetRoomDetails(currentIndex, ref response);

            Thread.Sleep(500);
            if (retVal == ErrorCode.Success)
            {
                pnl_roompicture.BackgroundImage = adminRepo.Image;

                if (AdminRepository._RoomDiscount > 0)
                {
                    //Meaning there is a possible disount percentage.
                    lbl_percentSale.Text = AdminRepository._RoomDiscount.ToString() + "% OFF";
                    lbl_OrigPrice.Text = AdminRepository._RoomPrice.ToString("C2");
                    //Set to visible
                    pnl_saleDetails.Visible = true;
                    pnl_saleLogo.Visible = true;
                }
                else
                {
                    pnl_saleDetails.Visible = false;
                    pnl_saleLogo.Visible = false;
                }
            }
            else
            {
                MessageDialog.Show(response, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Error, MessageDialogStyle.Dark);
            }

            //String response = String.Empty;
            //var retVal = adminRepo.GetRoomDetails(currentIndex, ref response);

            //Thread.Sleep(500);
            //if (retVal == ErrorCode.Success)
            //{
            //    //MessageDialog.Show(response, "Message", MessageDialogButtons.OK, MessageDialogIcon.Question, MessageDialogStyle.Light);
            //    pnl_roompicture.BackgroundImage = adminRepo.Image;
            //}
            //else
            //{
            //    MessageDialog.Show(response, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Error, MessageDialogStyle.Light);
            //}

            //This should place below to prevent delay.
            lbl_roomType.Text = adminRepo._RoomType;
            lbl_roomDetails1.Text = adminRepo._RoomDetails;
            lbl_roomPrice.Text = adminRepo._DiscountedPrice.ToString("C2");
            var price = adminRepo._DiscountedPrice.ToString("C2");

            lbl_priceDetails.Text = $"Per Night\r\n {price} Total for 1 night\r\nExcluding Taxes & Fees";


            //Store this values and use it later for storing into the database.
            roomPrice = adminRepo._DiscountedPrice;
            finalRoomType = adminRepo._RoomType;



            var message = String.Empty;
            RoomAvailable currentTotalRoom = RoomAvailable.MIN;//this is equivalent assigning zero to this variable
            retVal = userRepo.GetRoomStatus(FinalRoomType, ref currentTotalRoom, ref message);
            if (currentTotalRoom == RoomAvailable.MAX)
            {
                lbl_roomLeft.Text = "FULLY BOOKED";
                lbl_roomLeft.ForeColor = Color.Red;
                btnNext.BackColor = Color.Gray;
                btnNext.Enabled = false;
            }
            else
            {
                lbl_roomLeft.Text = "Vacant Room: " + ((int)(RoomAvailable.MAX - currentTotalRoom)).ToString();
                btnNext.Enabled = true;
                btnNext.BackColor = Color.FromArgb(46, 134, 222);
                lbl_roomLeft.ForeColor = Color.RoyalBlue;
            }
            //lbl_roomLeft.Text = "Room Vacant: " + ((int)(RoomAvailable.MAX - currentTotalRoom)).ToString();
        }

        private static Frm_BookNow_S2 s22;
        public static Frm_BookNow_S2 GetInstance
        {
            get { return s22; }
            set { s22 = value; }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (Frm_ProcessPayment.HasPaid)
            {
                Frm_BookNow_S1 s1 = new Frm_BookNow_S1();
                s1.Show();
            }
            else
            {
                s1 = new Frm_BookNow_S1(this.s1,this, this.s3);
                s1.Show();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var msg = "Sorry, the selected room type is fully book\n" +
                "Please select another one.";
            //Check first if roomtype is fullybook or not.
            var message = String.Empty;
            RoomAvailable currentTotalRoom = RoomAvailable.MIN;//this is equivalent to zero variable
            var retVal = userRepo.GetRoomStatus(FinalRoomType, ref currentTotalRoom, ref message);

            if (retVal == ErrorCode.Success)//if successfully query
            {
                if (currentTotalRoom == RoomAvailable.MAX)//if fullybook then prompt user that specific roomtype is fullybook
                {
                    MessageDialog.Show(msg, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
                    return;// Simply return it directly to stop executing the other statement.
                }
            }


            s22 = this;
            this.Hide();
            if (s3 == null)
            {
                Frm_BookNow_S3 s3 = new Frm_BookNow_S3(this.s1, this, this.s3);
                s3.Show();
            }
            else
            {
                s3.Show();
            }
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
