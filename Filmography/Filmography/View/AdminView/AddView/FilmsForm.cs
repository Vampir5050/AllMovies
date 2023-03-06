using Filmography.Controller;
using Filmography.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmography.View.AdminView.AddView
{
    public partial class FilmsForm : Form
    {
        List<Country> countriesCol;
        List<Genres> genresCol;
        List<Films> filmsCol;
        public FilmsForm()
        {
            InitializeComponent();
        }

        private async void UpdateFilms()
        {
            filmsCol.Clear();
            ChangeFilmsComboBox.Items.Clear();
            RemoveFilmsComboBox.Items.Clear();
            filmsCol = await AdminManager.instance.GetFilms();
            filmsCol.ForEach(ShowFilms);
        }
        private void ShowFilms(Films films)
        {
            ChangeFilmsComboBox.Items.Add(films.Name);
            RemoveFilmsComboBox.Items.Add(films.Name);
        }
        private void ShowCountry(Country country)
        {
            CountryComboBox.Items.Add(country.CountryManufacture);
            ChangeCountryComboBox.Items.Add(country.CountryManufacture);

        }
        private void ShowGenres(Genres genres)
        {
            GenresComboBox.Items.Add(genres.Genre);
            ChangeGenreComboBox.Items.Add(genres.Genre);
        }

        private async void ChangeButton_Click(object sender, EventArgs e)
        {
            if (ChangeFilmsComboBox.SelectedItem == null) return;
            var film = await AdminManager.instance.ReturnFilms(ChangeFilmsComboBox.SelectedItem.ToString());
            if (string.IsNullOrWhiteSpace(ChangeNametextBox.Text) == false)
            {
                film.Name = ChangeNametextBox.Text;
                ChangeNametextBox.Text = "";
            }
            if (string.IsNullOrWhiteSpace(ChangeYearTextBox.Text) == false)
            {
                film.YearRelease = int.Parse(ChangeYearTextBox.Text);
                ChangeYearTextBox.Text = "";
            }
            if (ChangeGenreComboBox.SelectedItem != null)
            {
                film.Genres_FK = ChangeGenreComboBox.SelectedIndex + 1;
                ChangeGenreComboBox.SelectedItem = null;
            }
            if (ChangeCountryComboBox.SelectedItem != null)
            {
                film.Country_FK = ChangeCountryComboBox.SelectedIndex + 1;
                ChangeCountryComboBox.SelectedItem = null;
            }
            if (string.IsNullOrWhiteSpace(ChangeViewrsTextBox.Text) == false)
            {
                film.Viewers = int.Parse(ChangeViewrsTextBox.Text);
                ChangeViewrsTextBox.Text = "";
            }
            if (string.IsNullOrWhiteSpace(ChangeRatingTextBox.Text) == false)
            {
                film.Rating = double.Parse(ChangeRatingTextBox.Text);
                ChangeRatingTextBox.Text = "";
            }
            if (ChangeCostNumericUpDown.Value != 0)
            {
                film.Cost = ChangeCostNumericUpDown.Value;
                ChangeCostNumericUpDown.Value = 0;
            }
            listBox1.Items.Add(await AdminManager.instance.ChangeFilms(film)).ToString();
            UpdateFilms();
        }

        private async void AddFilmsForm_Load(object sender, EventArgs e)
        {
            countriesCol = await AdminManager.instance.GetCountry();
            genresCol = await AdminManager.instance.GetGenres();
            filmsCol = await AdminManager.instance.GetFilms();
            filmsCol.ForEach(ShowFilms);
            countriesCol.ForEach(ShowCountry);
            genresCol.ForEach(ShowGenres);
        }

        private async void RemoveButton_Click(object sender, EventArgs e)
        {
            if (RemoveFilmsComboBox.SelectedItem == null) return;
            var check = await AdminManager.instance.RemoveFilms(RemoveFilmsComboBox.SelectedItem.ToString());
            if(check==false)
            {
                MessageBox.Show("Не удалось удалить фильм!");
                RemoveFilmsComboBox.Text = "";
                return;
            }
            MessageBox.Show("Фильм успешно удален!");
            UpdateFilms();

        }

        private async void AddFilmsButton_Click_1(object sender, EventArgs e)
        {
            //TODO: добавить больше проверок.
            //проверки
            #region
            if (string.IsNullOrWhiteSpace(NameTextBox.Text)) return;
            if (string.IsNullOrWhiteSpace(YearTextBox.Text)) return;
            if (GenresComboBox.SelectedItem == null) return;
            if (CountryComboBox.SelectedItem == null) return;
            if (string.IsNullOrWhiteSpace(ViewirsTextBox.Text)) return;
            if (string.IsNullOrWhiteSpace(RatingTextBox.Text)) return;
            #endregion
            try
            {
                Films films = new Films();
                films.Name = NameTextBox.Text;
                films.YearRelease = int.Parse(YearTextBox.Text);
                films.Genres_FK = GenresComboBox.SelectedIndex + 1;
                films.Country_FK = CountryComboBox.SelectedIndex + 1;
                films.Viewers = int.Parse(ViewirsTextBox.Text);
                films.Rating = double.Parse(RatingTextBox.Text);
                films.Cost = CostNumericUpDown.Value;
                var check = await AdminManager.instance.AddFilms(films);
                if (check == null)
                {
                    MessageBox.Show("Не удалось добавить! Возможно уже существует данный фильм");
                    NameTextBox.Text = "";
                    YearTextBox.Text = "";
                    GenresComboBox.SelectedItem = null;
                    CountryComboBox.SelectedItem = null;
                    ViewirsTextBox.Text = "";
                    RatingTextBox.Text = "";
                    CostNumericUpDown.Value = 0;
                    return;

                }
                MessageBox.Show("Успешно добавлен новый фильм!");
                NameTextBox.Text = "";
                YearTextBox.Text = "";
                GenresComboBox.SelectedItem = null;
                CountryComboBox.SelectedItem = null;
                ViewirsTextBox.Text = "";
                RatingTextBox.Text = "";
                CostNumericUpDown.Value = 0;
                UpdateFilms();
            }
            catch { };

        }
    }
}
