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
        public int NumberOfDays { get; set; }
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

            //txtbox_fName.Text = Fname;
            //txtbox_lName.Text = Lname;
            //txtbox_Email.Text = Email;
            if (Phone == 0)
                txtbox_Phone.Text = string.Empty;
            else
                txtbox_Phone.Text = Phone.ToString();
            //txtbox_Address.Text = Address;
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
            //Frm_BookNow_S2 s2 = new Frm_BookNow_S2();
            //s2.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Frm_Confirmation.GetInstance(GetGuestByIndex(), GetTimeByIndex("After ", Frm_BookNow_S1.SelectedTime_CheckIn), GetTimeByIndex("Before ", Frm_BookNow_S1.SelectedTime_CheckOut),
            //                                            GetAM_PM_ByIndex(Frm_BookNow_S1.Selected_CheckIn_AM_PM), GetAM_PM_ByIndex(Frm_BookNow_S1.Selected_CheckOut_AM_PM),
            //                                            Frm_BookNow_S1.CheckIn.ToString("ddd, MMM dd, yyyy"), Frm_BookNow_S1.CheckOut.ToString("ddd, MMM dd, yyyy"), GetTotalPrice());

            //if (Frm_Confirmation.GetInstance() != null)
            //{
            //    Frm_Confirmation.GetInstance().Show();
            //}
            Frm_BookNow_S4 fc = new Frm_BookNow_S4(GetNoOfGuestByValue(Frm_BookNow_S1.NoOfGuest), GetGuestByIndex(), GetTimeByIndex("After ", Frm_BookNow_S1.SelectedTime_CheckIn), GetTimeByIndex("Before ", Frm_BookNow_S1.SelectedTime_CheckOut),
                                                        GetAM_PM_ByIndex(Frm_BookNow_S1.Selected_CheckIn_AM_PM), GetAM_PM_ByIndex(Frm_BookNow_S1.Selected_CheckOut_AM_PM),
                                                        Frm_BookNow_S1.CheckIn.ToString("ddd, MMM dd, yyyy"), Frm_BookNow_S1.CheckOut.ToString("ddd, MMM dd, yyyy"), GetTotalAmount(Frm_BookNow_S1.CheckIn.Day, Frm_BookNow_S1.CheckOut.Day));
            fc.Show();
        }
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
            //var GuestIndex = Frm_BookNow_S1.GetInstance().Guest;
            var GuestIndex = Frm_BookNow_S1.Guest;
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
        private String GetTotalAmount(int CheckInDay, int CheckOutDay)
        {

            //DateTime birthDate = metroDateTime_Birthdate.Value;
            //DateTime currentDate = DateTime.Now;
            //age = currentDate.Year - birthDate.Year;

            //// Check if the birthdate has not yet occurred this year
            //if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
            //{
            //    age--;
            //}
            //txtboxAge.Text = age.ToString();


            var totalDays = 0;
            var numOfDays  = 0;

            if (CheckOutDay > CheckInDay)
            {
                numOfDays = CheckOutDay - CheckInDay;
                totalDays = numOfDays;
            }
            else
            {
                var getMonth = Frm_BookNow_S1.CheckIn.Month;

                //var inDay = Frm_BookNow_S1.CheckIn.Day;
                //var outDay = Frm_BookNow_S1.CheckOut.Day;

                var monthDays = 0;

                if (getMonth == 1 || getMonth == 3 || getMonth == 5 || getMonth == 7 || getMonth == 8 || getMonth == 10 || getMonth == 12)
                {
                    monthDays = 31;
                }
                else
                {
                    if (getMonth == 2)
                    {
                        monthDays = 28;
                    }
                    monthDays = 30;
                }

                var prevMonthVal = 0;                   
                if (CheckInDay > CheckOutDay)
                {
                    for (int i = CheckInDay; i <= monthDays; i++) //Addan og one para mag start og count ig ugma OR skip ang first index para di ma apil og count.
                    {
                        if (i == CheckInDay)
                        {
                            continue;
                        }
                        prevMonthVal++;
                        //Console.WriteLine(prevMonthVal);
                    }

                    for (int j = 1; j <= CheckOutDay; j++)
                    {
                        numOfDays++;
                        //Console.WriteLine(numOfDays);
                    }
                }
                totalDays = prevMonthVal + numOfDays;
                NumberOfDays = totalDays;
            }
            //Console.WriteLine(totalDays);


            string retVal = String.Empty;
            var roomPrice = Frm_BookNow_S2.GetInstance().RoomType;

            //Total Payment Based on RoomType multiply by the totalDays of Stay
            switch (roomPrice)
            {
                case 0:
                    retVal = "₱ " + ParseVal(10000 * totalDays);
                    break;
                case 1:
                    retVal = "₱ " + ParseVal(14000 * totalDays);
                    break;
                case 2:
                    retVal = "₱ " + ParseVal(20000 * totalDays);
                    break;
            }
            return retVal;
        }
    }
}
