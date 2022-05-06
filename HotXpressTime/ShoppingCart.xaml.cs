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
            if (menuItems.Count > 10)
            {
               // menuItems.Clear();
            }

            Orders.ItemsSource = Orders.ItemsSource = menuItems; //your query result 
            GridViewColumn column = new GridViewColumn();
            column.Header = "Product";
            column.DisplayMemberBinding = new Binding("product");
            GridViewControl.Columns.Add(column);

            GridViewColumn column2 = new GridViewColumn();
            column2.Header = "Price";
            column2.DisplayMemberBinding = new Binding("price");
            GridViewControl.Columns.Add(column2);

            GridViewColumn column3 = new GridViewColumn();
            column3.Header = "Quantity";
            column3.DisplayMemberBinding = new Binding("quantity");
            GridViewControl.Columns.Add(column3);




            //Orders.ItemsSource = menuItems;
        }
  
    }
}
