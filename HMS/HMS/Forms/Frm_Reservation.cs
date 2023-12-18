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
using System.Windows.Interop;

namespace HMS.Forms
{
    public partial class Frm_Reservation : Form
    {
        private UserRepository userRepo;
        private HMSEntities db;
        private static Frm_Reservation instance;
        public static int ID; //use for deleting reservation, will be accessible to confirmDelete Frm
        private bool acceptReservation = false;
        private bool deleteAllReservation = false;
        public static Frm_Reservation Instance { get => instance; set => instance = value; }
        private string message = string.Empty;

        public Frm_Reservation()
        {
            InitializeComponent();
            userRepo = new UserRepository();
            instance = this;
        }

        private void Frm_Reservation_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            chkBox_showpAll.Checked = true;
        }
        public void LoadDataGrid()
        {
            if ((!Frm_ConfirmDelete.Reservation_ConfirmDelete && !acceptReservation && !deleteAllReservation))
            {
                dgv_roomreservation.DataSource = userRepo.LoadReservation(ref message);

                dgv_roomreservation.Columns["ID"].Width = 30;
                dgv_roomreservation.Columns["Guest"].Width = 40;
                dgv_roomreservation.Columns["Name"].Width = 90;
                dgv_roomreservation.Columns["Phone"].Width = 40;
                dgv_roomreservation.Columns["Address"].Width = 50;
                dgv_roomreservation.Columns["RoomType"].Width = 90;
                dgv_roomreservation.Columns["DateIn"].Width = 55;
                dgv_roomreservation.Columns["DateOut"].Width = 60;
                dgv_roomreservation.Columns["Total"].Width = 60;
                dgv_roomreservation.Columns["Status"].Width = 80;

                this.dgv_roomreservation.Columns["Total"].DefaultCellStyle.Format = "C";

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
                dgv_roomreservation.DataSource = userRepo.LoadReservation(ref message);
            }
        }

        private void dgv_roomreservation_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the column exists
            DataGridViewColumn accept_reserveColumn = dgv_roomreservation.Columns["AcceptReservationColumn"];

