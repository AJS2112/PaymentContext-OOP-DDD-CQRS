
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]

        public void AdicionarAssinatura()
        {
            var subscription = new Subscription(null);
            var student = new Student("Antonio","Sucre","012345789","ajs2104@gmail.com");

            student.AddSubscription(subscription); 
            
        }
    }
}