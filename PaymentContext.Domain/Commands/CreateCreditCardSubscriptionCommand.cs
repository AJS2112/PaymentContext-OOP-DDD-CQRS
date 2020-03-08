using System;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.Commands;
using PaymentContext.Shared.Nofitications;

namespace PaymentContext.Domain.Commands
{
    public class CreateCreditCardSubscriptionCommand : Notifiable, ICommand
    {
        public string FisrtName {get; set;}
        public string LastName {get; set;}
        public string Document { get; set; }   
        public string Email { get; set; }

        public string CarHolder { get; set; }
        public string CardNumber { get; set; }
        public string LastTransactionNumber { get; set; }
        public string PaymentNumber { get; set; }
        public DateTime PaidDate { get; set; }
        public DateTime ExpireDate { get; set; } 
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public string Payer { get; set; }
        public string PayerDocument { get; set; }
        public EDocumentType PayerDocumentType { get; set; }
        public string PayerEmail { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }

        public void Validate()
        {
            if  (string.IsNullOrEmpty(FisrtName))
                AddNotification("Name.FirstName","Nome inválido");
            if  (string.IsNullOrEmpty(LastName))
                AddNotification("Name.LastName","Sobrenome inválido");

        }
    }
}