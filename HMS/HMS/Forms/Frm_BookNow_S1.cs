using HMS.Forms;
using Pabo.Calendar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;


namespace HMS
{
    public partial class Frm_BookNow_S1 : Form
    {
        private Frm_BookNow_S1 s1;
        private Frm_BookNow_S2 s2;
        private Frm_BookNow_S3 s3;

        private int guest;
        private int noOfGuest;
        private String selectedTime_CheckIn = "After 2:00 PM";
        private String selectedTime_CheckOut = "Before 12:00 PM";
        public DateTime checkIn = DateTime.Now;
        public DateTime checkOut = DateTime.Now;

        //public static int Guest { get; set; }
        //public static int NoOfGuest { get; set; }
        //public static int SelectedTime_CheckIn { get; set; }
        //public static int SelectedTime_CheckOut { get; set; }
        //public static int Selected_CheckIn_AM_PM { get; set; }
        //public static int Selected_CheckOut_AM_PM { get; set; }
        //public static DateTime CheckIn { get; set; } = DateTime.Now;
        //public static DateTime CheckOut { get; set; } = DateTime.Now;
        public Frm_BookNow_S1()
        {
            InitializeComponent();
        }
        public Frm_BookNow_S1(Frm_BookNow_S1 s1, Frm_BookNow_S2 s2, Frm_BookNow_S3 s3)
        {
            InitializeComponent();
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
            //this.s4 = s4;
        }
        //public Frm_BookNow_S1(Frm_BookNow_S2 s2, Frm_BookNow_S3 s3, Frm_BookNow_S4 s4)
        //{
        //    InitializeComponent();
        //    this.s2 = s2;
        //    this.s3 = s3;
        //    this.s4 = s4;
        //}
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }
        //public static Frm_BookNow_S1 GetInstance()
        //{
        //    //if (s1 == null)
        //    s1 = new Frm_BookNow_S1();
        //    return s1;
        //}
        private void Frm_BookNow_S1_Load(object sender, EventArgs e)
        {
            // Start the Timer control
            CurrentDate.Start();

            // Get and display the current date and time
            UpdateDateTime();


            mc_GuideBooking.ActiveMonth.Month = DateTime.Now.Month;//Set active month to current month
            if(s2 == null)
            {
                Console.WriteLine("S2 IS NULL");
            }
            else
                Console.WriteLine("S2 NOT NULL");


            ////Frm_ProcessPayment p = new Frm_ProcessPayment();
            //Console.WriteLine(Frm_ProcessPayment.HasPaid);
            //if (Frm_ProcessPayment.HasPaid)
            //{
            //    cbBox_Guest.SelectedIndex = 0;
            //    nud_NumberOfGuest.Value = 0;
            //    DateTimePicker_CheckIn.Value = DateTime.Now;
            //    DateTimePicker_CheckOut.Value = DateTime.Now;

            //}
            //else
            //{
            //    //Assign Values For Users to see their reservation info
            //    cbBox_Guest.SelectedIndex = Guest;
            //    nud_NumberOfGuest.Value = NoOfGuest;
            //    DateTimePicker_CheckIn.Value = CheckIn;
            //    DateTimePicker_CheckOut.Value = CheckOut;
            //}

            if (s1 == null)
            {
                cbBox_Guest.SelectedIndex = Guest;
                nud_NumberOfGuest.Value = NoOfGuest;
                DateTimePicker_CheckIn.Value = CheckIn;
                DateTimePicker_CheckOut.Value = CheckOut;
                txtbox_CheckInTime.Text = SelectedTime_CheckIn.ToString();
                txtbox_CheckOutTime.Text = SelectedTime_CheckOut.ToString();
            }
            else
            {
                cbBox_Guest.SelectedIndex = s1.Guest;
                nud_NumberOfGuest.Value = s1.NoOfGuest;
                DateTimePicker_CheckIn.Value = s1.CheckIn;
                DateTimePicker_CheckOut.Value = s1.CheckOut;
                txtbox_CheckInTime.Text = s1.SelectedTime_CheckIn.ToString();
                txtbox_CheckOutTime.Text = s1.SelectedTime_CheckOut.ToString();
            }
        }
        private void mc_GuideBooking_DayQueryInfo(object sender, Pabo.Calendar.DayQueryInfoEventArgs e)
        {

            List<DateTime> dateArray = new List<DateTime>();
            dateArray.Add(new DateTime(2023, 11, 10));
            dateArray.Add(new DateTime(2023, 11, 15));
            dateArray.Add(new DateTime(2023, 11, 20));

            var size = dateArray.Count;

            for (int i = 0; i < size; i++)
            {

                // Check date and mark it with color to specify occupied or not available to select for booking.
                if (e.Date == dateArray[i])
                {
                    // Add custom formatting
                    e.Info.DateColor = Color.White;
                    e.Info.BackColor1 = Color.Red;
                    e.OwnerDraw = true;
                }
            }
        }
        private static Frm_BookNow_S1 s11;
        public static Frm_BookNow_S1 GetInstance
        {
            get { return s11; }
            set { s11 = value; }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_HomePage hp = new Frm_HomePage();
            hp.Show();
            Frm_ProcessPayment.HasPaid = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            s11 = this;
            this.Hide();
            if (this.s2 == null)
            {
                Frm_BookNow_S2 s2 = new Frm_BookNow_S2(this, this.s2, this.s3);
                s2.Show();
            }
            else
            {
                //this.s2 = new Frm_BookNow_S2(this, this.s2, s3, s4);
                //s2.GetInstance.Show();
                s2.Show();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_HomePage hp = new Frm_HomePage();
            hp.Show();
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
        private void DateTimePicker_CheckIn_ValueChanged(object sender, EventArgs e)
        {
            checkIn = DateTimePicker_CheckIn.Value.Date;
            //Console.WriteLine("S1: "+checkIn);
        }

        private void DateTimePicker_CheckOut_ValueChanged(object sender, EventArgs e)
        {
            checkOut = DateTimePicker_CheckOut.Value.Date;
            //Console.WriteLine("S1: "+checkOut);
        }
        public void cbBox_Guest_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbBox_Guest.SelectedIndex)
            {
                case 0:
                    guest = cbBox_Guest.SelectedIndex;
                    break;
                case 1:
                    guest = cbBox_Guest.SelectedIndex;
                    break;
                case 2:
                    guest = cbBox_Guest.SelectedIndex;
                    break;
            }
        }

