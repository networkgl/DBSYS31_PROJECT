using HMS.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    internal partial class Constant
    {
        public static String roomtype, roomDetails_1, roomDetails_2, roomPrice, priceDetails;
        public static System.Drawing.Image deluxeKing, preimeireDeluxe, filiSuite;
        public static int selectedIndex;

        public static void DeluxeKing()
        {
            switch (selectedIndex)
            {
                case 0:
                    deluxeKing = Properties.Resources.king;
                    roomtype = "DELUXE ROOM KING";
                    roomDetails_1 = "Luxurious room offering a king bed with city views";
                    //roomDetails_2 = "Enjoy a rejuvenating rest with our most \r\nflexible option. Best available room rate \r\nguaranteed.";
                    roomPrice = "₱10,000";
                    priceDetails = "Per Night\r\n₱10,000 Total for 1 night\r\nExcluding Taxes & Fees";
                    break;
                case 1:
                    preimeireDeluxe = Properties.Resources.premier_deluxe;
                    roomtype = "PREMIERE DELUXE TWIN BED";
                    roomDetails_1 = "Premiere Deluxe Twin Roon - 61 sqm\r\n";
                    //roomDetails_2 = "Enjoy a rejuvenating rest with our most \r\nflexible option. Best available room rate \r\nguaranteed.";
                    roomPrice = "₱14,000";
                    priceDetails = "Per Night\r\n₱14,000 Total for 1 night\r\nExcluding Taxes & Fees";
                    break;
                case 2:
                    filiSuite = Properties.Resources.fili_suite;
                    roomtype = "FILI SUITE SEA VIEW";
                    roomDetails_1 = "Fili Suite Sea View - 89 sqm\r\n";
                    //roomDetails_2 = "Enjoy a rejuvenating rest with our most \r\nflexible option. Best available room rate \r\nguaranteed.";
                    roomPrice = "₱20,000";
                    priceDetails = "Per Night\r\n₱20,000 Total for 1 night\r\nExcluding Taxes & Fees";
                    break;
            }
        }
    }
}
