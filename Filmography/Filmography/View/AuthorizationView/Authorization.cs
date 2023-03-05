﻿using Filmography.Controller;
using Filmography.Model;
using Filmography.View;
using Filmography.View.UserView;
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
            LoginTextBox.KeyDown += ColorEvent;
            PasswordTextBox.KeyDown += ColorEvent;
        }

        public void ColorEvent(object sender, EventArgs e)
        {
            if (LoginTextBox.Focused) LoginTextBox.BackColor = Color.White;
            if (PasswordTextBox.Focused) PasswordTextBox.BackColor = Color.White;

        }

        private async void EnterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginTextBox.Text)) return;
            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text)) return;
            var check = await Auth.instance.Login(LoginTextBox.Text, PasswordTextBox.Text);
            if (check!=null)
            {
                if(check.Role=="Пользователь")
                {
                    this.Visible = false;
                    if (new UserForm().ShowDialog() == DialogResult.Cancel) Close();
                }
                if (check.Role == "Администратор")
                {
                    DialogResult dialogResult = MessageBox.Show("Открыть форму пользователя?", "Открытие формы", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.Visible = false;
                        if (new UserForm().ShowDialog() == DialogResult.Cancel) Close();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Visible = false;
                        if (new AdminForms().ShowDialog() == DialogResult.Cancel) Close();
                    }
                    
                }

            }
            else
            {
                if(await Auth.instance.CheckUser(LoginTextBox.Text)==null)
                {
                    MessageBox.Show("Пользователь не существует!");
                    LoginTextBox.BackColor = Color.Red;
                    Clear();
                    return;
                }
                MessageBox.Show("Неверный пароль!");
                PasswordTextBox.BackColor = Color.White;
                Clear();
                
            }
        }

        private void Clear()
        {
            LoginTextBox.Text = "";
            PasswordTextBox.Text = "";
        }

        private void Registration_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            this.Visible = false;
            registration.ShowDialog();
            this.Visible = true;
            
        }

        private void PasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordCheckBox.Checked) PasswordTextBox.UseSystemPasswordChar = true;
            else PasswordTextBox.UseSystemPasswordChar = false;
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login = Александр, Password = 12345");
        }
    }
}
