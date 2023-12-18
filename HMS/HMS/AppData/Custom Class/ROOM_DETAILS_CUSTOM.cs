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
        public decimal roomPrice { get; set; }
        public string roomDetails { get; set; }
        public decimal roomDiscount { get; set; }
        public decimal discountedPrice { get; set; }

        //public Nullable<float> roomDiscount { get; set; }
    }

    public partial class sp_search_room_details_Result
    {
        public int ID { get; set; }
        public string RoomType { get; set; }
        public string Details { get; set; }
        public decimal Price { get; set; }
        public string Promo { get; set; }
        public decimal Discounted { get; set; }
    }
}
