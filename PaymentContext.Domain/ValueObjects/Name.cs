using System.Collections.Generic;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string fisrtName, string lastName)
        {
            FisrtName = fisrtName;
            LastName = lastName;

            //HERE IS THE PLACE FOR VALIDATIONS
            if  (string.IsNullOrEmpty(FisrtName))
                AddNotification("Name.FirstName","Nome inválido");
            if  (string.IsNullOrEmpty(LastName))
                AddNotification("Name.LastName","Sobrenome inválido");
        }

        public string FisrtName {get; private set;}
        public string LastName {get; private set;}

    }
}