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
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace HMS.Forms
{
    public partial class Frm_ViewCurrentRooms : Form
    {
        private HMSEntities db;
        private AdminRepository adminRepo;
        private static int currentIndex;

        public static int CurrentIndex { get => currentIndex; set => currentIndex = value; }

        //private int lastPrimaryKeyValue = 0;


        public Frm_ViewCurrentRooms()
        {
            InitializeComponent();
            db = new HMSEntities();
            adminRepo = new AdminRepository();
            CurrentIndex = adminRepo.LastPrimaryKeyValue;
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
        private void InitialLoad()
        {
            btnRoomDisplay.Enabled = false;

            //lbl_roomType.Text = adminRepo._RoomType;
            //lbl_roomDetails1.Text = adminRepo._RoomDetails;
            //lbl_roomPrice.Text += adminRepo._RoomPrice.ToString();

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
                Console.WriteLine(CurrentIndex);
            }
            else
            {
                MessageDialog.Show(response, "Message", MessageDialogButtons.OK, MessageDialogIcon.Question, MessageDialogStyle.Light);
            }

            pnl_roompicture.BackgroundImage = adminRepo.Image;
            lbl_roomType.Text = adminRepo._RoomType;
            lbl_roomDetails1.Text = adminRepo._RoomDetails;
            lbl_roomPrice.Text = "₱" + adminRepo._RoomPrice.ToString("#,##0");
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


            String response = String.Empty;
            var retVal = adminRepo.GetRoomDetails(currentIndex, ref response);

            Thread.Sleep(500);
            if (retVal == ErrorCode.Success)
            {
                pnl_roompicture.BackgroundImage = adminRepo.Image;
            }
            else
            {
                MessageDialog.Show(response, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Error, MessageDialogStyle.Light);
            }

            //This should place below to prevent delay.
            lbl_roomType.Text = adminRepo._RoomType;
            lbl_roomDetails1.Text = adminRepo._RoomDetails;
            lbl_roomPrice.Text = "₱"+adminRepo._RoomPrice.ToString("#,##0");
            var price = adminRepo._RoomPrice.ToString("#,##0");

            lbl_priceDetails.Text = $"Per Night\r\n ₱{price} Total for 1 night\r\nExcluding Taxes & Fees";
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

        private void pnl_Main_Paint(object sender, PaintEventArgs e)
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
