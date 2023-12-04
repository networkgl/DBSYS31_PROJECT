using Guna.UI2.WinForms;
using HMS.AppData;
using HMS.AppData.Custom_Class;
using HMS.Forms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        private string _roomType;
        private string _roomDetails;
        private double _roomPrice;
        private int? _roomDiscount;



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

        public string _RoomType { get => _roomType; set => _roomType = value; }
        public string _RoomDetails { get => _roomDetails; set => _roomDetails = value; }
        public double _RoomPrice { get => _roomPrice; set => _roomPrice = value; }
        public int? _RoomDiscount { get => _roomDiscount; set => _roomDiscount = value; }

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
        public ErrorCode GetRoomDetails(int index, ref string response)
        {
            index += 1;

            //Return Succcess Or Error.
            try
            {
                using (db = new HMSEntities())
                {
                    try
                    {
                        // Assuming the stored procedure returns an ObjectResult<byte[]>
                        var result = db.sp_get_room_photo_by_index(index);

                        //if (result != null && result.Any())
                        //{
                        byte[] photoBytes = result.First();

                        // Use the photoBytes as needed
                        // For example, you can convert it to an image and assign it to a PictureBox
                        using (MemoryStream stream = new MemoryStream(photoBytes))
                        {
                            image = Image.FromStream(stream);
                            //Console.WriteLine("HAS VAL");
                        }

                        try
                        {
                            var parameters = new SqlParameter("@index", index);
                            var roomDetails = db.Database.SqlQuery<ROOM_DETAILS_CUSTOM>("EXEC sp_get_room_details__by_index @index", parameters);

                            foreach (var roomDetail in roomDetails)
                            {
                                // Assuming ROOM_DETAILS_CUSTOM is the entity class with properties of specific columns that I query.
                                _roomType = roomDetail.roomType;
                                _roomDetails = roomDetail.roomDetails;
                                _roomPrice = roomDetail.roomPrice;
                                _roomDiscount = roomDetail.roomDiscount;

                                Console.WriteLine($"Room Type: {_roomType}, Room Details: {_roomDetails}, Room Price: {_roomPrice}, Room Discount: {_roomDiscount}");
                            }
                        }
                        catch (Exception ex)
                        {
                            response = ex.Message;
                            return ErrorCode.Error;
                        }
                        //This Approach is working also. 
                        /*
                        using (var db = new HMSEntities())
                        {
                            var roomDetails = db.ROOM_DETAILS
                                .Where(s => s.roomID == index)
                                .Select(r => new
                                {
                                    r.roomType,
                                    r.roomDetails,
                                    r.roomPrice,
                                    r.roomDiscount
                                })
                                .FirstOrDefault();

                            // Check if roomDetails is not null before accessing its properties
                            if (roomDetails != null)
                            {
                                // Assign the values to global variables
                                _roomType = roomDetails.roomType;
                                _roomDetails = roomDetails.roomDetails;
                                _roomPrice = roomDetails.roomPrice;
                                _roomDiscount = roomDetails.roomDiscount;

                                Console.WriteLine(_RoomType);
                                Console.WriteLine(_RoomDetails);
                                Console.WriteLine(_RoomPrice);
                                Console.WriteLine(_RoomDiscount);
                            }
                            else
                            {
                                Console.WriteLine($"No room found with ID {index}");
                            }
                       
                    } */
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions related to retrieving or processing the image data
                        Console.WriteLine("Error: " + ex.Message);
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
        public ErrorCode CountAllRows()
        {
            //Return Succcess Or Error.
            try
            {
                using (db = new HMSEntities())
                {
                    // Use the Max function directly without a Where clause
                    lastVal = db.ROOM_DETAILS.Count();
                    //Console.WriteLine("Admin: "+LastPrimaryKeyValue);
                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                MessageDialog.Show(ex.Message);
                return ErrorCode.Error;
            }
        }
        public ErrorCode GetRoomTypeByID(ref string response)
        {
            var retValRows = CountAllRows();
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
                            //var temp = db.ROOM_DETAILS.Where(s => s.roomID == i).Select(r => new { r.roomType, r.roomDetails, r.roomPrice, r.roomDiscount }).FirstOrDefault();


                            roomType.Add(temp.ToString());

                            Console.WriteLine(temp.ToString());
                        }
                        return ErrorCode.Success;
                    }
                    else
                    {
                        response = "Unsuccessfully Query";
                        MessageDialog.Show(response, "Message", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Light);
                        return ErrorCode.Error;
                    }
                }
            }
            catch (Exception ex)
            {
                response = ex.Message;
                return ErrorCode.Error;
            }
        }
        public List<vw_display_room_details> LoadRoomDetails()
        {
            using (db = new HMSEntities())
            {
                return db.vw_display_room_details.ToList();
            }
        }
        public ErrorCode DeleteRoomDetails(int? index, ref string response)
        {
            try
            {
                using (db = new HMSEntities())
                {
                    db.sp_delete_room_details(index);
                    return ErrorCode.Success;
                }
            }
            catch (Exception e)
            {
                response = e.Message;
                return ErrorCode.Error;
            }
        }
        public ErrorCode UpdateRoomDetails_WithPhoto(int? roomID,byte[] roomPhoto, string roomType, string roomDetails, double roomPrice, int roomDiscount, ref string response)
        {
            try
            {
                using (db = new HMSEntities())
                {
                    db.sp_update_room_details_withphoto(roomID, roomPhoto, roomType, roomDetails, roomPrice, roomDiscount);
                    response = "Successfully Updated";
                    return ErrorCode.Success;
                }
            }
            catch (Exception e)
            {
                response = e.Message;
                return ErrorCode.Error;
            }
        }
        public ErrorCode UpdateRoomDetails_NoPhoto(int? roomID, string roomType, string roomDetails, double roomPrice, int roomDiscount, ref string response)
        {
            try
            {
                using (db = new HMSEntities())
                {
                    db.sp_update_room_details_nophoto(roomID, roomType, roomDetails, roomPrice, roomDiscount);
                    response = "Successfully Updated";
                    return ErrorCode.Success;
                }
            }
            catch (Exception e)
            {
                response = e.Message;
                return ErrorCode.Error;
            }
        }
    }
}
