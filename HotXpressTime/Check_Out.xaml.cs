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
using System.Text.RegularExpressions;

namespace HotXpressTime
{
    /// <summary>
    /// Interaction logic for Check_Out.xaml
    /// </summary>
    public partial class Check_Out : Page
    {
        public Check_Out()
        {
            InitializeComponent();
        }

        private void saveInfo(object sender, RoutedEventArgs e)
        {
            bool nameIsValid = nameValidation(sender);
            bool cardIsValid = cardValidation(sender);
            bool expIsValid = expValidation(sender);
            bool cvvIsValid = cvvValidation(sender);

            if(!nameIsValid)
            { 
                MessageBox.Show($"Invalid Name Entry: {NameOnCard.Text}");
                NameOnCard.Clear();
            }
            if (!cardIsValid)
            {
                MessageBox.Show($"Invalid card entry: {cardNumber.Text}");
                cardNumber.Clear();
            }
            if (!expIsValid)
            {
                MessageBox.Show($"Invalid Expiration Date: {EXP.Text}");
                EXP.Clear();
            }
            if (!cvvIsValid)
            {
                MessageBox.Show($"Invalid CVV: {CVV.Text}");
                CVV.Clear();
            }
            

            if (nameIsValid && cardIsValid && expIsValid && cvvIsValid)
            {
                string custname = NameOnCard.Text;

                MessageBox.Show($"Thank you for submitting your order!");
                List<menuItems> menuItems = Utilities.GetCart();
                if(menuItems.Count > 0)
                {
                    List<Orders> order = Utilities.CreateCustomerOrder(menuItems, custname);
                    Update.updateOrders(order);
                }
                else
                {
                    //Probably don't have time to add this.
                    //Message to user their cart is empty.
                    //This check should really happen before seeing this page too.
                }

                this.Content = null;
            }
        }

        //Name Validation - Checks name for invalid characters, returns false message if invalid
        private bool nameValidation(object sender)
        {
            bool isValid = true;
           
            string specialChar = "0123456789@|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)                                               
            {

                if (NameOnCard.Text.Contains(item))                                       
                {
                    NameOnCard.Clear();
                    isValid = false;
                }
            }
            return isValid;
        }

        //Card Validation - Checks for 16-digits and verifies that there are only numbers.  
        private bool cardValidation(object sender)
        {
            bool isValid = true;
            if(!(cardNumber.Text.Length == 16))
            {
                cardNumber.Clear();
                isValid = false;
            }

            long parsedValue = 0;
            if (!long.TryParse(cardNumber.Text, out parsedValue))                             
            {

                isValid = false;
            }

            return isValid;
        }


        //Exp Validation - Checks for correct month and year number entry. 
        private bool expValidation(object sender)
        {
            bool isValid = true;

            //To check for expiration

            /*DateTime myDateTime = DateTime.Now;                                           
            string currentYear = myDateTime.Year.ToString();*/

            string[] date = EXP.Text.Split('/');
            string month = date[0];
            string year = date[1];

            /*if (year < currentYear)
            {
                isValid = false;
            }*/

            if (!(month.Length == 2 && year.Length == 4))
            {
                EXP.Clear();
                isValid = false;
            }

            int parsedValue = 0;
            if (!int.TryParse(month, out parsedValue) || !int.TryParse(year, out parsedValue))
            {
                EXP.Clear();
                isValid = false;
            }

            return isValid;
        }


        //CVV Validation - Checks that there's only 3 digits and no special characters
        private bool cvvValidation(object sender)
        {
            bool isValid = true;
            if (!(CVV.Text.Length == 3))
            {
                CVV.Clear();
                isValid = false;
            }

            int parsedValue = 0;
            if (!int.TryParse(CVV.Text, out parsedValue))
            {
                CVV.Clear();
                isValid = false;
            }
            return isValid;
        }
    }
 }