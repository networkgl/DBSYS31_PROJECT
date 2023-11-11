using Guna.UI2.WinForms;
using HMS.AppData;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    class AdminRepository
    {
        private HMSEntities db;
        private int lastVal;
        private byte[] retPhoto;
        private Image image;
        private List<string> roomType;

        public int LastPrimaryKeyValue 
        {
            get { return lastVal; }
            set { lastVal = value; }
        }
        public byte[] RetPhoto
        {
            get { return retPhoto; }
            set { retPhoto = value; }
        }
        public List<string> RoomType
        {
            get { return roomType; }
            set { roomType = value; }
        }

        public Image Image { get => image; set => image = value; }

        public AdminRepository()
        {
            db = new HMSEntities();
        }

        //Use this SP to allow dynamically inserting new advertisement 
        public ErrorCode InsertRoomDetails(int roomID, String roomType, byte[] roomPhoto, string roomDetails,double roomPrice, int roomDiscount, ref String response)
        {
            //Return Succcess Or Error.
            try
            {
                using (db = new HMSEntities())
                {
                    //Insert all details to the table ROOM_DETAILS.
                    db.sp_insert_room_details(roomID, roomType, roomPhoto, roomDetails, roomPrice, roomDiscount);
                    response = "Details Successfully Saved";
                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                response = ex.Message;
                return ErrorCode.Error;
            }
        }
        public void GetPhotoByIndex(int index)
        {
            //Return Succcess Or Error.
            try
            {
                using (db = new HMSEntities())
                {
                    //db.sp_getRoomPhoto_byIndex(index + 1).First();


                    try
                    {
                        // Assuming the stored procedure returns an ObjectResult<byte[]>
                        var result = db.sp_getRoomPhoto_byIndex(index + 1);

                        if (result != null && result.Any())
                        {
                            byte[] photoBytes = result.First();

                            // Use the photoBytes as needed
                            // For example, you can convert it to an image and assign it to a PictureBox
                            using (MemoryStream stream = new MemoryStream(photoBytes))
                            {
                                image = Image.FromStream(stream);
                                Console.WriteLine("HAS VAL");
                            }
                        }
                        else
                        {
                            // Handle the case where the result is empty
                            Console.WriteLine("Error: Empty result from the stored procedure");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions related to retrieving or processing the image data
                        Console.WriteLine("Error: " + ex.Message);
                    }


                    //return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                //response = ex.Message;
                //return ErrorCode.Error;
            }
        }
        public ErrorCode CountAllRows(String response)
        {
            //Return Succcess Or Error.
            try
            {
                using (db = new HMSEntities())
                {
                    // Use the Max function directly without a Where clause
                    lastVal = db.ROOM_DETAILS.Count();
                    Console.WriteLine("Admin: "+LastPrimaryKeyValue);
                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                response = ex.Message;
                return ErrorCode.Error;
            }
        }
        public ErrorCode GetRoomTypeByID(string response)
        {
            var retValRows = CountAllRows(response);
            roomType = new List<string>();

            try
            {
                using (db = new HMSEntities())
                {
                    if (retValRows == ErrorCode.Success)
                    {

                        for (int i = 1; i <= LastPrimaryKeyValue; i++)
                        {
                            var temp = db.ROOM_DETAILS.Where(s => s.roomID == i).Select(r => r.roomType).FirstOrDefault();
                            //var temp = db.ROOM_DETAILS.Select(r => r.roomType).Where(s => s.roo == i);

                            roomType.Add(temp.ToString());

                            Console.WriteLine(temp.ToString());
                        }
                        response = "Successfully Query";
                    }
                    else
                    {
                        response = "Unsuccessfully Query";
                        MessageDialog.Show(response, "Message", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Light);
                    }
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
