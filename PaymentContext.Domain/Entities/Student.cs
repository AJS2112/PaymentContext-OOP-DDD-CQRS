using System.Collections.Generic; 
using System.Linq;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities{
    public class Student : Entity
    {

        private IList<Subscription> _subscriptions;
        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }

        public Name Name {get; private set;}
        public Document Document {get; private set;}
        public Email Email {get; private set;}
        public Address Adress { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions {get {return _subscriptions.ToArray();}}

        public void AddSubscription(Subscription subscription)
        {
            var hasSubscriptionActive = false;
            foreach (var sub in Subscriptions){
                //sub.Inactivate();
                if (sub.Active)
                    hasSubscriptionActive=true;
            } 

            if (hasSubscriptionActive)
                AddNotification("Student.Subscription", "Você já tem uma assinatura ativa");
            if (subscription.Payments.Count < 0)
                AddNotification("Student.Subscription.Payments", "Esta assinatura não possui pagamentos");
            

            _subscriptions.Add(subscription);

        }

    }
}