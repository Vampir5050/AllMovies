using Filmography.Model;
using Filmography.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Filmography
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            
        }

        private async void EnterButton_Click(object sender, EventArgs e)
        {
           await Reg.instance.Login(PasswordTextBox.Text, LoginTextBox.Text);
            PasswordTextBox.Text = "";
        }

        private void Registration_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            this.Visible = false;
            registration.ShowDialog();
            this.Visible = true;
            
        }
    }
}
