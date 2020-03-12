
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        [TestMethod]
        public void SholdReturnErrorWhenDocumentExists()
        {            
            var handler = new SubscriptionHandler( new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();

            command.FisrtName="Bruce"; 
            command.LastName="Wayne";           
            command.Document="99999999999";   
            command.Email="hello@gmail.com";

            command.BarCode="123456789";
            command.BoletoNumber="123456789";
            command.PaymentNumber="111111";
            command.PaidDate=DateTime.Now;
            command.ExpireDate=DateTime.Now.AddMonths(1); 
            command.Total=60;
            command.TotalPaid=60;
            command.Payer="Wayne Corp";
            command.PayerDocument="12345678911";
            command.PayerDocumentType=EDocumentType.CPF;
            command.PayerEmail="batman@dc.com";
            command.Street="asass";
            command.Number="12121";
            command.Neighborhood="23232";
            command.City="Gotham";
            command.State="as";
            command.Country="as";
            command.ZipCode="123457";

            handler.Handle(command);

            Assert.AreEqual(false, handler.Valid);
        } 

    }
}