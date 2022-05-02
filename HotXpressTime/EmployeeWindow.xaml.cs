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
using System.Windows.Shapes;

namespace HotXpressTime
{
    /// <summary>
    /// Interaction logic for EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        public EmployeeWindow()
        {
            InitializeComponent();
            SetWaitTime();
            GetCustomerOrders();
        }

        private void GetCustomerOrders()
        {
            List<Orders> orders = Utilities.GetCustomerOrders();
            if(orders != null)
            {
                SetItemListView(orders);
            }
        }
        private void SetItemListView(List<Orders> orders)
        {
            Orders.Items.Refresh();
            Orders.ItemsSource = orders;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Orders> orders = Utilities.GetCustomerOrders();

            orders.RemoveAt(0);

            Update.CompleteCustomerOrder(orders);
            SetItemListView(orders);
        }
        private void SetWaitTime()
        {
            List<Orders> orders = Utilities.GetCustomerOrders();
            int orderCount = orders.Count;
            if (orderCount > 0)
            {
                string time = Utilities.GetWaitTime(orderCount);
                if (time != null)
                {
                    UpdateWaitTimeBlock.Text = time + " minutes";
                    QueueBlock.Text = $"{orderCount} in queue";

                }
            }
        }
    }
}
