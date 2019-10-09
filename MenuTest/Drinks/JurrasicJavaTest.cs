using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        //1
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava s = new JurassicJava();
            Assert.Equal(0.59, s.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava s = new JurassicJava();
            Assert.Equal<uint>(2, s.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurassicJava s = new JurassicJava();
            Assert.False(s.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava s = new JurassicJava();
            Assert.Equal<Size>(Size.Small, s.Size);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSpaceForCream()
        {
            JurassicJava s = new JurassicJava();
            Assert.False(s.RoomForCream);
        }

       

        //3
        [Fact]
        public void InvokingAddICeResultsInIcePropertyBeingTrue()
        {
            JurassicJava s = new JurassicJava();
            s.AddIce();
            Assert.True(s.Ice);
        }

        //4
        [Fact]
        public void InvokingLeaveRoomForCreamnPropertyMakesTrue()
        {
            JurassicJava s = new JurassicJava();
            s.LeaveRoomForCream();
            Assert.True(s.RoomForCream);
        }

      
        //5
        [Fact]
        public void ShouldHaveCorrectDefaultIngedients()
        {
            JurassicJava s = new JurassicJava();
            Assert.Contains<string>("Water", s.Ingredients);
            Assert.Contains<string>("Coffee", s.Ingredients);
            Assert.Equal<int>(2, s.Ingredients.Count);
        }

      

        //2
        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            JurassicJava s = new JurassicJava
            {
                Size = Size.Medium
            };
            Assert.Equal(0.99, s.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            JurassicJava s = new JurassicJava
            {
                Size = Size.Medium
            };
            Assert.Equal<uint>(4, s.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            JurassicJava s = new JurassicJava
            {
                Size = Size.Medium
            };
            Assert.Equal<Size>(Size.Medium, s.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            JurassicJava s = new JurassicJava
            {
                Size = Size.Large
            };
            Assert.Equal(1.49, s.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            JurassicJava s = new JurassicJava
            {
                Size = Size.Large
            };
            Assert.Equal<uint>(8, s.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            JurassicJava s = new JurassicJava
            {
                Size = Size.Large
            };
            Assert.Equal<Size>(Size.Large, s.Size);
        }
    }
}

