using Filmography.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmography.View
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private async void RegButton_Click(object sender, EventArgs e)
        {
            //TODO: добавить проверку по емаил и скрывать пароль при заполнении;
            if (await Reg.instance.CheckUser(LoginTextBox.Text) != null)
            {
                LoginTextBox.BackColor = Color.Red;
                MessageBox.Show("Пользователь с таким логином уже существует!");
                ClearField();
                return;
            }
            if (PasswordTextBox.Text != AgainPasTextBox.Text)
            {
                PasswordTextBox.BackColor = Color.Red;
                AgainPasTextBox.BackColor = Color.Red;
                MessageBox.Show("Пароли не совподают");
                ClearField();
                return;
            }
            await Reg.instance.AddUser(new User { Login = LoginTextBox.Text, Password = PasswordTextBox.Text, E_mail = EmailTextBox.Text, Role = "Пользователь" });
            this.DialogResult = DialogResult.OK;
        }

        private void ClearField()
        {
            LoginTextBox.Text = "";
            EmailTextBox.Text = "";
            PasswordTextBox.Text = "";
            AgainPasTextBox.Text = "";
        }

    }
}
