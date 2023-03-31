using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test11_20.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test11_20.Windows.Tests
{
    [TestClass()]
    public class CalcWindowTests
    {

        // сложение двух положительных чисел
        [TestMethod()]
        public void Check_PositiveSum10And10_Return20()
        {
            int a = 10;
            int b = 10;
            string expected = "20";

            Assert.AreEqual(expected, CalcWindow.Sum(a, b));
        }

        // сложение положительного и отрицательного чисел
        [TestMethod()]
        public void Check_NegativeSum10AndMinus90_ReturnMinus80()
        {
            int a = 10;
            int b = -90;
            string expected = "-80";

            Assert.AreEqual(expected, CalcWindow.Sum(a, b));
        }

        // сложение целочисленного и десятичного чисел
        [TestMethod()]
        public void Check_PositiveSum10And5Point3_Return15Point3()
        {
            int a = 10;
            double b = 5.3;
            string expected = "15,3";

            Assert.AreEqual(expected, CalcWindow.Sum(a, b));
        }

        // вычитание двух положительных чисел
        [TestMethod()]
        public void Check_NegativeMinus10And20_ReturnMinus10()
        {
            int a = 10;
            int b = 20;
            string expected = "-10";

            Assert.AreEqual(expected, CalcWindow.Minus(a, b));
        }

        // вычитание нуля и отрицательного чисел
        [TestMethod()]
        public void Check_PositiveMinus0AndMinus20_Return20()
        {
            int a = 0;
            int b = -20;
            string expected = "20";

            Assert.AreEqual(expected, CalcWindow.Minus(a, b));
        }

        // умножение на 0
        [TestMethod()]
        public void Check_PositiveMultiply0And10_Return0()
        {
            int a = 0;
            int b = 10;
            string expected = "0";

            Assert.AreEqual(expected, CalcWindow.Multiply(a, b));
        }

        // умножение целочисленного числа на десятичное
        [TestMethod()]
        public void Check_PositiveMultiply45And4Point3_Return193Point5()
        {
            int a = 45;
            double b = 4.3;
            string expected = "193,5";

            Assert.AreEqual(expected, CalcWindow.Multiply(a, b));
        }

        // умножение положительного числа на отрицательное
        [TestMethod()]
        public void Check_NegativeMultiply5AndMinus7_ReturnMinus35()
        {
            int a = 5;
            int b = -7;
            string expected = "-35";

            Assert.AreEqual(expected, CalcWindow.Multiply(a, b));
        }

        // деление числа на 0
        [TestMethod()]
        public void Check_PositiveDivide5By0_ReturnInfinity()
        {
            int a = 5;
            int b = 0;
            string expected = Convert.ToString(double.PositiveInfinity);

            Assert.AreEqual(expected, CalcWindow.Substract(a, b));
        }

        // деление целочисленного числа на десятичное
        [TestMethod()]
        public void Check_PositiveDivide5By2Point5_Return6Point0344()
        {
            int a = 5;
            double b = 2.5;
            string expected = "2";

            Assert.AreEqual(expected, CalcWindow.Substract(a, b));
        }

        // нахождение корня положительного числа
        [TestMethod()]
        public void Check_SquareOf36_Return6()
        {
            int a = 36;
            string expected = "6";

            Assert.AreEqual(expected, CalcWindow.Square(a));
        }

        // нахождение корня орицательного числа
        [TestMethod()]
        public void Check_SquareOfMinus5_Return6()
        {
            int a = -5;
            string expected = Convert.ToString(double.NaN);

            Assert.AreEqual(expected, CalcWindow.Square(a));
        }
    }
}