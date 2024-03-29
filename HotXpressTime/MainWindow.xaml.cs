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
            DateTime start = DateTime.Parse(DateTime.Now.ToShortDateString() + " 11:00 AM");
            DateTime end = DateTime.Parse(DateTime.Now.ToShortDateString() + " 8:00 PM");
            //false    
            if (DateTime.Now > end || DateTime.Now < start)
            {
                Menu_Button.Visibility = Visibility.Collapsed;
                HotXpressTextBlock.Visibility = Visibility.Collapsed;
                ViewCartButton.Visibility = Visibility.Collapsed;
                LoginButton.Visibility = Visibility.Collapsed;
                SignUpButton.Visibility = Visibility.Collapsed;
                /*Hide the menu buttons*/
                BaconWrappedFigs.Visibility = Visibility.Collapsed;
                PPFT_Button1.Visibility = Visibility.Collapsed;
                Fig_Smoothie.Visibility = Visibility.Collapsed;
                Fig_Panacotta.Visibility = Visibility.Collapsed;
                FT_Button1.Visibility = Visibility.Collapsed;
                Bacon_Wrapped_Figs.Visibility = Visibility.Collapsed;
                Pulled_Pork_Fig_Tacos.Visibility = Visibility.Collapsed;
                Fig_Smoothie1.Visibility = Visibility.Collapsed;
                Fig_Panacotta1.Visibility = Visibility.Collapsed;
                Fig_Tart.Visibility = Visibility.Collapsed;
                //Continue Shopping Button
                ContinueShopping.Visibility = Visibility.Collapsed;
                //Checkout Button
                CheckoutButton.Visibility = Visibility.Collapsed;
                Checkout.Visibility = Visibility.Collapsed;
                //Wait time blocks
                WaitTimeBlock.Visibility = Visibility.Collapsed;
                UpdateWaitTimeBlock.Visibility = Visibility.Collapsed;
                QueueBlock.Visibility = Visibility.Collapsed;
                //Location 
                Current_Location_Button.Visibility = Visibility.Collapsed;
                UpdateLocationBlock.Visibility = Visibility.Collapsed;
                closed.Visibility = Visibility.Visible;
            }

            else
            {
                SetWaitTime();
                ViewCartButton.Visibility = Visibility.Visible;
                ViewCartButton.Visibility = Visibility.Collapsed;
                //LogInButton.Visibility = Visibility.Collapsed;
                SignUpButton.Visibility = Visibility.Collapsed;
                /*Hide the menu buttons*/
                BaconWrappedFigs.Visibility = Visibility.Collapsed;
                PPFT_Button1.Visibility = Visibility.Collapsed;
                Fig_Smoothie.Visibility = Visibility.Collapsed;
                Fig_Panacotta.Visibility = Visibility.Collapsed;
                FT_Button1.Visibility = Visibility.Collapsed;
                Bacon_Wrapped_Figs.Visibility = Visibility.Collapsed;
                Pulled_Pork_Fig_Tacos.Visibility = Visibility.Collapsed;
                Fig_Smoothie1.Visibility = Visibility.Collapsed;
                Fig_Panacotta1.Visibility = Visibility.Collapsed;
                Fig_Tart.Visibility = Visibility.Collapsed;
                //Continue Shopping Button
                ContinueShopping.Visibility = Visibility.Collapsed;
                //Checkout Button
                Checkout.Visibility = Visibility.Collapsed;

                closed.Visibility = Visibility.Collapsed;

                string location;

                DateTime dateValue = DateTime.Today;
                int newdatevalue = ((int)dateValue.DayOfWeek);
                if (newdatevalue == 1)
                {
                    location = "E Front st and Wellington";
                    UpdateLocationBlock.Text = location.ToString();
                }
                else if (newdatevalue == 2)
                {
                    location = "Station st and Railroad Ave";
                    UpdateLocationBlock.Text = location.ToString();
                }
                else if (newdatevalue == 3)
                {
                    location = "E State St and S Union St";
                    UpdateLocationBlock.Text = location.ToString();
                }
                else if (newdatevalue == 4)
                {
                    location = "West Beach Parking Lot";
                    UpdateLocationBlock.Text = location.ToString();
                }
                else if (newdatevalue == 5)
                {
                    location = "Dennos Museum Parking lot";
                    UpdateLocationBlock.Text = location.ToString();
                }
                else if (newdatevalue == 6)
                {
                    location = "Right Brain Brewery lot";
                    UpdateLocationBlock.Text = location.ToString();
                }
                else
                {
                    location = "Closed on Sundays";
                    UpdateLocationBlock.Text = location.ToString();
                }
            }
            
        }
        private void navToMenu(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.NavigationService.Navigate(new Uri("Menu_Page.xaml", UriKind.Relative));
            Menu_Button.Visibility = Visibility.Collapsed;
            HotXpressTextBlock.Visibility = Visibility.Collapsed;
            CheckoutButton.Visibility = Visibility.Visible;
            LoginButton.Visibility = Visibility.Visible;
            //LogInButton.Visibility = Visibility.Collapsed;
            SignUpButton.Visibility = Visibility.Collapsed;
            /*Show the menu buttons*/
            BaconWrappedFigs.Visibility = Visibility.Visible;
            PPFT_Button1.Visibility = Visibility.Visible;
            Fig_Smoothie.Visibility = Visibility.Visible;
            Fig_Panacotta.Visibility = Visibility.Visible;
            FT_Button1.Visibility = Visibility.Visible;
            Bacon_Wrapped_Figs.Visibility = Visibility.Visible;
            Pulled_Pork_Fig_Tacos.Visibility = Visibility.Visible;
            Fig_Smoothie1.Visibility = Visibility.Visible;
            Fig_Panacotta1.Visibility = Visibility.Visible;
            Fig_Tart.Visibility = Visibility.Visible;
            // Viewcart button
            ViewCartButton.Visibility = Visibility.Collapsed;
            //Continue Shopping Button
            ContinueShopping.Visibility = Visibility.Collapsed;
            //Checkout Button
            Checkout.Visibility = Visibility.Collapsed;
            closed.Visibility = Visibility.Collapsed;
        }

        private void Nav_ToCheckout(object sender, RoutedEventArgs e)
        {

            MainWindowFrame.NavigationService.Navigate(new Uri("Check_Out.xaml", UriKind.Relative));
            CheckoutButton.Visibility = Visibility.Collapsed;
            Menu_Button.Visibility = Visibility.Visible;
            LoginButton.Visibility = Visibility.Visible;
            HotXpressTextBlock.Visibility = Visibility.Collapsed;
            //LogInButton.Visibility = Visibility.Collapsed;
            SignUpButton.Visibility = Visibility.Collapsed;
            /*Hide the menu buttons*/
            BaconWrappedFigs.Visibility = Visibility.Collapsed;
            PPFT_Button1.Visibility = Visibility.Collapsed;
            Fig_Smoothie.Visibility = Visibility.Collapsed;
            Fig_Panacotta.Visibility = Visibility.Collapsed;
            FT_Button1.Visibility = Visibility.Collapsed;
            Bacon_Wrapped_Figs.Visibility = Visibility.Collapsed;
            Pulled_Pork_Fig_Tacos.Visibility = Visibility.Collapsed;
            Fig_Smoothie1.Visibility = Visibility.Collapsed;
            Fig_Panacotta1.Visibility = Visibility.Collapsed;
            Fig_Tart.Visibility = Visibility.Collapsed;
            //Continue Shopping Button
            ContinueShopping.Visibility = Visibility.Collapsed;
            //Checkout Button
            Checkout.Visibility = Visibility.Collapsed;
            closed.Visibility = Visibility.Collapsed;
        }

        private void Nav_ToLogin(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.NavigationService.Navigate(new Uri("Login_Landing_Page.xaml", UriKind.Relative));
            
            LoginButton.Visibility = Visibility.Collapsed;
            HotXpressTextBlock.Visibility = Visibility.Collapsed;
            //LogInButton.Visibility = Visibility.Visible;
            SignUpButton.Visibility = Visibility.Visible;
            /*Hide the menu buttons*/
            BaconWrappedFigs.Visibility = Visibility.Collapsed;
            PPFT_Button1.Visibility = Visibility.Collapsed;
            Fig_Smoothie.Visibility = Visibility.Collapsed;
            Fig_Panacotta.Visibility = Visibility.Collapsed;
            FT_Button1.Visibility = Visibility.Collapsed;
            Bacon_Wrapped_Figs.Visibility = Visibility.Collapsed;
            Pulled_Pork_Fig_Tacos.Visibility = Visibility.Collapsed;
            Fig_Smoothie1.Visibility = Visibility.Collapsed;
            Fig_Panacotta1.Visibility = Visibility.Collapsed;
            Fig_Tart.Visibility = Visibility.Collapsed;
            //Continue Shopping Button
            ContinueShopping.Visibility = Visibility.Collapsed;
            //Checkout Button
            Checkout.Visibility = Visibility.Collapsed;
            closed.Visibility = Visibility.Collapsed;

        }

        private void NavTo_Sign_Up_Page(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.NavigationService.Navigate(new Uri("Sign_Up_Page.xaml", UriKind.Relative));
            //LogInButton.Visibility = Visibility.Collapsed;
            SignUpButton.Visibility = Visibility.Collapsed;
            Menu_Button.Visibility = Visibility.Visible;
            /*Hide the menu buttons*/
            BaconWrappedFigs.Visibility = Visibility.Collapsed;
            PPFT_Button1.Visibility = Visibility.Collapsed;
            Fig_Smoothie.Visibility = Visibility.Collapsed;
            Fig_Panacotta.Visibility = Visibility.Collapsed;
            FT_Button1.Visibility = Visibility.Collapsed;
            Bacon_Wrapped_Figs.Visibility = Visibility.Collapsed;
            Pulled_Pork_Fig_Tacos.Visibility = Visibility.Collapsed;
            Fig_Smoothie1.Visibility = Visibility.Collapsed;
            Fig_Panacotta1.Visibility = Visibility.Collapsed;
            Fig_Tart.Visibility = Visibility.Collapsed;
            //Continue Shopping Button
            ContinueShopping.Visibility = Visibility.Collapsed;
            //Checkout Button
            Checkout.Visibility = Visibility.Collapsed;
            closed.Visibility = Visibility.Collapsed;
        }

        private void Change_Day(object sender, RoutedEventArgs e)
        {
            
            string location;
            DateTime dateValue = DateTime.Today;
            int newdatevalue = ((int)dateValue.DayOfWeek);


            if (Current_Location_Button.Content.ToString() == "Current Location:")
            {
                
                Current_Location_Button.Content = "Tomorrow Location:";
                if (newdatevalue == 0)
                {
                    location = "Station st and Railroad Ave";
                    UpdateLocationBlock.Text = location.ToString();
                }
                else if (newdatevalue == 1)
                {
                   

                    location = "E State St and S Union St";
                    UpdateLocationBlock.Text = location.ToString();
                }
                else if (newdatevalue == 2)
                {
                    

                    location = "West Beach Parking Lot";
                    UpdateLocationBlock.Text = location.ToString();
                }
                else if (newdatevalue == 3)
                {
                    


                    location = "Dennos Museum Parking lot";
                    UpdateLocationBlock.Text = location.ToString();
                }
                else if (newdatevalue == 4)
                {
                    

                    location = "Right Brain Brewery lot";
                    UpdateLocationBlock.Text = location.ToString();
                }
                else if (newdatevalue == 5)
                {
                    
                    location = "Closed on Sundays";
                    UpdateLocationBlock.Text = location.ToString();

                }
                else if (newdatevalue == 6)
                {
                    location = "E Front st and Wellington";
                    UpdateLocationBlock.Text = location.ToString();
                }
                else
                {
                    location = "E Front st and Wellington";
                    UpdateLocationBlock.Text = location.ToString();
                }

            }
            else if (Current_Location_Button.Content.ToString() == "Tomorrow Location:")
            {
                Current_Location_Button.Content = "Current Location:";
                if (newdatevalue == 1)
                {
                    location = "E Front st and Wellington";
                    UpdateLocationBlock.Text = location.ToString();
                }
                else if (newdatevalue == 2)
                {
                    location = "Station st and Railroad Ave";
                    UpdateLocationBlock.Text = location.ToString();
                }
                else if (newdatevalue == 3)
                {
                    location = "E State St and S Union St";
                    UpdateLocationBlock.Text = location.ToString();
                }
                else if (newdatevalue == 4)
                {
                    location = "West Beach Parking Lot";
                    UpdateLocationBlock.Text = location.ToString();
                }
                else if (newdatevalue == 5)
                {
                    location = "Dennos Museum Parking lot";
                    UpdateLocationBlock.Text = location.ToString();
                }
                else if (newdatevalue == 6)
                {
                    location = "Right Brain Brewery lot";
                    UpdateLocationBlock.Text = location.ToString();
                }
                else if (newdatevalue == 0)
                {
                    location = "Closed on Sundays";
                    UpdateLocationBlock.Text = location.ToString();
                }
                else
                {
                    location = $"{newdatevalue}";
                    UpdateLocationBlock.Text = location.ToString() ;
                }
            }
        }

        private void NavToBcnWrpFig(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.NavigationService.Navigate(new Uri("MenuItems/BaconWrappedFig.xaml", UriKind.Relative));
            /*Show Menu, Log in, Checkout Button*/
            Menu_Button.Visibility = Visibility.Visible;
            LoginButton.Visibility = Visibility.Visible;
            CheckoutButton.Visibility = Visibility.Visible;
            /*Hide the menu buttons*/
            BaconWrappedFigs.Visibility = Visibility.Collapsed;
            PPFT_Button1.Visibility = Visibility.Collapsed;
            Fig_Smoothie.Visibility = Visibility.Collapsed;
            Fig_Panacotta.Visibility = Visibility.Collapsed;
            FT_Button1.Visibility = Visibility.Collapsed;
            Bacon_Wrapped_Figs.Visibility = Visibility.Collapsed;
            Pulled_Pork_Fig_Tacos.Visibility = Visibility.Collapsed;
            Fig_Smoothie1.Visibility = Visibility.Collapsed;
            Fig_Panacotta1.Visibility = Visibility.Collapsed;
            Fig_Tart.Visibility = Visibility.Collapsed;
            // Cart button
            ViewCartButton.Visibility = Visibility.Visible;
            //Continue Shopping Button
            ContinueShopping.Visibility = Visibility.Collapsed;
            //Checkout Button
            Checkout.Visibility = Visibility.Collapsed;
            closed.Visibility = Visibility.Collapsed;

        }

        private void NavToPPFT(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.NavigationService.Navigate(new Uri("MenuItems/PulledPorkTacos.xaml", UriKind.Relative));
            /*Show Menu, Log in, Checkout Button*/
            Menu_Button.Visibility = Visibility.Visible;
            LoginButton.Visibility = Visibility.Visible;
            CheckoutButton.Visibility = Visibility.Visible;
            /*Hide the menu buttons*/
            BaconWrappedFigs.Visibility = Visibility.Collapsed;
            PPFT_Button1.Visibility = Visibility.Collapsed;
            Fig_Smoothie.Visibility = Visibility.Collapsed;
            Fig_Panacotta.Visibility = Visibility.Collapsed;
            FT_Button1.Visibility = Visibility.Collapsed;
            Bacon_Wrapped_Figs.Visibility = Visibility.Collapsed;
            Pulled_Pork_Fig_Tacos.Visibility = Visibility.Collapsed;
            Fig_Smoothie1.Visibility = Visibility.Collapsed;
            Fig_Panacotta1.Visibility = Visibility.Collapsed;
            Fig_Tart.Visibility = Visibility.Collapsed;
            // Cart button
            ViewCartButton.Visibility = Visibility.Visible;
            //Continue Shopping Button
            ContinueShopping.Visibility = Visibility.Collapsed;
            //Checkout Button
            Checkout.Visibility = Visibility.Collapsed;
            closed.Visibility = Visibility.Collapsed;
        }

        private void NavToFigSmooth(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.NavigationService.Navigate(new Uri("MenuItems/FigSmoothie.xaml", UriKind.Relative));
            /*Show Menu, Log in, Checkout Button*/
            Menu_Button.Visibility = Visibility.Visible;
            LoginButton.Visibility = Visibility.Visible;
            CheckoutButton.Visibility = Visibility.Visible;
            /*Hide the menu buttons*/
            BaconWrappedFigs.Visibility = Visibility.Collapsed;
            PPFT_Button1.Visibility = Visibility.Collapsed;
            Fig_Smoothie.Visibility = Visibility.Collapsed;
            Fig_Panacotta.Visibility = Visibility.Collapsed;
            FT_Button1.Visibility = Visibility.Collapsed;
            Bacon_Wrapped_Figs.Visibility = Visibility.Collapsed;
            Pulled_Pork_Fig_Tacos.Visibility = Visibility.Collapsed;
            Fig_Smoothie1.Visibility = Visibility.Collapsed;
            Fig_Panacotta1.Visibility = Visibility.Collapsed;
            Fig_Tart.Visibility = Visibility.Collapsed;
            // Cart button
            ViewCartButton.Visibility = Visibility.Visible;
            //Continue Shopping Button
            ContinueShopping.Visibility = Visibility.Collapsed;
            //Checkout Button
            Checkout.Visibility = Visibility.Collapsed;
            closed.Visibility = Visibility.Collapsed;
        }

        private void FigPannacotta(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.NavigationService.Navigate(new Uri("MenuItems/PannaCotta.xaml", UriKind.Relative));
            /*Show Menu, Log in, Checkout Button*/
            Menu_Button.Visibility = Visibility.Visible;
            LoginButton.Visibility = Visibility.Visible;
            CheckoutButton.Visibility = Visibility.Visible;
            /*Hide the menu buttons*/
            BaconWrappedFigs.Visibility = Visibility.Collapsed;
            PPFT_Button1.Visibility = Visibility.Collapsed;
            Fig_Smoothie.Visibility = Visibility.Collapsed;
            Fig_Panacotta.Visibility = Visibility.Collapsed;
            FT_Button1.Visibility = Visibility.Collapsed;
            Bacon_Wrapped_Figs.Visibility = Visibility.Collapsed;
            Pulled_Pork_Fig_Tacos.Visibility = Visibility.Collapsed;
            Fig_Smoothie1.Visibility = Visibility.Collapsed;
            Fig_Panacotta1.Visibility = Visibility.Collapsed;
            Fig_Tart.Visibility = Visibility.Collapsed;
            // Cart button
            ViewCartButton.Visibility = Visibility.Visible;
            //Continue Shopping Button
            ContinueShopping.Visibility = Visibility.Collapsed;
            //Checkout Button
            Checkout.Visibility = Visibility.Collapsed;
            closed.Visibility = Visibility.Collapsed;
        }

        private void NavToFigTart(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.NavigationService.Navigate(new Uri("MenuItems/FigTart.xaml", UriKind.Relative));
            /*Show Menu, Log in, Checkout Button*/
            Menu_Button.Visibility = Visibility.Visible;
            LoginButton.Visibility = Visibility.Visible;
            CheckoutButton.Visibility = Visibility.Visible;
            /*Hide the menu buttons*/
            BaconWrappedFigs.Visibility = Visibility.Collapsed;
            PPFT_Button1.Visibility = Visibility.Collapsed;
            Fig_Smoothie.Visibility = Visibility.Collapsed;
            Fig_Panacotta.Visibility = Visibility.Collapsed;
            FT_Button1.Visibility = Visibility.Collapsed;
            Bacon_Wrapped_Figs.Visibility = Visibility.Collapsed;
            Pulled_Pork_Fig_Tacos.Visibility = Visibility.Collapsed;
            Fig_Smoothie1.Visibility = Visibility.Collapsed;
            Fig_Panacotta1.Visibility = Visibility.Collapsed;
            Fig_Tart.Visibility = Visibility.Collapsed;
            // Cart button
            ViewCartButton.Visibility = Visibility.Visible;
            //Continue Shopping Button
            ContinueShopping.Visibility = Visibility.Collapsed;
            //Checkout Button
            Checkout.Visibility = Visibility.Collapsed;
            closed.Visibility = Visibility.Collapsed;
        }

        private void ViewCart(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.NavigationService.Navigate(new Uri("ShoppingCart.xaml", UriKind.Relative));
            /*Hide the menu buttons*/
            BaconWrappedFigs.Visibility = Visibility.Collapsed;
            PPFT_Button1.Visibility = Visibility.Collapsed;
            Fig_Smoothie.Visibility = Visibility.Collapsed;
            Fig_Panacotta.Visibility = Visibility.Collapsed;
            FT_Button1.Visibility = Visibility.Collapsed;
            Bacon_Wrapped_Figs.Visibility = Visibility.Collapsed;
            Pulled_Pork_Fig_Tacos.Visibility = Visibility.Collapsed;
            Fig_Smoothie1.Visibility = Visibility.Collapsed;
            Fig_Panacotta1.Visibility = Visibility.Collapsed;
            Fig_Tart.Visibility = Visibility.Collapsed;
            /*Show Menu, Log in, Checkout Button*/
            Menu_Button.Visibility = Visibility.Visible;
            LoginButton.Visibility = Visibility.Visible;
            CheckoutButton.Visibility = Visibility.Collapsed;// Cart button
            ViewCartButton.Visibility = Visibility.Collapsed;
            //Continue Shopping Button
            ContinueShopping.Visibility = Visibility.Visible;
            //Checkout Button
            Checkout.Visibility = Visibility.Visible;
            closed.Visibility = Visibility.Collapsed;

        }

        
        private void ContinueShopping_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.NavigationService.Navigate(new Uri("Menu_Page.xaml", UriKind.Relative));
            Menu_Button.Visibility = Visibility.Collapsed;
            HotXpressTextBlock.Visibility = Visibility.Collapsed;
            CheckoutButton.Visibility = Visibility.Visible;
            LoginButton.Visibility = Visibility.Visible;
            //LogInButton.Visibility = Visibility.Collapsed;
            SignUpButton.Visibility = Visibility.Collapsed;
            /*Show the menu buttons*/
            BaconWrappedFigs.Visibility = Visibility.Visible;
            PPFT_Button1.Visibility = Visibility.Visible;
            Fig_Smoothie.Visibility = Visibility.Visible;
            Fig_Panacotta.Visibility = Visibility.Visible;
            FT_Button1.Visibility = Visibility.Visible;
            Bacon_Wrapped_Figs.Visibility = Visibility.Visible;
            Pulled_Pork_Fig_Tacos.Visibility = Visibility.Visible;
            Fig_Smoothie1.Visibility = Visibility.Visible;
            Fig_Panacotta1.Visibility = Visibility.Visible;
            Fig_Tart.Visibility = Visibility.Visible;
            // Viewcart button
            ViewCartButton.Visibility = Visibility.Collapsed;
            //Continue Shopping Button
            ContinueShopping.Visibility = Visibility.Collapsed;
            //Checkout Button
            Checkout.Visibility = Visibility.Collapsed;
            closed.Visibility = Visibility.Collapsed;

        }

      private void Checkout_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.NavigationService.Navigate(new Uri("Check_Out.xaml", UriKind.Relative));
            CheckoutButton.Visibility = Visibility.Collapsed;
            Menu_Button.Visibility = Visibility.Visible;
            LoginButton.Visibility = Visibility.Visible;
            HotXpressTextBlock.Visibility = Visibility.Collapsed;
            //LogInButton.Visibility = Visibility.Collapsed;
            SignUpButton.Visibility = Visibility.Collapsed;
            /*Hide the menu buttons*/
            BaconWrappedFigs.Visibility = Visibility.Collapsed;
            PPFT_Button1.Visibility = Visibility.Collapsed;
            Fig_Smoothie.Visibility = Visibility.Collapsed;
            Fig_Panacotta.Visibility = Visibility.Collapsed;
            FT_Button1.Visibility = Visibility.Collapsed;
            Bacon_Wrapped_Figs.Visibility = Visibility.Collapsed;
            Pulled_Pork_Fig_Tacos.Visibility = Visibility.Collapsed;
            Fig_Smoothie1.Visibility = Visibility.Collapsed;
            Fig_Panacotta1.Visibility = Visibility.Collapsed;
            Fig_Tart.Visibility = Visibility.Collapsed;
            //Continue Shopping Button
            ContinueShopping.Visibility = Visibility.Collapsed;
            //Checkout Button
            Checkout.Visibility = Visibility.Collapsed;
            closed.Visibility = Visibility.Collapsed;
        }
        private void SetWaitTime()
        {
            List<Orders> orders = Utilities.GetCustomerOrders();
            int orderCount = orders.Count;
            if(orderCount > 0)
            {
                string time = Utilities.GetWaitTime(orderCount);
                if (time != null)
                {
                    UpdateWaitTimeBlock.Text = time + " minutes";
                    QueueBlock.Text =$"{orderCount} in queue";

                }
            }

        }
    }
}
