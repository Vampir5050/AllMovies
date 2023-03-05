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
    public partial class TranslationsForm : Form
    {
        List<Films> films;
        public TranslationsForm()
        {
            InitializeComponent();
        }
        private void ShowFilms(Films films)
        {
           
            FilmsComboBox.Items.Add(films.Name);

        }

        private async void AddTranslationsForm_Load(object sender, EventArgs e)
        {
            films = await AdminManager.instance.GetFilms();
            films.ForEach(ShowFilms);
        }

        private async void AddTranslationsButton_Click(object sender, EventArgs e)
        {
            if (FilmsComboBox.SelectedItem == null) return;
            if (string.IsNullOrWhiteSpace(TransleytTextBox.Text)) return;
            try
            {
                var check = await AdminManager.instance.CheckFilmsTrancleyt(FilmsComboBox.SelectedItem.ToString());
                if (check == null)
                {
                    MessageBox.Show("Не удалось добавить! Возможно уже существует перевод для этого фильма!");
                    TransleytTextBox.Text = "";
                    FilmsComboBox.SelectedItem = null;
                    return;
                }
                Translations translations = new Translations();
                translations.Transleyt = TransleytTextBox.Text;
                translations.Films_FK = check.id;
                await AdminManager.instance.AddTransleyt(translations);
                MessageBox.Show("Успешно добавлен перевод для фильма!");
                TransleytTextBox.Text = "";
                FilmsComboBox.SelectedItem = null;
            }
            catch { };
            
        }
        private async void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FilmsComboBox.SelectedItem == null) return;
                var films = await AdminManager.instance.RemoveTransleytFilms(FilmsComboBox.SelectedItem.ToString());
                if (films == false)
                {
                    MessageBox.Show("Удалить не получилось! Возможно для данного фильма отсутствует перевод!");
                    FilmsComboBox.SelectedItem = null;
                    return;
                }
                MessageBox.Show("Удаление прошло успешно!");
                FilmsComboBox.SelectedItem = null;
            }
            catch { };
            
        }
    }
    
}
