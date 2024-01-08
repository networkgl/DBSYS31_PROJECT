using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Interop;
using static Guna.UI2.Native.WinApi;

namespace HMS.Forms
{
    public partial class Frm_BookingDetails : Form
    {
        private UserRepository userRepo;
        private AdminRepository adminRepo;
        private int currentIndex;

        public static Frm_BookingDetails Instance { get; set; }

        public Frm_BookingDetails()
        {
            InitializeComponent();
            userRepo = new UserRepository();
            adminRepo = new AdminRepository();
            Instance = this;
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
        private void Frm_Client_Load(object sender, EventArgs e)
        {
            LoadDataGrid_All();
            populateCBboxRooms();

            chkBox_showOverAll.Checked = true;
            cbBox_rooms.Enabled = true;
        }
        private void populateCBboxRooms()
        {
            String response = String.Empty;
            var retValRows = adminRepo.GetRoomTypeByID(ref response);
            cbBox_rooms.Items.Clear();

            //cbBox_rooms.Items.Add("SELECT ROOM TO FILTER");
            if (retValRows == ErrorCode.Success)
            {
                foreach (var i in adminRepo.RoomType)
                {
                    cbBox_rooms.Items.Add(i);
                }
                cbBox_rooms.SelectedIndex = 0;
            }
            else
            {
                MessageDialog.Show(response, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
            }
        }

        public void LoadDataGrid_Currently()
        {
            string message = string.Empty;
            dgv_roomdetails.DataSource = userRepo.GetCurrentReservation_CheckIn_ByDate(ref message);

            dgv_roomdetails.Columns["ID"].Width = 25;
            dgv_roomdetails.Columns["Adult"].Width = 30;
            dgv_roomdetails.Columns["Children"].Width = 40;
            dgv_roomdetails.Columns["Senior"].Width = 35;
            dgv_roomdetails.Columns["Name"].Width = 30;
            dgv_roomdetails.Columns["RoomType"].Width = 70;
            dgv_roomdetails.Columns["DateIn"].Width = 45;
            dgv_roomdetails.Columns["DateOut"].Width = 55;
            dgv_roomdetails.Columns["Address"].Width = 50;
            dgv_roomdetails.Columns["Email"].Width = 60;
            dgv_roomdetails.Columns["Phone"].Width = 45;
            dgv_roomdetails.Columns["Days"].Width = 30;
            dgv_roomdetails.Columns["Payment"].Width = 90;

            this.dgv_roomdetails.Columns["Payment"].DefaultCellStyle.Format = "C";
            //this.dgv_roomdetails.Columns["Payment"].DefaultCellStyle.FormatProvider = new CultureInfo("en-PH");
        }
        public void LoadDataGrid_Ongoing()
        {
            string message = string.Empty;
            dgv_roomdetails.DataSource = userRepo.LoadClientsInformation_Ongoing(ref message);

            dgv_roomdetails.Columns["ID"].Width = 25;
            dgv_roomdetails.Columns["Adult"].Width = 30;
            dgv_roomdetails.Columns["Children"].Width = 40;
            dgv_roomdetails.Columns["Senior"].Width = 35;
            dgv_roomdetails.Columns["Name"].Width = 30;
            dgv_roomdetails.Columns["RoomType"].Width = 70;
            dgv_roomdetails.Columns["DateIn"].Width = 45;
            dgv_roomdetails.Columns["DateOut"].Width = 55;
            dgv_roomdetails.Columns["Address"].Width = 50;
            dgv_roomdetails.Columns["Email"].Width = 60;
            dgv_roomdetails.Columns["Phone"].Width = 45;
            dgv_roomdetails.Columns["Days"].Width = 30;
            dgv_roomdetails.Columns["Payment"].Width = 100;

            this.dgv_roomdetails.Columns["Payment"].DefaultCellStyle.Format = "C";
        }

        public void LoadDataGrid_All()
        {
            string message = string.Empty;
            dgv_roomdetails.DataSource = userRepo.LoadClientsInformation_All(ref message);

            dgv_roomdetails.Columns["ID"].Width = 25;
            dgv_roomdetails.Columns["Adult"].Width = 30;
            dgv_roomdetails.Columns["Children"].Width = 40;
            dgv_roomdetails.Columns["Senior"].Width = 35;
            dgv_roomdetails.Columns["Name"].Width = 30;
            dgv_roomdetails.Columns["RoomType"].Width = 70;
            dgv_roomdetails.Columns["DateIn"].Width = 45;
            dgv_roomdetails.Columns["DateOut"].Width = 55;
            dgv_roomdetails.Columns["Address"].Width = 50;
            dgv_roomdetails.Columns["Email"].Width = 60;
            dgv_roomdetails.Columns["Phone"].Width = 45;
            dgv_roomdetails.Columns["Days"].Width = 30;
            dgv_roomdetails.Columns["Payment"].Width = 90;

            this.dgv_roomdetails.Columns["Payment"].DefaultCellStyle.Format = "C";
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
        private bool toggleOngoing;
        private bool toggleShowAll;
        private bool toggleCurrently;

        private void HandleCheckboxCheckedState(Guna2CustomCheckBox clickedCheckbox)
        {
            if (chkBox_showCurrentlyCheck_In.Checked)
            {
                toggleOngoing = false;
                toggleShowAll = false;

                toggleCurrently = true;
                LoadDataGrid_Currently();
            }
            else if (chkBox_showOngoingCheck_In.Checked)
            {
                toggleShowAll = false;
                toggleCurrently = false;

                toggleOngoing = true;
                LoadDataGrid_Ongoing();
            }
            else if (chkBox_showOverAll.Checked)
            {
                toggleOngoing = false;
                toggleCurrently = false;

                toggleShowAll = true;
                LoadDataGrid_All();
            }

            FilterDataGridByChkBx();
        }

        private void chkBox_showCurrentlyCheck_In_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CustomCheckBox clickedCheckbox = (Guna2CustomCheckBox)sender;

            if (clickedCheckbox.Checked)
            {
                UncheckOtherCheckboxes(clickedCheckbox);
                HandleCheckboxCheckedState(clickedCheckbox);
                cbBox_rooms.Enabled = true;
            }
            else
            {
                toggleOngoing = false;
                toggleShowAll = false;
                toggleCurrently = false;

                //cbBox_rooms.SelectedIndex = 0;
                cbBox_rooms.Enabled = false;

                LoadDataGrid_All();
            }

            Frm_Main.LastActivity = "Filtering Current Check In";
        }

        private void chkBox_showOverAll_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CustomCheckBox clickedCheckbox = (Guna2CustomCheckBox)sender;

            if (clickedCheckbox.Checked)
            {
                UncheckOtherCheckboxes(clickedCheckbox);
                HandleCheckboxCheckedState(clickedCheckbox);
                cbBox_rooms.Enabled = true;
            }
            else
            {
                toggleOngoing = false;
                toggleShowAll = false;
                toggleCurrently = false;

                //cbBox_rooms.SelectedIndex = 0;
                cbBox_rooms.Enabled = false;

                LoadDataGrid_All();
            }
        }
        private void chkBox_showOngoingCheck_In_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CustomCheckBox clickedCheckbox = (Guna2CustomCheckBox)sender;

            if (clickedCheckbox.Checked)
            {
                UncheckOtherCheckboxes(clickedCheckbox);
                HandleCheckboxCheckedState(clickedCheckbox);
                cbBox_rooms.Enabled = true;
            }
            else
            {
                toggleOngoing = false;
                toggleShowAll = false;
                toggleCurrently = false;

                //cbBox_rooms.SelectedIndex = 0;
                cbBox_rooms.Enabled = false;

                LoadDataGrid_All();
            }
        }

        private void cbBox_rooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDataGridByChkBx();
        }
        private void FilterDataGridByChkBx()
        {
            if (toggleOngoing)
            {
                LoadDataGridByCondition(cbBox_rooms.SelectedItem.ToString(), "ongoing");
                return;
            }
            if (toggleCurrently)
            {
                LoadDataGridByCondition(cbBox_rooms.SelectedItem.ToString(), "currently");
                return;
            }
            if (toggleShowAll)
            {
                LoadDataGridByCondition(cbBox_rooms.SelectedItem.ToString(), "showall");
                return;
            }
        }
        private void LoadDataGridByCondition(string roomtype,string typeoffilter)
        {
            var message = string.Empty;
            var retVal = userRepo.DisplayRoomTypeByCondition(roomtype, typeoffilter, ref message);

             dgv_roomdetails.DataSource = retVal;
        }
    }
}
