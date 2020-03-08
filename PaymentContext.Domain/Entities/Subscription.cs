using System;
using System.Collections.Generic;
using System.Linq;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities{
    public class Subscription :  Entity
    {
        private IList<Payment> _payments;

        public Subscription(DateTime? expireDate)
        {
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            ExpireDate = expireDate;
            Active = true;
            _payments = new List<Payment>();

            if (string.IsNullOrEmpty(ExpireDate.ToString()))
                AddNotification("Subscription.ExpireDate","Data de expiração inválida");
        }

        public DateTime CreateDate {get; private set;}
        public DateTime LastUpdateDate {get; private set;}
        public DateTime? ExpireDate {get; private set;}
        public bool Active {get; private set;}
        public IReadOnlyCollection<Payment> Payments { get { return _payments.ToArray();} }

        public void AddPayment(Payment payment){
            if  (payment.PaidDate<DateTime.Now)
                AddNotification("Subscription.Payments","A data do pagamento deve ser futura");
            //if (Valid) //Só adiciona se for válido
            _payments.Add(payment);
        }

        public void Activate(){
            Active=true;
            LastUpdateDate=DateTime.Now;
        }
        public void Inactivate(){
            Active=false;
            LastUpdateDate=DateTime.Now;
        }
    }
}