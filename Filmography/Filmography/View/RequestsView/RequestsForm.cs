using Filmography.Controller;
using Filmography.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Filmography.View.Requests
{
    public partial class RequestsForm : Form
    {
        List<Genre> genreCol;
        List<Film> filmCol;
        List<Country> countryCol;
        public RequestsForm()
        {
            InitializeComponent();
            Request1comboBox.SelectedIndexChanged += new EventHandler(Requestions1Event);

            GenreComboBox.SelectedIndexChanged += new EventHandler(Requestions2Event);
            CountrycomboBox.SelectedIndexChanged += new EventHandler(Requestions2Event);

            Req3tabPage.Enter += new EventHandler(Req3tabPage_Enter);


        }
        private void ShowGenre(Genre genreCol)
        {
            GenreComboBox.Items.Add(genreCol.Genre1);
        }
        private void ShowFilms(Film filmCol)
        {
            FilmcomboBox.Items.Add(filmCol.Name);
        }
        private void ShowCountres(Country countryCol)
        {
            CountrycomboBox.Items.Add(countryCol.CountryManufacture);
        }


        private async void Requestions1Event(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var film = await RequestClass.instance.Request1(Request1comboBox.SelectedIndex);
            listBox1.Items.Add(film).ToString();

        }
        private void Requestions2Event(object sender, EventArgs e)
        {
            FilmcomboBox.SelectedItem = null;
            FilmcomboBox.Items.Clear();
            try
            {
                foreach (var item in filmCol)
                {
                    if (item.Genre.Genre1 == GenreComboBox.SelectedItem.ToString() && item.Country.CountryManufacture == CountrycomboBox.SelectedItem.ToString())
                    {
                        FilmcomboBox.Items.Add(item.Name);
                    }
                }
            }
            catch { }
        }
        private void Req3tabPage_Enter(object sender, EventArgs e)
        {
            try
            {
                
                var films = (from x in filmCol
                             orderby x.YearRelease
                             select x.YearRelease).Distinct();

                foreach (var item in films)
                {
                    Req3YearComboBox.Items.Add(item);
                }
                foreach (var item in countryCol)
                {
                    Riq3CountryComboBox.Items.Add(item.CountryManufacture);
                }

            }
            catch { }
            

        }





        private async void SearchReq2button_Click(object sender, EventArgs e)
        {
            try
            {
                var f = await RequestClass.instance.Request2(GenreComboBox.SelectedItem.ToString(), FilmcomboBox.SelectedItem.ToString(), CountrycomboBox.SelectedItem.ToString());
                foreach (var item in f)
                {
                    listBox2.Items.Add(item).ToString();
                }
                FilmcomboBox.SelectedItem = null;
                FilmcomboBox.Items.Clear();
                CountrycomboBox.SelectedItem = null;

            }
            catch { };

        }
        private async void SearchReq3button_Click(object sender, EventArgs e)
        {
            var x = await RequestClass.instance.Request3(Req3YearComboBox.SelectedItem.ToString(), Riq3CountryComboBox.SelectedItem.ToString(),
                Req3MinNumericUpDown.Value, Req3MaxNumericUpDown.Value);
            foreach (var item in x)
            {
                listBox3.Items.Add(item).ToString();
            }
        }




        private async void RequestsForm_Load(object sender, EventArgs e)
        {
            genreCol = await RequestClass.instance.GetGenres();
            filmCol = await RequestClass.instance.GetFilms();
            countryCol = await RequestClass.instance.GetCountries();
            countryCol.ForEach(ShowCountres);
            genreCol.ForEach(ShowGenre);

        }

    }
}
