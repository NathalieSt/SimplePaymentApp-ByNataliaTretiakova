using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SimplePaymentApp.Core.Tests
{
    [TestFixture]
    public class SimpleUnitTest
    {

        [Test]
        public void TestPayment()
        {
            //Ask
            string NameOnCardEnter = "Natalia Tretiakova";
            string CardNumberEnter = "4111111111111111";
            string ExpiryDateEnter = "12/20";
            string SecurityCode = "123";
            string PostalCodeEnter = "123456";

            // Assert
            Assert.NotNull(NameOnCardEnter, CardNumberEnter, ExpiryDateEnter, SecurityCode, PostalCodeEnter);

        }
    }
}

