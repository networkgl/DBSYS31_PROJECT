using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Forms
{
    public partial class Frm_Confirmation : Form
    {
        private static Frm_Confirmation confirmation;
        private Frm_Confirmation()
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
        public static Frm_Confirmation GetInstance()
        {
            if (confirmation == null)           
                confirmation = new Frm_Confirmation();           
            return confirmation;
        }
        private void Frm_Confirmation_Load(object sender, EventArgs e)
        {
            CurrentDate.Start();
            UpdateDateTime();
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

    }
}
