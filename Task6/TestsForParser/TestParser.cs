using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parser;
using Parser.Exceptions;

namespace TestsForParser
{
    [TestClass]
    public class TestParser
    {

        Cage cage;
        Logic logic;

        [TestInitialize]
        public void Initialize()
        {
            cage = new Cage();
            logic = new Logic();
        }


        [TestMethod]
        public void CheckCorrectWorkForPositiveInt()
        {
            int actual;
            cage.ParseIntCorrectly("+1254786",out actual);
            int expected = +1254786;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckCorrectWorkForNegativeInt()
        {
            int actual;
            cage.ParseIntCorrectly("-1254786", out actual);
            int expected = -1254786;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckInt()
        {
            int actual;
            cage.ParseIntCorrectly("0", out actual);
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetFirstArgumentNullException()
        {
            int actual = logic.DetermineType("");
            string expected = "";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetSecondArgumentNullException()
        {
            int actual = logic.DetermineType(null);
            string expected = null;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [ExpectedException(typeof(NumberIsOutOfIntegerException))]
        public void GetItIsAPositivelongNumberException()
        {
            int actual = logic.DetermineType("214748364785");
            long expected = 2147483648;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(NumberIsOutOfIntegerException))]
        public void GetItIsANegativelongNumberException()
        {
            int actual = logic.DetermineType("-214748364785");
            long expected = -2147483648;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [ExpectedException(typeof(ItIsAFloatNumberException))]
        public void GetItIsAPositiveFloatNumberException()
        {
            int actual = logic.DetermineType("2.8");
            float expected = 2.8F;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ItIsAFloatNumberException))]
        public void GetItIsANegativeFloatNumberException()
        {
            int actual = logic.DetermineType("-2.8");
            float expected = -2.8F;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [ExpectedException(typeof(ItIsAStringException))]
        public void GetItIsAStringException()
        {
            int actual = logic.DetermineType("56;5mo");
            string expected = "56;5mo";
            Assert.AreEqual(expected, actual);
        }


        //[TestMethod]
        //public void TempTest1()
        //{
        //    int actual;
        //    cage.ParseIntCorrectly(Int32.MaxValue.ToString(), out actual);
        //    int expected = Int32.MaxValue;
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void TempTest2()
        //{
        //    int actual;
        //    cage.ParseIntCorrectly(Int32.MinValue.ToString(), out actual);
        //    int expected = Int32.MinValue;
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
