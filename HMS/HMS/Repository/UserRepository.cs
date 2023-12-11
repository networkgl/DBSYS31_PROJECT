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

namespace HMS
{
    class UserRepository
    {
        private HMSEntities db;
        public ErrorCode InsertClientReservation(String typeOfGuest, int noOfGuest, String fName,String lName, String email, String phone, String address, DateTime reservationDateIn,
                                                DateTime reservationDateOut, int noOfDays, String roomType, DateTime paymentDate,
                                                int paymentTotal, ref String response)
        {
            var success = 0;

            //Return Succcess Or Error.
            try
            {
                using (db = new HMSEntities())
                {

                    //return ErrorCode.Success;


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
                            db.sp_insert_client_info_fnameOnly(fName,lName);
                        }
                        else
                        {
                            db.sp_insert_client_info(fName,lName, email, phone, address);
                        }
                        success++;
                    }
                    catch (Exception ex)
                    {
                        response = ex.Message;
                    }

                    //Reservation Info
                    var payment_lastPK = db.PAYMENT.Max(r => (int?)r.paymentID) ?? 0;
                    var client_lastPK = db.CLIENT.Max(r => (int?)r.clientID) ?? 0;

                    try
                    {
                        db.sp_insert_reservation_info(typeOfGuest,noOfGuest, reservationDateIn, reservationDateOut, noOfDays, payment_lastPK, client_lastPK);
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
                        db.sp_insert_room_info(roomType, reserve_lastPK);
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
            if (success == 4)
            {
                return ErrorCode.Success;
            }

            else
            {
                return ErrorCode.Error;
            }
        }
        public List<vw_display_reservation_details> LoadReservation()
        {
            using (db = new HMSEntities())
            {
                return db.vw_display_reservation_details.ToList();
            }
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
                    db.sp_approve_reservation(id);//Pass specific id to delete entire row that matches the id.
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
                using (db=new HMSEntities())
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

    }
}
