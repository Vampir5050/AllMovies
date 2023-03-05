using Filmography.Model;
using Filmography.Controller;
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
    public partial class HumansForm : Form
    {
        public HumansForm()
        {
            InitializeComponent();
        }

        private async void AddHumansButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddFirstNameTextBox.Text)) return;
            if (string.IsNullOrWhiteSpace(AddLastNameTextBox.Text)) return;
            if (string.IsNullOrWhiteSpace(AddPlaceTextBox.Text)) return;
            if (string.IsNullOrWhiteSpace(AddAdressTextBox.Text)) return;
            if (GenderComboBox.SelectedItem == null) return;
            if (AddIncomeNumericUpDown.Value == 0) return;

            var human = await AdminManager.instance.AddHumans(new Humans
            {
                FirstName = AddFirstNameTextBox.Text,
                LastName = AddLastNameTextBox.Text,
                Gender = GenderComboBox.SelectedItem.ToString(),
                PlaceResidence = AddPlaceTextBox.Text,
                Address = AddAdressTextBox.Text,
                Income = AddIncomeNumericUpDown.Value
            });
            if(human==null)
            {
                MessageBox.Show("Не удалось добавить человека!");
                AddFirstNameTextBox.Text = "";
                AddLastNameTextBox.Text = "";
                AddPlaceTextBox.Text = "";
                AddAdressTextBox.Text = "";
                GenderComboBox.Text = "";
                AddIncomeNumericUpDown.Value = 0;
                return;
            }
            MessageBox.Show("Успешно!");
            AddFirstNameTextBox.Text = "";
            AddLastNameTextBox.Text = "";
            AddPlaceTextBox.Text = "";
            AddAdressTextBox.Text = "";
            GenderComboBox.Text = "";
            AddIncomeNumericUpDown.Value = 0;
        }
    }
}
