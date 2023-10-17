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
        public Frm_Main()
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
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnl_main.Controls.Clear();
            var db = new Frm_Dashboard();
            db.TopLevel = false;
            db.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(db);
            db.Show();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            pnl_main.Controls.Clear();
            var db = new Frm_Dashboard();
            db.TopLevel = false;
            db.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(db);
            db.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            pnl_main.Controls.Clear();
            var clt = new Frm_Client();
            clt.TopLevel = false;
            clt.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(clt);
            clt.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var ask = MessageBox.Show("Are you sure you want to logout ?", "Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(ask == DialogResult.Yes) {
               Frm_HomePage frm_HomePage = new Frm_HomePage();
                frm_HomePage.Show();
                this.Hide();
            }
        }
    }
}
