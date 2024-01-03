using Guna.UI2.WinForms;
using HMS.AppData;
using HMS.Forms;
using Pabo.Calendar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;


namespace HMS
{
    public partial class Frm_BookNow_S1 : Form
    {
        private Frm_BookNow_S1 s1;
        private Frm_BookNow_S2 s2;
        private Frm_BookNow_S3 s3;

        private int noOfGuest_children;
        private int noOfGuest_adult;
        private int noOfGuest_senior;

        private String selectedTime_CheckIn = "After 2:00 PM";
        private String selectedTime_CheckOut = "Before 12:00 PM";
        public DateTime checkIn = DateTime.Now;
        public DateTime checkOut = DateTime.Now;

        private HMSEntities db;

        public Frm_BookNow_S1()
        {
            InitializeComponent();
            //userRepo = new UserRepository();
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
                nud_NumberOfGuest_Adult.Value = NoOfGuest_Adult;
                nud_NumberOfGuest_Children.Value = NoOfGuest_Children;
                nud_NumberOfGuest_SeniorCitizen.Value = NoOfGuest_Senior;

                DateTimePicker_CheckIn.Value = CheckIn;
                DateTimePicker_CheckOut.Value = CheckOut;
            }
            else
            {
                nud_NumberOfGuest_Adult.Value = s1.NoOfGuest_Adult;
                nud_NumberOfGuest_Children.Value = s1.NoOfGuest_Children;
                nud_NumberOfGuest_SeniorCitizen.Value = s1.NoOfGuest_Senior;

                DateTimePicker_CheckIn.Value = s1.CheckIn;
                DateTimePicker_CheckOut.Value = s1.CheckOut;
            }
            //dateArray.Add(new DateTime(2023, 11, 10));
            //dateArray.Add(new DateTime(2023, 11, 15));
            //dateArray.Add(new DateTime(2023, 11, 20));
            //FormDisplay();
        }
        private List<vw_get_total_reservation_by_date> GetTotalReservationByDate(ref string message)
        {
            var retVal = new List<AppData.vw_get_total_reservation_by_date>();

            try
            {
                using (db = new HMSEntities())
                {
                    retVal = db.vw_get_total_reservation_by_date.ToList();
                }
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return retVal;

        }
        private void mc_GuideBooking_DayQueryInfo(object sender, Pabo.Calendar.DayQueryInfoEventArgs e)
        {
            List<DateTime> dateArray = new List<DateTime>();

            var message = string.Empty;
            var Dates = new List<AppData.vw_get_total_reservation_by_date>();
            if (s1 == null)
            {
                Dates = GetTotalReservationByDate(ref message);
            }
            else
            {
                Dates = s1.GetTotalReservationByDate(ref message);
            }

            foreach (var date in Dates)
            {
                dateArray.Add(date.reservationDateIn.Date); // Use Date property to get only the date part
                Console.WriteLine(date.reservationDateIn);
            }

            var size = dateArray.Count;

            // Count occurrences of each date
            var dateCounts = dateArray.GroupBy(date => date).ToDictionary(group => group.Key, group => group.Count());

            for (int i = 0; i < size; i++)
            {
                // Check date and mark it with color to specify occupied or not available to select for booking.
                if (e.Date.Date == dateArray[i])
                {
                    // Check the count of reservations for the current date
                    if (dateCounts.ContainsKey(e.Date.Date))
                    {
                        int count = dateCounts[e.Date.Date];

                        // Set different colors based on the count threshold
                        if (count <= 27 && count >= 21)
                        {
                            // Fully booked
                            e.Info.DateColor = Color.White;
                            e.Info.BackColor1 = Color.Blue; // You can choose a different color for fully booked dates
                            e.OwnerDraw = true;
                        }
                        else if (count <= 20 && count >= 11)
                        {
                            // Almost fully booked
                            e.Info.DateColor = Color.White;
                            e.Info.BackColor1 = Color.OrangeRed; // You can choose a different color for almost fully booked dates
                            e.OwnerDraw = true;
                        }
                        else if (count <= 10 && count >= 1)
                        {
                            // Minimally booked
                            e.Info.DateColor = Color.White;
                            e.Info.BackColor1 = Color.YellowGreen; // You can choose a different color for minimally booked dates
                            e.OwnerDraw = true;
                        }
                        else
                        {
                            //// Not booked
                            //e.Info.ResetBackColor();
                        }
                    }
                }
            }
        }


        //private void mc_GuideBooking_DayQueryInfo(object sender, Pabo.Calendar.DayQueryInfoEventArgs e)
        //{

        //    List<DateTime> dateArray = new List<DateTime>();

        //    var message = string.Empty;
        //    var Dates = userRepo.GetTotalReservationByDate(ref message);

        //    foreach (var date in Dates)
        //    {
        //        dateArray.Add(date.reservationDateIn.Date);
        //        //Console.WriteLine(date.reservationDateIn.Date);
        //    }


        //    var size = dateArray.Count;
        //    for (int i = 0; i < size; i++)
        //    {
        //        // Check date and mark it with color to specify occupied or not available to select for booking.
        //        if (e.Date == dateArray[i])
        //        {
        //            // Add custom formatting
        //            e.Info.DateColor = Color.White;
        //            e.Info.BackColor1 = Color.Red;
        //            e.OwnerDraw = true;
        //        }
        //    }
        //}
        private static Frm_BookNow_S1 _instace;
        public static Frm_BookNow_S1 GetInstance
        {
            get { return _instace; }
            set { _instace = value; }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_HomePage hp = new Frm_HomePage();
            hp.Show();
            Frm_ProcessPayment.HasPaid = false;


            //if (S1)
            //{
            //    pnl_main.Controls.Clear();
            //    s1.Show();
            //}

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var countedRows = new AdminRepository();
            if (countedRows.CheckRoomsAvailability() == 0)
            {
                var msg = "System is under Maintenance\nSorry for inconvenience";
                MessageDialog.Show(msg, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
                return;
            }

            //pnl_Main.Controls.Clear();
            _instace = this;
            this.Hide();
            if (this.s2 == null)
            {
                Frm_BookNow_S2 s2 = new Frm_BookNow_S2(this, this.s2, this.s3);
                s2.Show();
              //Frm_BookNow_S2 s2 = new Frm_BookNow_S2(this, this.s2, this.s3);

            }
            else
            {
                //this.s2 = new Frm_BookNow_S2(this, this.s2, s3, s4);
                //s2.GetInstance.Show();
                s2.Show();
            }

            //s2.TopLevel = false;
            //s2.Dock = DockStyle.Fill;
            //pnl_Main.Controls.Add(s2);
            //s2.Show();
            Console.WriteLine("Guest: "+(NoOfGuest_Adult+NoOfGuest_Children+NoOfGuest_Senior));
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
        }

        private void DateTimePicker_CheckOut_ValueChanged(object sender, EventArgs e)
        {
            checkOut = DateTimePicker_CheckOut.Value.Date;
        }
        private void nud_NumberOfGuest_Adult_ValueChanged(object sender, EventArgs e)
        {
            noOfGuest_adult = (Int32)nud_NumberOfGuest_Adult.Value;
        }
        private void nud_NumberOfGuest_Children_ValueChanged(object sender, EventArgs e)
        {
            noOfGuest_children = (Int32)nud_NumberOfGuest_Children.Value;
        }
        private void nud_NumberOfGuest_SeniorCitizen_ValueChanged(object sender, EventArgs e)
        {
            noOfGuest_senior = (Int32)nud_NumberOfGuest_SeniorCitizen.Value;
        }

        public int NoOfGuest_Children
        {
            get { return noOfGuest_children; }
            set { noOfGuest_children = value; }
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

        public int NoOfGuest_Adult { get => noOfGuest_adult; set => noOfGuest_adult = value; }
        public int NoOfGuest_Senior { get => noOfGuest_senior; set => noOfGuest_senior = value; }
    }
}
