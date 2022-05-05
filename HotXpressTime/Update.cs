using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotXpressTime
{
    internal class Update
    {
        internal static void CreateNewUser(string username, string password)
        {
            using (StreamWriter stream = new StreamWriter("Users/Users.txt", false))
            {
                string info = $"2,{username},{password},,";
                stream.Write(info);
                stream.Close();
            }
            
        }

        internal static void CompleteCustomerOrder(List<Orders> orders)
        {
            using (StreamWriter stream = new StreamWriter("Data/orders.txt", false))
            {
                foreach (var item in orders)
                {
                    string info = $"{item.Customer},{item.Total},{item.MenuItem},";
                    stream.Write(info);

                }
                stream.Close();
            }

        }
        internal static void updateCart(List<menuItems> items)
        {
            using (StreamWriter stream = new StreamWriter("Data/cart.txt", false))
            {
                foreach (menuItems item in items)
                {
                    string info = $"{item.product}, {item.price}, {item.quantity},\n";
                    stream.Write(info);
                }
                stream.Close();
            }
        }
        internal static void updateOrders(List<Orders> items)
        {
            using (StreamWriter stream = new StreamWriter("Data/orders.txt", append: true))
            {
                foreach (var item in items)
                {
                    string info = $"{item.Customer}: , {item.Total}, x{item.Quantity},\n";
                    stream.Write(info);
                }
                stream.Close();
            }
        }
    }
}
