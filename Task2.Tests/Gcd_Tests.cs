using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2Logic;
using System.Diagnostics;

namespace Task2.Tests
{
    [TestClass]
    public class GCDCalculatorClassTests
    {
        #region Tests for Euclidean algorithm methods
        [TestMethod]
        public void GetGCD_TwoPositiveNumbers_NotNullGCD()
        {
            int arrangeGCD = 21;
            double elapsedTime;
            int actGCD = GcdSolver.GetGCD(252, 105, out elapsedTime);
            Debug.WriteLine("GCD(252, 105) = {0}, algorithm took {1}", actGCD, elapsedTime);
            Assert.AreEqual(arrangeGCD, actGCD);
        }

        [TestMethod]
        public void GetGCD_TwoSameNegativeandPositiveNumbers_TheSamePositiveNumber()
        {
            int arrangeGCD = 12345;
            double elapsedTime;
            int actGCD = GcdSolver.GetGCD(-12345, 12345, out elapsedTime);
            Debug.WriteLine("GCD(12345, -12345) = {0}, algorithm took {1}", actGCD, elapsedTime);
            Assert.AreEqual(arrangeGCD, actGCD);
        }

        [TestMethod]
        public void GetGCD_OneOfTwoNumbersIsNull_GCDIsNull()
        {
            int arrangeGCD = 252;
            double elapsedTime;
            int actGCD = GcdSolver.GetGCD(252, 0, out elapsedTime);
            Debug.WriteLine("GCD(252, 0) = {0}, algorithm took {1}", actGCD, elapsedTime);
            Assert.AreEqual(arrangeGCD, actGCD);
        }


        [TestMethod]
        public void GetGCD_OneOfTwoNumbersIsNegative_NotNullPositiveGCD()
        {
            int arrangeGCD = 21;
            double elapsedTime;
            int actGCD = GcdSolver.GetGCD(252, -105, out elapsedTime);
            Debug.WriteLine("GCD(252, -105) = {0}, algorithm took {1}", actGCD, elapsedTime);
            Assert.AreEqual(arrangeGCD, actGCD);
        }

        [TestMethod]
        public void GetGCD_ThreePositiveNumbers_NotNullGCD()
        {
            int arrangeGCD = 256;
            double elapsedTime;
            int actGCD = GcdSolver.GetGCD(out elapsedTime,1024, 512, 256);
            Debug.WriteLine("GCD(1024, 512, 256) = {0}, algorithm took {1}", actGCD, elapsedTime);
            Assert.AreEqual(arrangeGCD, actGCD);
        }

        [TestMethod]
        public void GetGCD_TwoOfThreeNumbersAreNegative_NotNullGCD()
        {
            int arrangeGCD = 256;
            double elapsedTime;
            int actGCD = GcdSolver.GetGCD(out elapsedTime, 1024, -512, -256);
            Debug.WriteLine("GCD(1024, -512, -256) = {0}, algorithm took {1}", actGCD, elapsedTime);
            Assert.AreEqual(arrangeGCD, actGCD);
        }

        [TestMethod]
        public void GetGCD_TwoOfThreeNumbersAreNull_NotNullGCD()
        {
            int arrangeGCD = 256;
            double elapsedTime;
            int actGCD = GcdSolver.GetGCD(out elapsedTime,0, 0, -256);
            Debug.WriteLine("GCD(0, 0, -256) = {0}, algorithm took {1}", actGCD, elapsedTime);
            Assert.AreEqual(arrangeGCD, actGCD);
        }

    
        [TestMethod]
        public void GetGCD_SevenPositiveNumbers_NotNullGCD()
        {
            int arrangeGCD = 2;
            double elapsedTime;
            int actGCD = GcdSolver.GetGCD(out elapsedTime, 2, 4, 8, 16, 32, 64, 128);
            Debug.WriteLine("GCD(2, 4, 8, 16, 32, 64, 128) = {0}, algorithm took {1}", actGCD, elapsedTime);
            Assert.AreEqual(arrangeGCD, actGCD);
        }

        [TestMethod]
        public void GetGCD_FiveOfTenNumbersAreNegative_NotNullGCD()
        {
            int arrangeGCD = 2;
            double elapsedTime;
            int actGCD = GcdSolver.GetGCD(out elapsedTime, 2, -4, 8, -16, 32, -64, 128, -256, 512, -1024);
            Debug.WriteLine("GCD( 2, -4, 8, -16, 32, -64, 128, -256, 512, -1024) = {0}, algorithm took {1}", actGCD, elapsedTime);
            Assert.AreEqual(arrangeGCD, actGCD);
        }

