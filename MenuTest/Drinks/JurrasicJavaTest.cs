﻿using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        //1
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava s = new JurrasicJava();
            Assert.Equal(0.59, s.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurrasicJava s = new JurrasicJava();
            Assert.Equal<uint>(2, s.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurrasicJava s = new JurrasicJava();
            Assert.False(s.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurrasicJava s = new JurrasicJava();
            Assert.Equal<Size>(Size.Small, s.Size);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSpaceForCream()
        {
            JurrasicJava s = new JurrasicJava();
            Assert.False(s.RoomForCream);
        }

       

        //3
        [Fact]
        public void InvokingAddICeResultsInIcePropertyBeingTrue()
        {
            JurrasicJava s = new JurrasicJava();
            s.AddIce();
            Assert.True(s.Ice);
        }

        //4
        [Fact]
        public void InvokingLeaveRoomForCreamnPropertyMakesTrue()
        {
            JurrasicJava s = new JurrasicJava();
            s.LeaveRoomForCream();
            Assert.True(s.RoomForCream);
        }

      
        //5
        [Fact]
        public void ShouldHaveCorrectDefaultIngedients()
        {
            JurrasicJava s = new JurrasicJava();
            Assert.Contains<string>("Water", s.Ingredients);
            Assert.Contains<string>("Coffee", s.Ingredients);
            Assert.Equal<int>(2, s.Ingredients.Count);
        }

      

        //2
        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            JurrasicJava s = new JurrasicJava
            {
                Size = Size.Medium
            };
            Assert.Equal(0.99, s.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            JurrasicJava s = new JurrasicJava
            {
                Size = Size.Medium
            };
            Assert.Equal<uint>(4, s.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            JurrasicJava s = new JurrasicJava
            {
                Size = Size.Medium
            };
            Assert.Equal<Size>(Size.Medium, s.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            JurrasicJava s = new JurrasicJava
            {
                Size = Size.Large
            };
            Assert.Equal(1.49, s.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            JurrasicJava s = new JurrasicJava
            {
                Size = Size.Large
            };
            Assert.Equal<uint>(8, s.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            JurrasicJava s = new JurrasicJava
            {
                Size = Size.Large
            };
            Assert.Equal<Size>(Size.Large, s.Size);
        }
    }
}