        /*
        private void cbBox_CheckIn_Time_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbBox_CheckIn_Time.SelectedIndex)
            {
                case 0:
                    SelectedTime_CheckIn = cbBox_CheckIn_Time.SelectedIndex;
                    break;
                case 1:
                    SelectedTime_CheckIn = cbBox_CheckIn_Time.SelectedIndex;
                    break;
                case 2:
                    SelectedTime_CheckIn = cbBox_CheckIn_Time.SelectedIndex;
                    break;
                case 3:
                    SelectedTime_CheckIn = cbBox_CheckIn_Time.SelectedIndex;
                    break;
                case 4:
                    SelectedTime_CheckIn = cbBox_CheckIn_Time.SelectedIndex;
                    break;
                case 5:
                    SelectedTime_CheckIn = cbBox_CheckIn_Time.SelectedIndex;
                    break;
                case 6:
                    SelectedTime_CheckIn = cbBox_CheckIn_Time.SelectedIndex;
                    break;
                case 7:
                    SelectedTime_CheckIn = cbBox_CheckIn_Time.SelectedIndex;
                    break;
                case 8:
                    SelectedTime_CheckIn = cbBox_CheckIn_Time.SelectedIndex;
                    break;
                case 9:
                    SelectedTime_CheckIn = cbBox_CheckIn_Time.SelectedIndex;
                    break;
                case 10:
                    SelectedTime_CheckIn = cbBox_CheckIn_Time.SelectedIndex;
                    break;
                case 11:
                    SelectedTime_CheckIn = cbBox_CheckIn_Time.SelectedIndex;
                    break;
            }
        }
        private void cbBox_CheckIn_AM_PM_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbBox_CheckIn_AM_PM.SelectedIndex)
            {
                case 0:
                    Selected_CheckIn_AM_PM = cbBox_CheckIn_AM_PM.SelectedIndex;
                    break;
                case 1:
                    Selected_CheckIn_AM_PM = cbBox_CheckIn_AM_PM.SelectedIndex;
                    break;
            }
        }
        private void cbBox_CheckOut_Time_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbBox_CheckOut_Time.SelectedIndex)
            {
                case 0:
                    SelectedTime_CheckOut = cbBox_CheckOut_Time.SelectedIndex;
                    break;
                case 1:
                    SelectedTime_CheckOut = cbBox_CheckOut_Time.SelectedIndex;
                    break;
                case 2:
                    SelectedTime_CheckOut = cbBox_CheckOut_Time.SelectedIndex;
                    break;
                case 3:
                    SelectedTime_CheckOut = cbBox_CheckOut_Time.SelectedIndex;
                    break;
                case 4:
                    SelectedTime_CheckOut = cbBox_CheckOut_Time.SelectedIndex;
                    break;
                case 5:
                    SelectedTime_CheckOut = cbBox_CheckOut_Time.SelectedIndex;
                    break;
                case 6:
                    SelectedTime_CheckOut = cbBox_CheckOut_Time.SelectedIndex;
                    break;
                case 7:
                    SelectedTime_CheckOut = cbBox_CheckOut_Time.SelectedIndex;
                    break;
                case 8:
                    SelectedTime_CheckOut = cbBox_CheckOut_Time.SelectedIndex;
                    break;
                case 9:
                    SelectedTime_CheckOut = cbBox_CheckOut_Time.SelectedIndex;
                    break;
                case 10:
                    SelectedTime_CheckOut = cbBox_CheckOut_Time.SelectedIndex;
                    break;
                case 11:
                    SelectedTime_CheckOut = cbBox_CheckOut_Time.SelectedIndex;
                    break;
            }
        }
        private void cbBox_CheckOut_AM_PM_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbBox_CheckOut_AM_PM.SelectedIndex)
            {
                case 0:
                    Selected_CheckOut_AM_PM = cbBox_CheckOut_AM_PM.SelectedIndex;
                    break;
                case 1:
                    Selected_CheckOut_AM_PM = cbBox_CheckOut_AM_PM.SelectedIndex;
                    break;
            }
        }
        */

        private void nud_NumberOfGuest_ValueChanged(object sender, EventArgs e)
        {
            noOfGuest = (Int32)nud_NumberOfGuest.Value;
        }

        public int Guest
        {
            get { return guest; }
            set { guest = value; }
        }

        public int NoOfGuest
        {
            get { return noOfGuest; }
            set { noOfGuest = value; }
        }

        public String SelectedTime_CheckIn//No need to have setters because it is a const var
        {
            get { return selectedTime_CheckIn; }
            set { selectedTime_CheckIn = value; }
        }

        public String SelectedTime_CheckOut//No need to have setters because it is a const var
        {
            get { return selectedTime_CheckOut; }
            set { selectedTime_CheckOut = value; }
        }

        public DateTime CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }
        }

        public DateTime CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }
    }
}
