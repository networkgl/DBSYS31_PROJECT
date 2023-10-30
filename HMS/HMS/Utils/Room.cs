using HMS.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    internal class Room
    {
        private static Room r;
        public static string RoomType { get; set; }
        public static string RoomDetails { get; set; }
        public static string RoomPrice { get; set; }
        public static string PriceDetails { get; set; }

        public static Image DeluxeKing { get; set; }
        public static Image FiliSuite { get; set; }
        public static Image PreimeireDeluxe { get; set; }
        public static int RoomType_selectedIndex { get; set; }

        public static Room GetInstance()
        {
            if (r == null)
            {
                r = new Room();
            }
            return r;
        }
        public static void GetRoomType()
        {
            switch (RoomType_selectedIndex)
            {
                case 0:
                    DeluxeKing = Resources.king;
                    RoomType = "DELUXE ROOM KING";
                    RoomDetails = "Luxurious room offering a king bed with city views";
                    RoomPrice = "₱10,000";
                    PriceDetails = "Per Night\r\n₱10,000 Total for 1 night\r\nExcluding Taxes & Fees";
                    break;
                case 1:
                    PreimeireDeluxe = Resources.premier_deluxe;
                    RoomType = "PREMIERE DELUXE TWIN BED";
                    RoomDetails = "Premiere Deluxe Twin Roon - 61 sqm\r\n";
                    RoomPrice = "₱14,000";
                    PriceDetails = "Per Night\r\n₱14,000 Total for 1 night\r\nExcluding Taxes & Fees";
                    break;
                case 2:
                    FiliSuite = Resources.fili_suite;
                    RoomType = "FILI SUITE SEA VIEW";
                    RoomDetails = "Fili Suite Sea View - 89 sqm\r\n";
                    RoomPrice = "₱20,000";
                    PriceDetails = "Per Night\r\n₱20,000 Total for 1 night\r\nExcluding Taxes & Fees";
                    break;
            }
        }
    }
}
