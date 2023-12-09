using Guna.UI2.WinForms;
using HMS.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Forms
{
    public partial class Frm_Reservation : Form
    {
        private UserRepository userRepo;
        private HMSEntities db;
        private static Frm_Reservation frm;
        public static int ID; //use for deleting reservation, will be accessible to confirmDelete Frm
        private bool acceptReservation = false;
        public static Frm_Reservation Frm { get => frm; set => frm = value; }

        public Frm_Reservation()
        {
            InitializeComponent();
            userRepo = new UserRepository();
        }

        private void Frm_Reservation_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
        public void LoadDataGrid()
        {
            if (!Frm_ConfirmDelete.Reservation_ConfirmDelete && !acceptReservation)
            {
                dgv_roomreservation.DataSource = userRepo.LoadReservation();

                dgv_roomreservation.Columns["ID"].Width = 20;
                dgv_roomreservation.Columns["Name"].Width = 100;
                dgv_roomreservation.Columns["Phone"].Width = 40;
                dgv_roomreservation.Columns["Address"].Width = 50;
                dgv_roomreservation.Columns["Room_Type"].Width = 90;
                dgv_roomreservation.Columns["Date_In"].Width = 60;
                dgv_roomreservation.Columns["Date_Out"].Width = 70;
                dgv_roomreservation.Columns["Total"].Width = 50;
                dgv_roomreservation.Columns["Status"].Width = 80;

                DataGridViewImageColumn acceptReservation = new DataGridViewImageColumn();

                // Add an image column
                acceptReservation.HeaderText = "Accept";
                acceptReservation.Name = "AcceptReservationColumn"; // Use a unique name for the column
                acceptReservation.ImageLayout = DataGridViewImageCellLayout.Normal; // Adjust as needed
                dgv_roomreservation.Columns.Add(acceptReservation);
                dgv_roomreservation.Columns["AcceptReservationColumn"].Width = 80;

                DataGridViewImageColumn deniedReservation = new DataGridViewImageColumn();

                // Add an image column
                deniedReservation.HeaderText = "Decline";
                deniedReservation.Name = "DeniedReservationColumn"; // Use a unique name for the column
                deniedReservation.ImageLayout = DataGridViewImageCellLayout.Normal; // Adjust as needed
                dgv_roomreservation.Columns.Add(deniedReservation);
                dgv_roomreservation.Columns["DeniedReservationColumn"].Width = 80;
            }
            else
            {
                dgv_roomreservation.DataSource = userRepo.LoadReservation();
            }
        }

        private void dgv_roomreservation_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the column exists
            DataGridViewColumn accept_reserveColumn = dgv_roomreservation.Columns["AcceptReservationColumn"];

            if (accept_reserveColumn != null && e.ColumnIndex == accept_reserveColumn.Index && e.RowIndex >= 0)
            {
                e.Value = Properties.Resources.update1;
                e.FormattingApplied = true;
            }

            DataGridViewColumn denied_reserveColumn = dgv_roomreservation.Columns["DeniedReservationColumn"];
            
            if (denied_reserveColumn != null && e.ColumnIndex == denied_reserveColumn.Index && e.RowIndex >= 0)
            {
                e.Value = Properties.Resources.decline;
                e.FormattingApplied = true;
            }
        }

        private void dgv_roomreservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var msg = "Please select only row cells!";

            if (e.RowIndex == -1)
            {
                MessageDialog.Show(msg, "Message", MessageDialogButtons.OK, MessageDialogIcon.Warning, MessageDialogStyle.Dark);
                return;
            }

            DataGridViewRow clickedRow = dgv_roomreservation.Rows[e.RowIndex];
            ID = Convert.ToInt32(clickedRow.Cells["ID"].Value); //Get ID first then pass to the stored procedure.
            //Console.WriteLine(roomID);

            if (e.RowIndex >= 0 && e.RowIndex < dgv_roomreservation.Rows.Count)
            {
                string colName = dgv_roomreservation.Columns[e.ColumnIndex].Name;
                if (colName.Equals("AcceptReservationColumn"))
                {
                    var message = string.Empty;
                    var retVal = userRepo.ApproveReservation(ID,ref message);
                    msg = "Do you want to accept this booking reservation ?";
                    var isConfirm = MessageDialog.Show(msg, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Warning, MessageDialogStyle.Dark) == DialogResult.Yes;
                    
                    if (isConfirm)
                    {
                        if (retVal == ErrorCode.Success)
                        {
                            msg = "Reservation Successfully Accepted";

                            acceptReservation = true;
                            LoadDataGrid();
                            MessageDialog.Show(msg, "Message", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Light);
                        }
                        else
                        {
                            MessageDialog.Show(message, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
                        }
                    }
                }
                if (colName.Equals("DeniedReservationColumn"))
                {
                    msg = "Declining reservation will delete this record\nPlease confirm.";
                    var isConfirm = MessageDialog.Show(msg, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Warning, MessageDialogStyle.Dark) == DialogResult.Yes;

                    if (isConfirm)
                    {
                        Thread.Sleep(2000);
                        Frm_ConfirmDelete.Toggle_reservation_confirmDelete = true;
                        var del = new Frm_ConfirmDelete();
                        del.ShowDialog();

                        if (Frm_ConfirmDelete.Reservation_ConfirmDelete)
                        {
                            LoadDataGrid();//load data grid to refresh.
                            Frm_ConfirmDelete.Reservation_ConfirmDelete = false;
                        }
                    }
                }
            }
        }
    }
}
