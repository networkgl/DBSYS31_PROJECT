using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using System.Windows.Interop;
using HMS.AppData;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using System.Data;

namespace HMS
{
    class UserRepository
    {
        private string[,] clientDetails;
        private HMSEntities db;
        private const int ROOM_COUNTER = 1;//use this variable to pass in view and help calculate the total count of room in terms of roomType
        public string[,] ClientDetails { get => clientDetails; set => clientDetails = value; }

        public ErrorCode InsertClientReservation
        (
            int noOfAdult,
            int noOfChildren,
            int noOfSeniorCitizen,
            String fName,
            String lName,
            String email,
            String phone,
            String address,
            DateTime reservationDateIn,
            DateTime reservationDateOut,
            int noOfDays,
            String roomType,
            DateTime paymentDate,
            decimal paymentTotal,
            ref String response)
        {
            var success = 0;

            //Return Succcess Or Error.
            try
            {
                using (db = new HMSEntities())
                {

                    //Payment Info
                    try
                    {
                        db.sp_insert_payment_info(paymentDate, paymentTotal);
                        success++;
                    }
                    catch (Exception ex)
                    {
                        response = ex.Message;
                    }

                    //Client Info
                    try
                    {
                        if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(phone) && string.IsNullOrEmpty(address))
                        {
                            db.sp_insert_client_info_fnameOnly(fName, lName);
                        }
                        else
                        {
                            db.sp_insert_client_info(fName, lName, email, phone, address);
                        }
                        success++;
                    }
                    catch (Exception ex)
                    {
                        response = ex.Message;
                    }

                    //Guest Info
                    try
                    {
                        db.sp_insert_number_of_guest(noOfAdult, noOfChildren, noOfSeniorCitizen);
                        success++;
                    }
                    catch (Exception ex)
                    {
                        response = ex.Message;
                    }


                    //Reservation Info
                    //Get individual table last PK value using MAX to make it the same PK and FK
                    var payment_lastPK = db.PAYMENT.Max(r => (int?)r.paymentID) ?? 0;
                    var client_lastPK = db.CLIENT.Max(r => (int?)r.clientID) ?? 0;
                    var guest_lastPK = db.GUEST.Max(r => (int?)r.guestID) ?? 0;
                    try
                    {
                        db.sp_insert_reservation_info(reservationDateIn, reservationDateOut, noOfDays, guest_lastPK, payment_lastPK, client_lastPK);
                        success++;
                    }
                    catch (Exception ex)
                    {
                        response = ex.Message;
                    }


                    //Room Info
                    var reserve_lastPK = db.RESERVATION.Max(r => (int?)r.reservationID) ?? 0;

                    try
                    {
                        db.sp_insert_room_info(roomType, reserve_lastPK, ROOM_COUNTER);
                        success++;
                    }
                    catch (Exception ex)
                    {
                        response = ex.Message;
                    }
                }
            }

            catch (Exception ex)//Handle Error if db malfunction
            {
                response = ex.Message;
                return ErrorCode.Error;
            }

            Console.WriteLine("Success : " + success);

            //Check if all insertion is successfull using var success
            if (success == 5)
            {
                return ErrorCode.Success;
            }

