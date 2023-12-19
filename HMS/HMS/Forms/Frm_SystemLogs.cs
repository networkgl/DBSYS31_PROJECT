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
    public partial class Frm_SystemLogs : Form
    {
        private UserRepository userRepo;
        public Frm_SystemLogs()
        {
            InitializeComponent();
            userRepo = new UserRepository();
        }

        private void btnsSystemAccounts_Click(object sender, EventArgs e)
        {
            Frm_Main.GetInstanceClass.pnl_main.Controls.Clear();
            Frm_ManageSystem ms = new Frm_ManageSystem();
            ms.TopLevel = false;
            ms.Dock = DockStyle.Fill;
            Frm_Main.GetInstanceClass.pnl_main.Controls.Add(ms);
            ms.Show();
        }

        private void dgv_systemlogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_SystemLogs_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
        private void LoadDataGrid()
        {
            string message = string.Empty;
            dgv_systemlogs.DataSource = userRepo.LoadSystemLog(ref message);

            dgv_systemlogs.Columns["ID"].Width = 50;
            dgv_systemlogs.Columns["Role"].Width = 150;
            dgv_systemlogs.Columns["DateIn"].Width = 180;
            dgv_systemlogs.Columns["TimeIn"].Width = 180;
        }

        private void btnClearLogs_Click(object sender, EventArgs e)
        {
            Frm_Main.LastActivity = "Deleting values from system logs";
        }
    }
}
