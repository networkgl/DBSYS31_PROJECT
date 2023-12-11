using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Interop;

namespace HMS.Forms
{
    public partial class Frm_Client : Form
    {
        private UserRepository userRepo;
        public Frm_Client()
        {
            InitializeComponent();
            userRepo = new UserRepository();
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
        private void Frm_Client_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
        private void LoadDataGrid()
        {
            string message = string.Empty;
            dgv_roomdetails.DataSource = userRepo.LoadClientsInformation(ref message);

            dgv_roomdetails.Columns["ID"].Width = 20;
            dgv_roomdetails.Columns["Type_of_Guest"].Width = 90;
            dgv_roomdetails.Columns["No_of_Guest"].Width = 80;
            dgv_roomdetails.Columns["Name"].Width = 40;
            dgv_roomdetails.Columns["Phone"].Width = 45;
            dgv_roomdetails.Columns["Address"].Width = 60;
            dgv_roomdetails.Columns["Email"].Width = 60;
            dgv_roomdetails.Columns["Room_Type"].Width = 80;
            dgv_roomdetails.Columns["Date_In"].Width = 60;
            dgv_roomdetails.Columns["Date_Out"].Width = 70;
            dgv_roomdetails.Columns["Days"].Width = 30;
            dgv_roomdetails.Columns["Payment"].Width = 80;

            this.dgv_roomdetails.Columns["Payment"].DefaultCellStyle.Format = "C";
            //this.dgv_roomdetails.Columns["Payment"].DefaultCellStyle.FormatProvider = new CultureInfo("en-PH");
        }
    }
}
