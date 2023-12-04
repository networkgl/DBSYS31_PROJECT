using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.AppData;
using iTextSharp.text.pdf;

namespace HMS
{
    class UserRepository
    {
        private HMSEntities db;
        public ErrorCode InsertClientReservation(String fName, String lName, String email, String phone, String addres, DateTime reservationDateIn,
                                                DateTime reservationDateOut, String reservationStatus, String roomType, DateTime paymentDate,
                                                int paymentTotal, ref String response)
        {
            var success = 0;

            //Return Succcess Or Error.
            try
            {
                using (db = new HMSEntities())
                {
                    //Individually, Handle Error to identify which sp will going to error if possible.

                    //db.sp_insert_client_info(fName, lName, email, phone, addres);
                    //db.sp_insert_reservation_info(reservationDateIn, reservationDateOut, reservationStatus);
                    //db.sp_insert_room_info(roomType);
                    //db.sp_insert_payment_info(paymentDate, paymentTotal);


                    //return ErrorCode.Success;


                    //Client Info
                    try
                    {
                        db.sp_insert_client_info(fName, lName, email, phone, addres);
                        success++;
                    }
                    catch (Exception ex)
                    {
                        response = ex.Message;
                    }


                    //Reservation Info
                    try
                    {
                        db.sp_insert_reservation_info(reservationDateIn, reservationDateOut, reservationStatus);
                        success++;
                    }
                    catch (Exception ex)
                    {
                        response = ex.Message;
                    }

                    //Room Info
                    try
                    {
                        db.sp_insert_room_info(roomType);
                        success++;
                    }
                    catch (Exception ex)
                    {
                        response = ex.Message;
                    }

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
    }
}
