using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace MegaPrimesProgram
{
    [TestFixture]
    class ClsNUnitMegaprimes
    {
        private static UInt32 _ValueUnderTest;
        private static UInt32[] _ExpectedValues;       
        [SetUp]
        public void Setup()
        {
            _ValueUnderTest = 10;
            _ExpectedValues = new UInt32[]
            {
                2,
                3,
                5,
                7
            };
        }        
        [Test]
        public void ShouldHaveMegaprimeNumbers_Below10()
        {
            List<uint> expected = new List<uint> { 2, 3, 5, 7 };
            var result = ClsMegaPrimes_UsingLinq.GetMegaPrime(10);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void ShouldHaveMegaprimeNumbers_Max37()
        {
            List<uint> expected = new List<uint> { 2, 3, 5, 7, 23, 37 };
            var result = ClsMegaPrimes_UsingLinq.GetMegaPrime(37);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void ShouldHaveNoMegaprimeNumberReturned()
        {
            List<uint> expected = new List<uint> { };
            var result = ClsMegaPrimes_UsingLinq.GetMegaPrime(1);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void ShouldYield_ExpectedValues()
            => Assert.AreEqual(_ExpectedValues, ClsMegaPrimes_UsingLinq.GetMegaPrime(_ValueUnderTest));
        [Test]
        public void ShouldHaveLength_EqualTo_ExpectedValuesLength()
            => Assert.AreEqual(_ExpectedValues.Length, ClsMegaPrimes_UsingLinq.GetMegaPrime(_ValueUnderTest).Count);
        [Test]
        public void ShouldNotYield_ProvidedValue()
            => Assert.IsFalse(ClsMegaPrimes_UsingLinq.GetMegaPrime(_ValueUnderTest).Contains(_ValueUnderTest));
        [Test]
        public void ShouldHaveMegaprimeNumbers_Below100()
        {
            List<uint> expected = new List<uint> { 2, 3, 5, 7, 23, 37, 53, 73 };
            var result = ClsMegaPrimes_UsingLinq.GetMegaPrime(100);
            Assert.AreEqual(expected, result);
        }
    }
}
