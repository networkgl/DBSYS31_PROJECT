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
    public partial class Frm_Room : Form
    {
        public Frm_Room()
        {
            InitializeComponent();
        }

        private void cbBox_RoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var form = new Form();
            var labelRoomType = String.Empty;

            switch (cbBox_RoomType.SelectedIndex)
            {
                case 0:
                    form = new Frm_RType_Deluxe();
                    labelRoomType = "Deluxe";
                    break;
                case 1:
                    form = new Frm_RType_PriemereDeluxe();
                    labelRoomType = "Priemere Deluxe";
                    break;
                case 2:
                    form = new Frm_RType_FiliSuite();
                    labelRoomType = "Fili Suite";
                    break;
            }

            lbl_RoomType.Text = labelRoomType;
            pnl_RoomType.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnl_RoomType.Controls.Add(form);
            form.Show();
        }

        private void Frm_Room_Load(object sender, EventArgs e)
        {
            Frm_RType_Deluxe form = new Frm_RType_Deluxe();

            pnl_RoomType.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnl_RoomType.Controls.Add(form);
            form.Show();
            cbBox_RoomType.SelectedIndex = 0;
        }
    }
}
