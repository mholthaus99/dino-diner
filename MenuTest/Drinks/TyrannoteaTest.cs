using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        //1
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea s = new Tyrannotea();
            Assert.Equal(0.99, s.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea s = new Tyrannotea();
            Assert.Equal<uint>(8, s.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Tyrannotea s = new Tyrannotea();
            Assert.True(s.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea s = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, s.Size);
        }
        
        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Tyrannotea s = new Tyrannotea();
            Assert.False(s.Lemon);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSweet()
        {
            Tyrannotea s = new Tyrannotea();
            Assert.False(s.Sweet);
        }

        //3
        [Fact]
        public void InvokingHoldIceMakesIcePropertyFalse()
        {
            Tyrannotea s = new Tyrannotea();
            s.HoldIce();
            Assert.False(s.Ice);
        }

        //4
        [Fact]
        public void InvokingAddLemonMakesLemonPropertyTrue()
        {
            Tyrannotea s = new Tyrannotea();
            s.AddLemon();
            Assert.True(s.Lemon);
        }

        //5
        [Fact]
        public void SweetPropertyMakesCorrectCalories()
        {
            Tyrannotea s = new Tyrannotea
            {
                Sweet = true,
                Size = Size.Small
            };
            Assert.Equal<uint>(16, s.Calories);
            s.Size = Size.Medium;
            Assert.Equal<uint>(32, s.Calories);
            s.Size = Size.Large;
            Assert.Equal<uint>(64, s.Calories);

        }

            //6 
            [Fact]
            public void SweetPropertyFalseMakesCorrectCalories()
        {
            Tyrannotea s = new Tyrannotea
            {
                Sweet = true
            };
            s.Sweet = false;
            s.Size = Size.Small;
            Assert.Equal<uint>(8, s.Calories);
            s.Size = Size.Medium;
            Assert.Equal<uint>(16, s.Calories);
            s.Size = Size.Large;
            Assert.Equal<uint>(32, s.Calories);

        }
        //7
        [Fact]
        public void ShouldHaveCorrectDefaultIngedients()
        {
            Tyrannotea s = new Tyrannotea();
            Assert.Contains<string>("Water", s.Ingredients);
            Assert.Contains<string>("Tea", s.Ingredients);
            Assert.Equal<int>(2, s.Ingredients.Count);
        }

        [Fact]
        public void AddingLemonShouldAddLemonIngredient()
        {
            Tyrannotea s = new Tyrannotea();
            s.AddLemon();
            Assert.Contains<string>("Lemon", s.Ingredients);
        }

        [Fact]
        public void MakingSweetShouldAddCaneSugarIngredient()
        {
            Tyrannotea s = new Tyrannotea
            {
                Sweet = true
            };
            Assert.Contains<string>("Cane Sugar", s.Ingredients);
        }

        //2
        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Tyrannotea s = new Tyrannotea
            {
                Size = Size.Medium
            };
            Assert.Equal(1.49, s.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Tyrannotea s = new Tyrannotea
            {
                Size = Size.Medium
            };
            Assert.Equal<uint>(16, s.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Tyrannotea s = new Tyrannotea
            {
                Size = Size.Medium
            };
            Assert.Equal<Size>(Size.Medium, s.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Tyrannotea s = new Tyrannotea
            {
                Size = Size.Large
            };
            Assert.Equal(1.99, s.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Tyrannotea s = new Tyrannotea
            {
                Size = Size.Large
            };
            Assert.Equal<uint>(32, s.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Tyrannotea s = new Tyrannotea
            {
                Size = Size.Large
            };
            Assert.Equal<Size>(Size.Large, s.Size);
        }
    }
}
