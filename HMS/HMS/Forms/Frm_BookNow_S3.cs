using HMS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Frm_BookNow_S3 : Form
    {
        private static Frm_BookNow_S3 s3;
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }


        private void txtbox_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancel the input if it's not a digit or control character.
                MessageBox.Show("Please enter only a number","Message",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private Frm_BookNow_S3()
        {
            InitializeComponent();
        }
        public static Frm_BookNow_S3 GetInstance()
        {
            if(s3 == null)
                s3 = new Frm_BookNow_S3();
            return s3;
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
        private void CurrentDate_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        public void UpdateDateTime()
        {
            var currentDateTime = DateTime.Now;
            var culture = new CultureInfo("en-PH"); // Specify the desired culture
            lblSystemTime.Text = currentDateTime.ToString("yyyy-MM-dd  hh:mm:ss tt", culture);

        }
        private void Frm_BookNow_S3_Load(object sender, EventArgs e)
        {
            CurrentDate.Start();
            UpdateDateTime();

            txtbox_fName.Text = Fname;
            txtbox_lName.Text = Lname;
            txtbox_Email.Text = Email;
            if (Phone == 0)
                txtbox_Phone.Text = string.Empty;
            else
                txtbox_Phone.Text = Phone.ToString();
            txtbox_Address.Text = Address;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Fname = txtbox_fName.Text;
            Lname = txtbox_lName.Text;
            Email = txtbox_Email.Text;
            if (txtbox_Phone.Text.Equals(string.Empty))           
                Phone = 0;           
            else
                Phone = long.Parse(txtbox_Phone.Text);
            Address = txtbox_Address.Text;

            this.Hide();
            Frm_BookNow_S2.GetInstance().Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            InitializeConfirmation();
            this.Hide();
            //Frm_Confirmation.GetInstance().Show();
            Frm_Confirmation fc = new Frm_Confirmation(GetGuestByIndex(), Frm_BookNow_S1.SelectedTime_CheckIn.ToString(), 
                                                        Frm_BookNow_S1.SelectedTime_CheckOut.ToString(), Frm_BookNow_S1.Selected_CheckIn_AM_PM.ToString(), 
                                                        Frm_BookNow_S1.Selected_CheckOut_AM_PM.ToString(), Frm_BookNow_S1.CheckIn.ToString(), 
                                                        Frm_BookNow_S1.CheckOut.ToString(), GetTotalPrice());
            fc.Show();
        }
        public void InitializeConfirmation()
        {

            //lbl_CheckIn_Time.Text = timeCheckIn + " " + timeCheckIn_AM_PM;
            //lbl_CheckOut_Time.Text = timeCheckOut + " " + timeCheckOut_AM_PM;
            //lbl_CheckIn_Date.Text = checkInDate.ToString();
            //lbl_CheckOut_Date.Text = checkOutDate.ToString();
            //lbl_Guest.Text = guest.ToString();


            Frm_Confirmation.GetInstance().lbl_CheckIn_Time.Text = Frm_BookNow_S1.SelectedTime_CheckIn + " " + Frm_BookNow_S1.Selected_CheckIn_AM_PM;
            Frm_Confirmation.GetInstance().lbl_CheckOut_Time.Text = Frm_BookNow_S1.SelectedTime_CheckOut + " " + Frm_BookNow_S1.Selected_CheckOut_AM_PM;
            Frm_Confirmation.GetInstance().lbl_CheckIn_Date.Text = Frm_BookNow_S1.CheckIn.ToString();
            Frm_Confirmation.GetInstance().lbl_CheckOut_Date.Text = Frm_BookNow_S1.CheckOut.ToString();

            Frm_Confirmation.GetInstance().lbl_totalPrice.Text = GetTotalPrice();
            Frm_Confirmation.GetInstance().lbl_Guest.Text = GetGuestByIndex();
        }
        private String GetGuestByIndex()
        {
            string retVal = String.Empty;

            switch (Frm_BookNow_S1.Guest)
            {
                case 0:
                    retVal = "1 Adult";
                    break;
                case 1:
                    retVal = "Adult and Children";
                    break;
            }

            return retVal;
        }
        private String ParseVal(double retVal)
        {
            return retVal.ToString("#,##0");
        }
        private String GetTotalPrice()
        {
            string retVal = String.Empty;
            var price = Frm_BookNow_S2.RoomType;
            //Total Payment Based on RoomType
            switch (price)
            {
                case 0:
                    retVal = "₱ " + ParseVal(10000);
                    break;
                case 1:
                    retVal = "₱ " + ParseVal(14000);
                    break;
                case 2:
                    retVal = "₱ " + ParseVal(20000);
                    break;
            }
            return retVal;
        }
    }
}
