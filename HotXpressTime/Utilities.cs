using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HotXpressTime
{
    class Utilities
    {
        internal static bool IsCredentialsValid(string username, string password, string reEnterPass)
        {
            bool isValid = true;

            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                isValid = false;
                MessageBox.Show("Username or Password missing", "Generic Error", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            if (string.IsNullOrEmpty(password)|| password != reEnterPass)
            {
                isValid = false;
                //passwordBox.Clear();
                //passwordBox_ReEnter.Clear();
                MessageBox.Show("Passwords must be the same.", "Re-Enter Passwords", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return isValid;
            
        }



        internal static bool GetValidUserInfo(string userName, string password)
        {
            List<(string userID, string userName, string password)> userCredentials = new List<(string userID, string userName, string password)>();
            bool isValid = false;

            userCredentials = GetUserInfoData();

            foreach ((string userID, string userName, string password) userLoginInfo in userCredentials)
            {
                if ((userLoginInfo.userName == userName) && (userLoginInfo.password == password))
                {
                    isValid = true;
                    break;

                }
            }

            return isValid;
        }

        internal static List<menuItems> GetCart()
        {
            string file = $"Data/cart.txt";
            string[] fileContents = File.ReadAllLines(file);
            List<menuItems> itemList = new List<menuItems>();
            string[] fileArray;
            foreach (var item in fileContents)
            {
                menuItems menuItem = new menuItems();
                string itemDescripton = "";

                fileArray = item.Split(',');
                menuItem.product = fileArray[0];
                menuItem.price = Convert.ToDouble(fileArray[1]);
                menuItem.quantity = Convert.ToInt32(fileArray[2]);
                /*if (fileArray.Length > 3)
                {

                    foreach (string line in fileArray.Skip(2))
                    {
                        itemDescripton += line + ",";
                    }
                    menuItem.MenuItem = itemDescripton;

                }
                else
                {
                    menuItem.MenuItem = fileArray[2];
                }*/

                itemList.Add(menuItem);
            }
            return itemList;
        }

        internal static List<Orders> CreateCustomerOrder(List<menuItems> menuItems, string customerName)
        {
            //returning a list of orders to allow for easier streamwriting
            List<Orders> order = new List<Orders>();
            Orders tempOrder = new Orders();

            foreach (var item in menuItems)
            {
                tempOrder.Customer = customerName;
                tempOrder.Total = item.price;
                tempOrder.MenuItem = item.product;
                tempOrder.Quantity = item.quantity;
                order.Add(tempOrder);
            }
            return order;
        }

        public static void getMenuItem(string selectedItem)
        {
            string file = $"Data/menuItems.txt";
            string[] menuItem;
            menuItem = File.ReadAllLines(file);
            List<menuItems> listMenuItems = new List<menuItems>();
            foreach (string line in menuItem)
            {
                menuItems menuItems = new menuItems();
                menuItem = line.Split(',');
                menuItems.product = menuItem[0];
                menuItems.price = Convert.ToDouble(menuItem[1]);
                menuItems.quantity = 1;
                listMenuItems.Add(menuItems);
            }

            //Get Item details from menu
            menuItems item = listMenuItems.Find(x => x.product == selectedItem);

            List<menuItems> updatedCart = CombineDuplicateItems(item);

            if (updatedCart != null)
            {
                updateCart(updatedCart);
            }
        }
        internal static List<Orders> GetCustomerOrders()
        {
            string file = $"Data/orders.txt";
            string[] fileContents = File.ReadAllLines(file);
            List<Orders> itemList = new List<Orders>();
            string[] fileArray;
            foreach (var item in fileContents)
            {
                Orders order = new Orders();
                string itemDescripton = "";

                fileArray = item.Split(',');
                order.Customer = fileArray[0];
                order.Total = Convert.ToDouble(fileArray[1]);

                if(fileArray.Length > 3)
                {
                    foreach (string line in fileArray.Skip(2))
                    {
                        itemDescripton += line + ", ";
                    }
                   order.MenuItem = itemDescripton;
                       
                }
                else
                {
                order.MenuItem = fileArray[2];
                }

                itemList.Add(order);
            }
            return itemList;
        }
        private static List<menuItems> CombineDuplicateItems(menuItems? item)
        {
            List<menuItems> currentCart =  GetCart();
            List<menuItems> updatedCart = new List<menuItems>();
            if (currentCart.Count != 0)
            {
                foreach (var cartItem in currentCart)
                {
                    menuItems product = new menuItems();

                    if (cartItem.product == item.product)
                    {
                        //Combine quantity and total of same products
                        product.product = item.product;
                        product.price = cartItem.price + item.price;
                        product.quantity = cartItem.quantity + 1;

                        updatedCart.Add(product);
                    }
                    else
                    {
                        //add existing cart items into updated cart
                        product.product = cartItem.product;
                        product.price = cartItem.price;
                        product.quantity = cartItem.quantity;

                        updatedCart.Add(product);
                    }
                }
            }
            else
            {
                updatedCart.Add(item);
            }

            return updatedCart;
        }
        internal static void updateCart(List<menuItems> items)
        {
            using (StreamWriter stream = new StreamWriter("Data/cart.txt", append: true))
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
                    string info = $"{item.Customer}: , ${item.Total}, x{item.Quantity},\n";
                    stream.Write(info);
                }
                stream.Close();
            }
        }

        private static List<(string userID, string userName, string password)> GetUserInfoData()
        {
            string file = $"Users/Users.txt";

            string credentials;
            string[] credentialArray;
            (string userID, string userName, string password) loginInfo;

            List<(string userID, string userName, string password)> registeredUsers = new List<(string userID, string userName, string password)>();

            credentialArray = File.ReadAllLines(file);

            foreach (var item in credentialArray)
            {
                credentialArray = item.Split(',');
                loginInfo.userID = credentialArray[0];
                loginInfo.userName = credentialArray[1];
                loginInfo.password = credentialArray[2];

                registeredUsers.Add(loginInfo);

            }

            return registeredUsers;
        }

        internal static string GetWaitTime(int orderCount)
        {
            string stringTime = "";
            int time;

            time = (orderCount * 10) + orderCount;
            return  stringTime = time.ToString();
        }
    }
}
