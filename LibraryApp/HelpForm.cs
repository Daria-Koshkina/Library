using LibraryApp.Properties;
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
    public partial class HelpForm : Form
    {
        public bool IsAdmin { private set; get; }
        public HelpForm(bool isAdmin)
        {
            IsAdmin = isAdmin;
            InitializeComponent();
            helpText.ScrollBars = ScrollBars.Vertical;
            if (IsAdmin)
            {
                helpText.Text = Resources.AdminHelp;
            }
            else helpText.Text = Resources.GuestHelp;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
