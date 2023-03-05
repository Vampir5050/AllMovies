using Filmography.Controller;
using Filmography.Controller.Auth_and_Reg;
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

namespace Filmography.View.AdminView.AddView
{
    public partial class AddAdminForm : Form
    {
        public AddAdminForm()
        {
            InitializeComponent();
            LoginTextBox.KeyDown += ColorEvent;
            EmailTextBox.KeyDown += ColorEvent;
            PasswordTextBox.KeyDown += ColorEvent;
            AgainPasTextBox.KeyDown += ColorEvent;
        }
        private void ColorEvent(object sender, EventArgs e)
        {
            if (LoginTextBox.Focused) LoginTextBox.BackColor = Color.White;
            if (EmailTextBox.Focused) EmailTextBox.BackColor = Color.White;
            if (PasswordTextBox.Focused) PasswordTextBox.BackColor = Color.White;
            if (AgainPasTextBox.Focused) AgainPasTextBox.BackColor = Color.White;

        }

        private async void RegButton_Click(object sender, EventArgs e)
        {
            //проверки
            #region
            if (string.IsNullOrWhiteSpace(LoginTextBox.Text)) return;
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text)) return;
            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text)) return;
            if (string.IsNullOrWhiteSpace(AgainPasTextBox.Text)) return;

            if (await Reg.instance.CheckUser(LoginTextBox.Text) != null)
            {
                LoginTextBox.BackColor = Color.Red;
                MessageBox.Show("Пользователь с таким логином уже существует!");
                ClearField();
                return;
            }
            if (await Reg.instance.CheckEmail(EmailTextBox.Text) != null)
            {
                EmailTextBox.BackColor = Color.Red;
                MessageBox.Show("На данный е-маил уже зарегистрирован пользователь!");
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
            #endregion
            await AdminReg.instance.AddUser(new Users { Login = LoginTextBox.Text, Password = PasswordTextBox.Text, E_mail = EmailTextBox.Text, Role = "Администратор" });
            MessageBox.Show("Вы успешно зарегистрировали администратора");
            this.DialogResult = DialogResult.OK;
            
        }

        private void ClearField()
        {
            LoginTextBox.Text = "";
            EmailTextBox.Text = "";
            PasswordTextBox.Text = "";
            AgainPasTextBox.Text = "";
        }

        private void PasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordCheckBox.Checked) PasswordTextBox.UseSystemPasswordChar = true;
            else PasswordTextBox.UseSystemPasswordChar = false;
        }

        private void AgainPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AgainPasswordCheckBox.Checked) AgainPasTextBox.UseSystemPasswordChar = true;
            else AgainPasTextBox.UseSystemPasswordChar = false;
        }
    }
}
