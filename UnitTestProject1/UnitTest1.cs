using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class IntegralTests
    {
        [TestMethod]
        public void IdentityTest()
        {
            //Создание объекта для генерации чисел
            Random rnd = new Random(1111);

            int n = 10000;
            double a = 0;
            double b = 1;

            double S = 0;
            double h = (double)(b - a) / (double)n;

            for (int i = 0; i < n; i++)
            {
                double x = rnd.NextDouble() * (b - a) + a;
                double y = WindowsFormsApp1.Functions.IdentityFunction(x);
                S += y;
            }

            double integral = S * h;

            Assert.AreEqual(0.5, integral, 0.1);
        }

        [TestMethod]
        public void SquareTest()
        {
            //Создание объекта для генерации чисел
            Random rnd = new Random(1111);

            int n = 10000;
            double a = -1;
            double b = 1;

            double S = 0;
            double h = (double)(b - a) / (double)n;

            for (int i = 0; i < n; i++)
            {
                double x = rnd.NextDouble() * (b - a) + a;
                double y = WindowsFormsApp1.Functions.SquareFunction(x);
                S += y;
            }

            double integral = S * h;

            Assert.AreEqual(0.65, integral, 0.05);
        }

        [TestMethod]
        public void ExponentialTest()
        {
            //Создание объекта для генерации чисел
            Random rnd = new Random(1111);

            int n = 10000;
            double a = -1;
            double b = 1;

            double S = 0;
            double h = (double)(b - a) / (double)n;

            for (int i = 0; i < n; i++)
            {
                double x = rnd.NextDouble() * (b - a) + a;
                double y = WindowsFormsApp1.Functions.ExponentialFunction(x);
                S += y;
            }

            double integral = S * h;

            Assert.AreEqual(2.35, integral, 0.1);
        }

        [TestMethod]
        public void SineTest()
        {
            //Создание объекта для генерации чисел
            Random rnd = new Random(1111);

            int n = 10000;
            double a = 0;
            double b = 2;

            double S = 0;
            double h = (double)(b - a) / (double)n;

            for (int i = 0; i < n; i++)
            {
                double x = rnd.NextDouble() * (b - a) + a;
                double y = WindowsFormsApp1.Functions.SineFunction(x);
                S += y;
            }

            double integral = S * h;

            Assert.AreEqual(1.4, integral, 0.05);
        }

        [TestMethod]
        public void CosineTest()
        {
            //Создание объекта для генерации чисел
            Random rnd = new Random(1111);

            int n = 10000;
            double a = 0;
            double b = 2;

            double S = 0;
            double h = (double)(b - a) / (double)n;

            for (int i = 0; i < n; i++)
            {
                double x = rnd.NextDouble() * (b - a) + a;
                double y = WindowsFormsApp1.Functions.CosineFunction(x);
                S += y;
            }

            double integral = S * h;

            Assert.AreEqual(0.9, integral, 0.05);
        }

        [TestMethod]
        public void TangentTest()
        {
            //Создание объекта для генерации чисел
            Random rnd = new Random(1111);

            int n = 10000;
            double a = 0;
            double b = 1;

            double S = 0;
            double h = (double)(b - a) / (double)n;

            for (int i = 0; i < n; i++)
            {
                double x = rnd.NextDouble() * (b - a) + a;
                double y = WindowsFormsApp1.Functions.TangentFunction(x);
                S += y;
            }

            double integral = S * h;

            Assert.AreEqual(0.6, integral, 0.05);
        }
    }
}
