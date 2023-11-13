using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.AppData.Custom_Class
{
    public partial class ROOM_DETAILS_CUSTOM
    {
        public string roomType { get; set; }
        public double roomPrice { get; set; }
        public string roomDetails { get; set; }
        public Nullable<int> roomDiscount { get; set; }
    }
}
