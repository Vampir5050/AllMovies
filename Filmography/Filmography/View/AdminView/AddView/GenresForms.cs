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
    public partial class GenresForms : Form
    {
        public GenresForms()
        {
            InitializeComponent();
        }

        private async void AddGenresButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(GanresTextBox.Text)) return;;
            var check = await AdminManager.instance.AddGanres(new Genres { Genre = GanresTextBox.Text});
            if(check == null)
            {
                MessageBox.Show("Не удалось добавить! Возможно уже существует данный жанр в базе!");
                GanresTextBox.Text = "";
                return;
            }
            MessageBox.Show("Успешно добавлен новый жанр!");
            this.DialogResult = DialogResult.OK;
        }
    }
}
