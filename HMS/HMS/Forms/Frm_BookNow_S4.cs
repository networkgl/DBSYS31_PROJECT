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
using System.Windows.Forms;
using System.Windows.Interop;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;
//using Aspose.Words;
//using Document = Aspose.Words.Document;

namespace HMS
{
    public partial class Frm_BookNow_S4 : Form
    {
        //private static Frm_BookNow_S4 confirmation;
        //private int roomType = this.s2.RoomType;

        //public string NoOfGuest => Frm_BookNow_S1.GetInstance().NoOfGuest.ToString();
        //public string Guest => Frm_BookNow_S1.GetInstance().Guest.ToString(); // Modify this based on what you want to display
        //public string CheckIn => Frm_BookNow_S1.GetInstance().SelectedTime_CheckIn.ToString();
        //public string CheckOut => Frm_BookNow_S1.GetInstance().SelectedTime_CheckOut.ToString();

        //private int guest = Frm_BookNow_S1.GetInstance().Guest;
        //private DateTime checkInDate = Frm_BookNow_S1.GetInstance().CheckIn;
        //private DateTime checkOutDate = Frm_BookNow_S1.GetInstance().CheckOut;
        //private int timeCheckIn = Frm_BookNow_S1.GetInstance().SelectedTime_CheckIn;
        //private int timeCheckOut = Frm_BookNow_S1.GetInstance().SelectedTime_CheckOut;
        //private int timeCheckIn_AM_PM = Frm_BookNow_S1.GetInstance().Selected_CheckIn_AM_PM;
        //private int timeCheckOut_AM_PM = Frm_BookNow_S1.GetInstance().Selected_CheckOut_AM_PM;
        //private string NoOfGuest = String.Empty,Guest = String.Empty, CheckIn = String.Empty, CheckOut = String.Empty, CheckIn_am_pm = String.Empty, CheckOut_am_pm = String.Empty, CheckIn_date = String.Empty, CheckOut_date = String.Empty, TotalPrice = String.Empty, NumberOfDays = String.Empty;
        private int totalDays;

        private Frm_BookNow_S1 s1;
        private Frm_BookNow_S2 s2;
        private Frm_BookNow_S3 s3;

        public Frm_BookNow_S4()
        {
            InitializeComponent();
        }
        public Frm_BookNow_S4(Frm_BookNow_S1 s1, Frm_BookNow_S2 s2, Frm_BookNow_S3 s3)
        {
            InitializeComponent();
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
        }
        /*
        public Frm_BookNow_S4 (string _noOfGuest, string guest, string checkIn, string checkOut, string checkIn_am_pm, string checkOut_am_pm, string checkIn_date, string checkOut_date, string totalPrice)
        {
            InitializeComponent();
            NoOfGuest = _noOfGuest;
            Guest = guest;
            CheckIn = checkIn;
            CheckOut = checkOut;
            CheckIn_am_pm = checkIn_am_pm;
            CheckOut_am_pm = checkOut_am_pm;
            CheckIn_date = checkIn_date;
            CheckOut_date = checkOut_date;
            //NumberOfDays = numberOfDays;
            TotalPrice = totalPrice;
        }
        */

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }

        //public static Frm_BookNow_S4 GetInstance()
        //{
        //    if (confirmation == null)
        //        confirmation = new Frm_BookNow_S4();
        //    return confirmation;
        //}
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
            s3.Show();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var waitForm = new WaitFormFunc();

