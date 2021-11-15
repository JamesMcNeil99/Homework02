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
    /// Interaction logic for CompletedOrder.xaml
    /// </summary>
    public partial class CompletedOrder : Window
    {
        Model model;
        public CompletedOrder(Model model)
        {
            InitializeComponent();
            this.model = model;
            checkOrderValues();
        }
        private void checkOrderValues()
        {
            txtCurrentOrder.Text = $"Current Order: {model.UserGenre}({model.UserRating})";
            txtChildren.Text = $"Children (x{model.getTicketCount("Children")}): ${String.Format("{0:#,0.00}", model.getTicketCount("Children") * model.getTicketPrice("Children"))}";
            txtStudent.Text = $"Students (x{model.getTicketCount("Students")}): ${String.Format("{0:#,0.00}", model.getTicketCount("Students") * model.getTicketPrice("Students"))}";
            txtAdult.Text = $"Adults (x{model.getTicketCount("Adults")}): ${String.Format("{0:#,0.00}", model.getTicketCount("Adults") * model.getTicketPrice("Adults"))}";
            txtSenior.Text = $"Seniors (x{model.getTicketCount("Seniors")}): ${String.Format("{0:#,0.00}", model.getTicketCount("Seniors") * model.getTicketPrice("Seniors"))}";


            if (model.ConvenienceFee > 0)
                txtConvenience.Text = $"Convenience Fee: ${String.Format("{0:#,0.00}", model.ConvenienceFee)}";
            else
                txtConvenience.Visibility = Visibility.Hidden;
            txtPrice.Text = $"Price: ${String.Format("{0:#,0.00}", model.getTotalPrice())}";
            txtTax.Text = $"Tax: ${String.Format("{0:#,0.00}", model.getTotalPrice() * model.Tax)}";
            txtTotal.Text = $"Total: ${String.Format("{0:#,0.00}", model.getTotalPrice() + model.getTotalPrice() * model.Tax + model.ConvenienceFee)}";
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
