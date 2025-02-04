﻿using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        //1
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water s = new Water();
            Assert.Equal(0.10, s.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water s = new Water();
            Assert.Equal<uint>(0, s.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Water s = new Water();
            Assert.True(s.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water s = new Water();
            Assert.Equal<Size>(Size.Small, s.Size);
        }

        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Water s = new Water();
            Assert.False(s.Lemon);
        }


        //3
        [Fact]
        public void InvokingHoldIceResultsPropertyInBeingFalse()
        {
            Water s = new Water();
            s.HoldIce();
            Assert.False(s.Ice);
            Assert.Contains<string>("Hold Ice", s.Special);
        }

        //4
        [Fact]
        public void InvokingAddLemonMakesLemonTrue()
        {
            Water s = new Water();
            s.AddLemon();
            Assert.True(s.Lemon);
        }

      

        //5
        [Fact]
        public void ShouldHaveCorrectDefaultIngedients()
        {
            Water s = new Water();
            Assert.Contains<string>("Water", s.Ingredients);
            Assert.Single(s.Ingredients);
        }



        //2
        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Water s = new Water
            {
                Size = Size.Medium
            };
            Assert.Equal(0.10, s.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Water s = new Water
            {
                Size = Size.Medium
            };
            Assert.Equal<uint>(0, s.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Water s = new Water
            {
                Size = Size.Medium
            };
            Assert.Equal<Size>(Size.Medium, s.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Water s = new Water
            {
                Size = Size.Large
            };
            Assert.Equal(0.10, s.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Water s = new Water
            {
                Size = Size.Large
            };
            Assert.Equal<uint>(0, s.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Water s = new Water
            {
                Size = Size.Large
            };
            Assert.Equal<Size>(Size.Large, s.Size);
        }
    }
}

