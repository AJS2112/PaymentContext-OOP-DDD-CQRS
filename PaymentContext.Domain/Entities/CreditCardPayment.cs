using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(string carHolder, string cardNumber, string lastTransactionNumber,DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, Document document, string payer, Address adress, Email email):base( paidDate, expireDate,  total, totalPaid, document, payer, adress, email)
        {
            CarHolder = carHolder;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CarHolder { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }

    }

}