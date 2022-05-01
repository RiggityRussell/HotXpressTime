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
                menuItems.items = menuItem[0];
                menuItems.price = Convert.ToDouble(menuItem[1]);
                menuItems.quantity = 1;
                listMenuItems.Add(menuItems);
            }

            menuItems items = listMenuItems.Find(x => x.items == selectedItem);

            if (items != null)
            {
                updateCart(items);
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

                if(fileContents.Length >= 2)
                {
                    
                    foreach (string line in fileArray)
                    {
                        itemDescripton += line + ",";
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

        internal static void updateCart(menuItems items)
        {
            using (StreamWriter stream = new StreamWriter("Data/cart.txt", false))
            {
                string info = $"{items.items},{items.price},1,";
                stream.Write(info);
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

    }
}
