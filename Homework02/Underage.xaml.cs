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
    /// Interaction logic for Underage.xaml
    /// </summary>
    public partial class Underage : Window
    {
        Model model;
        Menu menu;
        public Underage(Model model, Menu menu)
        {
            this.menu = menu;
            this.model = model;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            
            menu.Show();
            this.Close();
        }
    }
}
