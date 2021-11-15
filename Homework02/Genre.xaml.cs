using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Homework02
{
    /// <summary>
    /// Interaction logic for Genre.xaml
    /// </summary>
    public partial class Genre : Window
    {
        Model model;
        public Genre(Model model)
        {
            this.model = model;
            InitializeComponent();
            addGenresToList();
            btnOK.Click += BtnOK_Click;
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            if (cmbGenre.SelectedIndex > -1)
            {
                model.UserGenre = cmbGenre.SelectedItem.ToString();
                Rating r = new Rating(model);
                r.Show();
                this.Close();
            }
        }

        void addGenresToList()
        {
            cmbGenre.Text = "Select movie genre";
            cmbGenre.ItemsSource = model.Genres;
            
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
