using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities{
    public class BoletoPayment:Payment 
    {
        public BoletoPayment(string barCode, string boletoNumber,DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, Document document, string payer, Address adress, Email email):base( paidDate, expireDate,  total, totalPaid, document, payer, adress, email)
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;

            if (string.IsNullOrEmpty(BoletoNumber))
                AddNotification("BoletoPayment.BoletoNumber","Numero de boleto vazio");
        }

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }
    
    }

}