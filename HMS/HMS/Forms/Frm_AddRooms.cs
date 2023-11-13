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
    public partial class Frm_AddRooms : Form
    {
        private HMSEntities db;
        private AdminRepository adminRepo;
        public string RoomType { get; set; }
        public string RoomDetails { get; set; }
        public double RoomPrice{ get; set; }
        public int RoomDiscount { get; set; }
        public Image RoomPhoto { get; set; }

        public Frm_AddRooms()
        {
            InitializeComponent();
            db = new HMSEntities();
            adminRepo = new AdminRepository();
        }
        private void Frm_AddRooms_Load(object sender, EventArgs e)
        {
            btnAddRooms.Enabled = false;
        }
        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            var message = "Required";
            var msg = "Please select photo before saving";

            if (txtboxRoomType.Text.Equals(string.Empty))
            {
                errorProvider.SetError(txtboxRoomType, message);
                return;
            }
            if (txtboxRoomDetails.Text.Equals(string.Empty))
            {
                errorProvider.SetError(txtboxRoomDetails, message);
                return;
            }
            if (pcBox_Room.Image == null)
            {
                MessageDialog.Show(msg, "Message", MessageDialogButtons.OK, MessageDialogIcon.Warning, MessageDialogStyle.Dark);
                return;
            }


            int lastVal = GetLastPrimaryKeyValue(); //Adding one to manually increment
            var response = String.Empty;

           ErrorCode retVal = adminRepo.InsertRoomDetails(lastVal + 1, txtboxRoomType.Text, InsertPhoto(), txtboxRoomDetails.Text, int.Parse(txtboxRoomPrice.Text), int.Parse(txtboxRoomDiscount.Text), ref response);


            msg = "Are you sure all information to be added is correct ?";
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
        private int GetLastPrimaryKeyValue()
        {
            using (db = new HMSEntities())
            {
                // Use the Max function directly without a Where clause
                int? lastPrimaryKeyValue = db.ROOM_DETAILS.Max(n => (int?)n.roomID);

                // If there are no records in the table, handle the case accordingly
                return lastPrimaryKeyValue ?? 0; // Return 0 default value if no records
            }
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

        private void btnRoomDisplay_Click(object sender, EventArgs e)
        {
            Frm_Main.GetInstanceClass.pnl_main.Controls.Clear();
            Frm_ViewCurrentRooms vcr = new Frm_ViewCurrentRooms();
            vcr.TopLevel = false;
            vcr.Dock = DockStyle.Fill;
            Frm_Main.GetInstanceClass.pnl_main.Controls.Add(vcr);
            vcr.Show();
        }

        private void btnUpdateDeleteRooms_Click(object sender, EventArgs e)
        {
            Frm_Main.GetInstanceClass.pnl_main.Controls.Clear();
            Frm_ViewRoomAvailable udr = new Frm_ViewRoomAvailable();
            udr.TopLevel = false;
            udr.Dock = DockStyle.Fill;
            Frm_Main.GetInstanceClass.pnl_main.Controls.Add(udr);
            udr.Show();
        }

        private void txtboxRoomPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            var msg = String.Empty;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancel the input if it's not a digit or control character.
                                  //MessageBox.Show("Please enter only a number","Message",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                msg = "Please enter only a number.";
                MessageDialog.Show(msg, "Message", MessageDialogButtons.OK, MessageDialogIcon.Warning, MessageDialogStyle.Light);
            }
        }

        private void txtboxRoomDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            var msg = String.Empty;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancel the input if it's not a digit or control character.
                                  //MessageBox.Show("Please enter only a number","Message",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                msg = "Please enter only a number.";
                MessageDialog.Show(msg, "Message", MessageDialogButtons.OK, MessageDialogIcon.Warning, MessageDialogStyle.Light);
            }
        }
    }
}
