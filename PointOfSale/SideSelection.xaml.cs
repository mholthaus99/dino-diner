﻿using System;
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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {

        private bool _forCombo;
        CretaceousCombo _combo;
           private Side side;
        /*
        public SideSelection()
        {
            InitializeComponent();

            foreach (UIElement elem in WrapPanel.Children)
            {
                Button btn = (Button)elem;
                btn.Click += this.SideItemSelected;
            }

            SizeStackPanel.Visibility = Visibility.Hidden;
        }
        */

        public SideSelection()
        {
            _forCombo = false;
            Init();
        }

        public SideSelection(CretaceousCombo combo)
        {
            _combo = combo;
            _forCombo = true;
            Init();
        }

        private void Init()
        {
            InitializeComponent();
            foreach (UIElement elem in WrapPanel.Children)
            {
                Button btn = (Button)elem;
                btn.Click += this.SideItemSelected;
            }

            SizeStackPanel.Visibility = Visibility.Hidden;
        }
     

        private void SideItemSelected(object sender, RoutedEventArgs e)
        {
           
                Button btn = (Button)sender;
                string itemName = btn.Content.ToString();

                switch (itemName)
                {
                    case "Fryceritops":
                        side = new Fryceritops();
                        break;
                    case "Meteor Mac & Cheese":
                        side = new MeteorMacAndCheese();
                        break;
                    case "Mozzerella Sticks":
                        side = new MezzorellaSticks();
                        break;
                    case "Triceritots":
                        side = new Triceritots();
                        break;
                 
                }

            if (side != null)
            {
                if (_forCombo)
                {
                    _combo.Side = side;
                } else
                {
                    SizeStackPanel.Visibility = Visibility.Visible;
                }
            }
           
        }

        private void SizeClicked(object sender, RoutedEventArgs e)
        {
            RadioButton btn = (RadioButton)sender;
            string sizeName = btn.Content.ToString();

            switch (sizeName)
            {
                case "Small":
                    side.Size = DinoDiner.Menu.Size.Small;
                    break;
                case "Medium":
                    side.Size = DinoDiner.Menu.Size.Medium;
                    break;
                case "Large":
                    side.Size = DinoDiner.Menu.Size.Large;
                    break;

            }

            if (DataContext is Order order)
            {
                order.Add(side as IOrderItem);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.GoBack();
            }
        }
    }
}
