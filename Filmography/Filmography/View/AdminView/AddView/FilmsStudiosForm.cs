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
    
    public partial class FilmsStudiosForm : Form
    {
        List<FilmStudios> studiosCol;
        public FilmsStudiosForm()
        {
            InitializeComponent();
        }

        private void ShowFilmStudios(FilmStudios studiosCol)
        {
            StudiosComboBox.Items.Add(studiosCol.Name);
        }
        private async void UpdateStudios()
        {
            studiosCol.Clear();
            studiosCol = await AdminManager.instance.GetFilmStudios();
            StudiosComboBox.Items.Clear();
            studiosCol.ForEach(ShowFilmStudios);
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddNameTextBox.Text)) return;
            var studios = await AdminManager.instance.ChecStudios(AddNameTextBox.Text);
            if(studios!=null)
            {
                MessageBox.Show("Данная студия уже существует!");
                AddNameTextBox.Text = "";
                return;
            }
            await AdminManager.instance.AddFilmsStudios(new FilmStudios { Name = AddNameTextBox.Text, Workers_FK = null });
            MessageBox.Show("Успешно!");
            AddNameTextBox.Text = "";
            UpdateStudios();
        }

        private async void ChangeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ChangeNameTextBox.Text)) return;
            if (StudiosComboBox.SelectedItem == null) return;
            var check = await AdminManager.instance.ChangeFilmStudios(new FilmStudios { Name = StudiosComboBox.SelectedItem.ToString() }, ChangeNameTextBox.Text);
            if(check==null)
            {
                MessageBox.Show("Не удалось!");
                ChangeNameTextBox.Text = "";
                StudiosComboBox.SelectedItem = null; ;
                return;
            }
            MessageBox.Show("Успешно!");
            ChangeNameTextBox.Text = "";
            StudiosComboBox.SelectedItem = null; ;
            UpdateStudios();
        }

        private async void RemoveButton_Click(object sender, EventArgs e)
        {
            if (StudiosComboBox.SelectedItem == null) return;
            var check = await AdminManager.instance.RemoveFilmStudios(StudiosComboBox.SelectedItem.ToString());
            if(check==false)
            {
                MessageBox.Show("Невозможно удалить т.к. имеется президент! Удалите сначала президента в таблице сотрудников!");
                StudiosComboBox.SelectedItem = null; ;
                return;
            }
            MessageBox.Show("Удаление прошло успешно!");
            StudiosComboBox.SelectedItem = null; ;
            UpdateStudios();
            
        }

        private async void FilmsStudiosForm_Load(object sender, EventArgs e)
        {
            studiosCol = await AdminManager.instance.GetFilmStudios();
            studiosCol.ForEach(ShowFilmStudios);


        }
    }
}
