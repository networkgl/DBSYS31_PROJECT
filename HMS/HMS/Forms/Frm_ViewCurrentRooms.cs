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

namespace HMS.Forms
{
    public partial class Frm_ViewCurrentRooms : Form
    {
        private HMSEntities db;
        private AdminRepository adminRepo;
        private int currentIndex;
        //private int lastPrimaryKeyValue = 0;


        public Frm_ViewCurrentRooms()
        {
            InitializeComponent();
            db = new HMSEntities();
            adminRepo = new AdminRepository();
            currentIndex = adminRepo.LastPrimaryKeyValue;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ViewCurrentRooms_Load(object sender, EventArgs e)
        {
            String response = String.Empty;
            adminRepo.GetPhotoByIndex(currentIndex);
            pnl_roompicture.BackgroundImage = adminRepo.Image;

            InitialLoad();
        }
        //private Image GetImageFromDatabase(byte[] img)
        //{
        //    MemoryStream stream = new MemoryStream(img);
            
        //    return Image.FromStream(stream);
        //}
        private void InitialLoad()
        {
            String response = String.Empty;
            var retValRows = adminRepo.GetRoomTypeByID(response);
            
            if (retValRows == ErrorCode.Success)
            {
                cbBox_roomType.Items.Clear();
                foreach (var i in adminRepo.RoomType)
                {
                    cbBox_roomType.Items.Add(i);
                }


                Console.WriteLine(currentIndex);

                cbBox_roomType.SelectedIndex = currentIndex;


                //var retValIndex = adminRepo.GetPhotoByIndex(currentIndex, ref response);
                //Thread.Sleep(500);
                //if (retValIndex == ErrorCode.Success)
                //{
                //    MessageDialog.Show(response, "Message", MessageDialogButtons.OK, MessageDialogIcon.Question, MessageDialogStyle.Light);
                //}
                //else
                //{
                //    MessageDialog.Show(response, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Question, MessageDialogStyle.Light);
                //}
            }
            else
            {
                MessageDialog.Show(response, "Message", MessageDialogButtons.OK, MessageDialogIcon.Question, MessageDialogStyle.Light);
            }
        }

        private void cbBox_roomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < adminRepo.LastPrimaryKeyValue; i++)
            {
                if (cbBox_roomType.SelectedIndex == i)
                {
                    currentIndex = cbBox_roomType.SelectedIndex;
                    break;
                }
            }

            //String response = String.Empty;
            //var retVal = adminRepo.CountAllRows(response);
            //Thread.Sleep(500);
            //if (retVal == ErrorCode.Success)
            //{
            //    MessageDialog.Show(response, "Message", MessageDialogButtons.OK, MessageDialogIcon.Question, MessageDialogStyle.Light);
            //}
            //else
            //{
            //    MessageDialog.Show(response, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Question, MessageDialogStyle.Light);
            //}
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
