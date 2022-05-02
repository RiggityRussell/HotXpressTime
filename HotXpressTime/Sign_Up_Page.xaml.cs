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
            bool valid = true;
            if (password != reEnterPass)
            {
                passwordBox.Clear();
                passwordBox_ReEnter.Clear();
                MessageBox.Show("Passwords must be the same.", "Re-Enter Passwords", MessageBoxButton.OK, MessageBoxImage.Warning);
                valid = false;
            }
            else if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            { 
                //Create a textbox to display a generic error for now
                //"Username or password was missing, or passwords did not match. Try again"
                //If we have time give a message based on what was actually missing
                MessageBox.Show("Username or Password missing", "Generic Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                passwordBox.Clear();
                passwordBox_ReEnter.Clear();
                UsernameBox.Clear();
                valid = false;

            }
            if (valid)
            {
                Update.CreateNewUser(username, password);
                //Some sort of regristation completed toast?
                MessageBox.Show($"Welcome {username}!", "Welcome", MessageBoxButton.OK, MessageBoxImage.Warning  );
                //"Profile successfully completed!"
                passwordBox.Clear();
                passwordBox_ReEnter.Clear();
                UsernameBox.Clear();
            }

            //Nav back to home menu?

        }
    }
}
