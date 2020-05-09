using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryFramework.Models;

namespace LibraryApp
{
    public partial class RegistrationForm : Form
    {
        Library Library { get; set; }
        public RegistrationForm(Library library)
        {
            Library = library;
            InitializeComponent();
            this.Text = "Registration";
            this.Hide();
        }

        private bool validateUserEntry()
        {
            if(name.Text.Length == 0)
            {
                string message = "You did not enter a name";
                string caption = "Error Detected in Input";
                MessageBox.Show(message, caption);
                return false;
            }

            if (Library.IsInList(login.Text))
            {
                string message = "This login is exist";
                string caption = "Error Detected in Input";
                MessageBox.Show(message, caption);
                return false;
            }
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
            if (!admin.Checked && !guest.Checked) {
                string message = "You did not select a role";
                string caption = "Error Detected in Input";
                MessageBox.Show(message, caption);
                return false;
            }
            return true;
        }

        private void registrate_Click(object sender, EventArgs e)
        {
            bool isAdmin = admin.Checked;
            if (validateUserEntry())
            {
                if (Library.Register(name.Text, login.Text, password.Text, isAdmin)) {
                    if (isAdmin)
                    {
                        this.Hide();
                        new MainAdminForm(Library, true).ShowDialog(this);
                    }
                    else
                    {
                        this.Hide();
                        new MainAdminForm(Library, false).ShowDialog(this);
                    }
                } else
                {
                    
                }
            }
        }

        private void back_to_authorizatione_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AuthorizationForm(Library).ShowDialog(this);
        }
    }
}
