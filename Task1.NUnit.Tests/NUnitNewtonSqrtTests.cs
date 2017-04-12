using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using NUnit.Framework;
using Task1Logic;

namespace Task1.NUnit.Tests
{
    [TestFixture]
    public class RootCounterClassNUnitTests
    {
        [Test]
        [TestCase(4, 2, 2)]
        [TestCase(16, 2, 4)]
        [TestCase(81, 4, 3)]
        [TestCase(0, 3, 0)]
        public void Sqrt_Num_Root_Result(double num, int n, double res)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(RootCounter.GetRoot(num,n, 0.0000001), res);
        }

      
    }
}
