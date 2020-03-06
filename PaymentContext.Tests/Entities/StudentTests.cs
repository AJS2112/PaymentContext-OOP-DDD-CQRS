
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]

        public void TestMethod1()
        {
            var student = new Student("Antonio","Sucre","012345789","ajs2104@gmail.com");
        }
    }
}