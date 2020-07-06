using DashboardUI.Validators;
using DataAccess;
using FluentValidation.Results;
using ModelLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardUI
{
    public partial class Dashboard : Form
    {
        BindingList<string> Data = new BindingList<string>();
        ISerializer _serializer;
        IBaseRepository<User> userRepository;

        public Dashboard()
        {
            InitializeComponent();
            GetOnlyButtons();
            _serializer = new JsonWorker();
            userRepository = new UserRepositoryWorkingWithJson(_serializer);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            firstNameText.Text = null;
            lastNameText.Text = null;
            phoneNumberText.Text = null;
            emailAddressText.Text = null;
            Data.Clear();
            messageBox.DataSource = Data;
            GetAddView();
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            Data.Clear();
            getUsers_Click(sender, e);
            userIdText.Text = null;
            GetEditUserByIdView();
        }

        private void getUsers_Click(object sender, EventArgs e)
        {
            Data.Clear();
            GetAllUsersView();
            if (userRepository.GetAll().Count() == 0)
            {
                Data.Add("There is no user in the DB.");
                messageBox.DataSource = Data;
            }
            else
            {
                foreach (var item in userRepository.GetAll())
                {
                    Data.Add(item.ToString());
                }
                messageBox.DataSource = Data;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            User person = new User();
            person.FirstName = firstNameText.Text;
            person.LastName = lastNameText.Text;
            person.PhoneNumber = phoneNumberText.Text;
            person.EmailAddress = emailAddressText.Text;

            UserValidator validator = new UserValidator();

            ValidationResult results = validator.Validate(person);

            if (results.IsValid == false)
            {
                foreach (ValidationFailure failure in results.Errors)
                {
                    Data.Add(failure.ErrorMessage);
                    messageBox.DataSource = Data;
                }
                MessageBox.Show("Operation Faild");
            }
            else
            {
                userRepository.AddUser(person);
                userRepository.Save();
                Data.Add("User is succesfully saved");
                messageBox.DataSource = Data;
                MessageBox.Show("Saved");
            }

            GetOnlyButtons();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int Id;
            if (int.TryParse(userIdText.Text, out Id))
            {
                if (userRepository.IsValidId(Id))
                {
                    userRepository.RemoveUser(Id);
                    userRepository.Save();
                    Data.Clear();
                    messageBox.DataSource = Data;
                    MessageBox.Show("User is removed");
                }
                else
                {
                    MessageBox.Show("Invalid user ID");
                    GetOnlyButtons();
                }
            }
            else
            {
                MessageBox.Show("Id must be a number");
            }
            userIdText.Text = null;
            GetOnlyButtons();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            User userToEdit = new User()
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                PhoneNumber = phoneNumberText.Text,
                EmailAddress = emailAddressText.Text
            };
            UserValidator validator = new UserValidator();
            ValidationResult results = validator.Validate(userToEdit);
            if (results.IsValid == false)
            {
                foreach (ValidationFailure failure in results.Errors)
                {
                    Data.Add(failure.ErrorMessage);
                    messageBox.DataSource = Data;
                }
                MessageBox.Show("Operation Faild");
            }
            else
            {
                userRepository.Update(userToEdit, userToEdit.UserId);
                userRepository.Save();
                MessageBox.Show("User is edited");
            }

            GetOnlyButtons();
        }


        private void editButton_Click(object sender, EventArgs e)
        {
            int Id;
            if (int.TryParse(userIdText.Text, out Id))
            {

                if (userRepository.IsValidId(Id))
                {
                    var user = userRepository.GetUser(Id);
                    Data.Clear();
                    Data.Add(user.ToString());
                    messageBox.DataSource = Data;
                    firstNameText.Text = user.FirstName;
                    lastNameText.Text = user.LastName;
                    phoneNumberText.Text = user.PhoneNumber;
                    emailAddressText.Text = user.EmailAddress;
                    GetModifyView();
                }
                else
                {
                    MessageBox.Show("Invalid user ID");
                    GetOnlyButtons();
                }
            }
            else
            {
                MessageBox.Show("Id must be a number");
                GetOnlyButtons();
            }

        }

        private void removeUsers_Click(object sender, EventArgs e)
        {
            Data.Clear();
            getUsers_Click(sender, e);
            userIdText.Text = null;
            GetRemoveUserByIdView();
        }

        private void removeAllUsers_Click(object sender, EventArgs e)
        {
            GetOnlyButtons();
            DialogResult dialogResult = MessageBox.Show("Do you want to remove all users", "Remove all", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                userRepository.RemoveAllUsers();
                userRepository.Save();
                Data.Clear();
                messageBox.DataSource = Data;
                MessageBox.Show("All users are removed");
            }
        }

        private void quiteButton_Click(object sender, EventArgs e)
        {
            GetOnlyButtons();
            DialogResult dialogResult = MessageBox.Show("Are you sure want to quite", "Quite", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
