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
    /// Interaction logic for Delivery.xaml
    /// </summary>
    public partial class Delivery : Window
    {
        Model model;
        public Delivery(Model model)
        {
            InitializeComponent();
            this.model = model;
            btnTheatre.Click += BtnTheatre_Click;
        }

        private void BtnTheatre_Click(object sender, RoutedEventArgs e)
        {
            model.ConvenienceFee = 0;
            GoNext();
        }

        private void btnEmail_Click(object sender, RoutedEventArgs e)
        {
            model.ConvenienceFee = 5.00;
            GoNext();
        }

        private void GoNext()
        {
            CompletedOrder c = new CompletedOrder(model);
            c.Show();
            this.Close();
        }
    }
}
