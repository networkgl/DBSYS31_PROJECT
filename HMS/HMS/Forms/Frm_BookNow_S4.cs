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
        private static Frm_BookNow_S4 confirmation;
        private int roomType = Frm_BookNow_S2.GetInstance().RoomType;

        //private int guest = Frm_BookNow_S1.GetInstance().Guest;
        //private DateTime checkInDate = Frm_BookNow_S1.GetInstance().CheckIn;
        //private DateTime checkOutDate = Frm_BookNow_S1.GetInstance().CheckOut;
        //private int timeCheckIn = Frm_BookNow_S1.GetInstance().SelectedTime_CheckIn;
        //private int timeCheckOut = Frm_BookNow_S1.GetInstance().SelectedTime_CheckOut;
        //private int timeCheckIn_AM_PM = Frm_BookNow_S1.GetInstance().Selected_CheckIn_AM_PM;
        //private int timeCheckOut_AM_PM = Frm_BookNow_S1.GetInstance().Selected_CheckOut_AM_PM;
        private string NoOfGuest = String.Empty,Guest = String.Empty, CheckIn = String.Empty, CheckOut = String.Empty, CheckIn_am_pm = String.Empty, CheckOut_am_pm = String.Empty, CheckIn_date = String.Empty, CheckOut_date = String.Empty, TotalPrice = String.Empty, NumberOfDays = String.Empty;

        public Frm_BookNow_S4()
        {
            InitializeComponent();
        }

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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Guest_Click(object sender, EventArgs e)
        {

        }

        public static Frm_BookNow_S4 GetInstance()
        {
            if (confirmation == null)
                confirmation = new Frm_BookNow_S4();
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
            var NoOfDays = Frm_BookNow_S3.GetInstance().NumberOfDays;
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

            //lbl_CheckIn_Time.Text = timeCheckIn + " " + timeCheckIn_AM_PM;
            //lbl_CheckOut_Time.Text = timeCheckOut + " " + timeCheckOut_AM_PM;
            //lbl_CheckIn_Date.Text = checkInDate.ToString();
            //lbl_CheckOut_Date.Text = checkOutDate.ToString();
            //lbl_Guest.Text = guest.ToString();

            //lbl_CheckIn_Time.Text = Frm_BookNow_S1.SelectedTime_CheckIn + " " + Frm_BookNow_S1.Selected_CheckIn_AM_PM;
            //lbl_CheckOut_Time.Text = Frm_BookNow_S1.SelectedTime_CheckOut + " " + Frm_BookNow_S1.Selected_CheckOut_AM_PM;
            //lbl_CheckIn_Date.Text = Frm_BookNow_S1.CheckIn.ToString();
            //lbl_CheckOut_Date.Text = Frm_BookNow_S1.CheckOut.ToString();


            //lbl_CheckIn_Time.Text = this.checkIn + " " + this.checkIn_am_pm;
            //lbl_CheckOut_Time.Text = this.checkOut + " " + this.checkOut_am_pm;
            //lbl_CheckIn_Date.Text = this.checkIn_date;
            //lbl_CheckOut_Date.Text = this.checkOut_date;
            //lbl_totalPrice.Text = this.totalPrice;
            //lbl_Guest.Text = this.guest;




            //int guest = Frm_BookNow_S1.Guest;
            //DateTime checkInDate = Frm_BookNow_S1.CheckIn;
            //DateTime checkOutDate = Frm_BookNow_S1.CheckOut;
            //int timeCheckIn = Frm_BookNow_S1.SelectedTime_CheckIn;
            //int timeCheckOut = Frm_BookNow_S1.SelectedTime_CheckOut;
            //int timeCheckIn_AM_PM = Frm_BookNow_S1.Selected_CheckIn_AM_PM;
            //int timeCheckOut_AM_PM = Frm_BookNow_S1.Selected_CheckOut_AM_PM;


            //lbl_CheckIn_Time.Text = timeCheckIn + " " + timeCheckIn_AM_PM;
            //lbl_CheckOut_Time.Text = timeCheckOut + " " + timeCheckOut_AM_PM;
            //lbl_CheckIn_Date.Text = checkInDate.ToString(); ;
            //lbl_CheckOut_Date.Text = checkOutDate.ToString();
            ////lbl_totalPrice.Text = totalPrice.toS;
            //lbl_Guest.Text = guest.ToString();




            //if (Frm_BookNow_S1.GetInstance() != null)
            //{
            //    int guest = Frm_BookNow_S1.Guest;
            //    DateTime checkInDate = Frm_BookNow_S1.CheckIn;
            //    DateTime checkOutDate = Frm_BookNow_S1.CheckOut;
            //    int timeCheckIn = Frm_BookNow_S1.SelectedTime_CheckIn;
            //    int timeCheckOut = Frm_BookNow_S1.SelectedTime_CheckOut;
            //    int timeCheckIn_AM_PM = Frm_BookNow_S1.Selected_CheckIn_AM_PM;
            //    int timeCheckOut_AM_PM = Frm_BookNow_S1.Selected_CheckOut_AM_PM;


            //    lbl_CheckIn_Time.Text = timeCheckIn + " " + timeCheckIn_AM_PM;
            //    lbl_CheckOut_Time.Text = timeCheckOut + " " + timeCheckOut_AM_PM;
            //    lbl_CheckIn_Date.Text = checkInDate.ToString(); ;
            //    lbl_CheckOut_Date.Text = checkOutDate.ToString();
            //    //lbl_totalPrice.Text = totalPrice.toS;
            //    lbl_Guest.Text = guest.ToString();
            //}
        }
    }
}
