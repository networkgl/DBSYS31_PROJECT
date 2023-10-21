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
        private static Constant ct;
        public static string RoomType { get; set; }
        public static string RoomDetails { get; set; }
        public static string RoomPrice { get; set; }
        public static string PriceDetails { get; set; }

        public static Image DeluxeKing { get; set; }
        public static Image FiliSuite { get; set; }
        public static Image PreimeireDeluxe { get; set; }
        public static int RoomType_selectedIndex { get; set; }



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
            Student = 1,
            Teacher = 2,
            Admin = 3

        }
        //public static Constant GetInstance()
        //{
        //    if (ct == null)
        //    {
        //        ct = new Constant();
        //    }
        //    return ct;
        //}
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
