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
    public partial class Frm_Client : Form
    {
        private static Frm_Client client;
        private Frm_Client()
        {
            InitializeComponent();
        }
        public static Frm_Client GetInstance()
        {
            if (client == null)
                client = new Frm_Client();
            return client;
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

        }
    }
}
