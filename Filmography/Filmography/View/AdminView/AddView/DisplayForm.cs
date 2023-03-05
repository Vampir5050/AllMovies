using Filmography.Controller;
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
    public partial class DisplayForm : Form
    {
        List<Films> filmsCol;
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void ShowFilms(Films films)
        {
            FilmsComboBox.Items.Add(films.Name);
        }

        private async void AddDisplayButton_Click(object sender, EventArgs e)
        {
            if (FilmsComboBox.SelectedItem == null) return;
            if (string.IsNullOrWhiteSpace(DisplayTextBox.Text)) return;
            try
            {
                var check = await AdminManager.instance.CheckFilmsDisplay(FilmsComboBox.SelectedItem.ToString());
                if (check == null)
                {
                    MessageBox.Show("Не удалось добавить! Возможно уже существуют страны показа для этого фильма");
                    DisplayTextBox.Text = "";
                    FilmsComboBox.SelectedItem = null;
                    return;
                }
                Display display = new Display();
                display.Showing = DisplayTextBox.Text;
                display.Films_FK = check.id;
                await AdminManager.instance.AddDisplay(display);
                MessageBox.Show("Успешно добавлены страны показа!");
                DisplayTextBox.Text = "";
                FilmsComboBox.SelectedItem = null;
            }
            catch { };
        }

        private async void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FilmsComboBox.SelectedItem == null) return;
                var films = await AdminManager.instance.RemoveDisplayFilms(FilmsComboBox.SelectedItem.ToString());
                if (films == false)
                {
                    MessageBox.Show("Удалить не получилось! Возможно для данного фильма отсутствуют страны показа!");
                    FilmsComboBox.SelectedItem = null;
                    return;
                }
                MessageBox.Show("Удаление прошло успешно!");
                FilmsComboBox.SelectedItem = null;
            }
            catch { };
        }

        private async void DisplayForm_Load(object sender, EventArgs e)
        {
            filmsCol = await AdminManager.instance.GetFilms();
            filmsCol.ForEach(ShowFilms);
        }
    }
}
