﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Frm_ProcessPayment : Form
    {
        private string creditCardNumber = String.Empty;
        Frm_BookNow_S4 s4;
        private static bool hasPaid = false;
        private int toggle = 1;

        public static bool HasPaid
        {
            get { return hasPaid; }
            set { hasPaid = value; }

        }
        public Frm_ProcessPayment()
        {
            InitializeComponent();
        }
        public Frm_ProcessPayment(Frm_BookNow_S4 s4)
        {
            InitializeComponent();
            this.s4 = s4;
        }

        private void Frm_ProcessPayment_Load(object sender, EventArgs e)
        {
            Initialize();
        }
        private void Initialize()
        {
            txtboxCardNumber.Text = s4.CardNumber;
            SubTotalLocation();
        }
        private void SubTotalLocation()
        {
            //228, 328
            var x = 242;
            var y = 328;

            var subTotal = s4.GetTotalAmount();
            var valueWithoutPesoSign = subTotal.Replace("₱", "").Trim();

            if (float.Parse(valueWithoutPesoSign) >= 100000f)
            {
                x = 228;
                lbl_SubTotal.Location = new Point(x, y);
                lbl_SubTotal.Text = subTotal + ".00";
            }
            else
            {
                lbl_SubTotal.Location = new Point(x, y);
                lbl_SubTotal.Text = subTotal + ".00";
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            s4.CardNumber = txtboxCardNumber.Text;
            Console.WriteLine("Variable: "+hasPaid);
            Console.WriteLine("Getters: "+HasPaid);

            this.Close();           
        }

        private void cbBox_Note_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBox_Note.Checked)
            {
                btnPayNow.Enabled = true;
            }
            else
            {
                btnPayNow.Enabled = false;
            }
        }

        private void txtboxCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //s4.CardNumber = txtboxCardNumber.Text;

        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {

            var waitForm = new WaitFormFunc();

            var msg = "Are you sure all information is correct ? If yes,\nthen you can click pay now.";
            bool Proceed = MessageDialog.Show(msg, "Message", MessageDialogButtons.YesNo, MessageDialogIcon.Question, MessageDialogStyle.Light) == DialogResult.Yes;
            if (Proceed)
            {

                //msg = "Please input the amount to be paid";
                //MessageDialog.Show(msg, "Message", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Light);


                //Do something
                try
                {
                    //this.Hide();
                    waitForm.Show(this);
                    Thread.Sleep(1000);
                    waitForm.Close();

                    msg = "Payment Complete";
                    var done = MessageDialog.Show(msg, "Message", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Light);

                    if (done == DialogResult.OK)
                    {
                        this.Close();
                        hasPaid = true; //If Paymend Successfull then clear  / set to default all controls in the booking section.
                        s4.btn_DownloadOffline.Visible = true;
                        s4.lbl_DownloadNow.Visible = true;
                        s4.btnBookAgain.Visible = true;
                        s4.btnLogin.Visible = true;
                        s4.btnConfirm.Visible = false;
                        s4.btnBack.Visible = false;
                    }

                }
                catch(Exception error) 
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void lbl_Note_Click(object sender, EventArgs e)
        {
            toggle++;

            if (toggle % 2 == 0)
            {
                cbBox_Note.Checked = true;
                btnPayNow.Enabled = true;
            }
            else
            {
                cbBox_Note.Checked = false;
                btnPayNow.Enabled = false;
            }
        }
    }
}