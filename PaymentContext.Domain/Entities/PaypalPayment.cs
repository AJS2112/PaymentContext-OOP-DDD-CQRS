using System;

namespace PaymentContext.Domain.Entities{
    public class PaypalPayment : Payment
    {
        public PaypalPayment(string tansactionCode, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string document, string payer, string adress, string email):base( paidDate, expireDate,  total, totalPaid, document, payer, adress, email)
        {
            TansactionCode = tansactionCode;
        }

        public string TansactionCode { get; private set; }

    }
}