using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS.Forms;


namespace HMS
{
    public partial class Frm_BookNow_S1 : Form
    {
        private int getSelectedGuest = 0, getSelectedTime_CheckIn = 0, getSelectedTime_CheckOut = 0, getSelected_CheckIn_AM_PM = 0, getSelected_CheckOut_AM_PM = 0;
        //private string checkIn = DateTime.Now.ToString();
        //private string checkOut = DateTime.Now.ToString();
        private string fname, lname, email, address;
        private long phone;
        private int roomType;
        private DateTime checkIn = DateTime.Now;
        private DateTime checkOut = DateTime.Now;

        public Frm_BookNow_S1()
        {
            InitializeComponent();
        }
        public Frm_BookNow_S1(int getSelectedGuest, DateTime checkIn, DateTime checkOut, int getSelectedTime_CheckIn, int getSelectedTime_CheckOut, int getSelected_CheckIn_AM_PM, int getSelected_CheckOut_AM_PM, int roomType,
                        string fname, string lname, string email, long phone, string address)
        {
            InitializeComponent();
            this.getSelectedGuest = getSelectedGuest;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.getSelectedTime_CheckIn = getSelectedTime_CheckIn;
            this.getSelectedTime_CheckOut = getSelectedTime_CheckOut;
            this.getSelected_CheckIn_AM_PM = getSelected_CheckIn_AM_PM;
            this.getSelected_CheckOut_AM_PM = getSelected_CheckOut_AM_PM;

            this.roomType = roomType;

            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.phone = phone;
            this.address = address;
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

        private void Frm_BookNow_S1_Load(object sender, EventArgs e)
        {
            cbBox_Guest.SelectedIndex = getSelectedGuest;
            DateTimePicker_CheckIn.Value = checkIn;
            DateTimePicker_CheckOut.Value = checkOut;
            cbBox_CheckIn_Time.SelectedIndex = getSelectedTime_CheckIn;
            cbBox_CheckIn_AM_PM.SelectedIndex = getSelected_CheckIn_AM_PM;
            cbBox_CheckOut_Time.SelectedIndex = getSelectedTime_CheckOut;
            cbBox_CheckOut_AM_PM.SelectedIndex = getSelected_CheckOut_AM_PM;


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var hp = new Frm_HomePage();
            hp.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //DateTimePicker_CheckIn.Value = checkIn;
            //DateTimePicker_CheckOut.Value = checkOut;
            checkIn = DateTimePicker_CheckIn.Value.Date;
            checkOut = DateTimePicker_CheckOut.Value.Date;


            this.Hide();
            var s2 = new Frm_BookNow_S2(getSelectedGuest, checkIn, checkOut, getSelectedTime_CheckIn, getSelectedTime_CheckOut, getSelected_CheckIn_AM_PM, getSelected_CheckOut_AM_PM, roomType, fname, lname, email, phone, address);
            s2.Show();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var hp = new Frm_HomePage();
            hp.Show();
        }



        public void cbBox_Guest_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbBox_Guest.SelectedIndex)
            {
                case 0:
                    getSelectedGuest = cbBox_Guest.SelectedIndex;
                    break;
                case 1:
                    getSelectedGuest = cbBox_Guest.SelectedIndex;
                    break;
            }
            //Console.WriteLine(getSelectedGuest);
        }


        private void cbBox_CheckIn_Time_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbBox_CheckIn_Time.SelectedIndex)
            {
                case 0:
                        getSelectedTime_CheckIn = cbBox_CheckIn_Time.SelectedIndex;
                    break;
                case 1:
                        getSelectedTime_CheckIn = cbBox_CheckIn_Time.SelectedIndex;
                    break; 
                case 2:
                        getSelectedTime_CheckIn = cbBox_CheckIn_Time.SelectedIndex;
                    break;
                case 3:
                        getSelectedTime_CheckIn = cbBox_CheckIn_Time.SelectedIndex;
                    break;
                case 4:
                        getSelectedTime_CheckIn = cbBox_CheckIn_Time.SelectedIndex;
                    break;
                case 5:
                        getSelectedTime_CheckIn = cbBox_CheckIn_Time.SelectedIndex;
                    break;
                case 6:
                        getSelectedTime_CheckIn = cbBox_CheckIn_Time.SelectedIndex;
                    break;
                case 7:
                        getSelectedTime_CheckIn = cbBox_CheckIn_Time.SelectedIndex;
                    break;
                case 8:
                        getSelectedTime_CheckIn = cbBox_CheckIn_Time.SelectedIndex;
                    break;
                case 9:
                        getSelectedTime_CheckIn = cbBox_CheckIn_Time.SelectedIndex;
                    break;
                case 10:
                        getSelectedTime_CheckIn = cbBox_CheckIn_Time.SelectedIndex;
                    break;
                case 11:
                        getSelectedTime_CheckIn = cbBox_CheckIn_Time.SelectedIndex;
                    break;
            }
        }
        private void cbBox_CheckIn_AM_PM_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbBox_CheckIn_AM_PM.SelectedIndex)
            {
                case 0:
                        getSelected_CheckIn_AM_PM = cbBox_CheckIn_AM_PM.SelectedIndex;
                    break;
                case 1:
                        getSelected_CheckIn_AM_PM = cbBox_CheckIn_AM_PM.SelectedIndex;
                    break;
            }
        }
        private void cbBox_CheckOut_Time_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbBox_CheckOut_Time.SelectedIndex)
            {
                case 0:
                    getSelectedTime_CheckOut = cbBox_CheckOut_Time.SelectedIndex;
                    break;
                case 1:
                    getSelectedTime_CheckOut = cbBox_CheckOut_Time.SelectedIndex;
                    break;
                case 2:
                    getSelectedTime_CheckOut = cbBox_CheckOut_Time.SelectedIndex;
                    break;
                case 3:
                    getSelectedTime_CheckOut = cbBox_CheckOut_Time.SelectedIndex;
                    break;
                case 4:
                    getSelectedTime_CheckOut = cbBox_CheckOut_Time.SelectedIndex;
                    break;
                case 5:
                    getSelectedTime_CheckOut = cbBox_CheckOut_Time.SelectedIndex;
                    break;
                case 6:
                    getSelectedTime_CheckOut = cbBox_CheckOut_Time.SelectedIndex;
                    break;
                case 7:
                    getSelectedTime_CheckOut = cbBox_CheckOut_Time.SelectedIndex;
                    break;
                case 8:
                    getSelectedTime_CheckOut = cbBox_CheckOut_Time.SelectedIndex;
                    break;
                case 9:
                    getSelectedTime_CheckOut = cbBox_CheckOut_Time.SelectedIndex;
                    break;
                case 10:
                    getSelectedTime_CheckOut = cbBox_CheckOut_Time.SelectedIndex;
                    break;
                case 11:
                    getSelectedTime_CheckOut = cbBox_CheckOut_Time.SelectedIndex;
                    break;
            }
        }
        private void cbBox_CheckOut_AM_PM_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbBox_CheckOut_AM_PM.SelectedIndex)
            {
                case 0:
                    getSelected_CheckOut_AM_PM = cbBox_CheckOut_AM_PM.SelectedIndex;
                    break;
                case 1:
                    getSelected_CheckOut_AM_PM = cbBox_CheckOut_AM_PM.SelectedIndex;
                    break;
            }
        }
    }
}
