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
    public partial class WorkersForm : Form
    {
        List<Films> filmsCol;
        List<Humans> humansCol;
        List<FilmStudios> studios;
        public WorkersForm()
        {
            InitializeComponent();
        }
        private void ShowFilms(Films films)
        {
            FilmsComboBox.Items.Add(films.Name);
        }
        private void ShowHumans(Humans humans)
        {
            HumansComboBox.Items.Add($"{humans.FirstName} - {humans.LastName} - {humans.Gender} - {humans.PlaceResidence}");
        }
        private void ShowStudios(FilmStudios studios)
        {
            FilmsStudiosComboBox.Items.Add(studios.Name);
        }

        private async void WorkersForm_Load(object sender, EventArgs e)
        {
            filmsCol = await AdminManager.instance.GetFilms();
            humansCol = await AdminManager.instance.GetHumans();
            studios = await AdminManager.instance.GetFilmStudios();
            filmsCol.ForEach(ShowFilms);
            humansCol.ForEach(ShowHumans);
            studios.ForEach(ShowStudios);

        }

        private async void AddWorkersButton_Click_1(object sender, EventArgs e)
        {
            if (FilmsComboBox.SelectedItem == null) return;
            if (PostComboBox.SelectedItem == null) return;
            if (HumansComboBox.SelectedItem == null) return;
            var check = await AdminManager.instance.AddWorkers(FilmsComboBox.SelectedItem.ToString(), PostComboBox.SelectedItem.ToString(), HumansComboBox.SelectedIndex + 1);
            if (check == null)
            {
                MessageBox.Show("Не удалось добавить! Возможно уже существует такая запись!");
                FilmsComboBox.Text = "";
                PostComboBox.Text = "";
                HumansComboBox.Text = "";
                return;
            }
            MessageBox.Show("Удачно!");
            FilmsComboBox.SelectedItem = null;
            PostComboBox.SelectedItem = null;
            HumansComboBox.SelectedItem = null;
        }

        private async void RemoveButton_Click(object sender, EventArgs e)
        {
            if (FilmsComboBox.SelectedItem == null) return;
            if (PostComboBox.SelectedItem == null) return;
            if (HumansComboBox.SelectedItem == null) return;
            var check = await AdminManager.instance.RemoveWorkers(FilmsComboBox.SelectedItem.ToString(), PostComboBox.SelectedItem.ToString(), HumansComboBox.SelectedIndex + 1);
            if (check == false)
            {
                MessageBox.Show("Не удалось удалить! Возможно данной записи не существует");
                FilmsComboBox.Text = "";
                PostComboBox.Text = "";
                HumansComboBox.Text = "";
                return;
            }
            MessageBox.Show("Удачно!");
            FilmsComboBox.SelectedItem = null;
            PostComboBox.SelectedItem = null;
            HumansComboBox.SelectedItem = null;
        }

        private async void AddPrezidentButton_Click(object sender, EventArgs e)
        {
            if (HumansComboBox.SelectedItem == null) return;
            if (FilmsStudiosComboBox.SelectedItem == null) return;
            var check = await AdminManager.instance.AddPrezident(HumansComboBox.SelectedIndex + 1, FilmsStudiosComboBox.SelectedItem.ToString());
            if(check==null)
            {
                MessageBox.Show("Не удалось добавить!");
                HumansComboBox.SelectedItem = null;
                FilmsStudiosComboBox.SelectedItem = null;
            }
            MessageBox.Show("Успешно добавлен!");
            HumansComboBox.SelectedItem = null;
            FilmsStudiosComboBox.SelectedItem = null;


        }

        private async void RemotePrezidentButton_Click(object sender, EventArgs e)
        {
            if (HumansComboBox.SelectedItem == null) return;
            if (FilmsStudiosComboBox.SelectedItem == null) return;
            var check = await AdminManager.instance.RemovePrezident(HumansComboBox.SelectedIndex + 1, FilmsStudiosComboBox.SelectedItem.ToString());
            if (check == false)
            {
                MessageBox.Show("Не удалось удалить!");
                HumansComboBox.SelectedItem = null;
                FilmsStudiosComboBox.SelectedItem = null;
                return;
            }
            MessageBox.Show("Успешно удален!");
            HumansComboBox.SelectedItem = null;
            FilmsStudiosComboBox.SelectedItem = null;
        }
    }
}
