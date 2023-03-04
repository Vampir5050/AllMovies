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
        List<Genres> genreCol;
        List<Films> filmCol;
        List<Country> countryCol;
        List<Humans> humansCol;
        List<Workers> presidentCol; 
        public RequestsForm()
        {
            InitializeComponent();
            Request1comboBox.SelectedIndexChanged += new EventHandler(Requestions1Event);
            Req7tabPage.Parent = null;


            GenreComboBox.SelectedIndexChanged += new EventHandler(Requestions2Event);
            CountrycomboBox.SelectedIndexChanged += new EventHandler(Requestions2Event);

            Req3tabPage.Enter += new EventHandler(Req3tabPage_Enter);

            Req8tabPage.Enter += new EventHandler(Req8tabPage_Enter);


        }
        private void ShowGenre(Genres genreCol)
        {
            GenreComboBox.Items.Add(genreCol.Genre);
          
        }
        private void ShowFilms(Films filmCol)
        {   
                Req8FilmsComboBox.Items.Add(filmCol.Name);
        }
        private void ShowCountres(Country countryCol)
        {
            CountrycomboBox.Items.Add(countryCol.CountryManufacture);
        }
        private void ShowHumans(Humans humansCol)
        {
            string s = $"{humansCol.FirstName} - {humansCol.LastName}";
            Req9ActorComboBox.Items.Add(s);
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
                    if (item.Genres.Genre == GenreComboBox.SelectedItem.ToString() && item.Country.CountryManufacture == CountrycomboBox.SelectedItem.ToString())
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
        private void Req8tabPage_Enter(object sender, EventArgs e)
        {
            try
            {
                filmCol.ForEach(ShowFilms);

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
            listBox3.Items.Clear();
            try
            {
                var x = await RequestClass.instance.Request3(Req3YearComboBox.SelectedItem.ToString(), Riq3CountryComboBox.SelectedItem.ToString(),
                Req3MinNumericUpDown.Value, Req3MaxNumericUpDown.Value);
                foreach (var item in x)
                {
                    listBox3.Items.Add(item).ToString();
                }
            }
            catch { }
            
        }
        private async void SearchReq6button_Click(object sender, EventArgs e)
        {
            listBox6.Items.Clear();
            try
            {
                var items = await RequestClass.instance.Request6();
                var humans = items.GroupBy(x => x.Humans).Select(y => y.First());
                string s;
                foreach (var item in humans)
                {
                    s = $"{item.Humans.FirstName} - {item.Humans.LastName} - {item.Post} - {item.Humans.Gender} - {item.Humans.Address}";
                    listBox6.Items.Add(s);
                }
            }
            catch { }
            
        }
        private async void SearchReq7button_Click(object sender, EventArgs e)
        {
            listBox7.Items.Clear();
            try
            {
                var items = await RequestClass.instance.Request7();
                var humans = items.GroupBy(x => new { x.Post, x.Humans.FirstName, x.Humans.LastName }).Select(grp=>grp.First());
                string s;
                foreach (var item in humans.OrderBy(x=>x.Humans.FirstName))
                {
                    s = $"{item.Humans.FirstName} - {item.Humans.LastName} - {item.Post} - {item.Humans.Gender} - {item.Humans.Address} - {item.Humans.Income}$";
                    listBox7.Items.Add(s);
                }
            }
            catch { }
           
        }
        private async void SearchReq8button_Click(object sender, EventArgs e)
        {
            listBox8.Items.Clear();
            try
            {
                var humans = await RequestClass.instance.Request8(Req8FilmsComboBox.SelectedItem.ToString());
                string str = "";
                foreach (var item in humans)
                {
                    str = $"{item.Humans.FirstName} - {item.Humans.LastName} - {item.Humans.Gender} - {item.Post}";
                    listBox8.Items.Add(str);
                }
            }
            catch { };
           
        }
        private async void SearchReq9button_Click(object sender, EventArgs e)
        {
            listBox9.Items.Clear();
            string firstName = Req9ActorComboBox.SelectedItem.ToString();
            int pos = firstName.LastIndexOf('-');
            string lastName = firstName.Substring(pos+2);
            firstName = firstName.Substring(0, pos-1);
            var films = await RequestClass.instance.Request9(firstName, lastName, Req9YearComboBox.SelectedItem.ToString());
            foreach (var item in films)
            {
                listBox9.Items.Add(item.Films.Name);
            }

        }
        private async void SearchReq10button_Click(object sender, EventArgs e)
        {
            listBox10.Items.Clear();

            try
            {
                string firstName = Req10HumansComboBox.SelectedItem.ToString();
                int pos = firstName.LastIndexOf('-');
                string lastName = firstName.Substring(pos + 2);
                firstName = firstName.Substring(0, pos - 1);
                var items = await RequestClass.instance.Request10(firstName, lastName);
                var humans = items.GroupBy(x => new { x.Post, x.Humans.FirstName, x.Humans.LastName }).Select(grp => grp.First());
                string str;
                foreach (var item in humans)
                {
                    str = $"{item.Humans.FirstName} - {item.Humans.LastName} - {item.Post} - {item.Humans.Income}";
                    listBox10.Items.Add(str);
                }
            }
            catch { };
        }




        private async void RequestsForm_Load(object sender, EventArgs e)
        {
            genreCol = await RequestClass.instance.GetGenres();
            filmCol = await RequestClass.instance.GetFilms();
            countryCol = await RequestClass.instance.GetCountries();
            humansCol = await RequestClass.instance.GetHumans();
            presidentCol = await RequestClass.instance.GetPresident();
            countryCol.ForEach(ShowCountres);
            genreCol.ForEach(ShowGenre);
            humansCol.ForEach(ShowHumans);
            var films = (from x in filmCol
                         orderby x.YearRelease
                         select x.YearRelease).Distinct();
            foreach (var item in films)
            {
                Req9YearComboBox.Items.Add(item);

            }
            string s;
            foreach (var item in presidentCol)
            {
                s = $"{item.Humans.FirstName} - {item.Humans.LastName}";
                Req10HumansComboBox.Items.Add(s);
            }

        }

       
    }
}
