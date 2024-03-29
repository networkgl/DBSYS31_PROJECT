﻿using HMS.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS.Properties;

namespace HMS
{
    public enum ErrorCode
    {
        Success = 0,
        Error = 1
    }

    public enum Role
    {
        Admin = 1,
        Staff = 2,
        //Client = 3
    }
    public enum RoomAvailable
    {
        MAX = 9,
        MIN = 0
    }
}
