using Guna.UI2.WinForms;
using HMS.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Interop;

namespace HMS.Forms
{
    public partial class Frm_Dashboard : Form
    {
        private static Frm_Dashboard dashboard;
        private UserRepository userRepo;
        private int total;
        private int occupied;
        public Frm_Dashboard()
        {
            InitializeComponent();
            userRepo = new UserRepository();
            Frm_Main.LastActivity = "Viewing Dashboard";
            LoadChart();
        }
        //public static Frm_Dashboard GetInstance()
        //{
        //    //if (dashboard == null)
        //    //    dashboard = new Frm_Dashboard();
        //    return dashboard = new Frm_Dashboard();
        //}
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Dashboard_Load(object sender, EventArgs e)
        {

            DisplayTotalGuest();
            DisplayTotalGuest_Adult();
            DisplayTotalGuest_Children();
            DisplayTotalGuest_SeniorCitizen();
            DisplayTotalRoom_Occupied();
            DisplayTotalRoom_Available();

            DisplayTotalRoom_Reserved_Pending();
            DisplayTotalRoom_Reserved_Approved();
            DisplayTotalRoom_Reserved();


            PopulateProgressBar();
        }
        private void DisplayTotalGuest()
        {
            string message = string.Empty;
            var getTotalGuest = userRepo.GetRoomTotalGuest_Individually(ref message);
            int totalguest = 0;
            foreach(var guest in getTotalGuest)
            {
                totalguest += (int)guest.TotalGuest;
            }

            lbl_TotalGuest.Text = totalguest.ToString();
            if (totalguest >= 100)
            {
                lbl_TotalGuest.Location = new Point(134, 63);
            }
            else
            {
                //Default Location Point.
                lbl_TotalGuest.Location = new Point(156, 63);
            }
        }
        private void DisplayTotalGuest_Adult()
        {
            string message = string.Empty;
            var getTotalGuest = userRepo.GetRoomTotalGuest_Individually(ref message);
            int totalAdult = 0;
            foreach (var guest in getTotalGuest)
            {
                totalAdult += (int)guest.TotalAdult;
            }
            lbl_totalAdult.Text = totalAdult.ToString();
        }
        private void DisplayTotalGuest_Children()
        {
            string message = string.Empty;
            var getTotalGuest = userRepo.GetRoomTotalGuest_Individually(ref message);
            int totalChildren = 0;
            foreach (var guest in getTotalGuest)
            {
                totalChildren += (int)guest.TotalChildren;
            }
            lbl_totalChildren.Text = totalChildren.ToString();
        }
        private void DisplayTotalGuest_SeniorCitizen()
        {
            string message = string.Empty;
            var getTotalGuest = userRepo.GetRoomTotalGuest_Individually(ref message);
            int totalSenior = 0;
            foreach (var guest in getTotalGuest)
            {
                totalSenior += (int)guest.TotalSeniorCitizen;
            }
            lbl_totalSenior .Text = totalSenior.ToString();
        }
        private void DisplayTotalRoom_Occupied()
        {
            string message = string.Empty;
            var getTotalRoom = userRepo.GetRoomTotal_Occupied(ref message);
            
            foreach (var room in getTotalRoom)
            {
                occupied += (int)room.RoomOccupied;
            }
            lbl_totalRoomOccupied.Text = occupied.ToString();
        }
        private void DisplayTotalRoom_Available()
        {
            string message = string.Empty;
            var getTotalRoom = userRepo.GetRoomTotal_Occupied(ref message);
            foreach (var room in getTotalRoom)
            {
                total += (int)room.RoomOccupied;
            }

            try
            {
                HMSEntities db;
                using (db  = new HMSEntities())
                {
                    var available = ((int)RoomAvailable.MAX * db.ROOM_DETAILS.Count()) - total;//Get max roomtype available then use it to calculate and multiple max room doors in every room type in this case  = 9
                    lbl_totalRoomAvailable.Text = available.ToString();
                }
            }
            catch (Exception e)
            {
                MessageDialog.Show(e.Message, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
            }
        }

        private void DisplayTotalRoom_Reserved_Pending()
        {
            string message = string.Empty;
            var getTotalRoom_Pending = userRepo.GetRoomTotal_Reserve_Pending(ref message);
            int totalRoomPending = 0;
            foreach (var room in getTotalRoom_Pending)
            {
                totalRoomPending += (int)room.RoomReserved;
            }

            lblPending.Text = totalRoomPending.ToString();
        }
        private void DisplayTotalRoom_Reserved_Approved()
        {
            string message = string.Empty;
            var getTotalRoom_Approved = userRepo.GetRoomTotal_Reserve_Approved(ref message);
            int totalRoomApproved = 0;
            foreach (var room in getTotalRoom_Approved)
            {
                totalRoomApproved += (int)room.RoomReserved;
            }

            lblApproved.Text = totalRoomApproved.ToString();
        }
        private void DisplayTotalRoom_Reserved()
        {
            string message = string.Empty;
            var getTotalRoom_Pending = userRepo.GetRoomTotal_Reserve_Pending(ref message);
            int totalRoomPending = 0;
            foreach (var room in getTotalRoom_Pending)
            {
                totalRoomPending += (int)room.RoomReserved;
            }

            var getTotalRoom_Approved = userRepo.GetRoomTotal_Reserve_Approved(ref message);
            int totalRoomApproved = 0;
            foreach (var room in getTotalRoom_Approved)
            {
                totalRoomApproved += (int)room.RoomReserved;
            }

            lbl_totalRoomReserve.Text = (totalRoomPending + totalRoomApproved).ToString();
        }

        private void PopulateProgressBar()
        {
            var totalRoom = 0;

            try
            {
                HMSEntities db;
                using (db = new HMSEntities())
                {
                    totalRoom = ((int)RoomAvailable.MAX * db.ROOM_DETAILS.Count());//Get max roomtype available then use it to calculate and multiple max room doors in every room type in this case  = 9
                    Console.WriteLine(totalRoom);
                    Console.WriteLine(occupied);
                    double percentage = ((double)occupied / totalRoom) * 100;
                    pb_currentlyCheckIn.Value = (int)percentage;
                    lbl_Pecent.Text = percentage.ToString("F2") + "%";

                    if (percentage == 100.00)
                    {
                        //41, 74
                        lbl_Pecent.Location = new Point(25, 74);
                    }
                    else 
                    {
                        lbl_Pecent.Location = new Point(41, 74);
                    }
                    Console.WriteLine(percentage);
                }
            }
            catch (Exception e)
            {
                MessageDialog.Show(e.Message, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
            }
            lbl_outOf.Text = $"Out of {totalRoom} rooms";
        }

        private void LoadChart()
        {
            // Clear existing series
            chart1.Series.Clear();

            // Create a new series
            Series series = new Series("Monthly Sales");
            series.ChartType = SeriesChartType.Column; // or Line, Pie, etc.

            //// Sample data: months and corresponding sales
            //Dictionary<string, int> salesData = new Dictionary<string, int>()
            //    {
            //        { "January", 1200 },
            //        { "February", 950 },
            //        { "March", 1400 },
            //        { "April", 1150 },
            //        { "May", 1300 },
            //        { "June", 1250 },
            //        { "July", 1600 },
            //        { "August", 1450 },
            //        { "September", 1350 },
            //        { "October", 1500 },
            //        { "November", 1700 },
            //        { "December", 1800 }
            //    };

            var salesData = SalesByMonth();

            // Add data points to the series
            foreach (var data in salesData)
            {
                series.Points.AddXY(data.Months, data.Total);
            }

            // Add the series to the chart
            chart1.Series.Add(series);

            // Set chart title (optional)
            chart1.Titles.Add("Monthly Sales Report");
        }


        private List<sp_get_sales_by_year_group_by_months_Result> SalesByMonth()
        {
            try
            {
                using (var db = new HMSEntities())
                {
                    return db.sp_get_sales_by_year_group_by_months().ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                return null;
            }
        }
    }
}
