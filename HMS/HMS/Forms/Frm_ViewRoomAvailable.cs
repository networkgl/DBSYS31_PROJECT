using Guna.UI2.WinForms;
using HMS.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;

namespace HMS.Forms
{
    public partial class Frm_ViewRoomAvailable : Form
    {
        private AdminRepository adminRepo;
        private string roomDetails, roomType;
        private static int? roomID = null;
        private int roomPrice, roomDiscount;
        private static Image image = null;
        private HMSEntities db;
        private static Frm_ViewRoomAvailable frm;

        public static Image Image { get => image; set => image = value; }
        public static int? RoomID { get => roomID; set => roomID = value; }
        public static Frm_ViewRoomAvailable Frm { get => frm; set => frm = value; }

        public Frm_ViewRoomAvailable()
        {
            InitializeComponent();
            adminRepo = new AdminRepository();
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

        private void Frm_UDRoom_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
        public void LoadDataGrid()
        {
            btnUpdateDeleteRooms.Enabled = false;

            if (!Frm_ConfirmDelete.ConfirmDelete && !Frm_ChangeRoomDetails.ConfirmUpdate)
            {
                dgv_roomdetails.DataSource = adminRepo.LoadRoomDetails();

                dgv_roomdetails.Columns["ID"].Width = 20;
                dgv_roomdetails.Columns["Room_Type"].Width = 100;
                dgv_roomdetails.Columns["Price"].Width = 30;
                dgv_roomdetails.Columns["Discount"].Width = 90;


                DataGridViewImageColumn imageColumnUpdate = new DataGridViewImageColumn();
                DataGridViewImageColumn imageColumnDelete = new DataGridViewImageColumn();

                // Add an image column
                imageColumnUpdate.HeaderText = "Edit";
                imageColumnUpdate.Name = "ImageColumnUpdate"; // Use a unique name for the column
                imageColumnUpdate.ImageLayout = DataGridViewImageCellLayout.Normal; // Adjust as needed
                dgv_roomdetails.Columns.Add(imageColumnUpdate);
                dgv_roomdetails.Columns["ImageColumnUpdate"].Width = 40;


                imageColumnDelete.HeaderText = "Delete";
                imageColumnDelete.Name = "ImageColumnDelete"; // Use a unique name for the column
                imageColumnDelete.ImageLayout = DataGridViewImageCellLayout.Normal; // Adjust as needed
                dgv_roomdetails.Columns.Add(imageColumnDelete);
                dgv_roomdetails.Columns["ImageColumnDelete"].Width = 60;
            }
            else
            {
                dgv_roomdetails.DataSource = adminRepo.LoadRoomDetails();
            }
        }
        private void LoadDataGrids()
        {
            btnUpdateDeleteRooms.Enabled = false;
            dgv_roomdetails.DataSource = adminRepo.LoadRoomDetails();

            //dgv_roomdetails.Columns["ID"].Width = 35;
            //dgv_roomdetails.Columns["Room_Type"].Width = 200;
            //dgv_roomdetails.Columns["Price"].Width = 60;
            //dgv_roomdetails.Columns["Discount"].Width = 90;
            //dgv_roomdetails.Columns["ImageColumnUpdate"].Width = 40;
            //dgv_roomdetails.Columns["ImageColumnDelete"].Width = 60;
        }
        private void dgv_roomdetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the column exists
            DataGridViewColumn updateColumn = dgv_roomdetails.Columns["ImageColumnUpdate"];

            if (updateColumn != null && e.ColumnIndex == updateColumn.Index && e.RowIndex >= 0)
            {
                e.Value = Properties.Resources.update1;
                e.FormattingApplied = true;
            }


            DataGridViewColumn deleteColumn = dgv_roomdetails.Columns["ImageColumnDelete"];

            if (deleteColumn != null && e.ColumnIndex == deleteColumn.Index && e.RowIndex >= 0)
            {
                e.Value = Properties.Resources.delete1;
                e.FormattingApplied = true;
            }


        }
        private void dgv_roomdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private Image ResizeImage(Image originalImage, int targetWidth, int targetHeight)
        {
            Bitmap resizedImage = new Bitmap(targetWidth, targetHeight);

            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.DrawImage(originalImage, 0, 0, targetWidth, targetHeight);
            }

            return resizedImage;
        }
        private void dgv_roomdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var msg = "Please select only row cells!";

            if (e.RowIndex == -1)
            {
                MessageDialog.Show(msg, "Message", MessageDialogButtons.OK, MessageDialogIcon.Warning, MessageDialogStyle.Dark); 
                return;
            }

            DataGridViewRow clickedRow = dgv_roomdetails.Rows[e.RowIndex];

            roomID = Convert.ToInt32(clickedRow.Cells["ID"].Value); //Get ID first then pass to the stored procedure.
            Console.WriteLine(roomID);

            if (e.RowIndex >= 0 && e.RowIndex < dgv_roomdetails.Rows.Count)
            {
                string colName = dgv_roomdetails.Columns[e.ColumnIndex].Name;
                if (colName == "ImageColumnUpdate")
                {
                    frm = this; //assign instance and use this to refresh the datagrid when deleting, updating is happen.
                    try
                    {
                        using (db = new HMSEntities())
                        {
                            // Assuming the stored procedure returns an ObjectResult<byte[]>
                            var result = db.sp_get_room_photo_by_index(roomID);
                            byte[] photoBytes = result.First();

                            //Use this to adjust the size of picture and prevent out of memory exception
                            using (MemoryStream stream = new MemoryStream(photoBytes))
                            {
                                Image originalImage = Image.FromStream(stream);

                                // Resize the image to a specific width and height
                                int targetWidth = 600; // Adjust as needed
                                int targetHeight = 600; // Adjust as needed

                                image = ResizeImage(originalImage, targetWidth, targetHeight);
                            }
                        }


                        // Access cell values using column names if possible
                        roomType = Convert.ToString(clickedRow.Cells["Room_Type"].Value);
                        roomDetails = Convert.ToString(clickedRow.Cells["Details"].Value);
                        roomPrice = Convert.ToInt32(clickedRow.Cells["Price"].Value);
                        roomDiscount = Convert.ToInt32(clickedRow.Cells["Discount"].Value);

                        Frm_ChangeRoomDetails crd = new Frm_ChangeRoomDetails(RoomID, roomType, roomDetails, roomPrice, roomDiscount, image);
                        crd.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Exception : {ex.Message}");
                    }
                }
                if (colName == "ImageColumnDelete")
                {                    
                    msg = "Are you sure you want to delete this record ?";
                    bool delete = MessageDialog.Show(msg, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Warning, MessageDialogStyle.Dark) == DialogResult.Yes;
                    if (delete)
                    {
                        frm = this; //assign instance and use this to refresh the datagrid when deleting, updating is happen.
                        Frm_ConfirmDelete cd = new Frm_ConfirmDelete();
                        cd.ShowDialog();
                    }
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





        //private void dgv_roomdetails_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        //{
        //    // Check if it's the header cell of the specific column
        //    if (e.RowIndex == -1 && e.ColumnIndex == dgv_roomdetails.Columns["ID"].Index)
        //    {
        //        // Set the alignment for the specific column header
        //        e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  // Adjust alignment as needed
        //        e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);
        //        e.Handled = true;
        //    }
        //}
    }
}
