﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HotXpressTime
{
    /// <summary>
    /// Interaction logic for Menu_Page.xaml
    /// </summary>
    public partial class Menu_Page : Page
    {
        public Menu_Page()
        {
            InitializeComponent();
        }

        private void BWF_Nav(object sender, RoutedEventArgs e)
        {
            var window = new Window();
            window.Height = 1792;
            window.Width = 828;
            window.Show();
        }

        private void PPFT_Nav(object sender, RoutedEventArgs e)
        {
            var window = new Window();
            window.Height = 1792;
            window.Width = 828;
            window.Show();
        }

        private void FS_Nav(object sender, RoutedEventArgs e)
        {
            var window = new Window();
            window.Height = 1792;
            window.Width = 828;
            window.Show();
        }

        private void FP_Nav(object sender, RoutedEventArgs e)
        {
            var window = new Window();
            window.Height = 1792;
            window.Width = 828;
            window.Show();
        }

        private void FT_Nav(object sender, RoutedEventArgs e)
        {
            var window = new Window();
            window.Height = 1792;
            window.Width = 828;
            window.Show();
        }
    }
}
