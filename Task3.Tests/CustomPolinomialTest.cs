using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3Logic;

namespace Task3.Tests
{
    [TestClass]
    public class CustomPolinomialTest
    {
        [TestMethod]
        public void ToStringTest()
        {
            CustomPolinomial a = new CustomPolinomial(new int[4]{4,3,1,0},new double[4]{2,2,2,2});
            Assert.AreEqual("", a.ToString());
        }

        [TestMethod]
        public void SummOfPolinomTest()
        {
            CustomPolinomial a = new CustomPolinomial(new int[4] { 4, 3, 1, 0 }, new double[4] { 2, 2, 2, 2 });
            CustomPolinomial b = new CustomPolinomial(new int[4] { 4, 3, 1, 0 }, new double[4] { 2, 2, 2, 2 });
            CustomPolinomial result = new CustomPolinomial(new int[4] { 4, 3, 1, 0 }, new double[4] { 4, 4, 4, 4});

            Assert.AreEqual(result, a + b);
        }

        [TestMethod]
        public void MultiplyOfPolinomsTest()
        {
            CustomPolinomial a = new CustomPolinomial(new int[4] { 4, 3, 1, 0 }, new double[4] { 2, 2, 2, 2 });
            CustomPolinomial b = new CustomPolinomial(new int[4] { 4, 3, 1, 0 }, new double[4] { 2, 2, 2, 2 });
            CustomPolinomial result = new CustomPolinomial(new int[4] { 4, 3, 1, 0 }, new double[4] { 4, 4, 4, 4 });

            Assert.AreEqual(result, a * b);
        }

        [TestMethod]
        public void SubOfPolinomsTest()
        {
            CustomPolinomial a = new CustomPolinomial(new int[4] { 4, 3, 1, 0 }, new double[4] { 2, 2, 2, 2 });
            CustomPolinomial b = new CustomPolinomial(new int[4] { 4, 3, 1, 0 }, new double[4] { 2, 2, 2, 2 });
            CustomPolinomial result = new CustomPolinomial(new int[4] { 4, 3, 1, 0 }, new double[4] { 4, 4, 4, 4 });

            Assert.AreEqual(result, a - b);
        }

    }
}
