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
        private static Frm_BookNow_S3 s3;
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }


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
        private void Frm_BookNow_S3_Load(object sender, EventArgs e)
        {
            txtbox_fName.Text = Fname;
            txtbox_lName.Text = Lname;
            txtbox_Email.Text = Email;
            if (Phone == 0)
                txtbox_Phone.Text = string.Empty;
            else
                txtbox_Phone.Text = Phone.ToString();
            txtbox_Address.Text = Address;
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
        }
    }
}
