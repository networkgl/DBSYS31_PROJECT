using Guna.UI2.WinForms;
using HMS.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace HMS.Forms
{
    public partial class Frm_ViewCurrentRooms : Form
    {
        private HMSEntities db;
        private AdminRepository adminRepo;
        private static int currentIndex;
        //private static bool noRooms;
        public static int CurrentIndex { get => currentIndex; set => currentIndex = value; }
        //public static bool NoRooms { get => noRooms; set => noRooms = value; }

        //private int lastPrimaryKeyValue = 0;
        private UserRepository userRepo;


        public Frm_ViewCurrentRooms()
        {
            InitializeComponent();
            db = new HMSEntities();
            adminRepo = new AdminRepository();
            CurrentIndex = adminRepo.LastPrimaryKeyValue;
            userRepo = new UserRepository();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ViewCurrentRooms_Load(object sender, EventArgs e)
        {

           InitialLoad();
        }
        //private Image GetImageFromDatabase(byte[] img)
        //{
        //    MemoryStream stream = new MemoryStream(img);
            
        //    return Image.FromStream(stream);
        //}
        public void InitialLoad()
        {
            btnRoomDisplay.Enabled = false;

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
                    lbl_percentSale.Text = AdminRepository._RoomDiscount.ToString() +"% OFF";
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
                MessageDialog.Show(response, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
            }

            pnl_roompicture.BackgroundImage = adminRepo.Image;
            lbl_roomType.Text = adminRepo._RoomType;
            lbl_roomDetails1.Text = adminRepo._RoomDetails;
            lbl_roomPrice.Text = adminRepo._DiscountedPrice.ToString("C2");


            var message = String.Empty;
            RoomAvailable currentTotalRoom = RoomAvailable.MIN;//this is equivalent assigning zero to this variable
            var retVal = userRepo.GetRoomStatus(adminRepo._RoomType, ref currentTotalRoom, ref message);
            if (currentTotalRoom == RoomAvailable.MAX)
            {
                lbl_roomLeft.Text = "FULLY BOOKED";
                lbl_roomLeft.ForeColor = Color.Red;
                //btnNext.BackColor = Color.Gray;
                //btnNext.Enabled = false;
            }
            else
            {
                lbl_roomLeft.Text = "Vacant Room: " + ((int)(RoomAvailable.MAX - currentTotalRoom)).ToString();
                //btnNext.Enabled = true;
                //btnNext.BackColor = Color.FromArgb(100, 88, 255);
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

            //Call this function to display the discounted price if there is.
            DisplayRoomDiscount(currentIndex);


            //This should place below to prevent delay.
            lbl_roomType.Text = adminRepo._RoomType;
            lbl_roomDetails1.Text = adminRepo._RoomDetails;
            lbl_roomPrice.Text = adminRepo._DiscountedPrice.ToString("C2");
            var price = adminRepo._DiscountedPrice.ToString("C2");

            lbl_priceDetails.Text = $"Per Night\r\n {price} Total for 1 night\r\nExcluding Taxes & Fees";



            var message = String.Empty;
            RoomAvailable currentTotalRoom = RoomAvailable.MIN;//this is equivalent assigning zero to this variable
            var retVal = userRepo.GetRoomStatus(adminRepo._RoomType, ref currentTotalRoom, ref message);
            if (currentTotalRoom == RoomAvailable.MAX)
            {
                lbl_roomLeft.Text = "FULLY BOOKED";
                lbl_roomLeft.ForeColor = Color.Red;
                //btnNext.BackColor = Color.Gray;
                //btnNext.Enabled = false;
            }
            else
            {
                lbl_roomLeft.Text = "Vacant Room: " + ((int)(RoomAvailable.MAX - currentTotalRoom)).ToString();
                //btnNext.Enabled = true;
                //btnNext.BackColor = Color.FromArgb(100, 88, 255);
                lbl_roomLeft.ForeColor = Color.RoyalBlue;
            }
        }
        public void DisplayRoomDiscount(int index)
        {
            String response = String.Empty;
            var retVal = adminRepo.GetRoomDetails(index, ref response);

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
        }
        private void btnAddRooms_Click(object sender, EventArgs e)
        {
            Frm_Main.GetInstanceClass.pnl_main.Controls.Clear();
            Frm_AddRooms vcr = new Frm_AddRooms();
            vcr.TopLevel = false;
            vcr.Dock = DockStyle.Fill;
            Frm_Main.GetInstanceClass.pnl_main.Controls.Add(vcr);
            vcr.Show();
        }

        private void btnUpdateDeleteRooms_Click(object sender, EventArgs e)
        {
            Frm_Main.GetInstanceClass.pnl_main.Controls.Clear();
            Frm_ViewRoomAvailable vcr = new Frm_ViewRoomAvailable();
            vcr.TopLevel = false;
            vcr.Dock = DockStyle.Fill;
            Frm_Main.GetInstanceClass.pnl_main.Controls.Add(vcr);
            vcr.Show();
        }

        private void lbl_OrigPrice_Click(object sender, EventArgs e)
        {

        }


        /*
        public byte[] GetPhotoByIndex(int selectedIndex)
        {
            string response = String.Empty;
            // re-initialize db object because sometimes data in the list not updated
            using (db = new HMSEntities())
            {
                // SELECT TOP 1 * FROM USERACCOUNT WHERE userName == username
                //return db.UserAccount.Where(s => s.userName == username).FirstOrDefault();
                //return db.
            }


            var retValIndex = adminRepo.GetPhotoByIndex(currentIndex, ref response);
            Thread.Sleep(500);
            if (retValIndex == ErrorCode.Success)
            {
                MessageDialog.Show(response, "Message", MessageDialogButtons.OK, MessageDialogIcon.Question, MessageDialogStyle.Light);
            }
            else
            {
                MessageDialog.Show(response, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Question, MessageDialogStyle.Light);
            }

        }*/
    }
}
