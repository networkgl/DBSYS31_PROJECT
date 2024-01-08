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
using System.Windows.Interop;
using System.Windows.Media;


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
        public DateTime checkOut = DateTime.Now.AddDays(1);


        private HMSEntities db;
        private UserRepository userRepo;
        private List<vw_get_total_reservation_by_date> retVal = new List<vw_get_total_reservation_by_date>();


        public Frm_BookNow_S1()
        {
            InitializeComponent();
            //userRepo = new UserRepository();
        }
        private UserRepository GetInstanceUserRepo()
        {
            if (userRepo == null)
            {
                userRepo = new UserRepository();
            }
            return userRepo;
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
            mc_GuideBooking.ActiveMonth.Year = DateTime.Now.Year;
            mc_GuideBooking.Refresh();

            //mc_GuideBooking.Invalidate();


            if (s2 == null)
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

                //s1.InitializeDateItems();
            }
            //dateArray.Add(new DateTime(2023, 11, 10));
            //dateArray.Add(new DateTime(2023, 11, 15));
            //dateArray.Add(new DateTime(2023, 11, 20));
            //FormDisplay();



            totalRooms = 0;
            seventyFivePercent = 0.0;
            fiftyPercent = 0.0;
            twentyFivePercent = 0.0;

            var message = string.Empty;
            try
            {
                using (db = new HMSEntities())
                {
                    totalRooms = ((int)RoomAvailable.MAX * db.ROOM_DETAILS.Count());
                    seventyFivePercent = (totalRooms * 0.75);
                    fiftyPercent = (totalRooms * 0.50);
                    twentyFivePercent = (totalRooms * 0.25);

                    //Console.WriteLine(seventyFivePercent);
                    //Console.WriteLine(fiftyPercent);
                    //Console.WriteLine(twentyFivePercent);

                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                MessageDialog.Show(message, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
            }


            //Assign labels value based on max rooms calculation
            lbl_oneHundred.Text = $"{totalRooms} - Fully Booked";
            lbl_seventyFive.Text = $"{seventyFivePercent + 1} - {totalRooms-1}";
            lbl_fifty.Text = $"{fiftyPercent + 1} - {seventyFivePercent}";
            lbl_twentyFive.Text = $"{twentyFivePercent + 1} - {fiftyPercent}";
            lbl_below.Text = $"1 - {twentyFivePercent}";

            InitializeDateItems();
        }

        private void InitializeDateItems()
        {
            var message = string.Empty;
            //var retVal = userRepo.GetTotalReservationByDate(ref message);

            if (s1 == null)
            {
                RetVal = GetInstanceUserRepo().GetTotalReservationByDate();
            }
            else
            {
                RetVal = s1.GetInstanceUserRepo().GetTotalReservationByDate();
            }

            List<DateTime> dateArray = new List<DateTime>();
            List<int> totalReservation = new List<int>();
            foreach (var dates in RetVal)
            {
                totalReservation.Add((int)dates.TotalReservationByDate);

                // Add each date to the existing list
                dateArray.Add(new DateTime(dates.Date.Year, dates.Date.Month, dates.Date.Day));

                Console.WriteLine(dates.TotalReservationByDate +"\n"+ dates.Date.Year, dates.Date.Month, dates.Date.Day);
            }

            // Size of the DateItem array should match the size of dateArray
            var size = dateArray.Count;

            // Create an array of DateItem instances
               DateItem[] d = new DateItem[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Total Reservation: {totalReservation[i]}, Date: {dateArray[i].ToShortDateString()}");

                // Set different colors based on the count threshold
                if (totalReservation[i] == totalRooms)
                {
                    // Fully booked
                    d[i] = new DateItem();
                    d[i].Date = dateArray[i];
                    d[i].DateColor = System.Drawing.Color.Black;
                    d[i].BackColor1 = System.Drawing.Color.FromArgb(178, 190, 195);
                }
                else if (totalReservation[i] < totalRooms && totalReservation[i] >= seventyFivePercent + 1)
                {
                    // Almost fully booked
                    d[i] = new DateItem();
                    d[i].Date = dateArray[i];
                    d[i].DateColor = System.Drawing.Color.Black;
                    d[i].BackColor1 = System.Drawing.Color.FromArgb(116, 185, 255);
                }
                else if (totalReservation[i] <= seventyFivePercent && totalReservation[i] >= fiftyPercent + 1)
                {
                    // Half of the total rooms
                    d[i] = new DateItem();
                    d[i].Date = dateArray[i];
                    d[i].DateColor = System.Drawing.Color.Black;
                    d[i].BackColor1 = System.Drawing.Color.FromArgb(255, 118, 117);
                }
                else if (totalReservation[i] <= fiftyPercent && totalReservation[i] >= twentyFivePercent + 1)
                {
                    // Minimally booked
                    d[i] = new DateItem();
                    d[i].Date = dateArray[i];
                    d[i].DateColor = System.Drawing.Color.Black;
                    d[i].BackColor1 = System.Drawing.Color.YellowGreen;
                }
                else if (totalReservation[i] <= twentyFivePercent && totalReservation[i] >= 1)
                {
                    // Minimally booked
                    d[i] = new DateItem();
                    d[i].Date = dateArray[i];
                    d[i].DateColor = System.Drawing.Color.Black;
                    d[i].BackColor1 = System.Drawing.Color.FromArgb(250, 201, 21);
                }
            }
            mc_GuideBooking.AddDateInfo(d);
        }
        private void mc_GuideBooking_DayRender(object sender, DayRenderEventArgs e)
        {

        }
        private void mc_GuideBooking_DayQueryInfo(object sender, Pabo.Calendar.DayQueryInfoEventArgs e)
        {
            //DateBookingDisplay(e);
        }
        private void DateBookingDisplay(Pabo.Calendar.DayQueryInfoEventArgs e)
        {
            var message = string.Empty;
            if (s1 == null)
            {
                RetVal = GetInstanceUserRepo().GetTotalReservationByDate();
            }
            else
            {
                RetVal = s1.GetInstanceUserRepo().GetTotalReservationByDate();
            }

            // Find the reservation for the current date, if any
            var currentDateReservation = RetVal.FirstOrDefault(d => d.Date.Date == e.Date.Date);



            if (currentDateReservation != null)
            {
                var total = currentDateReservation.TotalReservationByDate;
                Console.WriteLine($"Total Reservation: {total}, Date: {currentDateReservation.Date.ToShortDateString()}");


                // Set different colors based on the count threshold
                if (total == totalRooms)
                {
                    // Fully booked
                    e.Info.DateColor = System.Drawing.Color.Black;
                    e.Info.BackColor1 = System.Drawing.Color.FromArgb(178, 190, 195);
                    e.OwnerDraw = true;
                }
                else if (total < totalRooms && total >= seventyFivePercent)
                {
                    // Almost fully booked
                    e.Info.DateColor = System.Drawing.Color.White;
                    e.Info.BackColor1 = System.Drawing.Color.Blue;
                    e.OwnerDraw = true;
                }
                else if (total <= seventyFivePercent && total >= fiftyPercent)
                {
                    // Half of the total rooms
                    e.Info.DateColor = System.Drawing.Color.White;
                    e.Info.BackColor1 = System.Drawing.Color.OrangeRed;
                    e.OwnerDraw = true;
                }
                else if (total <= fiftyPercent && total >= twentyFivePercent)
                {
                    // Minimally booked
                    e.Info.DateColor = System.Drawing.Color.Black;
                    e.Info.BackColor1 = System.Drawing.Color.YellowGreen;
                    e.OwnerDraw = true;
                }
                else if (total <= twentyFivePercent && total >= 1)
                {
                    // Minimally booked
                    e.Info.DateColor = System.Drawing.Color.Black;
                    e.Info.BackColor1 = System.Drawing.Color.FromArgb(250, 201, 21);
                    e.OwnerDraw = true;
                }
            }
            else
            {
                // Handle the case when there is no reservation for the current date
                // You may choose to set a default color or leave it unchanged
            }
        }
        //private void mc_GuideBooking_DayQueryInfo(object sender, Pabo.Calendar.DayQueryInfoEventArgs e)
        //{            
        //    //First group by date then count all
        //    var message = string.Empty;
        //    var retVal = userRepo.GetTotalReservationByDate(ref message);

        //    if (retVal.Count > 0)
        //    {
        //        foreach (var dates in retVal)
        //        {
        //            var total = dates.TotalReservationByDate;
        //            var date = dates.Date;

        //            Console.WriteLine(total);
        //            Console.WriteLine(date);
        //            Console.WriteLine();


        //            if (total == totalRooms)
        //            {

        //                //Fully booked
        //                e.Info.DateColor = Color.Black;
        //                e.Info.BackColor1 = Color.FromArgb(178, 190, 195); // You can choose a different color for fully booked dates
        //                e.OwnerDraw = true;
        //            }
        //            // Set different colors based on the count threshold
        //            else if (total > seventyFivePercent)
        //            {
        //                // Almost fully booked
        //                e.Info.DateColor = Color.White;
        //                e.Info.BackColor1 = Color.Blue; // You can choose a different color for fully booked dates
        //                e.OwnerDraw = true;
        //            }
        //            else if (total > fiftyPercent)
        //            {
        //                //Half of the total rooms
        //                e.Info.DateColor = Color.White;
        //                e.Info.BackColor1 = Color.OrangeRed; // You can choose a different color for almost fully booked dates
        //                e.OwnerDraw = true;
        //            }
        //            else if (total > twentyFivePercent)
        //            {
        //                // Minimally booked
        //                e.Info.DateColor = Color.Black;
        //                e.Info.BackColor1 = Color.YellowGreen; // You can choose a different color for minimally booked dates
        //                e.OwnerDraw = true;
        //            }
        //            else if (total <= 1)
        //            {
        //                // Minimally booked
        //                e.Info.DateColor = Color.Black;
        //                e.Info.BackColor1 = Color.FromArgb(250, 201, 21); // You can choose a different color for minimally booked dates
        //                e.OwnerDraw = true;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageDialog.Show("No current booking reservation", "Message", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Light);
        //    }
        //}

        //private void mc_GuideBooking_DayQueryInfo(object sender, Pabo.Calendar.DayQueryInfoEventArgs e)
        //{
        //    int count1 = 0, count2 = 0, count3 = 0, count4 = 0;

        //    List<DateTime> dateArray = new List<DateTime>();

        //    var message = string.Empty;
        //    var Dates = new List<AppData.vw_get_total_reservation_by_date>();


        //    if (s1 == null)
        //    {
        //        Dates = GetTotalReservationByDate(ref message);
        //    }
        //    else
        //    {
        //        Dates = s1.GetTotalReservationByDate(ref message);
        //    }

        //    foreach (var date in Dates)
        //    {
        //        dateArray.Add(date.reservationDateIn.Date); // Use Date property to get only the date part
        //        Console.WriteLine(date.reservationDateIn.Date);
        //    }

        //    // Count occurrences of each date
        //    var dateCounts = dateArray.GroupBy(date => date).ToDictionary(group => group.Key, group => group.Count());

        //    for (var i = 0; i < dateArray.Count; i++)
        //    {
        //        // Check date and mark it with color to specify occupied or not available to select for booking.
        //        if (e.Date.Date == dateArray[i])
        //        {
        //            // Check the count of reservations for the current date
        //            if (dateCounts.ContainsKey(e.Date.Date))
        //            {
        //                int count = dateCounts[e.Date.Date];

        //                var totalRooms = 0;
        //                var seventyFivePercent = 0.0;
        //                var fiftyPercent = 0.0;
        //                var twentyFivePercent = 0.0;

        //                try
        //                {
        //                    using (db = new HMSEntities())
        //                    {
        //                        totalRooms = ((int)RoomAvailable.MAX * db.ROOM_DETAILS.Count());
        //                        seventyFivePercent = (totalRooms * 0.75);
        //                        fiftyPercent = (totalRooms * 0.50);
        //                        twentyFivePercent = (totalRooms * 0.25);

        //                        //Console.WriteLine(seventyFivePercent);
        //                        //Console.WriteLine(fiftyPercent);
        //                        //Console.WriteLine(twentyFivePercent);

        //                    }
        //                }
        //                catch (Exception ex)
        //                {
        //                    message = ex.Message;
        //                }

        //                //Assign labels value based on max rooms calculation
        //                lbl_twentyFive.Text = $"{twentyFivePercent} above";
        //                lbl_fifty.Text = $"{fiftyPercent} above";
        //                lbl_seventyFive.Text = $"{seventyFivePercent} above";


        //                if (count == totalRooms)
        //                {
        //                    //Fully booked
        //                    e.Info.DateColor = Color.Black;
        //                    e.Info.BackColor1 = Color.FromArgb(178, 190, 195); // You can choose a different color for fully booked dates
        //                    e.OwnerDraw = true;
        //                }
        //                // Set different colors based on the count threshold
        //                else if (count > seventyFivePercent)
        //                {
        //                    // Almost fully booked
        //                    e.Info.DateColor = Color.White;
        //                    e.Info.BackColor1 = Color.Blue; // You can choose a different color for fully booked dates
        //                    e.OwnerDraw = true;

        //                    count4++;
        //                }
        //                else if (count > fiftyPercent)
        //                {
        //                    //Half of the total rooms
        //                    e.Info.DateColor = Color.White;
        //                    e.Info.BackColor1 = Color.OrangeRed; // You can choose a different color for almost fully booked dates
        //                    e.OwnerDraw = true;

        //                    count3++;
        //                }
        //                else if (count > twentyFivePercent)
        //                {
        //                    // Minimally booked
        //                    e.Info.DateColor = Color.Black;
        //                    e.Info.BackColor1 = Color.YellowGreen; // You can choose a different color for minimally booked dates
        //                    e.OwnerDraw = true;

        //                    count2++;
        //                }
        //                else if (count <= 1)
        //                {
        //                    // Minimally booked
        //                    e.Info.DateColor =  Color.Black;
        //                    e.Info.BackColor1 = Color.FromArgb(250, 201, 21); // You can choose a different color for minimally booked dates
        //                    e.OwnerDraw = true;

        //                    count1++;
        //                }
        //            }
        //        }
        //    }
        //    Console.WriteLine(count1);
        //    Console.WriteLine(count2);
        //    Console.WriteLine(count3);
        //    Console.WriteLine(count4);

        //}


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
        private int totalRooms;
        private double seventyFivePercent;
        private double fiftyPercent;
        private double twentyFivePercent;

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
            if ((noOfGuest_adult+noOfGuest_children+noOfGuest_senior) == 0)
            {
                MessageDialog.Show("Please select type of guest", "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
                return;
            }

            if ((noOfGuest_adult + noOfGuest_children + noOfGuest_senior) == 1 && noOfGuest_children == 1)
            {
                MessageDialog.Show("Children itself is not possible to checkin\nPlease select guardian or adult.", "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
                return;
            }


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
            if (DateTimePicker_CheckIn.Value < DateTime.Now)
            {
                DateTimePicker_CheckIn.Value = DateTime.Now;
            }
            else
            {
                checkIn = DateTimePicker_CheckIn.Value.Date;
            }
        }

        private void DateTimePicker_CheckOut_ValueChanged(object sender, EventArgs e)
        {
            if (DateTimePicker_CheckOut.Value <= checkIn)
            {
                MessageDialog.Show("Check-out date must be after the check-in date.", "Message", MessageDialogButtons.OK, MessageDialogIcon.Warning, MessageDialogStyle.Dark);
                DateTimePicker_CheckOut.Value = DateTimePicker_CheckIn.Value.AddDays(1);
            }
            else
            {
                checkOut = DateTimePicker_CheckOut.Value.Date;
            }
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
        public List<vw_get_total_reservation_by_date> RetVal { get => retVal; set => retVal = value; }
    }
}
