﻿using LibraryFramework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class AuthorizationForm : Form
    {
        Library Library { get; set;}
        public AuthorizationForm(Library library)
        {
            Library = library;
            InitializeComponent();
            this.Text = "Authorization";
        }

        private void log_in_Click(object sender, EventArgs e)
        {
            if (validateUserEntry())
            {
                if (Library.Authorize(login.Text, password.Text))
                {
                    if(Library.CurrentUser is Admin)
                    {
                        this.Hide();
                        new MainAdminForm(Library, true).ShowDialog(this);
                    }
                    else
                    {
                        this.Hide();
                        new MainAdminForm(Library, false).ShowDialog(this);
                    }
                }
                else
                {
                    string message = "User was not found. Check password or register";
                    string caption = "Error Detected in Input";
                    MessageBox.Show(message, caption);
                }
            }
        }
        private bool validateUserEntry()
        {
            if (login.Text.Length == 0)
            {
                string message = "You did not enter a login";
                string caption = "Error Detected in Input";
                MessageBox.Show(message, caption);
                return false;
            }

            if (password.Text.Length == 0)
            {
                string message = "You did not enter a password";
                string caption = "Error Detected in Input";
                MessageBox.Show(message, caption);
                return false;
            }
            
            return true;
        }

        private void register_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new RegistrationForm(Library)).ShowDialog(this);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            string caption = "Application closing";
            string message = "Are you sure that you would like to close this application?";
            if(MessageBox.Show(message, caption, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
