using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace HMS.Forms
{
    public partial class Frm_Login : Form
    {
        private static Frm_Login login;
        private System.Drawing.Image showPassImage = Properties.Resources.view__1_;
        private System.Drawing.Image notShowPassImage = Properties.Resources.hidden__1_;
        private int toggleShow = 0;
        private bool? firstRun = null;

        private UserRepository userRepo;
        public bool HasLogin { get; set; }
        public static string UserType { get; set; }
        //public static string GetUserAccountType { get; set; }
        public Frm_Login()
        {
            InitializeComponent();
            userRepo = new UserRepository();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }
        //public static Frm_Login GetInstance()
        //{
        //    if(login == null)
        //        login = new Frm_Login();
        //    return login;
        //}
        private void Frm_Login_Load(object sender, EventArgs e)
        {
            firstRun = true;
            txtboxUsername.Text = "Username";
            txtboxPassword.Text = "Password";

            txtboxUsername.ForeColor = System.Drawing.Color.Gray;
            txtboxPassword.ForeColor = System.Drawing.Color.Gray;
            LoginTextBox();
        }

        private void txtboxUsername_Enter(object sender, EventArgs e)
        {
            if (txtboxUsername.Text == "Username")
            {
                txtboxUsername.Text = "";
                txtboxUsername.ForeColor = System.Drawing.Color.Black;
            }
            //Console.WriteLine(toggleShow);
        }

        private void txtboxPassword_Enter(object sender, EventArgs e)
        {
            if ((bool)firstRun)
            {
                LoginTextBox();
                firstRun = false;
            }

            // Clear the textbox and change the text color when it's in focus
            if (txtboxPassword.Text == "Password")
            {
                txtboxPassword.Text = "";
                txtboxPassword.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtboxUsername_Leave(object sender, EventArgs e)
        {
            if (txtboxUsername.Text == "")
            {
                txtboxUsername.Text = "Username";
                txtboxUsername.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtboxPassword_Leave(object sender, EventArgs e)
        {
            if (txtboxPassword.Text == "")
            {
                txtboxPassword.Text = "Password";
                txtboxPassword.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_HomePage hp = new Frm_HomePage();
            hp.Show();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            LoginTextBox();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/gianlloyd.pinote");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            HasLogin = true;
            toggleShow = 0;

            //this.Hide();
            //Frm_Main main = new Frm_Main();
            //main.Show();


            ValidateUserLogin();
        }

        private void LoginTextBox()
        {
            toggleShow++;
            if (toggleShow % 2 == 0)
            {
                txtboxPassword.UseSystemPasswordChar = false;
                btnShowPassword.BackgroundImage = notShowPassImage;
                btnShowPassword.BackgroundImageLayout = ImageLayout.Center;
            }
            else
            {
                txtboxPassword.UseSystemPasswordChar = true;
                btnShowPassword.BackgroundImage = showPassImage;
                btnShowPassword.BackgroundImageLayout = ImageLayout.Center;
            }
            Console.WriteLine(toggleShow);
        }

        public void ValidateUserLogin()
        {
            var userLogged = userRepo.GetUserByUsername(txtboxUsername.Text);
            var message = "Successfully Login";

            if (userLogged != null)
            {
                if (userLogged.userPassword.Equals(txtboxPassword.Text))
                {
                    // Assigned to a singleton
                    UserLogged.GetInstance().UserAccount = userLogged;
                    Frm_Main main = new Frm_Main();
                    switch ((Role)userLogged.roleID)
                    {
                        case Role.Admin:
                            UserType = "Admin";
                            MessageDialog.Show("Admin " + message, "Message", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Light);
                            this.Hide();
                            main.Show();
                            break;
                        case Role.Staff:
                            UserType = "Staff";
                            MessageDialog.Show("Staff " + message, "Message", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Light);
                            this.Hide();
                            main.Show();
                            break;
                        default:
                            message = "User has no ROLE!";
                            MessageDialog.Show(message, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
                            break;
                    }
                }
                else
                {
                    message = "Invalid Password";
                    MessageDialog.Show(message, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
                }
            }
            else
            {
                message = "Username NOT FOUND";
                MessageDialog.Show(message, "Message", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
            }
        }
    }
}
