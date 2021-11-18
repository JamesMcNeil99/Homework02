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
    /// Interaction logic for CheckOrder.xaml
    /// </summary>
    public partial class CheckOrder : Window
    {
        Model model;
        Menu menu;
        public CheckOrder(Model model, Menu menu)
        {
            this.menu = menu;
            this.model = model;
            InitializeComponent();
            checkOrderValues();
            this.IsVisibleChanged += CheckOrder_IsVisibleChanged;
        }

        private void CheckOrder_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            checkOrderValues();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {     
            menu.Show();
            this.Hide();
        }

        private void checkOrderValues()
        {
            txtCurrentOrder.Text = $"Current Order: {model.UserGenre}({model.UserRating})";
            txtChildren.Text = $"Children (x{model.getTicketCount("Children")}): ${String.Format("{0:#,0.00}", model.getTicketCount("Children") * model.getTicketPrice("Children"))}";
            txtStudent.Text = $"Students (x{model.getTicketCount("Students")}): ${String.Format("{0:#,0.00}", model.getTicketCount("Students") * model.getTicketPrice("Students"))}";
            txtAdult.Text = $"Adults (x{model.getTicketCount("Adults")}): ${String.Format("{0:#,0.00}", model.getTicketCount("Adults") * model.getTicketPrice("Adults"))}";
            txtSenior.Text = $"Seniors (x{model.getTicketCount("Seniors")}): ${String.Format("{0:#,0.00}", model.getTicketCount("Seniors") * model.getTicketPrice("Seniors"))}";

            txtPrice.Text = $"Price: ${String.Format("{0:#,0.00}", model.getTotalPrice())}";
            txtTax.Text = $"Tax: ${String.Format("{0:#,0.00}", model.getTotalPrice() * model.Tax)}";
            txtTotal.Text = $"Total: ${String.Format("{0:#,0.00}", model.getTotalPrice() + model.getTotalPrice() * model.Tax)}";
        }
    }
}
