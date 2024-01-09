using Guna.UI2.WinForms;
using HMS.AppData;
using HMS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Forms
{
    public partial class Frm_Room : Form
    {
        //private Frm_RoomDetails form;

        private UserRepository userRepo;
        private AdminRepository adminRepo;
        private int currentIndex;
        public Label[,] roomDetails = new Label[9, 3];
        public Panel[] doorPicture = new Panel[9];
        public static string FullName { get; set; }
        public static string RoomType { get; set; }
        public static string Email { get; set; }
        public static string Phone { get; set; }
        public static string Address { get; set; }
        public static string Adult { get; set; }
        public static string Children { get; set; }
        public static string Senior { get; set; }
        public static string DateIn { get; set; }
        public static string DateOut { get; set; }
        public static string NoOfDays { get; set; }
        public static int RoomNumber { get; set; }

        private Panel[] roomPictures;
        private Guna2Panel[] doorPanels;
        public Frm_Room()
        {
            InitializeComponent();
            this.DoubleBuffered = false;

            userRepo = new UserRepository();
            adminRepo = new AdminRepository();
            //form = new Frm_RoomDetails();

            PopulateRoomDetails_Array();
            PopulateDoorPicture_Array();

            roomPictures = new Panel[]
            {
                pnl_door1,
                pnl_door2,
                pnl_door3,
                pnl_door4,
                pnl_door5,
                pnl_door6,
                pnl_door7,
                pnl_door8,
                pnl_door9,
            };

            doorPanels = new Guna2Panel[]
            {
                pnl_room1,
                pnl_room2,
                pnl_room3,
                pnl_room4,
                pnl_room5,
                pnl_room6,
                pnl_room7,
                pnl_room8,
                pnl_room9
            };

            // Wire up click events for each room panel
            for (int i = 0; i < doorPanels.Length; i++)
            {
                WireUpEvents(doorPanels[i].Controls, doorPanels[i]);
            }
        }

        private void cbBox_RoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeIndex();
        }

        private void Frm_Room_Load(object sender, EventArgs e)
        {
            InitialLoad();// Call this funtion to load upadted list for rooms available
            cbBox_RoomType.SelectedIndex = 0;//set first index to display something.           
        }
        //private void WireUpClickEvents(Control.ControlCollection controls, Guna2Panel panel)
        //{
        //    // Attach the same event handler to the Click event for the parent panel
        //    panel.Click += AnyControl_Click;
        //    panel.Click += Panel_MouseEnter;
        //    panel.Click += Panel_MouseLeave;

        //    // Store a reference to the parent panel in the Tag property of the parent panel itself
        //    panel.Tag = panel;

        //    foreach (Control control in controls)
        //    {
        //        // Attach the same event handler to the Click event for controls inside the panel
        //        control.Click += AnyControl_Click;
        //        control.MouseEnter += Panel_MouseEnter;
        //        control.MouseLeave += Panel_MouseLeave;

        //        // Store a reference to the parent panel in the Tag property of each control
        //        control.Tag = panel;

        //        if (control.HasChildren)
        //        {
        //            WireUpClickEvents(control.Controls, panel); // Recursively wire up click events for nested controls
        //        }
        //    }
        //}
        private void WireUpEvents(Control.ControlCollection controls, Guna2Panel panel)
        {
            // Attach the same event handler to the Click, MouseEnter, and MouseLeave events for the parent panel
            WireUpControlEvents(panel);

            panel.Tag = panel;

            foreach (Control control in controls)
            {
                // Attach the same event handler to the Click, MouseEnter, and MouseLeave events for controls inside the panel
                WireUpControlEvents(control);

                // Store a reference to the parent panel in the Tag property of each control
                control.Tag = panel;

                if (control.HasChildren)
                {
                    WireUpEvents(control.Controls, panel); // Recursively wire up events for nested controls
                }
            }
        }

        private void WireUpControlEvents(Control control)
        {
            // Attach the same event handler to the Click, MouseEnter, and MouseLeave events for the control
            control.Click += AnyControl_Click;
            control.MouseEnter += Panel_MouseEnter;
            control.MouseLeave += Panel_MouseLeave;
        }
        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            // Code to execute when any control is clicked
            Control enteredControl = (Control)sender;
            Guna2Panel parentPanel = (Guna2Panel)enteredControl.Tag;

            //Manually check if what pnl is being entered.
            switch (parentPanel.Name)
            {
                case "pnl_room1":
                    toolTip1.SetToolTip(this.pnl_room1, "Room Number 1");
                    GetBorderPanelColor(lbl_roomNumber_1, pnl_room1);
                    break;
                case "pnl_room2":
                    toolTip1.SetToolTip(this.pnl_room2, "Room Number 2");
                    GetBorderPanelColor(lbl_roomNumber_2, pnl_room2);
                    break;
                case "pnl_room3":
                    toolTip1.SetToolTip(this.pnl_room3, "Room Number 3");
                    GetBorderPanelColor(lbl_roomNumber_3, pnl_room3);
                    break;
                case "pnl_room4":
                    toolTip1.SetToolTip(this.pnl_room4, "Room Number 4");
                    GetBorderPanelColor(lbl_roomNumber_4, pnl_room4);
                    break;
                case "pnl_room5":
                    toolTip1.SetToolTip(this.pnl_room5, "Room Number 5");
                    GetBorderPanelColor(lbl_roomNumber_5, pnl_room5);
                    break;
                case "pnl_room6":
                    toolTip1.SetToolTip(this.pnl_room6, "Room Number 6");
                    GetBorderPanelColor(lbl_roomNumber_6, pnl_room6);
                    break;
                case "pnl_room7":
                    toolTip1.SetToolTip(this.pnl_room7, "Room Number 7");
                    GetBorderPanelColor(lbl_roomNumber_7, pnl_room7);
                    break;
                case "pnl_room8":
                    toolTip1.SetToolTip(this.pnl_room8, "Room Number 8");
                    GetBorderPanelColor(lbl_roomNumber_8, pnl_room8);
                    break;
                case "pnl_room9":
                    toolTip1.SetToolTip(this.pnl_room9, "Room Number 9");
                    GetBorderPanelColor(lbl_roomNumber_9, pnl_room9);
                    break;
            }
        }
        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            // Code to execute when any control is clicked
            Control leaveControl = (Control)sender;
            Guna2Panel parentPanel = (Guna2Panel)leaveControl.Tag;

            SetBorderPanelEmptyColor(parentPanel);    
        }
        private void AnyControl_Click(object sender, EventArgs e)
        {
            // Code to execute when any control is clicked
            Control clickedControl = (Control)sender;
            Panel parentPanel = (Panel)clickedControl.Tag;

            //Manually check if what pnl is being clicked.
            switch (parentPanel.Name)
            {
                case "pnl_room1":
                    RoomNumber = 1;
                    GetRoomClientDetails(lbl_roomNumber_1);
                    break;
                case "pnl_room2":
                    RoomNumber = 2;
                    GetRoomClientDetails(lbl_roomNumber_2);
                    break;
                case "pnl_room3":
                    RoomNumber = 3;
                    GetRoomClientDetails(lbl_roomNumber_3);
                    break;
                case "pnl_room4":
                    RoomNumber = 4;
                    GetRoomClientDetails(lbl_roomNumber_4);
                    break;
                case "pnl_room5":
                    RoomNumber = 5;
                    GetRoomClientDetails(lbl_roomNumber_5);
                    break;
                case "pnl_room6":
                    RoomNumber = 6;
                    GetRoomClientDetails(lbl_roomNumber_6);
                    break;
                case "pnl_room7":
                    RoomNumber = 7;
                    GetRoomClientDetails(lbl_roomNumber_7);
                    break;
                case "pnl_room8":
                    RoomNumber = 8;
                    GetRoomClientDetails(lbl_roomNumber_8);
                    break;
                case "pnl_room9":
                    RoomNumber = 9;
                    GetRoomClientDetails(lbl_roomNumber_9);
                    break;
            }
        }
        //Custom Function to determine border color base on room status
        private void GetBorderPanelColor(Label label, Guna2Panel panel)
        {
            if (label.Text.Equals("N/A"))
                panel.BorderColor = Color.Red;
            else
                panel.BorderColor = Color.Green;
        }
        private void SetBorderPanelEmptyColor(Guna2Panel panel)
        {
            panel.BorderColor = Color.Empty;
        }

        private void InitialLoad()
        {
            String response = String.Empty;
            var retValRows = adminRepo.GetRoomTypeByID(ref response);

            if (retValRows == ErrorCode.Success)
            {
                cbBox_RoomType.Items.Clear();
                foreach (var i in adminRepo.RoomType)
                {
                    cbBox_RoomType.Items.Add(i);
                }
                cbBox_RoomType.SelectedIndex = 0;

            }
            else
            {
                MessageDialog.Show(response, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
            }
        }
        private void ChangeIndex()
        {
            for (int i = 0; i < adminRepo.LastPrimaryKeyValue; i++)
            {
                if (cbBox_RoomType.SelectedIndex == i)
                {
                    currentIndex = i;
                    break;
                }
            }
            DisplayDoorPictre(currentIndex);
            //Assign door picture to specific room type
            //switch (currentIndex)
            //{
            //    case 0:
            //        DisplayDoorPictre(0);
            //        break;
            //    case 1:
            //        DisplayDoorPictre(1);
            //        break;
            //    case 2:
            //        DisplayDoorPictre(2);
            //        break;
            //    case 3:
            //        DisplayDoorPictre(3);
            //        break;
            //}


            String response = String.Empty;
            userRepo.GetClientRoomDetails(cbBox_RoomType.SelectedItem.ToString(), ref response);
            Frm_Main.LastActivity = "Viewing " + cbBox_RoomType.SelectedItem.ToString() + " Room Type";

            var details = userRepo.ClientDetails;
            var labelAssignVal = roomDetails;
            //This loops assigned a value to the each of room details 
            for (int row = 0; row < details.GetLength(0); row++)
            {
                for (int col = 0; col < details.GetLength(1); col++)
                {
                    if (string.IsNullOrEmpty(details[row, col]))
                    {
                        labelAssignVal[row, col].Text = "N/A";
                    }
                    else
                    {
                        labelAssignVal[row, col].Text = details[row, col];
                    }
                }
            }
            var roomMax = RoomAvailable.MAX;
            var countOccupied = 0;
            for (int roomNumber = 1; roomNumber <= (int)roomMax; roomNumber++)
            {
                // Get the label for the current room number
                Label roomNumberLabel = Controls.Find($"lbl_roomNumber_{roomNumber}", true).FirstOrDefault() as Label;

                // Get the corresponding status label
                Label statusLabel = Controls.Find($"lbl_status{roomNumber}", true).FirstOrDefault() as Label;

                if (roomNumberLabel != null && statusLabel != null)
                {
                    // Check if the room number is not "0"
                    if (!roomNumberLabel.Text.Equals("N/A"))
                    {
                        statusLabel.Text = "Occupied";
                        statusLabel.ForeColor = Color.Green;
                        countOccupied++;
                    }
                    else
                    {
                        statusLabel.Text = "Not Occupied";
                        statusLabel.ForeColor = Color.Red;
                    }
                }
            }
            var remainingRoom = (int)roomMax - countOccupied;

            if (remainingRoom == (int)RoomAvailable.MIN)
            {
                lbl_RoomType.Text = "FULL BOOKED";
                lbl_RoomType.ForeColor = Color.Red;
            }
            else
            {
                lbl_RoomType.Text = $"Vacant Room : {remainingRoom}";
                lbl_RoomType.ForeColor = Color.RoyalBlue;
            }
            //lbl_RoomType.Text = $"Vacant Room : {remainingRoom}";
        }
        private void DisplayDoorPictre(int index)
        {
            string response = string.Empty;
            var retVal = adminRepo.GetRoomDetails(index, ref response);


            if (retVal == ErrorCode.Success)
            {
                foreach (var panel in roomPictures)
                {
                    panel.BackgroundImage = adminRepo.Image;
                }
            }
            else
            {
                MessageDialog.Show(response, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
            }
        }
        private void PopulateRoomDetails_Array()
        {
            roomDetails[0, 0] = lbl_roomNumber_1;
            roomDetails[0, 1] = lbl_NumberOfPeople_1;
            roomDetails[0, 2] = lbl_NumberOfDays_1;

            roomDetails[1, 0] = lbl_roomNumber_2;
            roomDetails[1, 1] = lbl_NumberOfPeople_2;
            roomDetails[1, 2] = lbl_NumberOfDays_2;

            roomDetails[2, 0] = lbl_roomNumber_3;
            roomDetails[2, 1] = lbl_NumberOfPeople_3;
            roomDetails[2, 2] = lbl_NumberOfDays_3;

            roomDetails[3, 0] = lbl_roomNumber_4;
            roomDetails[3, 1] = lbl_NumberOfPeople_4;
            roomDetails[3, 2] = lbl_NumberOfDays_4;

            roomDetails[4, 0] = lbl_roomNumber_5;
            roomDetails[4, 1] = lbl_NumberOfPeople_5;
            roomDetails[4, 2] = lbl_NumberOfDays_5;

            roomDetails[5, 0] = lbl_roomNumber_6;
            roomDetails[5, 1] = lbl_NumberOfPeople_6;
            roomDetails[5, 2] = lbl_NumberOfDays_6;

            roomDetails[6, 0] = lbl_roomNumber_7;
            roomDetails[6, 1] = lbl_NumberOfPeople_7;
            roomDetails[6, 2] = lbl_NumberOfDays_7;

            roomDetails[7, 0] = lbl_roomNumber_8;
            roomDetails[7, 1] = lbl_NumberOfPeople_8;
            roomDetails[7, 2] = lbl_NumberOfDays_8;

            roomDetails[8, 0] = lbl_roomNumber_9;
            roomDetails[8, 1] = lbl_NumberOfPeople_9;
            roomDetails[8, 2] = lbl_NumberOfDays_9;
        }
        private void PopulateDoorPicture_Array()
        {
            doorPicture[0] = pnl_door1;
            doorPicture[1] = pnl_door2;
            doorPicture[2] = pnl_door3;
            doorPicture[3] = pnl_door4;
            doorPicture[4] = pnl_door5;
            doorPicture[5] = pnl_door6;
            doorPicture[6] = pnl_door7;
            doorPicture[7] = pnl_door8;
            doorPicture[8] = pnl_door9;
        }
        private List<HMS.AppData.sp_display_room_client_details_Result> retVal;
        private string message = string.Empty;


        private void GetRoomClientDetails(Label roomNumber)
        {
            List<string> ListOfDetails = new List<string>();

            if (!roomNumber.Text.Equals("N/A"))
            {
                retVal = userRepo.GetRoomClientDetailsById(int.Parse(roomNumber.Text), ref message);

                foreach (var details in retVal)
                {
                    FullName = details.FullName;
                    RoomType = details.RoomType;
                    Email = details.Email;
                    Phone = details.Phone;
                    Address = details.Address;
                    Adult = details.Adult.ToString();
                    Children = details.Children.ToString();
                    Senior = details.SeniorCitizen.ToString();
                    DateIn = details.DateIn.ToString("ddd, MMM dd, yyyy");
                    DateOut = details.DateOut.ToString("ddd, MMM dd, yyyy");
                    NoOfDays = details.NoOfDays.ToString();

                    ListOfDetails.Add(FullName);
                    ListOfDetails.Add(RoomType);
                    ListOfDetails.Add(Email);
                    ListOfDetails.Add(Phone);
                    ListOfDetails.Add(Address);
                    ListOfDetails.Add(Adult);
                    ListOfDetails.Add(Children);
                    ListOfDetails.Add(Senior);
                    ListOfDetails.Add(DateIn);
                    ListOfDetails.Add(DateOut);
                    ListOfDetails.Add(NoOfDays);
                }

                //Call the form to display
                var rcd = new Frm_RoomClientDetails();
                rcd.ShowDialog();
            }
            else 
            {
                MessageDialog.Show("No Currently Occupied", "Message", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Light);
                return; 
            }


            //For Debugging Purposes
            foreach (var details in ListOfDetails)
            {
                Console.WriteLine(details);
            }
        }
    }
}
