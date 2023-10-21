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
    public partial class MoreInfo_S1 : Form
    {
        public MoreInfo_S1()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Frm_BookNow_S2 frm_BookNow_S2 = new Frm_BookNow_S2();
            frm_BookNow_S2.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Frm_BookNow_S2 frm_BookNow_S2 = new Frm_BookNow_S2();
            frm_BookNow_S2.Show();
            this.Hide();
        }
    }
}
