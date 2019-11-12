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
    /// Interaction logic for ComboCustomize.xaml
    /// </summary>
    public partial class ComboCustomize : Page
    {
        private CretaceousCombo _combo;
        public ComboCustomize(CretaceousCombo combo)
        {
            this._combo = combo;
          
        
             
            InitializeComponent();
        }
   
        private void Click_CEntree(object sender, RoutedEventArgs e)
        {
            if(_combo.Entree is Brontowurst)
            {
                NavigationService.Navigate(new CustomizeBronto(_combo.Entree as Brontowurst));
            }

            if (_combo.Entree is DinoNuggets nuggets)
            {
                NavigationService.Navigate(new CustomizeNugget(nuggets));
            }

            if (_combo.Entree is PrehistoricPBJ pbj)
            {
                NavigationService.Navigate(new CustomizePBJ(pbj));
            }

            if (_combo.Entree is SteakosaurusBurger steak)
            {
                NavigationService.Navigate(new CustomizeSteak(steak));
            }

            if (_combo.Entree is TRexKingBurger tRex)
            {
                NavigationService.Navigate(new CustomizeTRex(tRex));
            }

            if (_combo.Entree is VelociWrap veloci)
            {
                NavigationService.Navigate(new CustomizeVeloci(veloci));
            }
        }

        private void Click_CSide(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection(this._combo));
        }

        private void Click_CDrink(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection(this._combo));
        }
    }
}
