using Guna.UI2.WinForms;
using HMS.AppData;
using HMS.Forms;
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
using System.Windows.Interop;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HMS
{
    public partial class Frm_ManageRoomType : Form
    {
        private AdminRepository adminRepo;
        private WaitFormFunc waitForm;
        private HMSEntities db;
        public Frm_ManageRoomType()
        {
            InitializeComponent();
            adminRepo = new AdminRepository();
            waitForm = new WaitFormFunc();
            db = new HMSEntities();
        }
        private void btnAddPhotos_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif|All files (*.*)|*.*";
                openFileDialog.Title = "Select Photos";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    Console.WriteLine($"Selected file: {selectedFilePath}");

                    pcBox_Room.Image = System.Drawing.Image.FromFile(selectedFilePath);

                    pcBox_Room.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            int lastVal = GetLastPrimaryKeyValue(); //Adding one to manually increment
            var response = String.Empty;
            ErrorCode retVal = adminRepo.InsertRoomDetails(lastVal + 1, txtboxRoomType.Text, InsertPhoto(), txtboxRoomDetails.Text,int.Parse(txtboxRoomPrice.Text), int.Parse(txtboxRoomDiscount.Text), ref response);

            var msg = "Are you sure all information to be added is correct ?";
            if (MessageDialog.Show(msg, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Question, MessageDialogStyle.Light) == DialogResult.Yes)
            {
                //ExecuteWaitForm();
                Thread.Sleep(500);
                if (retVal == ErrorCode.Success)
                {
                    MessageDialog.Show(response, "Message", MessageDialogButtons.OK, MessageDialogIcon.Question, MessageDialogStyle.Light);
                }
                else
                {
                    MessageDialog.Show(response, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Question, MessageDialogStyle.Light);
                }
            }
        }
        private byte[] InsertPhoto()
        {
            MemoryStream stream = new MemoryStream();
            pcBox_Room.Image.Save(stream, pcBox_Room.Image.RawFormat);
            return stream.GetBuffer();
        }     

        private void btnRoomDisplay_Click(object sender, EventArgs e)
        {
            Frm_ViewCurrentRooms vcr = new Frm_ViewCurrentRooms();
            vcr.ShowDialog();
        }
        private int GetLastPrimaryKeyValue()
        {
            using (HMSEntities db = new HMSEntities())
            {
                // Use the Max function directly without a Where clause
                int? lastPrimaryKeyValue = db.ROOM_DETAILS.Max(n => (int?)n.roomID);

                // If there are no records in the table, handle the case accordingly
                return lastPrimaryKeyValue ?? 0; // Return 0 default value if no records
            }
        }
    }
}
