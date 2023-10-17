using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Frm_BookNow_S3 : Form
    {
        private string fname, lname, email, address;
        private long phone;
        private int getSelectedGuest, getSelectedTime_CheckIn, getSelectedTime_CheckOut, getSelected_CheckIn_AM_PM, getSelected_CheckOut_AM_PM;
        string checkIn, checkOut;

        private void txtbox_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancel the input if it's not a digit or control character.
                MessageBox.Show("Please enter only a number","Message",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private int roomType;

        public Frm_BookNow_S3()
        {
            InitializeComponent();
        }
        public Frm_BookNow_S3(int getSelectedGuest, string checkIn, string checkOut, int getSelectedTime_CheckIn, int getSelectedTime_CheckOut, int getSelected_CheckIn_AM_PM, int getSelected_CheckOut_AM_PM, int roomType,
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
        private void Frm_BookNow_S3_Load(object sender, EventArgs e)
        {
            txtbox_fName.Text = fname;
            txtbox_lName.Text = lname;
            txtbox_Email.Text = email;
            if (phone == 0)
                txtbox_Phone.Text = string.Empty;
            else
                txtbox_Phone.Text = phone.ToString();
            //txtbox_Phone.Text = phone.ToString();
            txtbox_Address.Text = address;
        }
        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fname = txtbox_fName.Text;
            lname = txtbox_lName.Text;
            email = txtbox_Email.Text;
            if (txtbox_Phone.Text.Equals(string.Empty) )           
                phone = 0;           
            else
                phone = long.Parse(txtbox_Phone.Text);
            address = txtbox_Address.Text;

            this.Hide();
            var s2 = new Frm_BookNow_S2(getSelectedGuest, checkIn, checkOut, getSelectedTime_CheckIn, getSelectedTime_CheckOut, getSelected_CheckIn_AM_PM, getSelected_CheckOut_AM_PM, roomType, fname, lname, email, phone, address);
            s2.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
