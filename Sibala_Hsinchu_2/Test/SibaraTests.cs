using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sibala_Hsinchu_2
{
    [TestClass]
    public class SibaraTests
    {
        [TestMethod]
        public void input_1_1_1_1_should_be_sameColor()
        {
            var target = new Sibara(1, 1, 1, 1);
            var expected = "same color";
            var actual = target.SibaraResult;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void input_1_3_4_2_should_be_noPoints()
        {
            var target = new Sibara(1, 3, 4, 2);
            var expected = "no points";
            var actual = target.SibaraResult;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void input_3_6_3_3_should_be_noPoints()
        {
            var target = new Sibara(3, 6, 3, 3);
            var expected = "no points";
            var actual = target.SibaraResult;
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void input_6_2_6_2_should_be_Sibala()
        {
            var target = new Sibara(6, 2, 6, 2);
            var expected = "sibala";
            var actual = target.SibaraResult;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void input_5_5_2_2_should_be_10_Points()
        {
            var target = new Sibara(5, 5, 2, 2);
            var expected = "10 point";
            var actual = target.SibaraResult;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void input_4_4_2_1_should_be_BG()
        {
            var target = new Sibara(4, 4, 2, 1);
            var expected = "BG";
            var actual = target.SibaraResult;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void input_5_5_4_3_should_be_7_Points()
        {
            var target = new Sibara(5, 5, 4, 3);
            var expected = "7 point";
            var actual = target.SibaraResult;
            Assert.AreEqual(expected, actual);
        }


























        [TestMethod]
        public void input_1_1_1_1_should_be_1()
        {
            var target = new Sibara(1, 1, 1, 1);
            var expected = 1;
            var actual = target.MaxPoint;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void input_1_3_4_2_should_be_4()
        {
            var target = new Sibara(1, 3, 4, 2);
            var expected = 4;
            var actual = target.MaxPoint;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void input_3_6_3_3_should_be_6()
        {
            var target = new Sibara(3, 6, 3, 3);
            var expected = 6;
            var actual = target.MaxPoint;
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void input_6_2_6_2_should_be_6()
        {
            var target = new Sibara(6, 2, 6, 2);
            var expected = 6;
            var actual = target.MaxPoint;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void input_5_5_2_2_should_be_5()
        {
            var target = new Sibara(5, 5, 2, 2);
            var expected = 5;
            var actual = target.MaxPoint;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void input_4_4_2_1_should_be_2()
        {
            var target = new Sibara(4, 4, 2, 1);
            var expected = 2;
            var actual = target.MaxPoint;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void input_5_5_4_3_should_be_4()
        {
            var target = new Sibara(5, 5, 4, 3);
            var expected = 4;
            var actual = target.MaxPoint;
            Assert.AreEqual(expected, actual);
        }








    }
}