            var msg = "Are you sure all information is correct ? If yes,\nthen you can proceed to payment section";
            bool Proceed = MessageDialog.Show(msg, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Question, MessageDialogStyle.Light) == DialogResult.Yes;
            if (Proceed)
            {

                msg = "Please input the amount to be paid";
                MessageDialog.Show(msg,"Message", MessageDialogButtons.OK, MessageDialogIcon.Information,MessageDialogStyle.Light);

                
                //Do something
                try
                {
                    //this.Hide();
                    waitForm.Show(this);
                    Thread.Sleep(1000);
                    waitForm.Close();

                    msg = "Payment Complete";
                    MessageDialog.Show(msg, "Message", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Light);

                    btn_DownloadOffline.Visible = true;
                    lbl_DownloadNow.Visible = true;
                    btnConfirm.Visible = false;
                }
                catch { }    
            }
        }
        private void btn_DownloadOffline_Click(object sender, EventArgs e)
        {
            /*
            var msg = "Do you want to download the booking details offline ?";
            bool Download = MessageDialog.Show(msg, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Question, MessageDialogStyle.Light) == DialogResult.Yes;

            if (Download)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.FileName = "BookingDetails.pdf"; // Default file name

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Generate the PDF receipt
                    Document doc = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    doc.Open();

                    // Add content to the PDF
                    doc.Add(new Paragraph("Booking Details")); // Replace with your actual content

                    doc.Close();
                }
            }
            var msg = "Do you want to download the booking details offline?";
            bool Download = MessageDialog.Show(msg, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Question, MessageDialogStyle.Light) == DialogResult.Yes;

            if (Download)
            {
                // Load the PDF template
                PdfReader pdfReader = new PdfReader("template.pdf");

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.FileName = "BookingDetails.pdf"; // Default file name

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        // Create a PdfStamper
                        PdfStamper pdfStamper = new PdfStamper(pdfReader, fs);

                        // Optionally, flatten the PDF
                        pdfStamper.FormFlattening = true;

                        // Close the PdfStamper
                        pdfStamper.Close();
                    }
                }
            }
            */

            /*
            string templateFilePath = "template1.pdf"; // Default template file path

            var msg = "Do you want to download the booking details offline?";
            bool Download = MessageDialog.Show(msg, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Question, MessageDialogStyle.Light) == DialogResult.Yes;

            if (Download)
            {
                // Load the PDF template
                PdfReader pdfReader = new PdfReader(templateFilePath);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.FileName = "BookingDetails.pdf"; // Default file name

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        // Create a PdfStamper
                        PdfStamper pdfStamper = new PdfStamper(pdfReader, fs);

                        // Replace placeholders with actual values
                        AcroFields formFields = pdfStamper.AcroFields;
                        formFields.SetField("labelName", "John Doe");
                        //formFields.SetField("TotalAmount", "$100.00");

                        // Optionally, flatten the PDF
                        pdfStamper.FormFlattening = true;

                        // Close the PdfStamper
                        pdfStamper.Close();
                    }
                }
            }
            */

            /*
            var msg = "Do you want to download the booking details offline?";
            bool Download = MessageDialog.Show(msg, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Question, MessageDialogStyle.Light) == DialogResult.Yes;

            if (Download)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.FileName = "BookingDetails.pdf"; // Default file name

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Generate the PDF receipt
                    Document doc = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    doc.Open();

                    // Create a custom font for the title
                    Font titleFont = FontFactory.GetFont(FontFactory.TIMES_BOLD, 24, BaseColor.BLACK);

                    // Create a custom font for the content
                    Font contentFont = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, BaseColor.BLACK);

                    // Add the title to the document
                    Paragraph title = new Paragraph("Booking Details", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    title.SpacingBefore = 20f;
                    title.SpacingAfter = 20f;
                    doc.Add(title);

                    // Booking details
                    string bookingId = "Booking ID: 123456";
                    string guestName = "Guest Name: John Doe";
                    string totalGuest = "Total Guests: 3";
                    string roomType = "Room Type: Premiere Deluxe";
                    string checkinTime = "Check-In Time: 2023-10-31 15:00";
                    string checkoutTime = "Check-Out Time: 2023-11-02 11:00";
                    string totalPayment = "Total Payment: $300.00";

                    // Create a paragraph for the booking details with proper formatting
                    Paragraph bookingDetails = new Paragraph();
                    bookingDetails.Add(new Chunk(bookingId, contentFont));
                    bookingDetails.Add(Chunk.NEWLINE);
                    bookingDetails.Add(new Chunk(guestName, contentFont));
                    bookingDetails.Add(Chunk.NEWLINE);
                    bookingDetails.Add(new Chunk(totalGuest, contentFont));
                    bookingDetails.Add(Chunk.NEWLINE);
                    bookingDetails.Add(new Chunk(roomType, contentFont));
                    bookingDetails.Add(Chunk.NEWLINE);
                    bookingDetails.Add(new Chunk(checkinTime, contentFont));
                    bookingDetails.Add(Chunk.NEWLINE);
                    bookingDetails.Add(new Chunk(checkoutTime, contentFont));
                    bookingDetails.Add(Chunk.NEWLINE);
                    bookingDetails.Add(new Chunk(totalPayment, contentFont));

                    // Add the booking details paragraph to the document
                    doc.Add(bookingDetails);

                    // Close the document
                    doc.Close();
                }
            }
            */

            var msg = "Do you want to download the booking details offline?";
            bool Download = MessageDialog.Show(msg, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Question, MessageDialogStyle.Light) == DialogResult.Yes;

            if (Download)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.FileName = "BookingDetails.pdf"; // Default file name

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Generate the PDF receipt
                    Document doc = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    doc.Open();

                    // Create fonts for different sections
                    Font titleFont = FontFactory.GetFont(FontFactory.TIMES_BOLD, 18, BaseColor.BLACK);
                    Font headerFont = FontFactory.GetFont(FontFactory.TIMES_BOLD, 14, BaseColor.BLACK);
                    Font contentFont = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, BaseColor.BLACK);

                    // Title
                    Paragraph title = new Paragraph("You have successfully booked a hotel room.", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    title.SpacingBefore = 20f;
                    title.SpacingAfter = 20f;
                    doc.Add(title);

                    // Booking Reference
                    Paragraph bookingRef = new Paragraph("BOOKING REFERENCE", headerFont);
                    doc.Add(bookingRef);
                    doc.Add(Chunk.NEWLINE);

                    // Boarding Details
                    string spaces = "                                          ------------                                         ";
                    //Paragraph boarding1 = new Paragraph("CHECK - IN            "+ spaces + "              CHECK - OUT"+"" +
                    //                                    "\nFri, Oct 28, 2023                                                                                                                                       Sat, Nov 4, 2023", contentFont);
                    //doc.Add(boarding1);

                    headerFont = FontFactory.GetFont(FontFactory.TIMES_BOLD, 12, BaseColor.BLACK);
                    Paragraph boarding1 = new Paragraph("CHECK - IN            " + spaces + "              CHECK - OUT",headerFont);
                    doc.Add(boarding1);



                    contentFont = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 11, BaseColor.BLACK);
                    Paragraph boarding2 = new Paragraph("Fri, Oct 28, 2023                                                                                                                                       Sat, Nov 4, 2023", contentFont);
                    doc.Add(boarding2);

                    Paragraph boarding = new Paragraph("After 1:00 AM                                                                                                                                            Before 6:00 PM", contentFont);
                    doc.Add(boarding);
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);


                    headerFont = FontFactory.GetFont(FontFactory.TIMES_BOLD, 12, BaseColor.BLACK);

                    // Route and Flight Number
                    Paragraph room = new Paragraph("ROOM DETAILS", headerFont);
                    doc.Add(room);
                    doc.Add(Chunk.NEWLINE);

                    Room.GetInstance();
                    Paragraph roomDetails = new Paragraph(Room.RoomType+"\n"+Room.RoomDetails+"\n"+Room.RoomPrice + "\n" +Room.PriceDetails, contentFont);
                    doc.Add(roomDetails);
                    doc.Add(Chunk.NEWLINE);



                    //// Departure and Arrival
                    //Paragraph departureArrival = new Paragraph("DEPARTURE ARRIVAL", contentFont);
                    //doc.Add(departureArrival);
                    //doc.Add(Chunk.NEWLINE);
                    //Paragraph departureArrivalDetails = new Paragraph("1930H\n10 Jul 2023\nMonday  2020H\n10 Jul 2023\nMonday", contentFont);
                    //doc.Add(departureArrivalDetails);
                    //doc.Add(Chunk.NEWLINE);

                    //// Passenger Details
                    //Paragraph passengerDetails = new Paragraph("PASSENGER NAME SEAT NUMBER TICKET NUMBER CABIN CLASS", contentFont);
                    //doc.Add(passengerDetails);
                    //doc.Add(Chunk.NEWLINE);
                    //Paragraph passenger1 = new Paragraph("1. MR. GIANLLOYDBATADLAN PINOTE  14B  0799380792754  ECONOMY", contentFont);
                    //doc.Add(passenger1);
                    //doc.Add(Chunk.NEWLINE);

                    //// Greeting
                    //Paragraph greeting = new Paragraph("Dear MR. GIANLLOYDBATADLAN PINOTE,", contentFont);
                    //doc.Add(greeting);
                    //doc.Add(Chunk.NEWLINE);
                    //Paragraph mabuhay = new Paragraph("Mabuhay!", contentFont);
                    //doc.Add(mabuhay);
                    //doc.Add(Chunk.NEWLINE);
                    //Paragraph reminder = new Paragraph("You have successfully checked in for your flight from ILOILO (ILO) to CEBU (CEB). Please remember to print your boarding pass/es before you proceed to the airport.", contentFont);
                    //doc.Add(reminder);

                    // Close the document
                    doc.Close();
                }
            }

            /*
            var msg = "Do you want to download the booking details offline?";
            bool Download = MessageDialog.Show(msg, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Question, MessageDialogStyle.Light) == DialogResult.Yes;

            if (Download)
            {
                // Load the PDF template
                PdfReader pdfReader = new PdfReader("template.pdf");

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.FileName = "BookingDetails.pdf"; // Default file name

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        // Create a PdfStamper
                        PdfStamper pdfStamper = new PdfStamper(pdfReader, fs);

                        // Get the AcroFields from the template
                        AcroFields formFields = pdfStamper.AcroFields;

                        // Replace placeholders with actual values
                        // Use the SetField method with label fields
                        formFields.SetField("label", "Guest Name: Gian Lloyd");


                        // Optionally, flatten the PDF
                        pdfStamper.FormFlattening = true;

                        // Close the PdfStamper
                        pdfStamper.Close();
                    }
                }
            }*/

            /*
            var msg = "Do you want to download the booking details offline?";
            bool Download = MessageDialog.Show(msg, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Question, MessageDialogStyle.Light) == DialogResult.Yes;

            if (Download)
            {
                // Load the Word template
                var doc = new Document("template.docx");

                // Replace placeholders with actual values
                doc.Range.Replace("label", "John Doe");
                // Add more Replace calls for other placeholders

                // Save the Word document with replaced values
                doc.Save("temp_document.docx"); // Save it as a temporary Word document

                // Convert the Word document to PDF
                Aspose.Words.Saving.PdfSaveOptions pdfSaveOptions = new Aspose.Words.Saving.PdfSaveOptions();
                doc.Save("temp_document.pdf", pdfSaveOptions);

                // Prompt the user to save the PDF
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.FileName = "BookingDetails.pdf"; // Default file name

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Copy("temp_document.pdf", saveFileDialog.FileName, true);
                }

                // Clean up temporary files
                File.Delete("temp_document.docx");
                File.Delete("temp_document.pdf");
            }
            */

        }

        private void InitializeConfirmation()
        {
            /*
            var NoOfDays = Frm_BookNow_S3.GetInstance().NumberOfDays;
            Console.WriteLine("S4 :" + Frm_BookNow_S3.GetInstance().NumberOfDays);
            var formatString = String.Empty;

            if (NoOfDays > 1)
            {
                formatString = NoOfDays + " Days";
            }
            else
            {
                formatString = NoOfDays + " Day";
            }

            lbl_CheckIn_Time.Text = CheckIn + " " + CheckIn_am_pm;
            lbl_CheckOut_Time.Text = CheckOut + " " + CheckOut_am_pm;
            lbl_CheckIn_Date.Text = CheckIn_date;
            lbl_CheckOut_Date.Text = CheckOut_date;
            lbl_totalPrice.Text = TotalPrice;
            lbl_Guest.Text = Guest;
            lbl_NumberOfDays.Text = formatString;
            lbl_NoOfGuest.Text = NoOfGuest;
             
             */
            lbl_CheckIn_Time.Text = s1.SelectedTime_CheckIn;
            lbl_CheckOut_Time.Text = s1.SelectedTime_CheckOut;
            lbl_CheckIn_Date.Text = s1.CheckIn.ToString("ddd, MMM dd, yyyy");
            lbl_CheckOut_Date.Text = s1.CheckOut.ToString("ddd, MMM dd, yyyy");
            lbl_totalPrice.Text = GetTotalAmount();
            lbl_Guest.Text = GetGuestByIndex();
            lbl_NumberOfDays.Text = isDays();
            lbl_NoOfGuest.Text = GetNoOfGuestByValue(s1.NoOfGuest).ToString();

            lbl_FullName.Text = s3.Lname + ", " + s3.Fname;
            lbl_ContactNumber.Text = s3.Phone.ToString();




            //lbl_CheckIn_Time.Text = CheckIn; // Update this based on the actual label names
            //lbl_CheckOut_Time.Text = CheckOut; // Update this based on the actual label names
            //lbl_NoOfGuest.Text = NoOfGuest; // Update this based on the actual label names
            //lbl_Guest.Text = Guest; // Update this based on the actual label names
            //lbl_NumberOfDays.Text = isDays(); // You can keep this logic
            //lbl_totalPrice.Text = GetTotalAmount(); // You can keep this logic
        }
        private String GetNoOfGuestByValue(int recVal)
        {
            return ParseVal(recVal);
        }        
        private String GetGuestByIndex()
        {
            string retVal = String.Empty;
            var GuestIndex = s1.Guest;
            //var GuestIndex = Frm_BookNow_S1.Guest;
            switch (GuestIndex)
            {
                case 0:
                    retVal = "Adult";
                    break;
                case 1:
                    retVal = "Adult and Children";
                    break;
                case 2:
                    retVal = "Senior Citizen";
                    break;
            }

            return retVal;
        }
        private String ParseVal(double retVal)
        {
            return retVal.ToString("#,##0");
        }
        private String GetTotalAmount()
        {
            var totalDys = GetTotalDayStayed(this.s1.CheckIn, this.s1.CheckOut); // Call this function to calculate the date gap between check-in and checkout
            //var totalDys = GetTotalDayStayed(Frm_BookNow_S1.checkIn, Frm_BookNow_S1.checkOut); // Call this function to calculate the date gap between check-in and checkout

            Console.WriteLine(totalDys);
            string retVal = String.Empty;
            var roomPrice = this.s2.RoomType;

            // Total Payment Based on RoomType multiplied by the totalDays of Stay
            switch (roomPrice)
            {
                case 0:
                    retVal = "₱ " + ParseVal(10000 * totalDys);
                    break;
                case 1:
                    retVal = "₱ " + ParseVal(14000 * totalDys);
                    break;
                case 2:
                    retVal = "₱ " + ParseVal(20000 * totalDys);
                    break;
            }
            return retVal;
        }
        private int GetTotalDayStayed(DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                return NumberOfDayss = 0; // Check-out date is before or equal to check-in date, no days of stay
            }
            else
            {
                return NumberOfDayss = (int)(checkOut - checkIn).TotalDays;             
               //Console.WriteLine("Total Days: " + NumberOfDays);
            }
            //return NumberOfDays;
        }



        public int NumberOfDayss
        {
            get { return totalDays; }
            set { totalDays = value; }
        }

        //Scratch Methods!
        private String isDays()
        {
            var TotalDays = String.Empty;

            if (NumberOfDayss > 1)
            {
                TotalDays = NumberOfDayss.ToString() + " Days";
            }
            else
            {
                TotalDays = NumberOfDayss.ToString() + " Day";
            }
            Console.WriteLine(TotalDays);
            return TotalDays;
        }
        private String GetTimeByIndex(string happen, int indexTime)
        {
            string retVal = String.Empty;
            switch (indexTime)
            {
                case 0:
                    retVal = "1:00" as String;
                    break;
                case 1:
                    retVal = "2:00" as String;
                    break;
                case 2:
                    retVal = "3:00" as String;
                    break;
                case 3:
                    retVal = "4:00" as String;
                    break;
                case 4:
                    retVal = "5:00" as String;
                    break;
                case 5:
                    retVal = "6:00" as String;
                    break;
                case 6:
                    retVal = "7:00" as String;
                    break;
                case 7:
                    retVal = "8:00" as String;
                    break;
                case 8:
                    retVal = "9:00" as String;
                    break;
                case 9:
                    retVal = "10:00" as String;
                    break;
                case 10:
                    retVal = "11:00" as String;
                    break;
                case 11:
                    retVal = "12:00" as String;
                    break;
            }
            return happen + retVal;
        }
        private String GetAM_PM_ByIndex(int index_AM_PM)
        {
            string retVal = String.Empty;
            switch (index_AM_PM)
            {
                case 0:
                    retVal = "AM" as String;
                    break;
                case 1:
                    retVal = "PM" as String;
                    break;
            }
            return retVal;
        }
        /*
    private int GetTotalDayStayed(int CheckInDay, int CheckOutDay)
    {
        var currMonthVal_Counter = 0;
        var prevMonthVal_Counter = 0;

        var checkInMonth = Frm_BookNow_S1.CheckIn.Month;
        var checkOutMonth = Frm_BookNow_S1.CheckOut.Month;

        int monthDifference = GetMonthDiff() * 30;//Call this function to get the total diff in months from checkin to checkout


        //Execte this loop to determine gaps of numnber in months and use that value to determine num of days with a gap of months
        if (checkInMonth == checkOutMonth && CheckInDay == CheckOutDay)
        {
            return totalDays = 0;//return zero directly if user attempts to book same month and days.
            //Addiditon blocking if statement is also need to be added in the datetimepicker of Frm_BookNow_S1 to block this kind of booking.
        }
        if (CheckInDay == CheckOutDay)
        {
            totalDays = monthDifference;
           return totalDays;
        }
        if (checkInMonth == checkOutMonth)
        {
            //Minus directly the gap days
            return totalDays = CheckOutDay - CheckInDay;
        }

        var getMonth = Frm_BookNow_S1.CheckIn.Month;
        var monthDays = 0;

        if (getMonth == 1 || getMonth == 3 || getMonth == 5 || getMonth == 7 || getMonth == 8 || getMonth == 10 || getMonth == 12)              
            monthDays = 31;               
        else
        {
            if (getMonth == 2)                    
                monthDays = 28;                    
            else
                monthDays = 30;
        }


        if (checkInMonth == checkOutMonth)
        {
            for (int j = 1; j <= CheckOutDay; j++)
            {
                if (j == CheckInDay)
                    continue;
                else
                    currMonthVal_Counter++;
            }
        }
        else
        {
            for (int i = CheckInDay; i <= monthDays; i++)
            {
                if (i == CheckInDay)
                    continue;
                else
                    prevMonthVal_Counter++;
            }
            for (int j = 1; j <= CheckOutDay; j++)
            {
                //if (j == CheckInDay)
                //    continue;
                //else
                    currMonthVal_Counter++;
            }
        }

        Console.WriteLine("Prev Month: " + prevMonthVal_Counter);
        Console.WriteLine("Curr Month: " + currMonthVal_Counter);

        Console.WriteLine(monthDifference);

        totalDays = monthDifference + prevMonthVal_Counter + currMonthVal_Counter; //Add the possible MonthDiff, the prev month counter and curr month counter to return total days of stay.
        return totalDays;
    }

    private int GetMonthDiff()
    {
        var retVal = 0;

        var monthGap1 = 0;
        var monthGap2 = 0;
        var monthDiffTotal = 0;

        var checkInMonth = Frm_BookNow_S1.CheckIn.Month;
        var checkOutMonth = Frm_BookNow_S1.CheckOut.Month;

        var checkInDay = Frm_BookNow_S1.CheckIn.Day;
        var checkOutDay = Frm_BookNow_S1.CheckOut.Day;



        if (checkInMonth == checkOutMonth)
        {
            return retVal = 0;
        }
        else
        {
            if (checkOutMonth > checkInMonth && checkOutDay > checkInDay)
            {
                for (int i = checkInMonth; i <= 12; i++)
                {
                    if (i == checkInMonth)//Skip first index to start count at next month.
                    {
                        continue;
                    }
                    else
                    {
                        monthGap1++;
                    }
                }
            }


            if (monthDiffTotal + checkInMonth > 12)
            {
                //reset to one
                for (int j = 1; j < checkOutMonth; j++)
                {
                    monthGap2++;
                }
            }
            else
            {
                for (int j = (monthDiffTotal + checkInMonth); j < checkOutMonth; j++)
                {
                    monthGap2++;
                }
            }


            monthDiffTotal += monthGap1;

            monthDiffTotal += monthGap2;

        }

        Console.WriteLine("Lst Yr: " + monthGap1);
        Console.WriteLine("Crnt Yr: " + monthGap2);
        Console.WriteLine("Total Months Gap: " + monthDiffTotal);

        return retVal = monthDiffTotal;
    }
    */
    }
}
