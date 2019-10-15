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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
            HideAllButtons();
        }

        private void SodaClick(object sender, RoutedEventArgs e)
        {
            HideAllButtons();
            FlavorButton.Visibility = Visibility.Visible;
        }

        private void TeaClick(object sender, RoutedEventArgs e)
        {
            HideAllButtons();
            SweetButton.Visibility = Visibility.Visible;
            LemonButton.Visibility = Visibility.Visible;

        }

        private void JavaClick(object sender, RoutedEventArgs e)
        {
            HideAllButtons();
            DecafButton.Visibility = Visibility.Visible;
        }

        private void WaterClick(object sender, RoutedEventArgs e)
        {
            HideAllButtons();
            LemonButton.Visibility = Visibility.Visible;
        }

        private void HideAllButtons()
        {
            FlavorButton.Visibility = Visibility.Collapsed;
            SweetButton.Visibility = Visibility.Collapsed;
            LemonButton.Visibility = Visibility.Collapsed;
            DecafButton.Visibility = Visibility.Collapsed;
        }

        private void FlavorClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SodaFlavorSelection());
        }

    }
}
