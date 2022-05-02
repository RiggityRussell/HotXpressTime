using System;
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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class ShoppingCart : Page
    {
        public ShoppingCart()
        {
            InitializeComponent();
            List<menuItems> menuItems = Utilities.GetCart();
            Orders.ItemsSource = menuItems;
        }

        private void ContinueShopping_Click(object sender, RoutedEventArgs e)
        {
            ContinueShopping.Content = new MainWindow();
        }

        private void Checkout_Click(object sender, RoutedEventArgs e)
        {
            Checkout.Content = new MainWindow();
        }

        private void Total_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Your Total is: ");
        }
    }
}
