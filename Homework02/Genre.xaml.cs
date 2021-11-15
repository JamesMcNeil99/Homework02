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
        public Genre()
        {
            InitializeComponent();
            addGenresToList();
        }
        public void addGenresToList()
        {
            cmbGenre.Text = "Choose movie genre";
            List<string> genres = new List<string>();
            genres.Add("ACTION");
            genres.Add("COMEDY");
            genres.Add("ROMANCE");
            genres.Add("DOCUMENTARY");
            cmbGenre.ItemsSource = genres;
        }
    }
}
