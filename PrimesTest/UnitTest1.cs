using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Primes.PrimeNumber.IsPrime(7));
            Assert.IsTrue(Primes.PrimeNumber.IsPrime(5));
            Assert.IsTrue(Primes.PrimeNumber.IsPrime(13));
            Assert.IsFalse(Primes.PrimeNumber.IsPrime(9));
        }
    }
}
