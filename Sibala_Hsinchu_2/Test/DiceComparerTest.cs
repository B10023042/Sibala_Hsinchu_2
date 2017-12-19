using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Sibala_Hsinchu_2
{
    [TestClass]
    public class DiceComparerTest
    {
        [TestMethod]
        public void NormalPoint_greater_than_NoPoint()
        {
            var dice1 = new Sibara(1, 1, 4, 5);
            var dice2 = new Sibara(2, 5, 6, 1);
            FirstDiceShouldGreaterThanSecond(dice1, dice2);
        }

        [TestMethod]
        public void SameColor_greater_than_NoPoint()
        {
            var dice1 = new Sibara(4, 4, 4, 4);
            var dice2 = new Sibara(2, 2, 2, 1);
            FirstDiceShouldGreaterThanSecond(dice1, dice2);
        }

        [TestMethod]
        public void NormalPoint_less_than_SameColor()
        {
            var dice1 = new Sibara(5, 5, 2, 5);
            var dice2 = new Sibara(4, 4, 4, 4);
            FirstDiceShouldLessThanSecond(dice1, dice2);
        }

        [TestMethod]
        public void SameColor4_less_than_SameColor2()
        {
            var dice1 = new Sibara(4, 4, 4, 4);
            var dice2 = new Sibara(2, 2, 2, 2);
            FirstDiceShouldLessThanSecond(dice1, dice2);
        }

        [TestMethod]
        public void SameColor2_Equal_SameColor2()
        {
            var dice1 = new Sibara(2, 2, 2, 2);
            var dice2 = new Sibara(2, 2, 2, 2);
            FirstDiceShouldEqualThanSecond(dice1, dice2);
        }

        [TestMethod]
        public void NormalPoint_6146_Less_than_NormalPoint_4255()
        {
            var dice1 = new Sibara(6,1,4,6);
            var dice2 = new Sibara(4,2,5,5);
            FirstDiceShouldEqualThanSecond(dice1, dice2);
        }

        [TestMethod]
        public void NormalPoint_6446_greater_than_NormalPoint_6642()
        {
            var dice1 = new Sibara(6, 4, 4, 6);
            var dice2 = new Sibara(6, 6, 4, 2);
            FirstDiceShouldGreaterThanSecond(dice1, dice2);
        }

        [TestMethod]
        public void NormalPoint_6446_greater_than_NormalPoint_1144()
        {
            var dice1 = new Sibara(6, 4, 4, 6);
            var dice2 = new Sibara(1,1,4,4);
            FirstDiceShouldEqualThanSecond(dice1, dice2);
        }
        [TestMethod]
        public void NoPoint_1236_greater_than_NoPoint_2345()
        {
            var dice1 = new Sibara(1,2,3,6);
            var dice2 = new Sibara(2,3,4,5);
            FirstDiceShouldEqualThanSecond(dice1, dice2);
        }
        [TestMethod]
        public void NoPoint_2221_less_than_NoPoint_2345()
        {
            var dice1 = new Sibara(2,2,2,1);
            var dice2 = new Sibara(2, 3, 4, 5);
            FirstDiceShouldEqualThanSecond(dice1, dice2);
        }
        [TestMethod]
        public void NoPoint_2221_less_than_NoPoint_6661()
        {
            var dice1 = new Sibara(2, 2, 2, 1);
            var dice2 = new Sibara(26,6,6, 1);
            FirstDiceShouldEqualThanSecond(dice1, dice2);
        }

        private static void FirstDiceShouldEqualThanSecond(Sibara dice1, Sibara dice2)
        {
            new DiceComparer().Compare(dice1, dice2).Should().Equals(0);
        }

        private static void FirstDiceShouldLessThanSecond(Sibara dice1, Sibara dice2)
        {
            new DiceComparer().Compare(dice1, dice2).Should().BeLessThan(0);
        }

        private static void FirstDiceShouldGreaterThanSecond(Sibara dice1, Sibara dice2)
        {
            new DiceComparer().Compare(dice1, dice2).Should().BeGreaterThan(0);
        }
    }
}