            if (accept_reserveColumn != null && e.ColumnIndex == accept_reserveColumn.Index && e.RowIndex >= 0)
            {
                e.Value = Properties.Resources.accept;
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
            var reservationStatus = clickedRow.Cells["Status"].Value as String;
            //Console.WriteLine(roomID);

            if (e.RowIndex >= 0 && e.RowIndex < dgv_roomreservation.Rows.Count)
            {
                string colName = dgv_roomreservation.Columns[e.ColumnIndex].Name;
                if (colName.Equals("AcceptReservationColumn"))
                {
                    if (reservationStatus.Equals("APPROVE"))
                    {
                        msg = "The reservation details has been approved.\nPlease select another one.";
                        MessageDialog.Show(msg, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
                        return;
                    }

                    var roomType = clickedRow.Cells["RoomType"].Value as String;
                    var message = String.Empty;
                    RoomAvailable currentTotalRoom = RoomAvailable.MIN;//this is equivalent assigning zero to this variable
                    var retVal = userRepo.GetRoomStatus(roomType, ref currentTotalRoom, ref message);
                    if (retVal == ErrorCode.Success)
                    {
                        if (currentTotalRoom == RoomAvailable.MAX)
                        {
                            msg = "Unable to APPROVE this reservation because the\ncurrent room type is FULLY BOOK";
                            MessageDialog.Show(msg, "Message", MessageDialogButtons.OK, MessageDialogIcon.Warning, MessageDialogStyle.Dark);
                            return;
                        }
                    }
                    else
                    {
                        MessageDialog.Show(message, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
                    }



                    //var message = string.Empty;
                    msg = "Do you want to accept this booking reservation ?";
                    var isConfirm = MessageDialog.Show(msg, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Question, MessageDialogStyle.Light) == DialogResult.Yes;
                    
                    if (isConfirm)
                    {
                        var retVals = userRepo.ApproveReservation(ID, ref message);

                        if (retVals == ErrorCode.Success)
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
                    if (reservationStatus.Equals("APPROVE"))
                    {
                        //msg = "The reservation details has been approved.\nDeclining it is not possible!";
                        msg = "The reservation details has been approved.\nForcing to declined it requires administrator password";
                        MessageDialog.Show(msg, "Message", MessageDialogButtons.OK, MessageDialogIcon.Warning, MessageDialogStyle.Dark);

                        Thread.Sleep(1000);
                        Frm_ConfirmDelete.Toggle_reservation_confirmDelete = true;
                        var del = new Frm_ConfirmDelete();
                        del.ShowDialog();

                        if (Frm_ConfirmDelete.Reservation_ConfirmDelete)
                        {
                            LoadDataGrid();//load data grid to refresh.
                            Frm_ConfirmDelete.Reservation_ConfirmDelete = false;
                        }
                        return;
                    }


                    msg = "Declining reservation will delete this record\nPlease confirm.";
                    var isConfirm = MessageDialog.Show(msg, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Warning, MessageDialogStyle.Dark) == DialogResult.Yes;

                    if (isConfirm)
                    {
                        Thread.Sleep(1000);
                        Frm_ConfirmDelete.Toggle_reservation_confirmDelete = true;
                        var del = new Frm_ConfirmDelete();
                        del.lb_Note.Text = " Please enter your password !";
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
        private void dgv_roomreservation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void btnDeleteAllReservation_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            var msg = "Are you sure you want to delete all reservation ?";
            var isConfirm = MessageDialog.Show(msg, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Question, MessageDialogStyle.Dark) == DialogResult.Yes;

            if (isConfirm)
            {
                var retVal = userRepo.DeleteAllReservation(ref message);

                if (retVal == ErrorCode.Success)
                {
                    Thread.Sleep(100);
                    deleteAllReservation = true;
                    LoadDataGrid();
                    msg = "Successfully Delete All Reservations";
                    MessageDialog.Show(msg, "Message", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Light);
                }
                else
                {
                    MessageDialog.Show(message, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
                }
            }
        }


        private void chkBox_showpPending_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CustomCheckBox clickedCheckbox = (Guna2CustomCheckBox)sender;

            if (clickedCheckbox.Checked)
            {
                UncheckOtherCheckboxes(clickedCheckbox);
                HandleCheckboxCheckedState(clickedCheckbox);
            }
            else
            {
                dgv_roomreservation.DataSource = userRepo.LoadReservation(ref message);
            }
        }

        private void chkBox_showpApprove_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CustomCheckBox clickedCheckbox = (Guna2CustomCheckBox)sender;

            if (clickedCheckbox.Checked)
            {
                UncheckOtherCheckboxes(clickedCheckbox);
                HandleCheckboxCheckedState(clickedCheckbox);
            }
            else
            {
                dgv_roomreservation.DataSource = userRepo.LoadReservation(ref message);
            }
        }

        private void chkBox_showpAll_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CustomCheckBox clickedCheckbox = (Guna2CustomCheckBox)sender;

            if (clickedCheckbox.Checked)
            {
                UncheckOtherCheckboxes(clickedCheckbox);
                HandleCheckboxCheckedState(clickedCheckbox);
            }
            //NOT NECCESSARY
            //else
            //{
            //    dgv_roomreservation.DataSource = userRepo.LoadReservation(ref message);
            //}
        }
        private void chkBox_showHistory_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CustomCheckBox clickedCheckbox = (Guna2CustomCheckBox)sender;

            if (clickedCheckbox.Checked)
            {
                UncheckOtherCheckboxes(clickedCheckbox);
                HandleCheckboxCheckedState(clickedCheckbox);
            }
            else
            {
                dgv_roomreservation.DataSource = userRepo.LoadReservation(ref message);
            }
        }
        private void UncheckOtherCheckboxes(Guna2CustomCheckBox clickedCheckbox)
        {
            foreach (Control control in Controls)
            {
                if (control is Guna2CustomCheckBox checkbox && checkbox != clickedCheckbox)
                {
                    checkbox.Checked = false;
                }
            }
        }

        private void HandleCheckboxCheckedState(Guna2CustomCheckBox clickedCheckbox)
        {
            var msg = string.Empty;
            var message = string.Empty;

            if (chkBox_showpPending.Checked)
            {
                dgv_roomreservation.DataSource = userRepo.GetClientReservation_Pending(ref msg);
            }
            else if (chkBox_showpApprove.Checked)
            {
                dgv_roomreservation.DataSource = userRepo.GetClientReservation_Approve(ref msg);
            }
            else if (chkBox_showpAll.Checked)
            {
                dgv_roomreservation.DataSource = userRepo.LoadReservation(ref message);
            }
            else if (chkBox_showHistory.Checked)
            {
                dgv_roomreservation.DataSource = userRepo.GetReservationHistory(ref message);
            }
        }


    }
}
