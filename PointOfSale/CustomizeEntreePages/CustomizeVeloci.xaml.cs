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
    /// Interaction logic for CustomizeVeloci.xaml
    /// </summary>
    public partial class CustomizeVeloci : Page
    {
        private VelociWrap _veloci;
        public CustomizeVeloci()
        {
            InitializeComponent();
        }

        public CustomizeVeloci(VelociWrap veloci)
        {
            this._veloci = veloci;
            InitializeComponent();
        }

        private void Click_HDressing(object sender, RoutedEventArgs e)
        {
            _veloci.HoldDressing();
        }

        private void Click_HLettuce(object sender, RoutedEventArgs e)
        {
            _veloci.HoldLettuce();
        }

        private void Click_HCheese(object sender, RoutedEventArgs e)
        {
            _veloci.HoldCheese();
        }

        private void Click_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            NavigationService.GoBack();
        }
    }
}
