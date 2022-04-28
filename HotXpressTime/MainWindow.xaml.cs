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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LogInButton.Visibility = Visibility.Collapsed;
            SignUpButton.Visibility = Visibility.Collapsed;
        }

        private void navToMenu(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.NavigationService.Navigate(new Uri("Menu_Page.xaml", UriKind.Relative));
            Menu_Button.Visibility = Visibility.Collapsed;
            HotXpressTextBlock.Visibility = Visibility.Collapsed;
            CheckoutButton.Visibility = Visibility.Visible;
            LoginButton.Visibility = Visibility.Visible;
            LogInButton.Visibility = Visibility.Collapsed;
            SignUpButton.Visibility = Visibility.Collapsed;
        }

        private void Nav_ToCheckout(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.NavigationService.Navigate(new Uri("Check_Out.xaml", UriKind.Relative));
            CheckoutButton.Visibility = Visibility.Collapsed;
            Menu_Button.Visibility = Visibility.Visible;
            LoginButton.Visibility = Visibility.Visible;
            HotXpressTextBlock.Visibility = Visibility.Collapsed;
            LogInButton.Visibility = Visibility.Collapsed;
            SignUpButton.Visibility = Visibility.Collapsed;
        }

        private void Nav_ToLogin(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.NavigationService.Navigate(new Uri("Login_Landing_Page.xaml", UriKind.Relative));
            LoginButton.Visibility = Visibility.Collapsed;
            HotXpressTextBlock.Visibility = Visibility.Collapsed;
            LogInButton.Visibility = Visibility.Visible;
            SignUpButton.Visibility = Visibility.Visible;

        }

        private void NavTo_Sign_Up_Page(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.NavigationService.Navigate(new Uri("Sign_Up_Page.xaml", UriKind.Relative));
            LogInButton.Visibility = Visibility.Collapsed;
            SignUpButton.Visibility = Visibility.Collapsed;
        }

      
    }
}
