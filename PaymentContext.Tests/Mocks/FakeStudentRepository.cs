using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Repositories;

namespace PaymentContext.Tests.Mocks
{
    public class FakeStudentRepository : IStudentRepository
    {
        public void CreateSubscription(Student student)
        {
            throw new System.NotImplementedException();
        }

        public bool DocumentExist(string document)
        {
            if (document == "99999999999")
                return true;

            return false;
         }

        public bool EmailExist(string email)
        {
            if (email == "hello@gmail.com")
                return true;

            return false;
        }
    }
}