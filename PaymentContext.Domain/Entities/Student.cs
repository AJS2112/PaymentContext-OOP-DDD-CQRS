using System.Collections.Generic; 
using System.Linq;
namespace PaymentContext.Domain.Entities{
    public class Student{

        private IList<Subscription> _subscriptions;
        public Student(string fisrtName, string lastName, string document, string email)
        {
            FisrtName = fisrtName;
            LastName = lastName;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }

        public string FisrtName {get; private set;}
        public string LastName {get; private set;}
        public string Document {get; private set;}
        public string Email {get; private set;}
        public string Adress { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions {get {return _subscriptions.ToArray();}}

        public void AddSubscription(Subscription subscription)
        {
            //Se já tiver uma assinatura ativa, cancela
            
            //Cancela todas as outras assinaturas, e coloca esta como principal
            foreach (var sub in Subscriptions){
                sub.Inactivate();
            } 

            _subscriptions.Add(subscription);

        }

    }
}