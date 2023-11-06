using Guna.UI2.WinForms;
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
using System.Windows.Interop;

namespace HMS
{
    public partial class Frm_BookNow_S3 : Form
    {
        private Frm_BookNow_S1 s1;
        private Frm_BookNow_S2 s2;
        private Frm_BookNow_S3 s3;
        private Frm_BookNow_S4 s4;

        private int totalDays;
        private string fname;
        private string lname;
        private string email;
        private string phone;
        private string address;


        public Frm_BookNow_S3()
        {
            InitializeComponent();
        }
        public Frm_BookNow_S3(Frm_BookNow_S1 s1, Frm_BookNow_S2 s2, Frm_BookNow_S3 s3)
        {
            InitializeComponent();
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
            //this.s4 = s4;
        }
        //public static Frm_BookNow_S3 GetInstance()
        //{
        //    if(s3 == null)
        //        s3 = new Frm_BookNow_S3();
        //    return s3;
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

            //Console.WriteLine(s1.Guest);
            //Console.WriteLine(s1.NoOfGuest);
            //Console.WriteLine(s1.CheckIn);
            //Console.WriteLine(s1.CheckOut);

            //Console.WriteLine(s2);
            //Console.WriteLine(s3);



            if (s3 == null)
            {
                txtbox_fName.Text = Fname;
                txtbox_lName.Text = Lname;
                txtbox_Email.Text = Email;
                txtbox_Phone.Text = Phone;
                txtbox_Address.Text = Address;
            }
            else
            {
                txtbox_fName.Text = s3.Fname;
                txtbox_lName.Text = s3.Lname;
                txtbox_Email.Text = s3.Email;
                txtbox_Phone.Text = s3.Phone;
                txtbox_Address.Text = s3.Address;
            }
        }
        private static Frm_BookNow_S3 s33;
        public static Frm_BookNow_S3 GetInstance
        {
            get { return s33; }
            set { s33 = value; }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Fname = txtbox_fName.Text;
            Lname = txtbox_lName.Text;
            Email = txtbox_Email.Text;                
            Phone = txtbox_Phone.Text;
            Address = txtbox_Address.Text;


            this.Hide();
            if (Frm_ProcessPayment.HasPaid)
            {
                //Frm_BookNow_S2 s2 = new Frm_BookNow_S2(s1,this.s2,this,s4);
                Frm_BookNow_S2 s2 = new Frm_BookNow_S2();
                s2.Show();
            }
            else
            {
                s2 = new Frm_BookNow_S2(Frm_BookNow_S1.GetInstance, Frm_BookNow_S2.GetInstance, this);
                s2.Show();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Frm_Confirmation.GetInstance(GetGuestByIndex(), GetTimeByIndex("After ", Frm_BookNow_S1.SelectedTime_CheckIn), GetTimeByIndex("Before ", Frm_BookNow_S1.SelectedTime_CheckOut),
            //                                            GetAM_PM_ByIndex(Frm_BookNow_S1.Selected_CheckIn_AM_PM), GetAM_PM_ByIndex(Frm_BookNow_S1.Selected_CheckOut_AM_PM),
            //                                            Frm_BookNow_S1.CheckIn.ToString("ddd, MMM dd, yyyy"), Frm_BookNow_S1.CheckOut.ToString("ddd, MMM dd, yyyy"), GetTotalPrice());

            //if (Frm_Confirmation.GetInstance() != null)
            //{
            //    Frm_Confirmation.GetInstance().Show();
            //}

            //Frm_BookNow_S4 fc = new Frm_BookNow_S4(GetNoOfGuestByValue(Frm_BookNow_S1.NoOfGuest), GetGuestByIndex(), GetTimeByIndex("After ", Frm_BookNow_S1.SelectedTime_CheckIn), GetTimeByIndex("Before ", Frm_BookNow_S1.SelectedTime_CheckOut),
            //                                            GetAM_PM_ByIndex(Frm_BookNow_S1.Selected_CheckIn_AM_PM), GetAM_PM_ByIndex(Frm_BookNow_S1.Selected_CheckOut_AM_PM),
            //                                            Frm_BookNow_S1.CheckIn.ToString("ddd, MMM dd, yyyy"), Frm_BookNow_S1.CheckOut.ToString("ddd, MMM dd, yyyy"), GetTotalAmount());
            //fc.Show();

            fname = txtbox_fName.Text;
            lname = txtbox_lName.Text;
            email = txtbox_Email.Text;
            phone = txtbox_Phone.Text;           
            address = txtbox_Address.Text;


            s33 = this;

            this.Hide();
            Frm_BookNow_S4 s4 = new Frm_BookNow_S4(Frm_BookNow_S1.GetInstance, this.s2, this, this.s4);
            s4.Show();

            //if (s4 == null)
            //{
            //    Frm_BookNow_S4 s4 = new Frm_BookNow_S4(s1, s2, this, this.s4);
            //    s4.Show();
            //}
            //else
            //{
            //    s4.Show();
            //}
        }
        private void txtbox_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            var msg = String.Empty;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancel the input if it's not a digit or control character.
                                  //MessageBox.Show("Please enter only a number","Message",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                msg = "Please enter only a number.";
                MessageDialog.Show(msg, "Message", MessageDialogButtons.OK, MessageDialogIcon.Warning, MessageDialogStyle.Light);
            }
            else if (txtbox_Phone.Text.Length == 0 && e.KeyChar != '0')
            {
                e.Handled = true;
                msg = "Invalid Prefix Number !\n Please Start With -> 0";
                MessageDialog.Show(msg, "Message", MessageDialogButtons.OK, MessageDialogIcon.Warning, MessageDialogStyle.Light);
            }
            else if (txtbox_Phone.Text.Length == 1 && e.KeyChar != '9')
            {
                e.Handled = true;
                msg = "Invalid Prefix Number !\nSecond Number must be -> 9";
                MessageDialog.Show(msg, "Message", MessageDialogButtons.OK, MessageDialogIcon.Warning, MessageDialogStyle.Light);
            }
            else if (txtbox_Phone.Text.Length > 11 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                msg = "Phone Number is only 11 digit long\nPlease enter a correct one.";
                MessageDialog.Show(msg, "Message", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Light);
            }
        }

        //Getters And Setters
        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int NumberOfDays
        {
            get { return totalDays; }
            set { totalDays = value; }
        }
      

        //Scatch Methods
        /*
         *         
        private String GetNoOfGuestByValue(int recVal)
        {       
            return ParseVal(recVal);
        }
        private String GetTimeByIndex(string happen,int indexTime)
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
        private String GetGuestByIndex()
        {
            string retVal = String.Empty;
            var GuestIndex = this.s1.Guest;
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

            //Console.WriteLine("Getters: " + NumberOfDays);

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
         */
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
