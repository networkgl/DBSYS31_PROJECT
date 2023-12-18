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

namespace HMS.Forms
{
    public partial class Frm_BookingDetails : Form
    {
        private UserRepository userRepo;
        public static Frm_BookingDetails Instance { get; set; }

        public Frm_BookingDetails()
        {
            InitializeComponent();
            userRepo = new UserRepository();
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
            LoadDataGrid();
        }
        public void LoadDataGrid()
        {
            string message = string.Empty;
            dgv_roomdetails.DataSource = userRepo.LoadClientsInformation(ref message);

            dgv_roomdetails.Columns["ID"].Width = 20;
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
            //this.dgv_roomdetails.Columns["Payment"].DefaultCellStyle.FormatProvider = new CultureInfo("en-PH");
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

            if (chkBox_showCurrentlyCheck_In.Checked)
            {
                dgv_roomdetails.DataSource = userRepo.GetCurrentReservation_CheckIn_ByDate(ref msg);
            }


        }

        private void chkBox_showCurrentlyCheck_In_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CustomCheckBox clickedCheckbox = (Guna2CustomCheckBox)sender;

            if (clickedCheckbox.Checked)
            {
                UncheckOtherCheckboxes(clickedCheckbox);
                HandleCheckboxCheckedState(clickedCheckbox);
            }
            else
            {
                LoadDataGrid();
            }

            Frm_Main.LastActivity = "Filtering Current Check In";

        }

        private void chkBox_showCurrentlyCheck_In_Click(object sender, EventArgs e)
        {

        }
    }
}
