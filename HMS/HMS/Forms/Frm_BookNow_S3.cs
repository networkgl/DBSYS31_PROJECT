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
            //if (Frm_BookNow_S2.GetInstance == null)
            //{
            //    Console.WriteLine("S2 NULL !!!");
            //}
            //else
            //    Console.WriteLine("S2 IS NOT NULL !!!");



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
            fname = txtbox_fName.Text;
            lname = txtbox_lName.Text;
            email = txtbox_Email.Text;
            phone = txtbox_Phone.Text;           
            address = txtbox_Address.Text;


            s33 = this;

            this.Hide();
            Frm_BookNow_S4 s4 = new Frm_BookNow_S4(Frm_BookNow_S1.GetInstance, this.s2, this, this.s4);
            s4.Show();
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
    }
}
