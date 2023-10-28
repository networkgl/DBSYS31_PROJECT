using Pabo.Calendar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace HMS
{
    public partial class Frm_Calendar : Form
    {
        public Frm_Calendar()
        {
            InitializeComponent();
        }

        private void Frm_Calendar_Load(object sender, EventArgs e)
        {
            monthCalendar2.Header.BackColor1 = Color.FromArgb(101, 28, 50);
            //monthCalendar2.Weekdays.TextColor = Color.Blue;


            //monthCalendar2.Weeknumbers.BorderColor = Color.Red;
            //InitializeCustomCalendar();

        }
        private void FormatDates()
        {
            DateItem[] d = new DateItem[5];
            d.Initialize();
            for (int i = 0; i < 5; i++)
                d[i] = new DateItem();

            d[0].Date = new DateTime(2005, 6, 3);
            d[0].BackColor1 = Color.Red;
            d[0].ImageListIndex = 3;
            d[0].Text = "Help";
            d[1].Date = new DateTime(2005, 6, 12);
            d[1].ImageListIndex = 2;
            d[2].Date = new DateTime(2005, 6, 16);
            d[2].BackColor1 = Color.LightBlue;
            d[2].ImageListIndex = 8;
            d[3].Date = new DateTime(2005, 6, 18);
            d[3].BackColor1 = Color.GreenYellow;
            d[3].ImageListIndex = 1;
            d[3].Text = "NorDev";
            d[4].Date = new DateTime(2005, 6, 22);
            d[4].ImageListIndex = 1;
            d[4].Text = "Cebit";

            monthCalendar2.AddDateInfo(d);
        }

        private void monthCalendar2_DayQueryInfo(object sender, DayQueryInfoEventArgs e)
        {          

            List<DateTime> dateArray = new List<DateTime>();
            dateArray.Add(new DateTime(2023, 11, 10));
            dateArray.Add(new DateTime(2023, 11, 15));
            dateArray.Add(new DateTime(2023, 11, 20));

            var size = dateArray.Count;

            for (int i = 0; i < size; i++)
            {

                // Check date and mark it with color to specify occupied or not available to select for booking.
                if (e.Date == dateArray[i])
                {
                    // Add custom formatting
                    e.Info.DateColor = Color.White;

                    e.Info.BackColor1 = Color.Violet;
                    e.OwnerDraw = true;
                }
            }
        }
        private void InitializeCustomCalendar()
        {

            List<DateTime> dateArray = new List<DateTime>();
            dateArray.Add(new DateTime(2023, 11, 10));
            dateArray.Add(new DateTime(2023, 11, 15));
            dateArray.Add(new DateTime(2023, 11, 20));

            // Size of the DateItem array should match the size of dateArray
            var size = dateArray.Count;

            // Create an array of DateItem instances
            DateItem[] d = new DateItem[size];

            for (int i = 0; i < size; i++)
            {
                d[i] = new DateItem();
                d[i].Date = dateArray[i];
                d[i].BackColor1 = Color.Red;
            }

            // Add multiple dates to the DateItem
            monthCalendar2.AddDateInfo(d);
        }
    }
}
