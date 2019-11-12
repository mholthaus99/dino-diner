using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents a combo
    /// </summary>
    public class CretaceousCombo: IMenuItem, IOrderItem
    {
        /// <summary>
        /// Entree of the combo
        /// </summary>
        private Entree _entree;
        private Drink _drink;
        private Side _side;
        private Size _size;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// init with entree
        /// </summary>
        /// <param name="entree"></param>
        public CretaceousCombo(Entree entree)
        {
            entree.PropertyChanged += OnItemPropertyChanged;
            this.Entree = entree;

         
            Side = new Fryceritops();
            Drink = new Sodasaurus();


        }

        public Entree Entree
        {
            get;set;
        }

        public Drink Drink
        {
            get
            {
                return this._drink;
            }
            set
            {
                _drink = value;
                _drink.Size = this._size;
                _drink.PropertyChanged += OnItemPropertyChanged;
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Drink");
                NotifyOfPropertyChanged("Special");
            }
        }

        public Side Side
        {
            get
            {
                return this._side;
            }
            set
            {
                _side = value;
                _side.Size = this._size;
                _side.PropertyChanged += OnItemPropertyChanged;
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Side");
                NotifyOfPropertyChanged("Special");

            }
        }

        public Size Size
        {
            get
            {
                return this._size;
            }
            set
            {
                _size = value;
                _drink.Size = value;
                _side.Size = value;
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
            }
        }

  

        /// <summary>
        /// Combo price
        /// </summary>
        public double Price
        {
            get
            {
                Console.WriteLine(this.Entree?.Price + this.Drink?.Price + this.Side?.Price);
                return this.Entree.Price + this.Drink.Price + this.Side.Price;
                //return this.Entree.Price;
            }
        }

        /// <summary>
        /// Combo total calories
        /// </summary>
        public uint Calories
        {
            get
            {
                return this.Entree.Calories + this.Drink.Calories + this.Side.Calories;
            }
        }

        /// <summary>
        /// All ingredients in combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> allIngredients = new List<string>();
                allIngredients.AddRange(this.Entree.Ingredients);
                allIngredients.AddRange(this.Side.Ingredients);
                allIngredients.AddRange(this.Drink.Ingredients);
                return allIngredients;
            }
        }

        /// <summary>
        /// Add side to combo
        /// </summary>
        /// <param name="side"></param>
        public void AddSide(Side side)
        {
            this._side = side;
        }

        /// <summary>
        /// Add drink to side;
        /// </summary>
        /// <param name="drink"></param>
        public void AddDrink(Drink drink)
        {
            this._drink = drink;
        }

        /// <summary>
        /// Combo name as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Entree.ToString() + " " + "Combo";
        }   

        /// <summary>
        /// Special
        /// </summary>
        public string[] Special
        {
            get
            {
               List<string> special = new List<string>();
                
                //ENTREE INSTRUCTIONS
                foreach(string s in this.Entree.Special)
                {
                    Console.WriteLine(s);
                    special.Add(s);
                }

                //SIDE DESCRIPTION
                special.Add(this.Side.Description);

                //SIDE INSTRUCTIONS
                foreach (string s in this.Side.Special)
                {
                    Console.WriteLine(s);
                    special.Add(s);
                }

                //DRINK DESCRIPTION
                special.Add(this.Drink.Description);

                //DRINK INSTRUCTIONS
                foreach (string s in this.Drink.Special)
                {
                    Console.WriteLine(s);
                    special.Add(s);
                }

                return special.ToArray();
            }
        }

        /// <summary>
        /// Description of combo
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Description")
            {
                NotifyOfPropertyChanged("Special");
            }
            else
            {
                NotifyOfPropertyChanged(e.PropertyName);
            }
        }
    }
}
