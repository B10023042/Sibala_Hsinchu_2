using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sibala_Hsinchu_2
{
    [TestClass]
    public class SibaraOutputTests
    {
        private static Sibara _sibara;

        [TestMethod]
        public void input_4Same_should_be_sameColor()
        {
            _sibara = new Sibara(1, 1, 1, 1);
            OutputShouldBe("same color");
            PointsShouldBe(0);
            MaxPointShouldBe(1);
            DiceTypeShouldBe(SibaraStatus.DiceTypeEnum.SameColor);
        }

        [TestMethod]
        public void input_4Diff_should_be_noPoint()
        {
            _sibara = new Sibara(1, 2, 4, 5);
            OutputShouldBe("no point");
            PointsShouldBe(0);
            MaxPointShouldBe(5);
            DiceTypeShouldBe(SibaraStatus.DiceTypeEnum.NoPoint);
        }

        [TestMethod]
        public void input_3Same_should_be_noPoint()
        {
            _sibara = new Sibara(3, 3, 1, 3);
            OutputShouldBe("no point");
            PointsShouldBe(0);
            MaxPointShouldBe(3);
            DiceTypeShouldBe(SibaraStatus.DiceTypeEnum.NoPoint);
        }

        [TestMethod]
        public void input_2Pair_contain66_should_be_Sibala()
        {
            _sibara = new Sibara(2, 6, 6, 2);
            OutputShouldBe("sibala");
            PointsShouldBe(12);
            MaxPointShouldBe(6);
            DiceTypeShouldBe(SibaraStatus.DiceTypeEnum.NormalPoint);
        }

        [TestMethod]
        public void input_2Pair_should_be_Points()
        {
            _sibara = new Sibara(1, 1, 5, 5);
            OutputShouldBe("10 point");
            PointsShouldBe(10);
            MaxPointShouldBe(5);
            DiceTypeShouldBe(SibaraStatus.DiceTypeEnum.NormalPoint);
        }

        [TestMethod]
        public void input_1Pair_contain21_should_be_BG()
        {
            _sibara = new Sibara(4,4,1,2);
            OutputShouldBe("BG");
            PointsShouldBe(3);
            MaxPointShouldBe(2);
            DiceTypeShouldBe(SibaraStatus.DiceTypeEnum.NormalPoint);
            
        }

        [TestMethod]
        public void input_1Pair_should_be_Points()
        {
            _sibara = new Sibara(5, 5, 4, 3);
            OutputShouldBe("7 point");
            PointsShouldBe(7);
            MaxPointShouldBe(4);
            DiceTypeShouldBe(SibaraStatus.DiceTypeEnum.NormalPoint);
        }
        private static void PointsShouldBe(int points)
        {
            var actual = _sibara.Points;
            Assert.AreEqual(points, actual);
        }

        private static void MaxPointShouldBe(int maxPoint)
        {
            var actual = _sibara.MaxPoint;
            Assert.AreEqual(maxPoint, actual);
        }

        private static void DiceTypeShouldBe(SibaraStatus.DiceTypeEnum diceType)
        {
            var actual = _sibara.DiceType;
            Assert.AreEqual(diceType, actual);
        }

        private static void OutputShouldBe(string output)
        {
            var actual = _sibara.Output;
            Assert.AreEqual(output, actual);
        }

    }
}