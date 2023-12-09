using HMS.Forms;
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
    public partial class Frm_HomePage : Form
    {
        public Frm_HomePage()
        {
            InitializeComponent();
        }
        //public static Frm_HomePage GetInstance()
        //{
        //    if (hp == null)
        //        hp = new Frm_HomePage();
        //    return hp;
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
        private void Frm_HomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Frm_BookNow_S1.GetInstance().Show();
            Frm_BookNow_S1 s1 = new Frm_BookNow_S1();
            s1.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Frm_Login.GetInstance().ShowDialog();
            var login = new Frm_Login();
            login.ShowDialog();

            if (login.HasLogin)
            {
                this.Hide();
            }
        }
    }
}
