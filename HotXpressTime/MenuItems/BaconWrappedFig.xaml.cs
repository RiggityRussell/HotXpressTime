using System;
using System.Collections.Generic;
using System.IO;
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

namespace HotXpressTime.MenuItems
{
    /// <summary>
    /// Interaction logic for BaconWrappedFig.xaml
    /// </summary>
    public partial class BaconWrappedFig : Page
    {
        public BaconWrappedFig()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result= MessageBox.Show("Would you like to add Bacon Wrapped Figs?", "Bacon FIGS", MessageBoxButton.YesNo);
            switch(result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("You have added 1 Order \nof Delicious Bacon \nWrapped Figs to your cart.");
                    string item = "Bacon Wrapped Figs";

                    Utilities.getMenuItem(item);
                    break;

                case MessageBoxResult.No:
                    MessageBox.Show("More for me then!");
                    break;
            }  
        }
      
    }
}
    

