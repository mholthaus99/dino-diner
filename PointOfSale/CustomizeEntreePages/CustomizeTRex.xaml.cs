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
    /// Interaction logic for CustomizeTRex.xaml
    /// </summary>
    public partial class CustomizeTRex : Page
    {

        private TRexKingBurger _tRex;

        public CustomizeTRex()
        {
            InitializeComponent();
        }

        public CustomizeTRex(TRexKingBurger tRex)
        {
            this._tRex = tRex;
            InitializeComponent();
        }

        private void Click_HBun(object sender, RoutedEventArgs e)
        {
            _tRex.HoldBun();
        }

        private void Click_HLettuce(object sender, RoutedEventArgs e)
        {
            _tRex.HoldLettuce();
        }

        private void Click_HTomato(object sender, RoutedEventArgs e)
        {
            _tRex.HoldTomato();
        }

        private void Click_HOnion(object sender, RoutedEventArgs e)
        {
            _tRex.HoldOnion();
        }

        private void Click_HPickle(object sender, RoutedEventArgs e)
        {
            _tRex.HoldPickle();
        }

        private void Click_HMustard(object sender, RoutedEventArgs e)
        {
            _tRex.HoldMustard();
        }

        private void Click_HKetchup(object sender, RoutedEventArgs e)
        {
            _tRex.HoldKetchup();
        }

        private void Click_HMayo(object sender, RoutedEventArgs e)
        {
            _tRex.HoldMayo();
        }

        private void Click_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            NavigationService.GoBack();
        }
    }
}
