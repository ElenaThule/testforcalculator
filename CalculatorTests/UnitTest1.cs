using NUnit.Framework;
using ConsoleApp_калькулятор_Туленцева;
namespace CalculatorTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Plus_1plus6_7()
        {
            Calculator calc = new Calculator();
            double result = calc.Plus(1, 6);
            Assert.AreEqual(7,result);
        }
        [Test]
        public void Minus_6minus1_5()
        {
            Calculator calc = new Calculator();
            double result = calc.Minus(6, 1);
            Assert.AreEqual(5, result);
        }
        [Test]
        public void Multiplication_6multi1_6()
        {
            Calculator calc = new Calculator();
            double result = calc.Multiplication(6, 1);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Divide_6divide2_3()
        {
            Calculator calc = new Calculator();
            double result = calc.Divide(6, 2);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void TriangleSquare_4multi_5_10()
        {
            Calculator calc = new Calculator();
            double result = calc.TriangleSquare(4, 5);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void RoundSquare_PImulti_2()
        {
            Calculator calc = new Calculator();
            double result = calc.RoundSquare(2);
            Assert.GreaterOrEqual(result, 12);
        }

        //[Test]
        //public void Average_12345_3()
        //{
        //    Calculator calc = new Calculator();
        //    double [] array = new double[] { 1,2,3,4,5};
        //    double result = calc.Average(array);      
        //    Assert.AreEqual(3,result);
        //}

        [Test]
        public void Multiplication_2multi3_6()
        {
            Calculator calc = new Calculator();
            double result = calc.Multiplication(2, 3);
            Assert.AreEqual(6, result);
        }
        [Test]
        public void Plus_22plus22_44()
        {
            Calculator calc = new Calculator();
            double result = calc.Plus(22, 22);
            Assert.AreEqual(44, result);
        }
    }
}