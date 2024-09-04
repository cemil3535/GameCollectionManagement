﻿using GameCollectionManagement.Models;
using GameCollectionManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCollectionManagement
{
    public partial class AddUser : UserControl
    {

        private IUserService _userService;

        private UserList _userList;

        private bool _fromLoginPage = false;



        public AddUser(bool fromLoginPage = false)
        {
            InitializeComponent();

            _userService = new UserService();
            _fromLoginPage = fromLoginPage;
        }

        


        public AddUser(UserList userList)
        {
            InitializeComponent();

            _userService = new UserService();

            _userList = userList;
        }



        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                User user = new User();
                user.UserName = txtUserName.Text.Trim();
                user.Email = txtEmail.Text.Trim();
                user.Password = txtPassword.Text.Trim();
                user.Role = txtRole.Text.Trim();

                try
                {
                    _userService.Add(user);

                    MessageBox.Show("Kullanici olusturuldu.");

                    if (_userList != null)
                    {
                        _userList.LoadUsers();

                        ((Form)Parent.Parent).Close();
                    }

                    if (_fromLoginPage)
                    {
                        ((Form)Parent.Parent).Close();
                    }

                    ClearForm();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void ClearForm()
        {
            txtEmail.Clear();
            txtPassword.Clear();
            txtRole.Clear();
            txtUserName.Clear();
        }


        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Kullanici adi giriniz", "Giris Hatasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email giriniz", "Giris Hatasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password giriniz", "Giris Hatasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtRole.Text))
            {
                MessageBox.Show("Rol giriniz", "Giris Hatasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
