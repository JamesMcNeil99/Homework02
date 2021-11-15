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
    /// Interaction logic for Rating.xaml
    /// </summary>
    public partial class Rating : Window
    {
        Model model;
        public Rating(Model model)
        {
            InitializeComponent();
            this.model = model;
            cmbRating.Text = "Choose movie rating.";
            cmbRating.ItemsSource = model.Ratings;
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if(cmbRating.SelectedIndex > -1)
            {
                model.UserRating = cmbRating.SelectedItem.ToString();
                
                Menu menu = new Menu(model);
                menu.Show();
                this.Close();
            }
        }
    }
}
