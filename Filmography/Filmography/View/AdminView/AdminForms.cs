using Filmography.View.AdminView.AddView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmography
{
    public partial class AdminForms : Form
    {
        public AdminForms()
        {
            InitializeComponent();
            AddWorkersButton.Visible = false;
            AddFilmsStudiosButton.Visible = false;
        }

        private void AddGanresButton_Click(object sender, EventArgs e)
        {
            new GenresForms().ShowDialog();
        }

        private void AddCountryButton_Click(object sender, EventArgs e)
        {
            new CountryForm().ShowDialog();
        }

        private void AddFilmsButton_Click(object sender, EventArgs e)
        {
            new FilmsForm().ShowDialog();
        }

        private void AddTranslationsButton_Click(object sender, EventArgs e)
        {
            new TranslationsForm().ShowDialog();
        }

        private void AddDisplayButton_Click(object sender, EventArgs e)
        {
            new DisplayForm().ShowDialog();
        }

        private void AddFilmsStudiosButton_Click(object sender, EventArgs e)
        {

        }

        private void AddHumansButton_Click(object sender, EventArgs e)
        {
            new HumansForm().ShowDialog();
        }

        private void AddWorkersButton_Click(object sender, EventArgs e)
        {

        }

        private void AddAdminButton_Click(object sender, EventArgs e)
        {
            new AddAdminForm().ShowDialog();
        }
    }
}