            else
            {
                return ErrorCode.Error;
            }
        }
        public List<vw_display_reservation_details> LoadReservation(ref string message)
        {
            var retVal = new List<vw_display_reservation_details>();
            try
            {
                using (db = new HMSEntities())
                {
                    return db.vw_display_reservation_details.ToList();
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            return retVal;
        }

        public List<vw_display_client_details> LoadClientsInformation(ref string message)
        {
            var retVal = new List<vw_display_client_details>();
            try
            {
                using (db = new HMSEntities())
                {
                    retVal = db.vw_display_client_details.ToList();
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            return retVal;
        }

        public ErrorCode DeniedReservation(int id, ref string message)
        {
            try
            {
                using (db = new HMSEntities())
                {
                    db.sp_denied_reservation(id);//Pass specific id to delete entire row that matches the id.
                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return ErrorCode.Error;
            }
        }
        public ErrorCode ApproveReservation(int id, ref string message)
        {
            try
            {
                using (db = new HMSEntities())
                {
                    db.sp_approve_reservation(id);//Pass specific id to accept entire row that matches the id.
                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return ErrorCode.Error;
            }
        }
        public ErrorCode DeleteAllReservation(ref string message)
        {
            try
            {
                using (db = new HMSEntities())
                {
                    db.sp_delete_all_reservation();
                    return ErrorCode.Success;
                }
            }
            catch (Exception e)
            {
                message = e.Message;
                return ErrorCode.Error;
            }
        }
        public void GetClientRoomDetails(string roomType, ref string response)
        {
            ClientDetails = new string[9, 3];

            try
            {
                using (db = new HMSEntities())
                {
                    var getVal = db.sp_get_client_room_details(roomType);

                    int row = 0;
                    foreach (var details in getVal)
                    {
                        // Assuming details.RoomID, details.TotalGuest, and details.Days are of type string
                        ClientDetails[row, 0] = details.RoomID.ToString();
                        ClientDetails[row, 1] = details.TotalGuest.ToString();
                        ClientDetails[row, 2] = details.Days.ToString();

                        // Print values for verification
                        //Console.WriteLine($"{ClientDetails[row, 0]}, {ClientDetails[row, 1]}, {ClientDetails[row, 2]}");

                        // Move to the next row
                        row++;
                    }

                    //foreach (var i in getVal)
                    //{
                    //    clientDetails = i.RoomID;
                    //    Console.WriteLine($"ID: {i.RoomID}, TotalGuest: {i.TotalGuest}, NumberOfDays: {i.Days}");

                    //    //Console.WriteLine($"Room Type: {_roomType}, Room Details: {_roomDetails}, Room Price: {_roomPrice}, Room Discount: {_roomDiscount}+%, Discounted Price{_discountedPrice}");
                    //}
                    //return ErrorCode.Success;
                }
            }
            catch (Exception e)
            {
                response = e.Message;
                //return ErrorCode.Error;
            }
        }
        public List<vw_display_pending_reservation> GetClientReservation_Pending(ref string message)
        {
            var retVal = new List<vw_display_pending_reservation>();

            try
            {
                using (db = new HMSEntities())
                {
                    retVal = db.vw_display_pending_reservation.ToList();
                }
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return retVal;
        }
        public List<vw_display_approve_reservation> GetClientReservation_Approve(ref string message)
        {
            var retVal = new List<vw_display_approve_reservation>();

            try
            {
                using (db = new HMSEntities())
                {
                    retVal = db.vw_display_approve_reservation.ToList();
                }
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return retVal;
        }
        public ErrorCode GetRoomStatus(string roomType, ref RoomAvailable currentTotal, ref string message)
        {
            try
            {
                using (db = new HMSEntities())
                {
                    // Execute the stored procedure and assign the result to currentTotal
                    var result = db.Database.SqlQuery<int>("EXEC sp_get_room_status @roomtype", new SqlParameter("@roomtype", roomType)).FirstOrDefault();
                    currentTotal = (RoomAvailable)result;

                    return ErrorCode.Success;
                }
            }
            catch (Exception e)
            {
                message = e.Message;
                return ErrorCode.Error;
            }
        }
        public List<vw_display_total_approve_guest> GetRoomTotalGuest_Individually(ref string message)
        {
            var retVal = new List<vw_display_total_approve_guest>();

            try
            {
                using (db = new HMSEntities())
                {

                    retVal = db.vw_display_total_approve_guest.ToList();
                }
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return retVal;
        }
        public List<vw_get_total_room_occupied> GetRoomTotal_Occupied(ref string message)
        {
            var retVal = new List<vw_get_total_room_occupied>();

            try
            {
                using (db = new HMSEntities())
                {

                    retVal = db.vw_get_total_room_occupied.ToList();
                }
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return retVal;
        }
        public List<vw_get_room_reserve_pending_current_occurence> GetRoomTotal_Reserve_Pending(ref string message)
        {
            var retVal = new List<vw_get_room_reserve_pending_current_occurence>();

            try
            {
                using (db = new HMSEntities())
                {

                    retVal = db.vw_get_room_reserve_pending_current_occurence.ToList();
                }
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return retVal;
        }
        public List<vw_get_room_reserve_approve_current_occurence> GetRoomTotal_Reserve_Approved(ref string message)
        {
            var retVal = new List<vw_get_room_reserve_approve_current_occurence>();

            try
            {
                using (db = new HMSEntities())
                {

                    retVal = db.vw_get_room_reserve_approve_current_occurence.ToList();
                }
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return retVal;
        }
        public List<vw_get_reservation_history> GetReservationHistory(ref string message)
        {
            var retVal = new List<vw_get_reservation_history>();

            try
            {
                using (db = new HMSEntities())
                {
                    retVal = db.vw_get_reservation_history.ToList();
                }
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return retVal;
        }
        public List<vw_get_current_booking_bydate> GetCurrentReservation_CheckIn_ByDate(ref string message)
        {
            var retVal = new List<vw_get_current_booking_bydate>();

            try
            {
                using (db = new HMSEntities())
                {
                    retVal = db.vw_get_current_booking_bydate.ToList();
                }
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return retVal;
        }
        //public ErrorCode SearchReservationByName(string searchName, ref string message)
        //{
        //    try
        //    {
        //        using (db = new HMSEntities())
        //        {
        //            db.sp_search_client_details(searchName);
        //            return ErrorCode.Success;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        message = e.Message;
        //        return ErrorCode.Error;
        //    }
        //}
        public List<sp_search_client_details_Result> SearchBookingDetailsByName(string searchName)
        {
            try
            {
                using (var db = new HMSEntities())
                {
                    // Use Entity Framework to call the stored procedure
                    var result = db.Database.SqlQuery<sp_search_client_details_Result>("EXEC sp_search_client_details @SearchTerm", new SqlParameter("@SearchTerm", searchName)).ToList();

                    return result;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
                throw ex;
            }
        }
        public List<sp_search_reservation_details_Result> SearchReservationDetails(string searchName)
        {
            try
            {
                using (var db = new HMSEntities())
                {
                    // Use Entity Framework to call the stored procedure
                    var result = db.Database.SqlQuery<sp_search_reservation_details_Result>("EXEC sp_search_reservation_details @SearchTerm", new SqlParameter("@SearchTerm", searchName)).ToList();

                    return result;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
                throw ex;
            }
        }
        public List<HMS.AppData.Custom_Class.sp_search_room_details_Result> SearchRoomDetails(string searchName)
        {
            try
            {
                using (var db = new HMSEntities())
                {
                    // Use Entity Framework to call the stored procedure
                    var result = db.Database.SqlQuery<HMS.AppData.Custom_Class.sp_search_room_details_Result>("EXEC sp_search_room_details @SearchTerm", new SqlParameter("@SearchTerm", searchName)).ToList();

                    return result;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
                throw ex;
            }
        }
        public ErrorCode InsertSystemAccounts(string username, string password, int roleID, ref string message)
        {
            try
            {
                using (db = new HMSEntities())
                {
                    db.sp_insert_system_accounts(username, password, roleID);
                    message = "Account Successfully Created";
                    return ErrorCode.Success;
                }
            }
            catch (Exception e)
            {
                message = e.Message;
                return ErrorCode.Error;
            }
        }
        public List<vw_display_sytem_accounts> GetSystemAccounts(ref string message)
        {
            var retVal = new List<vw_display_sytem_accounts>();

            try
            {
                using (db = new HMSEntities())
                {
                    retVal = db.vw_display_sytem_accounts.ToList();
                }
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return retVal;
        }
        public ErrorCode UpdateSystemAccounts(int userID, string username, string password, int roleID, ref string message)
        {
            try
            {
                using (db = new HMSEntities())
                {
                    db.sp_update_system_accounts(userID, username, password, roleID);
                    message = "Account Successfully Updated";
                    return ErrorCode.Success;
                }
            }
            catch (Exception e)
            {
                message = e.Message;
                return ErrorCode.Error;
            }
        }
        public ErrorCode DeleteSystemAccounts(int userID, ref string message)
        {
            try
            {
                using (db = new HMSEntities())
                {
                    db.sp_delete_system_accounts(userID);
                    message = "Account Successfully Deleted";
                    return ErrorCode.Success;
                }
            }
            catch (Exception e)
            {
                message = e.Message;
                return ErrorCode.Error;
            }
        }
        public ACCOUNTS GetUserByUsername(String username)
        {
            // re-initialize db object because sometimes data in the list not updated
            using (db = new HMSEntities())
            {
                // SELECT TOP 1 * FROM USERACCOUNT WHERE userName == username
                Console.WriteLine("Out: " + db.ACCOUNTS.Where(s => s.userName == username).FirstOrDefault());
                return db.ACCOUNTS.Where(s => s.userName == username).FirstOrDefault();
               
            }
        }
        public ErrorCode InsertSystemLogs(string typeOfAccount,DateTime date, TimeSpan time, string lastActivity, ref string message)
        {
            try
            {
                using (db = new HMSEntities())
                {
                    db.sp_insert_system_log(typeOfAccount, date, time, lastActivity);
                    return ErrorCode.Success;
                }
            }
            catch (Exception e)
            {
                message = e.Message;
                return ErrorCode.Error;
            }
        }
        public List<vw_display_system_log> LoadSystemLog(ref string message)
        {
            var retVal = new List<vw_display_system_log>();

            try
            {
                using (db = new HMSEntities())
                {
                    retVal = db.vw_display_system_log.ToList();
                }
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return retVal;
        }

        public List<sp_display_room_client_details_Result> GetRoomClientDetailsById(int ID, ref string message)
        {
            var retVal = new List<sp_display_room_client_details_Result>();
            try 
            {
                using (db = new HMSEntities())
                {
                    retVal = db.sp_display_room_client_details(ID).ToList();
                }
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return retVal;
        }
    }
}
