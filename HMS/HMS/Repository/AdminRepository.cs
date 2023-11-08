using HMS.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    internal class AdminRepository
    {
        private HMSEntities db;
        public AdminRepository()
        {
            db = new HMSEntities();
        }

        //Use this SP to allow dynamically inserting new advertisement 
        public ErrorCode InsertRoomDetails(String roomType, byte[] roomPhoto, string roomDetails,double roomPrice, int roomDiscount, ref String response)
        {
            //Return Succcess Or Error.
            try
            {
                using (db = new HMSEntities())
                {
                    //Insert all details to the table ROOM_DETAILS.
                    db.sp_insert_room_details(roomType, roomPhoto, roomDetails, roomPrice, roomDiscount);
                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                response = ex.Message;
                return ErrorCode.Error;
            }
        }
    }
}
