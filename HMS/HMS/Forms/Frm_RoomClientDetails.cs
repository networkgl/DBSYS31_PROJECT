using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Forms
{
    public partial class Frm_RoomClientDetails : Form
    {
        public Frm_RoomClientDetails()
        {
            InitializeComponent();
        }

        private void Frm_RoomClientDetails_Load(object sender, EventArgs e)
        {
            LoadDetails();
        }
        private void LoadDetails()
        {
            lbl_CheckIn_Date.Text = Frm_Room.DateIn;
            lbl_CheckOut_Date.Text = Frm_Room.DateOut;
            lbl_totalDays.Text = FormatDay(int.Parse(Frm_Room.NoOfDays));
            lbl_TotalGuest.Text = (int.Parse(Frm_Room.Adult) + int.Parse(Frm_Room.Children) + int.Parse(Frm_Room.Senior)).ToString();
            lbl_totalAdult.Text = Frm_Room.Adult; 
            lbl_totalChildren.Text = Frm_Room.Children;
            lbl_totalSenior.Text = Frm_Room.Senior;
            lbl_FullName.Text = Frm_Room.FullName;
            lbl_Email.Text = Frm_Room.Email;
            lbl_ContactNumber.Text = Frm_Room.Phone;
            lbl_Address.Text = Frm_Room.Address;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string FormatDay(int d)
        {
            if (d > 1)
                return $"{d} Days";
            else
                return $"{d} Day";
        }
    }
}
