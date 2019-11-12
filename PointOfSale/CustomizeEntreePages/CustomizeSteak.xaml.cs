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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeSteak.xaml
    /// </summary>
    public partial class CustomizeSteak : Page
    {
        private SteakosaurusBurger _steak;

        public CustomizeSteak()
        {
            InitializeComponent();
        }

        public CustomizeSteak(SteakosaurusBurger steak)
        {
            this._steak = steak;
            InitializeComponent();
        }

        private void Click_HPickle(object sender, RoutedEventArgs e)
        {
            _steak.HoldPickle();
        }

        private void Click_HBun(object sender, RoutedEventArgs e)
        {
            _steak.HoldBun();
        }

        private void Click_HKetchup(object sender, RoutedEventArgs e)
        {
            _steak.HoldKetchup();
        }

        private void Click_HMustard(object sender, RoutedEventArgs e)
        {
            _steak.HoldMustard();
        }

        private void Click_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            NavigationService.GoBack();
        }
    }
}
