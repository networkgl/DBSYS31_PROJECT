﻿using HMS.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_HomePage());
            //Application.Run(new Frm_BookNow_S4());
            //Application.Run(new Frm_Main());
            //Application.Run(new Form1());
            //Application.Run(new Frm_ManageSystem());

        }
    }
}
