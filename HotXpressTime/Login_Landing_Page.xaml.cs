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
using System.IO;

namespace HotXpressTime
{
    /// <summary>
    /// Interaction logic for Login_Landing_Page.xaml
    /// </summary>
    public partial class Login_Landing_Page : Page
    {
        public Login_Landing_Page()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameBox.Text.ToString();
            string password = passwordBox.Password.ToString();
            bool valid = false;

            if (username != "" && password != "")
            {
                valid = Utilities.GetValidUserInfo(username, password);

                if (valid)
                {
                    MessageBox.Show($"Welcome back,{username}!", "Welcome Message");
                }
                else
                {
                    MessageBox.Show($"Could not find that user, Please try againg.", "No User Found");
                }
            }
            else if (username == "Employee")
            {

            }
            else
            {
                MessageBox.Show($"Please enter a valid username and password!", "Invalid Credentials");

            }
        }
    }
}
