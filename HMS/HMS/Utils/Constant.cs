using HMS.Forms;
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
    internal partial class Constant
    {
        private Constant()
        {

        }
        public enum ErrorCode
        {
            Success = 0,
            Error = 1
        }

        public enum Role
        {
            Manager = 1,
            Staff = 2,
            Client = 3
        }
    }
}
