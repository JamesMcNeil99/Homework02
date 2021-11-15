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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        Model model;
        public Menu(Model model)
        {
            this.model = model;
            InitializeComponent();
            btnCloseOrder.Click += BtnCloseOrder_Click;
        }

        private void BtnCloseOrder_Click(object sender, RoutedEventArgs e)
        {
            if (model.getTotalTickets() == 0)
            {
                NoTickets t = new NoTickets(model);
                t.Show();
                this.Close();
            }
            else
            {
                Delivery d = new Delivery(model);
                d.Show();
                this.Close();
            }
        }

        private void btnAddTicket_Click(object sender, RoutedEventArgs e)
        {
            PlaceOrder o = new PlaceOrder(model);
            o.Show();
            this.Close();
        }

        private void btnCheckOrder_Click(object sender, RoutedEventArgs e)
        {
            CheckOrder c = new CheckOrder(model);
            c.Show();
            this.Close();
        }
    }
}
