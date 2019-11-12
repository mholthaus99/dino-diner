using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{

    /// <summary>
    /// Order object
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Items
        /// </summary>
        //  public ObservableCollection<IMenuItem> OrderItems {get; protected set;} = new ObservableCollection<IMenuItem>();
        private List<IOrderItem> _orderItems = new List<IOrderItem>();

        public IOrderItem[] Items
        {
            get
            {
                return this._orderItems.ToArray();
            }
        }

        /// <summary>
        /// Idk honestly
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Creates new order instance
        /// </summary>
        public Order()
        {
           

        }

        private void Item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            NotifyPropertyChanged("Items");
            NotifyPropertyChanged("SubtotalCost");
            NotifyPropertyChanged("SalesTaxCost");
            NotifyPropertyChanged("TotalCost");
        }

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += Item_PropertyChanged;
            this._orderItems.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));

        }

   

        public void Remove(IOrderItem item)
        {
            if (_orderItems.Remove(item))
            {
                item.PropertyChanged -= Item_PropertyChanged;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
        }

        /// <summary>
        /// Subtotal cost
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subtotal = 0;
                foreach(IMenuItem item in Items)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            } 
        }

    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}
