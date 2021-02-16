using System;
using System.ComponentModel;
using System.Windows.Forms;
using WallStreet.Services.UserServices;
using WallStreet.Validators.RegistrationValidators;

namespace WallStreet.Forms
{
    public partial class RegisterForm : Form
    {
        private bool firstNameTextBoxFirstClick = true;
        private bool lastNameTextBoxFirstClick = true;
        private bool emailTextBoxFirstClick = true;
        private bool usernameTextBoxFirstClick = true;
        private bool passwordTextBoxFirstClick = true;
        private readonly IUserService userService = new UserService();
        private readonly IRegistrationValidator registrationValidator = new RegistrationValidator();

        public RegisterForm()
        {
            InitializeComponent();
            tbPassword.UseSystemPasswordChar = true;
        }

        private void btnBackToWelcomeForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            var welcomeForm = new WelcomeForm();
            welcomeForm.Closed += (s, args) => this.Close();
            welcomeForm.Show();
        }

        private void tbFirstName_Click(object sender, System.EventArgs e)
        {
            if (firstNameTextBoxFirstClick)
            {
                tbFirstName.Text = String.Empty;
                firstNameTextBoxFirstClick = false;
            }
        }

        private void tbLastName_Click(object sender, EventArgs e)
        {
            if (lastNameTextBoxFirstClick)
            {
                tbLastName.Text = String.Empty;
                lastNameTextBoxFirstClick = false;
            }
        }

        private void tbEmail_Click(object sender, EventArgs e)
        {
            if (emailTextBoxFirstClick)
            {
                tbEmail.Text = String.Empty;
                emailTextBoxFirstClick = false;
            }
        }

        private void tbUsername_Click(object sender, EventArgs e)
        {
            if (usernameTextBoxFirstClick)
            {
                tbUsername.Text = String.Empty;
                usernameTextBoxFirstClick = false;
            }
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            if (passwordTextBoxFirstClick)
            {
                tbPassword.Text = String.Empty;
                passwordTextBoxFirstClick = false;
            }
        }

        private void btnRegisterNow_Click(object sender, EventArgs e)
        {
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            string email = tbEmail.Text;
            string username = tbUsername.Text;
            string password = tbPassword.Text;


            // TODO Finish this if statement

            if (!registrationValidator.IsValidFirstName(firstName))
            {
                lblInvalidFirstName.Text = "Invalid input";
            }
            else if (!registrationValidator.IsValidLastName(lastName))
            {
                lblInvalidLastName.Text = "Invalid input";
            }
            else if (!registrationValidator.IsValidEmail(email))
            {
                lblInvalidEmail.Text = "Invalid input";
            }
            else if (!registrationValidator.IsValidUsername(username))
            {
                lblInvalidUsername.Text = "Invalid input";
            }
            else if (!registrationValidator.IsValidPassword(password))
            {
                lblInvalidPassword.Text = "Invalid input";
            }
            else
            {
                userService.CreateUser(firstName, lastName, email, username, password);

            }

            if (userService.IsSuccessfulCreationOfUser(username))
            {
                this.Hide();
                var loginForm = new LoginForm();
                loginForm.Closed += (s, args) => this.Close();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Unsuccessful registration!");
            }
        }
    }
}
