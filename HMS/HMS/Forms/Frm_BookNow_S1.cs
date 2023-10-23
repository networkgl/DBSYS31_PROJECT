using System;
using System.Globalization;
using System.Windows.Forms;


namespace HMS
{
    public partial class Frm_BookNow_S1 : Form
    {
        private static Frm_BookNow_S1 s1;
        private int Guest { get; set; }
        private int SelectedTime_CheckIn { get; set; }
        private int SelectedTime_CheckOut { get; set; }
        private int Selected_CheckIn_AM_PM { get; set; }
        private int Selected_CheckOut_AM_PM { get; set; }
        private DateTime CheckIn { get; set; } = DateTime.Now;
        private DateTime CheckOut { get; set; } = DateTime.Now;

        private Frm_BookNow_S1()
        {
            InitializeComponent();
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
        public static Frm_BookNow_S1 GetInstance()
        {
            if (s1 == null)
                s1 = new Frm_BookNow_S1();
            return s1;
        }
        private void Frm_BookNow_S1_Load(object sender, EventArgs e)
        {
            // Start the Timer control
            CurrentDate.Start();

            // Get and display the current date and time
            UpdateDateTime();

            cbBox_Guest.SelectedIndex = Guest;
            DateTimePicker_CheckIn.Value = CheckIn;
            DateTimePicker_CheckOut.Value = CheckOut;
            cbBox_CheckIn_Time.SelectedIndex = SelectedTime_CheckIn;
            cbBox_CheckIn_AM_PM.SelectedIndex = Selected_CheckIn_AM_PM;
            cbBox_CheckOut_Time.SelectedIndex = SelectedTime_CheckOut;
            cbBox_CheckOut_AM_PM.SelectedIndex = Selected_CheckOut_AM_PM;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_HomePage.GetInstance().Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_BookNow_S2.GetInstance().Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_HomePage.GetInstance().Show();
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
        public void cbBox_Guest_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbBox_Guest.SelectedIndex)
            {
                case 0:
                    Guest = cbBox_Guest.SelectedIndex;
                    break;
                case 1:
                    Guest = cbBox_Guest.SelectedIndex;
                    break;
            }
        }
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


    }
}
