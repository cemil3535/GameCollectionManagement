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
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;

        public bool IsAuthenticaed { get; private set; }

        public User User {  get; private set; }



        public LoginForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Kullanici adi yada sifre gerekli");
            }

            var result = _userService.Login(txtUserName.Text.Trim(), txtPassword.Text.Trim());

            if (result.isAuthenticated)
            {

                User user = _userService.GetById(result.userId.Value);

                User = user;
                IsAuthenticaed = true;
                Close();

            }
            else
            {
                MessageBox.Show("Gecersiz kullanici adi veya sifre.");
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            AddUserForm form = new AddUserForm();
            form.ShowDialog();
            
        }
    }
}
