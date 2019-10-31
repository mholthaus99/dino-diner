using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class SodaSaurusTest
    {
       
        //1
        [Fact]
        public void CanBeEachPossibleFlavor()
        {
            Sodasaurus s = new Sodasaurus();
            for(int i = 0; i < 7; i++)
            {
                s.Flavor = (SodasaurusFlavor)i;
                Assert.Equal(i, (int) s.Flavor);
            }
        }

        //2
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Equal(1.50, s.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Equal<uint>(112, s.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.True(s.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, s.Size);
        }

        //4
        [Fact]
        public void InvokingHoldIceMakesIcePropertyFalse()
        {
            Sodasaurus s = new Sodasaurus();
            s.HoldIce();
            Assert.False(s.Ice);
            Assert.Contains<string>("Hold Ice", s.Special);
        }
        //5
        [Fact]
        public void ShouldHaveCorrectDefaultIngedients()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Contains<string>("Water", s.Ingredients);
            Assert.Contains<string>("Natural Flavors", s.Ingredients);
            Assert.Contains<string>("Cane Sugar", s.Ingredients);
            Assert.Equal<int>(3, s.Ingredients.Count);
        }

    

        //3
        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Sodasaurus s = new Sodasaurus
            {
                Size = Size.Medium
            };
            Assert.Equal(2.00, s.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Sodasaurus s = new Sodasaurus
            {
                Size = Size.Medium
            };
            Assert.Equal<uint>(156, s.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Sodasaurus s = new Sodasaurus
            {
                Size = Size.Medium
            };
            Assert.Equal<Size>(Size.Medium, s.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Sodasaurus s = new Sodasaurus
            {
                Size = Size.Large
            };
            Assert.Equal(2.50, s.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Sodasaurus s = new Sodasaurus
            {
                Size = Size.Large
            };
            Assert.Equal<uint>(208, s.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Sodasaurus s = new Sodasaurus
            {
                Size = Size.Large
            };
            Assert.Equal<Size>(Size.Large, s.Size);
        }
    }
}
