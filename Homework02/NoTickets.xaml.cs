﻿using System;
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
    /// Interaction logic for NoTickets.xaml
    /// </summary>
    public partial class NoTickets : Window
    {
        Model model;
        Menu menu;
        public NoTickets(Model model, Menu menu)
        {
            this.menu = menu;
            this.model = model;
            InitializeComponent();
            btnCancel.Click += BtnCancel_Click;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            
            menu.Show();
            this.Close();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
