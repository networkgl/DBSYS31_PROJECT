using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Forms
{
    public partial class Frm_ChangeRoomDetails : Form
    {
        private string roomType, roomDetails;
        private decimal roomPrice;
        private string roomDiscount;
        private Frm_ViewRoomAvailable frm;
        private int? roomID;
        private Image image;
        private decimal discountedPrice;
        private static bool confirmUpdate;
        private bool hasEditted;
        private AdminRepository adminRepo;

        public static bool ConfirmUpdate { get => confirmUpdate; set => confirmUpdate = value; }

        public Frm_ChangeRoomDetails(int? roomID, string roomType, string roomDetails, decimal roomPrice, string roomDiscount, Image image)//decimal discountedPrice
        {

            InitializeComponent();
            adminRepo = new AdminRepository();

            this.roomID = roomID;
            this.roomType = roomType;
            this.roomDetails = roomDetails;
            this.roomPrice = roomPrice;
            this.roomDiscount = roomDiscount;
            //this.discountedPrice = discountedPrice;
            this.image = image;

            Frm_Main.LastActivity = "Updating a records of rooms from the database";
        }

        private void Frm_ChangeRoomDetails_Load(object sender, EventArgs e)
        {
            pcBox_Room.BackgroundImage = image;
            pcBox_Room.BackgroundImageLayout = ImageLayout.Stretch; // Set the background layout to None

            txtboxRoomType.Text = roomType;
            txtboxRoomDetails.Text = roomDetails;
            txtboxRoomPrice.Text = roomPrice.ToString();
            txtboxRoomDiscount.Text = GetDiscountByNumber(roomDiscount);

        }
        private string GetDiscountByNumber(string input)
        {
            var temp = string.Empty;

            foreach (char a in input)
            {
                if (a != '%')
                {
                    temp += a;
                }
            }
            return temp;
        }
        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            String response = String.Empty;
            //Console.WriteLine(decimal.Parse(GetDiscountByNumber(txtboxRoomDiscount.Text)));
            var getDiscountedPrice = decimal.Parse(txtboxRoomPrice.Text) - ((roomPrice / 100) * decimal.Parse(GetDiscountByNumber(txtboxRoomDiscount.Text)));
           
            Console.WriteLine(getDiscountedPrice);
            
            var retVal = new ErrorCode();

            if (!hasEditted)
            {
                retVal = adminRepo.UpdateRoomDetails_NoPhoto(roomID, txtboxRoomType.Text, txtboxRoomDetails.Text, decimal.Parse(txtboxRoomPrice.Text), decimal.Parse(txtboxRoomDiscount.Text), getDiscountedPrice, ref response);
            }
            else
            {
                retVal = adminRepo.UpdateRoomDetails_WithPhoto(roomID, InsertPhoto(), txtboxRoomType.Text, txtboxRoomDetails.Text, decimal.Parse(txtboxRoomPrice.Text), decimal.Parse(txtboxRoomDiscount.Text), getDiscountedPrice, ref response);
            }


            if (retVal == ErrorCode.Success)
            {

                MessageDialog.Show(response, "Message", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Light);
                this.Close();

                confirmUpdate = true;
                Frm_ViewRoomAvailable.Frm.LoadDataGrid();
                confirmUpdate = false;
            }
            else
            {
                MessageDialog.Show(response, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Light);
            }
        }
        private byte[] InsertPhoto()
        {
            MemoryStream stream = new MemoryStream();
            pcBox_Room.Image.Save(stream, pcBox_Room.Image.RawFormat);
            return stream.GetBuffer();
        }

        private void btnEditPhoto_Click(object sender, EventArgs e)
        {
            SelectPhoto();
        }
        private void SelectPhoto()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif|All files (*.*)|*.*";
                openFileDialog.Title = "Select Photos";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    // Remove the previous image (set to null)
                    pcBox_Room.BackgroundImage = null;

                    // Load and assign the new image
                    Image newImage = System.Drawing.Image.FromFile(selectedFilePath);
                    pcBox_Room.Image = newImage;

                    pcBox_Room.SizeMode = PictureBoxSizeMode.StretchImage;

                    hasEditted = true;
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();
            int radius = 20; // Adjust the radius for more or less rounding
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
            path.AddArc(rect.X + rect.Width - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
            path.AddArc(rect.X + rect.Width - radius * 2, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 90, 90);

            this.Region = new Region(path);

            using (Pen pen = new Pen(Color.Transparent, 2))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}
