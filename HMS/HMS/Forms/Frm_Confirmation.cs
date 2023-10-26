using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Forms
{
    //public int SelectedTime_CheckIn { get; set; }
    //public int SelectedTime_CheckOut { get; set; }
    //public int Selected_CheckIn_AM_PM { get; set; }
    //public int Selected_CheckOut_AM_PM { get; set; }
    public partial class Frm_Confirmation : Form
    {
        private static Frm_Confirmation confirmation;
        //private int roomType = Frm_BookNow_S2.GetInstance().RoomType;
        //private int guest = Frm_BookNow_S1.GetInstance().Guest;
        //private DateTime checkInDate = Frm_BookNow_S1.GetInstance().CheckIn;
        //private DateTime checkOutDate = Frm_BookNow_S1.GetInstance().CheckOut;
        //private int timeCheckIn = Frm_BookNow_S1.GetInstance().SelectedTime_CheckIn;
        //private int timeCheckOut = Frm_BookNow_S1.GetInstance().SelectedTime_CheckOut;
        //private int timeCheckIn_AM_PM = Frm_BookNow_S1.GetInstance().Selected_CheckIn_AM_PM;
        //private int timeCheckOut_AM_PM = Frm_BookNow_S1.GetInstance().Selected_CheckOut_AM_PM;
        private string guest = String.Empty, checkIn = String.Empty, checkOut = String.Empty, checkIn_am_pm = String.Empty, checkOut_am_pm = String.Empty, checkIn_date = String.Empty, checkOut_date = String.Empty, totalPrice = String.Empty;
        public Frm_Confirmation()
        {
            InitializeComponent();
        }
        public Frm_Confirmation(string guest, string checkIn, string checkOut, 
                                 string checkIn_am_pm, string checkOut_am_pm, 
                                 string checkIn_date, string checkOut_date, string totalPrice)
        {
            InitializeComponent();

            this.guest = guest;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.checkIn_am_pm = checkIn_am_pm;
            this.checkOut_am_pm = checkOut_am_pm;
            this.checkIn_date = checkIn_date;
            this.checkOut_date = checkOut_date;
            this.totalPrice = totalPrice;
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
        public static Frm_Confirmation GetInstance()
        {
            if (confirmation == null)           
                confirmation = new Frm_Confirmation();           
            return confirmation;
        }
        private void Frm_Confirmation_Load(object sender, EventArgs e)
        {
            CurrentDate.Start();
            UpdateDateTime();
            //Frm_BookNow_S3.GetInstance().InitializeConfirmation();
            InitializeConfirmation();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_BookNow_S3.GetInstance().Show();
        }
        private void InitializeConfirmation()
        {

            //lbl_CheckIn_Time.Text = timeCheckIn + " " + timeCheckIn_AM_PM;
            //lbl_CheckOut_Time.Text = timeCheckOut + " " + timeCheckOut_AM_PM;
            //lbl_CheckIn_Date.Text = checkInDate.ToString();
            //lbl_CheckOut_Date.Text = checkOutDate.ToString();
            //lbl_Guest.Text = guest.ToString();

            //lbl_CheckIn_Time.Text = Frm_BookNow_S1.SelectedTime_CheckIn + " " + Frm_BookNow_S1.Selected_CheckIn_AM_PM;
            //lbl_CheckOut_Time.Text = Frm_BookNow_S1.SelectedTime_CheckOut + " " + Frm_BookNow_S1.Selected_CheckOut_AM_PM;
            //lbl_CheckIn_Date.Text = Frm_BookNow_S1.CheckIn.ToString();
            //lbl_CheckOut_Date.Text = Frm_BookNow_S1.CheckOut.ToString();


            lbl_CheckIn_Time.Text = this.checkIn;
            lbl_CheckOut_Time.Text = this.checkOut;
            lbl_CheckIn_Date.Text = this.checkIn_date;
            lbl_CheckOut_Date.Text = this.checkOut;

            lbl_totalPrice.Text = this.totalPrice;
            lbl_Guest.Text = this.guest;
        }
    }
}
