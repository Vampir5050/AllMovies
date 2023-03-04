using Filmography.Controller;
using Filmography.Model;
using Filmography.View.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmography.View.UserView
{
    public partial class UserForm : Form
    {
        List<Films> myfilms;

        public UserForm()
        {
            InitializeComponent();
            SortGroupBox.Visible = false;
            MetodComboBox.SelectedIndex = 0;


            YearRadioButton.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            AbcRadioButton.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            PriceRadioButton.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            CountryRadioButton.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);

            MetodComboBox.SelectedIndexChanged += new EventHandler(MetodComboBox_SelectionChangeCommitted);
        }

        private void ShowFilms(Films films)
        {
            listBox1.Items.Add(films).ToString();
        }

        private async void UserForm_Load(object sender, EventArgs e)
        {
            myfilms = await UserManagement.instance.LoadFim();
            myfilms.ForEach(ShowFilms);
        }

        private void SortCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SortCheckBox.Checked) SortGroupBox.Visible = true;
            else SortGroupBox.Visible = false;
        }

    
        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            PushEvent();
        }
      
        private void MetodComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PushEvent();
        }

        private void PushEvent()
        {
            listBox1.Items.Clear();
            int index = 0;
            if (YearRadioButton.Checked) index = 1;
            else if (AbcRadioButton.Checked) index = 2;
            else if (PriceRadioButton.Checked) index = 3;
            else if (CountryRadioButton.Checked) index = 4;

            if (MetodComboBox.SelectedIndex == 0)
            {
                myfilms = UserManagement.instance.Sortdescending(myfilms, index);
            }
            else if (MetodComboBox.SelectedIndex == 1)
            {
                myfilms = UserManagement.instance.SortAscending(myfilms, index);
            }
            myfilms.ForEach(ShowFilms);
        }

        private void RequestsButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new RequestsForm().ShowDialog();
        }
    }
}
