using System;
using System.Linq;
using System.Text.RegularExpressions;	
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email (string address){
            Address = address;

            if (string.IsNullOrEmpty(Address))
                AddNotification("Email.Address","Email address está vazio");
            
            if (!IsEmail(Address))
            AddNotification("Email.Address","Email inválido");
        }
        public string Address { get; private set; }
        public bool IsEmail(string email)
        {
            const string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            if (!Regex.IsMatch(email ?? "", pattern))
            return false;

            return true;
        }
    }

}