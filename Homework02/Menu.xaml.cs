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
        PlaceOrder placeOrder; 
        CheckOrder checkOrder;
        public Menu(Model model)
        {
            this.model = model;
            placeOrder = new PlaceOrder(model, this);
            checkOrder = new CheckOrder(model, this);
            InitializeComponent();
            btnCloseOrder.Click += BtnCloseOrder_Click;
        }

        private void BtnCloseOrder_Click(object sender, RoutedEventArgs e)
        {
            if (model.getTotalTickets() == 0)
            {
                NoTickets t = new NoTickets(model, this);
                t.Show();
                this.Hide();
            }
            else
            {
                Delivery d = new Delivery(model);
                d.Show();
                this.Close();
                placeOrder.Close();
                checkOrder.Close();
            }
        }

        private void btnAddTicket_Click(object sender, RoutedEventArgs e)
        {
            
            placeOrder.Show();
            this.Hide();
        }

        private void btnCheckOrder_Click(object sender, RoutedEventArgs e)
        {
            checkOrder.Show();
            this.Hide();
        }
    }
}
