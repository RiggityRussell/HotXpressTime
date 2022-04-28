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
    public partial class Sign_Up_Page : Page
    {
        public Sign_Up_Page()
        {
            //test
            InitializeComponent();
        }

        private void CreateProfileButton_Click(object sender, RoutedEventArgs e)
        {

            string username = UsernameBox.Text.ToString();
            string password = PasswordBox.Text.ToString();
            string reEnterPass = PasswordBox_ReEnter.Text.ToString();

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
