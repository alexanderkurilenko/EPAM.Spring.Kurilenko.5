using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1Logic;

namespace Task1.Tests
{
    [TestClass]
    public class NewtonSqrtTests
    {
        [TestMethod]
        public void Sqrt_TheRootOfThe2Degree4_2()
        {
            //Arange
            int num = 4;
            //Act
            double expectedResult = 2;
            double realResult = SqrtSolver.NewtonMethod(num);
            Assert.AreEqual(expectedResult, realResult);
        }

        [TestMethod]
        public void Sqrt_TheRootOfThe2Degree9_3()
        {
            //Arange
            int num = 9;
            //Act
            double expectedResult = 3;
            double realResult = SqrtSolver.NewtonMethod(num, 0.0000000000000000001);
            //Assert
            Assert.AreEqual(expectedResult, realResult);
        }

        [TestMethod]
        public void Sqrt_TheRootOfThe2DegreeNegative9_3()
        {
            //Arange
            int num = -9;
            //Act
            double expectedResult = Double.NaN;
            double realResult = SqrtSolver.NewtonMethod(num);
            //Assert
            Assert.AreEqual(expectedResult, realResult);
        }
    }
}
