using System;
using System.Windows.Forms;

namespace DashboardUI
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        private Label firstNameLabel;
        private TextBox firstNameText;
        private Label lastNameLabel;
        private TextBox lastNameText;
        private Label emailAddressLabel;
        private TextBox emailAddressText;
        private Label phoneNumberLabel;
        private TextBox phoneNumberText;
        private ListBox messageBox;
        private Label messageerrorListLabel;
        private Label userIdLabel;
        private TextBox userIdText;
        private Button createButton;
        private Button getUsersButton;
        private Button removeAllUsersButton;
        private Button quiteButton;
        private Button editUserButton;
        private Button removeUserButton;
        private Button saveUsersButton;
        private Button editButton;
        private Button removeButton;
        private Button modifyUsersButton;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void FirstNameLabelAndText()
        {
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(76, 138);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(131, 29);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            this.firstNameText.Location = new System.Drawing.Point(282, 132);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(214, 35);
            this.firstNameText.TabIndex = 2;
        }
        private void LastNameLabelAndText()
        {
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(79, 181);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(128, 29);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name";
            this.lastNameText.Location = new System.Drawing.Point(283, 178);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(214, 35);
            this.lastNameText.TabIndex = 4;
        }
        private void EmailAddressLabelAndText()
        {
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Location = new System.Drawing.Point(79, 227);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(169, 29);
            this.emailAddressLabel.TabIndex = 5;
            this.emailAddressLabel.Text = "Email Address";

            this.emailAddressText.Location = new System.Drawing.Point(282, 224);
            this.emailAddressText.Name = "emailAddressText";
            this.emailAddressText.Size = new System.Drawing.Size(214, 35);
            this.emailAddressText.TabIndex = 6;
        }
        private void PhoneNumberLabelAndText()
        {
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(79, 276);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(176, 29);
            this.phoneNumberLabel.TabIndex = 7;
            this.phoneNumberLabel.Text = "Phone Number";

            this.phoneNumberText.Location = new System.Drawing.Point(283, 270);
            this.phoneNumberText.Name = "phoneNumberText";
            this.phoneNumberText.Size = new System.Drawing.Size(214, 35);
            this.phoneNumberText.TabIndex = 10;
        }
        private void UserIdLabelAndText()
        {
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(200, 500);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(150, 29);
            this.userIdLabel.TabIndex = 1;
            this.userIdLabel.Text = "Please provide user ID";
            this.userIdText.Location = new System.Drawing.Point(500, 500);
            this.userIdText.Name = "firstNameText";
            this.userIdText.Size = new System.Drawing.Size(214, 35);
            this.userIdText.TabIndex = 2;
        }
        private void AddUserButton()
        {
            this.createButton.Location = new System.Drawing.Point(44, 29);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(140, 60);
            this.createButton.TabIndex = 9;
            this.createButton.Text = "Add User";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);

        }
        private void GetAllUsersButton()
        {
            this.getUsersButton.Location = new System.Drawing.Point(570, 29);
            this.getUsersButton.Name = "getUsersButton";
            this.getUsersButton.Size = new System.Drawing.Size(140, 60);
            this.getUsersButton.TabIndex = 12;
            this.getUsersButton.Text = "Get Users";
            this.getUsersButton.UseVisualStyleBackColor = true;
            this.getUsersButton.Click += new System.EventHandler(this.getUsers_Click);
        }
        private void RemoveAllUsersButton()
        {
            this.removeAllUsersButton.Location = new System.Drawing.Point(740, 29);
            this.removeAllUsersButton.Name = "removeAllUsersButton";
            this.removeAllUsersButton.Size = new System.Drawing.Size(180, 60);
            this.removeAllUsersButton.TabIndex = 12;
            this.removeAllUsersButton.Text = "Remove All";
            this.removeAllUsersButton.UseVisualStyleBackColor = true;
            this.removeAllUsersButton.Click += new System.EventHandler(this.removeAllUsers_Click);
        }

        private void QuitButton()
        {
            this.quiteButton.Location = new System.Drawing.Point(940, 29);
            this.quiteButton.Name = "quiteButton";
            this.quiteButton.Size = new System.Drawing.Size(180, 60);
            this.quiteButton.TabIndex = 12;
            this.quiteButton.Text = "Quite";
            this.quiteButton.UseVisualStyleBackColor = true;
            this.quiteButton.Click += new System.EventHandler(this.quiteButton_Click);
        }



        private void RemoveUserButton()
        {
            this.removeUserButton.Location = new System.Drawing.Point(374, 29);
            this.removeUserButton.Name = "removeUserButton";
            this.removeUserButton.Size = new System.Drawing.Size(175, 60);
            this.removeUserButton.TabIndex = 14;
            this.removeUserButton.Text = "Remove User";
            this.removeUserButton.UseVisualStyleBackColor = true;
            this.removeUserButton.Click += new System.EventHandler(this.removeUsers_Click);
        }
        private void EditUserButton()
        {
            this.editUserButton.Location = new System.Drawing.Point(213, 29);
            this.editUserButton.Name = "editButton";
            this.editUserButton.Size = new System.Drawing.Size(140, 60);
            this.editUserButton.TabIndex = 9;
            this.editUserButton.Text = "Edit User";
            this.editUserButton.UseVisualStyleBackColor = true;
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
        }
        private void SaveUserButton()
        {
            this.saveUsersButton.Location = new System.Drawing.Point(800, 500);
            this.saveUsersButton.Name = "saveButton";
            this.saveUsersButton.Size = new System.Drawing.Size(100, 60);
            this.saveUsersButton.TabIndex = 13;
            this.saveUsersButton.Text = "Save";
            this.saveUsersButton.UseVisualStyleBackColor = true;
            this.saveUsersButton.Click += new System.EventHandler(this.saveButton_Click);
        }

        private void EditButton()
        {
            this.editButton.Location = new System.Drawing.Point(800, 500);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(90, 50);
            this.editButton.TabIndex = 13;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
        }

        private void RemoveButton()
        {
            this.removeButton.Location = new System.Drawing.Point(800, 500);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(120, 50);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
        }



        private void ModifyUserButton()
        {
            this.modifyUsersButton.Location = new System.Drawing.Point(800, 340);
            this.modifyUsersButton.Name = "modifyButton";
            this.modifyUsersButton.Size = new System.Drawing.Size(100, 60);
            this.modifyUsersButton.TabIndex = 13;
            this.modifyUsersButton.Text = "Modify";
            this.modifyUsersButton.UseVisualStyleBackColor = true;
            this.modifyUsersButton.Click += new System.EventHandler((this.modifyButton_Click));
        }
        private void MyMessageBox(string name, int itemHeight, int xPoint, int xsize, int ysize)
        {
            this.messageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageBox.FormattingEnabled = true;
            this.messageBox.ItemHeight = itemHeight;
            this.messageBox.Location = new System.Drawing.Point(xPoint, 132);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(xsize, ysize);
            this.messageBox.TabIndex = 11;
            // messageerrorListLabel
            this.messageerrorListLabel.AutoSize = true;
            this.messageerrorListLabel.Location = new System.Drawing.Point(782, 100);
            this.messageerrorListLabel.Name = "messageerrorListLabel";
            this.messageerrorListLabel.Size = new System.Drawing.Size(124, 29);
            this.messageerrorListLabel.TabIndex = 1;
            this.messageerrorListLabel.Text = name;
        }


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            #region Dashboard
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new Padding(7, 8, 7, 8);
            this.Name = "Dashboard";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
            this.SuspendLayout();
            #endregion

            this.firstNameLabel = new Label();
            this.firstNameText = new TextBox();
            this.userIdLabel = new Label();
            this.userIdText = new TextBox();
            this.lastNameLabel = new Label();
            this.lastNameText = new TextBox();
            this.emailAddressLabel = new Label();
            this.emailAddressText = new TextBox();
            this.phoneNumberLabel = new Label();
            this.phoneNumberText = new TextBox();
            this.createButton = new Button();
            this.saveUsersButton = new Button();
            this.editButton = new Button();
            this.removeButton = new Button();
            this.editUserButton = new Button();
            this.removeAllUsersButton = new Button();
            this.removeUserButton = new Button();
            this.messageBox = new ListBox();
            this.messageerrorListLabel = new Label();
            this.getUsersButton = new Button();
            this.quiteButton = new Button();
            this.modifyUsersButton = new Button();

            UserIdLabelAndText();
            FirstNameLabelAndText();
            LastNameLabelAndText();
            EmailAddressLabelAndText();
            PhoneNumberLabelAndText();
            AddUserButton();
            GetAllUsersButton();
            RemoveUserButton();
            EditUserButton();
            SaveUserButton();
            EditButton();
            RemoveButton();
            QuitButton();
            RemoveAllUsersButton();
            MyMessageBox("Messages", 24, 551, 542, 196);
            ModifyUserButton();
        }

        private void GetOnlyButtons()
        {
            this.Controls.Clear();
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.editUserButton);
            this.Controls.Add(this.getUsersButton);
            this.Controls.Add(this.removeUserButton);
            this.Controls.Add(this.removeAllUsersButton);
            this.Controls.Add(this.quiteButton);
        }

        private void GetAddView()
        {
            GetOnlyButtons();
            MyMessageBox("Messages", 24, 551, 542, 196);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.phoneNumberText);
            this.Controls.Add(this.saveUsersButton);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.emailAddressText);
            this.Controls.Add(this.emailAddressLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.messageerrorListLabel);
            this.Controls.Add(this.firstNameLabel);
        }

        private void GetModifyView()
        {
            GetOnlyButtons();
            MyMessageBox("Messages", 24, 551, 542, 196);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.messageerrorListLabel);
            this.Controls.Add(this.phoneNumberText);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.modifyUsersButton);
            this.Controls.Add(this.emailAddressText);
            this.Controls.Add(this.emailAddressLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.firstNameLabel);
        }

        private void GetAllUsersView()
        {
            GetOnlyButtons();
            MyMessageBox("Users", 40, 100, 900, 300);
            this.Controls.Add(this.messageerrorListLabel);
            this.Controls.Add(this.messageBox);
        }

        private void GetEditUserByIdView()
        {
            GetAllUsersView();
            this.Controls.Add(this.userIdText);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.editButton);

        }

        private void GetRemoveUserByIdView()
        {
            GetAllUsersView();

            this.Controls.Add(this.userIdText);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.removeButton);

        }
        #endregion

    }


}