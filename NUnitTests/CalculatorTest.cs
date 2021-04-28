using CCalculator;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTests
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator calculator;
        private Calculator calculator2;
        static List<TestCaseData> TestCases
        {
            get
            {
                return AddTestData.Get();
            }
        }
        [SetUp]
        public void Setup()
        {
            //method 1 by using moq - this will ovrride the get methoda automatically by making sub class
            /*Mock<Offset> mockObj = new Mock<Offset>();
            mockObj.Setup(m => m.Get()).Returns(100);
            calculator = new Calculator(mockObj.Object);
            Mock<Offset> mockObj2 = new Mock<Offset>();
            mockObj2.Setup(m => m.Concatinating()).Returns("World");
            calculator2 = new Calculator(mockObj2.Object);*/
            //method 2 by faking the class - here we crate custom class which inherits Offset class and overriding the methods
            FakeOffset fake = new FakeOffset();
            calculator = new Calculator(fake);
            
        }



        [Test]
        public void AddWithOffset_Test()
        {

            //Arrange

            int num1 = 20, num2 = 40;
            int expectedRes = 160;
            //Act

            int res = calculator.AddWithOffset(num1, num2);

            //Assert

            Assert.AreEqual(expectedRes, res);
        }
        [Test]
        public void ConcatWithOffset_Test()
        {
            string s = "Hello";
            string expected = "HelloWorld";
            //  string res = calculator2.ConcatWithOffset(s);
            string res = calculator.ConcatWithOffset(s);
            Assert.AreEqual(expected, res);
        }
        //Data Driven Approach
        [Test]
        /*[TestCase(10,20, ExpectedResult =30)]
        [TestCase(10, 30, ExpectedResult = 40)]*/
        [TestCaseSource("TestCases")]
        public int DDAdd_Test(int x,int y)
        {
           
            //Act
            return calculator.Add(x, y);

        }
        [Test]
        public void Add_Test()
        {
            //Arrange
            int num1 = 20, num2 = 40;
            int expectedRes = 60;
            //Act

            int res = calculator.Add(num1, num2);

            //Assert

            Assert.AreEqual(expectedRes, res);
        }
        [Test]
        public void Sub_Test()
        {
            //Arrange
            int num1 = 200, num2 = 40;
            int expectedRes = 160;
            //Act

            int res = calculator.Sub(num1, num2);

            //Assert

            Assert.AreEqual(expectedRes, res);
        }
        [Test]
        public void Mul_Test()
        {
            //Arrange
            int num1 = 20, num2 = 40;
            int expectedRes = 800;
            //Act

            int res = calculator.Mul(num1, num2);

            //Assert

            Assert.AreEqual(expectedRes, res);
        }
        [Test]
        public void Div_Test()
        {
            //Arrange
            int num1 = 0, num2 = 0;

            //Act //Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Div(num1, num2));
        }
    }
}
