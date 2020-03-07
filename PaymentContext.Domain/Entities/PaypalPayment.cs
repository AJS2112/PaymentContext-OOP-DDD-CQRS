using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities{
    public class PaypalPayment : Payment
    {
        public PaypalPayment(string tansactionCode, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, Document document, string payer, Address adress, Email email):base( paidDate, expireDate,  total, totalPaid, document, payer, adress, email)
        {
            TansactionCode = tansactionCode;
        }

        public string TansactionCode { get; private set; }

    }
}