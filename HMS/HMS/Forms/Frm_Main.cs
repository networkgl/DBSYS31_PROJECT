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
    public partial class Frm_Main : Form
    {
        private static Frm_Main main;
        private Frm_Main()
        {
            InitializeComponent();
        }
        public static Frm_Main GetInstance()
        {
            if(main == null)
                main = new Frm_Main();
            return main;
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnl_main.Controls.Clear();
            Frm_Dashboard.GetInstance().TopLevel = false;
            Frm_Dashboard.GetInstance().Dock = DockStyle.Fill;
            pnl_main.Controls.Add(Frm_Dashboard.GetInstance());
            Frm_Dashboard.GetInstance().Show();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            pnl_main.Controls.Clear();
            Frm_Dashboard.GetInstance().TopLevel = false;
            Frm_Dashboard.GetInstance().Dock = DockStyle.Fill;
            pnl_main.Controls.Add(Frm_Dashboard.GetInstance());
            Frm_Dashboard.GetInstance().Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            pnl_main.Controls.Clear();
            Frm_Client.GetInstance().TopLevel = false;
            Frm_Client.GetInstance().Dock = DockStyle.Fill;
            pnl_main.Controls.Add(Frm_Client.GetInstance());
            Frm_Client.GetInstance().Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var ask = MessageBox.Show("Are you sure you want to logout ?", "Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(ask == DialogResult.Yes) {
                this.Hide();
                Frm_HomePage.GetInstance().Show();
                Frm_Login.GetInstance().HasLogin = false;
            }
        }
    }
}
