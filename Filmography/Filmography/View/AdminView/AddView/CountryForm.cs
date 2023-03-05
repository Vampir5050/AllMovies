using Filmography.Controller;
using Filmography.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmography.View.AdminView.AddView
{
    public partial class CountryForm : Form
    {
        public CountryForm()
        {
            InitializeComponent();
        }

        private async void AddCountryButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CountryTextBox.Text)) return;
            var check = await AdminManager.instance.AddCountry(new Country { CountryManufacture = CountryTextBox.Text });
            if (check == null)
            {
                MessageBox.Show("Не удалось добавить! Возможно уже существует данная страна в базе!");
                CountryTextBox.Text = "";
                return;
            }
            MessageBox.Show("Успешно добавлена новая страна!");
            this.DialogResult = DialogResult.OK;
        }
    }
}
