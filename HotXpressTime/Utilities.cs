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
