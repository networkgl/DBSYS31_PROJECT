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

        public Frm_Room()
        {
            InitializeComponent();
            userRepo = new UserRepository();
            adminRepo = new AdminRepository();
            //form = new Frm_RoomDetails();

            PopulateRoomDetails_Array();
            PopulateDoorPicture_Array();
        }

        private void cbBox_RoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var form = new Form();
            //var labelRoomType = String.Empty;

            //switch (cbBox_RoomType.SelectedIndex)
            //{
            //    case 0:
            //        form = new Frm_RType_Deluxe();
            //        labelRoomType = "Deluxe";
            //        break;
            //    case 1:
            //        form = new Frm_RType_PriemereDeluxe();
            //        labelRoomType = "Priemere Deluxe";
            //        break;
            //    case 2:
            //        form = new Frm_RType_FiliSuite();
            //        labelRoomType = "Fili Suite";
            //        break;
            //}

            //lbl_RoomType.Text = labelRoomType;
            //pnl_RoomType.Controls.Clear();
            //form.TopLevel = false;
            //form.Dock = DockStyle.Fill;
            //pnl_RoomType.Controls.Add(form);
            //form.Show();
            ChangeIndex();
        }

        private void Frm_Room_Load(object sender, EventArgs e)
        {

            //pnl_RoomType.Controls.Clear();
            //form.TopLevel = false;
            //form.Dock = DockStyle.Fill;
            //pnl_RoomType.Controls.Add(form);
            //form.Show();

            InitialLoad();// Call this funtion to load upadted list for rooms available

            cbBox_RoomType.SelectedIndex = 0;//set first index to display something.
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

            //Assign door picture to specific room type
            switch (currentIndex)
            {
                case 0:
                    DisplayDoorPictre(0);
                    break;
                case 1:
                    DisplayDoorPictre(1);
                    break;
                case 2:
                    DisplayDoorPictre(2);
                    break;
                case 3:
                    DisplayDoorPictre(3);
                    break;
            }


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
                lbl_RoomType.Text = "FULL BOOK";
            }
            else
            {
                lbl_RoomType.Text = $"Vacant Room : {remainingRoom}";
            }
            //lbl_RoomType.Text = $"Vacant Room : {remainingRoom}";
        }
        private void DisplayDoorPictre(int index)
        {
            var doors = doorPicture;

            switch (index)
            {
                case 0:
                    foreach (var door in doors)
                    {
                        door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                        door.BackgroundImage = Properties.Resources.icons8_door_100;
                    }
                    break;
                case 1:
                    foreach (var door in doors)
                    {
                        door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                        door.BackgroundImage = Properties.Resources.icons8_door_100__2_;
                    }
                    break;
                case 2:
                    foreach (var door in doors)
                    {
                        door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                        door.BackgroundImage = Properties.Resources.icons8_door_100__3_;
                    }
                    break;
                case 3:
                    foreach (var door in doors)
                    {
                        door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                        door.BackgroundImage = Properties.Resources.icons8_door_100__4_;
                    }
                    break;              
            }
        }

        public Label[,] roomDetails = new Label[9, 3];
        public Panel[] doorPicture = new Panel[9];
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
        private void pnl_room1_Click(object sender, EventArgs e)
        {
            GetRoomClientDetails(lbl_roomNumber_1);
        }

        private void pnl_room2_Click(object sender, EventArgs e)
        {
            GetRoomClientDetails(lbl_roomNumber_2);
        }
        private void pnl_room3_Click(object sender, EventArgs e)
        {
            GetRoomClientDetails(lbl_roomNumber_3);
        }

        private void pnl_room4_Click(object sender, EventArgs e)
        {
            GetRoomClientDetails(lbl_roomNumber_4);
        }

        private void pnl_room5_Click(object sender, EventArgs e)
        {
            GetRoomClientDetails(lbl_roomNumber_5);
        }

        private void pnl_room6_Click(object sender, EventArgs e)
        {
            GetRoomClientDetails(lbl_roomNumber_6);
        }

        private void pnl_room7_Click(object sender, EventArgs e)
        {
            GetRoomClientDetails(lbl_roomNumber_7);
        }

        private void pnl_room8_Click(object sender, EventArgs e)
        {
            GetRoomClientDetails(lbl_roomNumber_8);
        }

        private void pnl_room9_Click(object sender, EventArgs e)
        {
            GetRoomClientDetails(lbl_roomNumber_9);
        }

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