        [TestMethod]
        public void GetGCD_TenSameNegativeNumbers_NotNullGCD()
        {
            int arrangeGCD = 13;
            double elapsedTime;
            int actGCD = GcdSolver.GetGCD(out elapsedTime, -13, -13, -13, -13, -13, -13, -13, -13, -13, -13);
            Debug.WriteLine("GCD(-13, -13, -13, -13, -13, -13, -13, -13, -13, -13) = {0}, algorithm took {1}", actGCD, elapsedTime);
            Assert.AreEqual(arrangeGCD, actGCD);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetGCD_NoNumbersGiven_ArgumentException()
        {
            double elapsedTime;
            int actGCD = GcdSolver.GetGCD(out elapsedTime);
        }

       
        #endregion


        #region Tests for Stein's (binary) algorithm methods
        [TestMethod]
        public void GetBinaryGCD_TwoPositiveNumbers_NotNullGCD()
        {
            int arrangeGCD = 13;
            double elapsedTime;
            int actGCD = GcdSolver.GetBinaryGCD(169, 1326, out elapsedTime);
            Debug.WriteLine("binary GCD(169, 1326) = {0}, algorithm took {1}", actGCD, elapsedTime);
            Assert.AreEqual(arrangeGCD, actGCD);
        }

        [TestMethod]
        public void GetBinaryGCD_TwoSameNegativeandPositiveNumbers_TheSamePositiveNumber()
        {
            int arrangeGCD = 12345;
            double elapsedTime;
            int actGCD = GcdSolver.GetBinaryGCD(-12345, 12345, out elapsedTime);
            Debug.WriteLine("GCD(12345, -12345) = {0}, algorithm took {1}", actGCD, elapsedTime);
            Assert.AreEqual(arrangeGCD, actGCD);
        }

        [TestMethod]
        public void GetBinaryGCD_OneOfTwoNumbersIsNull_GCDIsNull()
        {
            int arrangeGCD = 252;
            double elapsedTime;
            int actGCD = GcdSolver.GetBinaryGCD(252, 0, out elapsedTime);
            Debug.WriteLine("binary GCD(252, 0) = {0}, algorithm took {1}", actGCD, elapsedTime);
            Assert.AreEqual(arrangeGCD, actGCD);
        }


        [TestMethod]
        public void GetBinaryGCD_OneOfTwoNumbersIsNegative_NotNullPositiveGCD()
        {
            int arrangeGCD = 202;
            double elapsedTime;
            int actGCD = GcdSolver.GetBinaryGCD(116150, -232704, out elapsedTime);
            Debug.WriteLine("binary GCD(116150, -232704) = {0}, algorithm took {1}", actGCD, elapsedTime);
            Assert.AreEqual(arrangeGCD, actGCD);
        }

        [TestMethod]
        public void GetBinaryGCD_ThreePositiveNumbers_NotNullGCD()
        {
            int arrangeGCD = 2560;
            double elapsedTime;
            int actGCD = GcdSolver.GetBinaryGCD(out elapsedTime,10240, 5120, 2560);
            Debug.WriteLine("binary GCD(10240, 5120, 2560) = {0}, algorithm took {1}", actGCD, elapsedTime);
            Assert.AreEqual(arrangeGCD, actGCD);
        }

       
        [TestMethod]
        public void GetBinaryGCD_SevenPositiveNumbers_NotNullGCD()
        {
            int arrangeGCD = 2;
            double elapsedTime;
            int actGCD = GcdSolver.GetBinaryGCD(out elapsedTime, 2, 4, 8, 16, 32, 64, 128);
            Debug.WriteLine("binary GCD(2, 4, 8, 16, 32, 64, 128) = {0}, algorithm took {1}", actGCD, elapsedTime);
            Assert.AreEqual(arrangeGCD, actGCD);
        }

        [TestMethod]
        public void GetBinaryGCD_FiveOfTenNumbersAreNegative_NotNullGCD()
        {
            int arrangeGCD = 2;
            double  elapsedTime;
            int actGCD = GcdSolver.GetBinaryGCD(out elapsedTime, 2, -4, 8, -16, 32, -64, 128, -256, 512, -1024);
            Debug.WriteLine("binary GCD( 2, -4, 8, -16, 32, -64, 128, -256, 512, -1024) = {0}, algorithm took {1}", actGCD, elapsedTime);
            Assert.AreEqual(arrangeGCD, actGCD);
        }

        [TestMethod]
        public void GetBinaryGCD_TenSameNegativeNumbers_NotNullGCD()
        {
            int arrangeGCD = 13;
            double elapsedTime;
            int actGCD = GcdSolver.GetBinaryGCD(out elapsedTime, -13, -13, -13, -13, -13, -13, -13, -13, -13, -13);
            Debug.WriteLine("binary GCD(-13, -13, -13, -13, -13, -13, -13, -13, -13, -13) = {0}, algorithm took {1}", actGCD, elapsedTime);
            Assert.AreEqual(arrangeGCD, actGCD);
        }

        #endregion

       
    }
}

