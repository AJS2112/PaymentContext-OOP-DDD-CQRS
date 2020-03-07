using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities{
    public abstract class Payment{
        protected Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, Document document, string payer, Address adress, Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0,10).ToUpper();
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Document = document;
            Payer = payer;
            Adress = adress;
            Email = email;
        }

        public string Number { get; private set; }
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; } 
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public Document Document { get; private set; }
        public string Payer { get; private set; }
        public Address Adress { get; private set; }
        public Email Email { get; private set; }
    }
    
}