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

namespace HotXpressTime.MenuItems
{
    /// <summary>
    /// Interaction logic for FigTart.xaml
    /// </summary>
    public partial class FigTart : Page
    {
        public FigTart()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Would you like to add a Fig Tart?", "TART", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:

                    string item = "Fig Tart";
                    var orderTotal = Utilities.GetCart().Count();
                    if (orderTotal >= 10)
                    {
                        MessageBox.Show("Sorry, we only allow \n" +
                            "           10 orders per customer!");
                    }
                    else
                    {
                        Utilities.getMenuItem(item);
                        MessageBox.Show("You have added 1 Order \nof Fig Tart to your cart.");
                    }
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("More for me then!");
                    break;
            }

        }
    }
}
