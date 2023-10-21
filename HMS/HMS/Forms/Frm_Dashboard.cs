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
    public partial class Frm_Dashboard : Form
    {
        private static Frm_Dashboard dashboard;
        private Frm_Dashboard()
        {
            InitializeComponent();
        }
        public static Frm_Dashboard GetInstance()
        {
            if (dashboard == null)
                dashboard = new Frm_Dashboard();
            return dashboard;
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
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
