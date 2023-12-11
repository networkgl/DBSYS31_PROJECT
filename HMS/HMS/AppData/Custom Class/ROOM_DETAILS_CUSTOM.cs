using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.AppData.Custom_Class
{
    public partial class ROOM_DETAILS_CUSTOM
    {

        public int roomID { get; set; }
        public string roomType { get; set; }
        public byte[] roomPhoto { get; set; }
        public double roomPrice { get; set; }
        public string roomDetails { get; set; }
        public double roomDiscount { get; set; }
        public double discountedPrice { get; set; }

        //public Nullable<float> roomDiscount { get; set; }
    }
}
