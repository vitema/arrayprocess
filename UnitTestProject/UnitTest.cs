using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProcessingNumbers;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestFindOnePair()
        {

            //arrange
            var numberArray = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var length = numberArray.Length;
            var number = 3;


            //act
            var pairs = ProcessNumbers.FindPairs(numberArray, number);


            //assert
            Assert.AreEqual(1, pairs.Count());
            Assert.AreEqual(1, pairs.First().number1);
            Assert.AreEqual(2, pairs.First().number2);

        }


        [TestMethod]
        public void TestCheckNoDublicates()
        {

            //arrange
            var numberArray = new[] { 1, 2, 2, 1, 1, 2, 5, 6, 7, 8, 9 };
            var length = numberArray.Length;
            var number = 3;

            //act
            var pairs = ProcessNumbers.FindPairs(numberArray, number).ToList();

            //assert
            Assert.AreEqual(1, pairs.Count());

        }


        [TestMethod]
        public void TestCheckVerifyNumbersInDifferntPosition()
        {

            //arrange
            var numberArray = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var length = numberArray.Length;
            var number = 2;

            //act
            var pairs = ProcessNumbers.FindPairs(numberArray, number);

            //assert
            Assert.AreEqual(0, pairs.Count());

        }



        [TestMethod]
        public void TestNotMatch()
        {

            //arrange
            var numberArray = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var length = numberArray.Length;
           

            var number = -1;

            //act
            var pairs = ProcessNumbers.FindPairs(numberArray, number).ToList(); ;

            //assert
            Assert.AreEqual(0, pairs.Count());

        }


        [TestMethod]
        public void TestCheckBigArray()
        {

            //arrange
            var numberArray = new int [20000];

            for (int i=0;i< numberArray.Length; i++)
            {
                numberArray[i] = i;
            }

            var length = numberArray.Length;
            var number = 10;

            //act
            var pairs = ProcessNumbers.FindPairs(numberArray, number).ToList(); ;

            //assert
            Assert.AreEqual(5, pairs.Count());

        }

    }


}
