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
    /// Interaction logic for Sign_Up_Page.xaml
    /// </summary>
    /// 
    

    public partial class Sign_Up_Page : Page
    {
        

        public Sign_Up_Page()
        {
            
            //test
            InitializeComponent();
             
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password == "Password")
            {
                statusText.Text = "'Password' is not allowed as a password.";
            }
            else
            {
                statusText.Text = string.Empty;
            }
        }

        private void CreateProfileButton_Click(object sender, RoutedEventArgs e)
        {

            string username = UsernameBox.Text.ToString();
            string password = passwordBox.Password.ToString();
            string reEnterPass = passwordBox_ReEnter.Password.ToString();

            if (password != reEnterPass)
            {
                passwordBox.Clear();
                passwordBox_ReEnter.Clear();
                MessageBox.Show("Passwords must be the same.", "Re-Enter Passwords", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            bool valid = Utilities.IsCredentialsValid(username, password, reEnterPass);

            if (valid)
            {
                Update.CreateNewUser(username, password);
            }
            else
            {
                //Create a textbox to display a generic error for now
                //"Username or password was missing, or passwords did not match. Try again"
                //If we have time give a message based on what was actually missing
             }

            //Some sort of regristaion completed toast?
            //"Profile successfully completed!"


            //Nav back to home menu?
        }
    }
}
