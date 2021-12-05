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
    /// Interaction logic for PlaceOrder.xaml
    /// </summary>
    public partial class PlaceOrder : Window
    {
        Model model;
        Menu menu;
        public PlaceOrder(Model model, Menu menu)
        {
            this.menu = menu;
            this.model = model;
            InitializeComponent();
            cmbTicket.Text = "Choose ticket type.";
            cmbTicket.ItemsSource = model.PriceList;
        }

        private void ReturnToMenu(object sender, RoutedEventArgs e)
        {
           
            menu.Show();
            this.Hide();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            if(cmbTicket.SelectedIndex > -1)
            {
                string selection = cmbTicket.SelectedItem.ToString().Split(",")[0];

                if(selection == "Children" && model.UserRating == "R"){
                    Underage u = new Underage(model, menu);
                    u.Show();
                    this.Hide();
                }
                else
                {
                    model.addTicket(selection);
                    menu.Show();
                    this.Hide();
                }
            }
        }
    }
}
