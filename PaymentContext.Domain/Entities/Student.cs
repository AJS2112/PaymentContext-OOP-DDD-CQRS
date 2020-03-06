using System.Collections.Generic; 
namespace PaymentContext.Domain.Entities{
    public class Student{
        public Student(string fisrtName, string lastName, string document, string email)
        {
            FisrtName = fisrtName;
            LastName = lastName;
            Document = document;
            Email = email;
        }

        public string FisrtName {get; private set;}
        public string LastName {get; private set;}
        public string Document {get; private set;}
        public string Email {get; private set;}
        public string Adress { get; private set; }
        public List<Subscription> Subscriptions {get;set;}
    }
}