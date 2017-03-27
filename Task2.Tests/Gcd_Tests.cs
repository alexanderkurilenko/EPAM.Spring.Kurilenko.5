using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2Logic;
using NUnit.Framework;

namespace Task2.Tests
{
    [TestFixture]
    public class Gcd_Tests
    {
        [TestCase(4, 2, TestName = "GCDOfTwoPositiveNumbers", ExpectedResult = 2, Description = "GCD of two numbers.")]
        [TestCase(5, 7, TestName = "GCDOfTwoRelativelyPrimeNumbers", ExpectedResult = 1, Description = "GCD of two numbers.")]
        [TestCase(-5, 10, TestName = "GCDOfOnePositiveAndOneNegative", ExpectedResult = 5, Description = "GCD of two numbers which one of them is negative.")]
        [TestCase(0, 10, TestName = "GCDOfZeroAndPositiveNumber", ExpectedResult = 10, Description = "GCD of two numbers which one of them is zero.")]
        [TestCase(-12, 0, TestName = "GCDOfZeroAndNegativeNumber", ExpectedResult = 12, Description = "GCD of two numbers which one of them is zero and another one is negative.")]
        [TestCase(0, 0, TestName = "GCDOfTwoZeros", Description = "GCD of two zeros.")]
        public int GCDOfTwoNumbers(int arg1, int arg2)
        {
            return GcdSolver.EuklidGcdWithTimeMeasure(arg1,arg2).Item1;
        }

        
    }
}
