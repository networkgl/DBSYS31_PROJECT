using HMS.Forms;
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
    public partial class Frm_HomePage : Form
    {
        private static Frm_HomePage instance;
        public Frm_HomePage()
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
        public static Frm_HomePage GetInstance()
        {
            if (instance == null)
            {
                instance = new Frm_HomePage();
            }
            return instance;
        }
        private void Frm_HomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_BookNow_S1 s1 = new Frm_BookNow_S1();
            s1.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Frm_Login.GetInstance().ShowDialog();

            if (Frm_Login.GetInstance().HasLogin)
            {
                //Thread.Sleep(5000);
                this.Hide();
            }
            //Frm_Login.GetInstance().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
