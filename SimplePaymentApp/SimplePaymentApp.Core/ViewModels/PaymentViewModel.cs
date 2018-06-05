using Acr.UserDialogs;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using PaymillWrapper;
using PaymillWrapper.Models;
using PaymillWrapper.Service;
using System;
using System.Windows.Input;

namespace SimplePaymentApp.Core.ViewModels
{
    public class PaymentViewModel : MvxViewModel
    {
        private string _nameOnCardEnter;
        private string _cardNumberEnter;
        private string _expiryDateEnter;
        private string _securityCode;
        private string _postalCodeEnter;

        public string NameOnCardEnter
        {
            get
            {
                return _nameOnCardEnter;
            }
            set
            {
                _nameOnCardEnter = value;
                RaisePropertyChanged(() => NameOnCardEnter);
            }
        }
        
        public string CardNumberEnter
        {
            get
            {
                return _cardNumberEnter;
            }
            set
            {
                _cardNumberEnter = value;
                RaisePropertyChanged(() => CardNumberEnter);
                RaisePropertyChanged(() => IncorrectCardNumber);
            }
        }

       public string IncorrectCardNumber
       {
          get
           {
               return (CardNumberEnter.Length == 0 || CardNumberEnter.Length == 16) && Int64.TryParse(CardNumberEnter, out Int64 n) ? null : "Incorrect Card Number";
          }
       }

        public string ExpiryDateEnter
        {
            get
            {
                return _expiryDateEnter;
            }
            set
            {
                _expiryDateEnter = value;
                RaisePropertyChanged(() => ExpiryDateEnter);
            }
        }

       public string SecurityCode
        {
            get
            {
                return _securityCode;
            }
            set
            {
                _securityCode = value;
                RaisePropertyChanged(() => SecurityCode);
            }
        }

        public string PostalCodeEnter
        {
            get
            {
                return _postalCodeEnter;
            }
            set
            {
                _postalCodeEnter = value;
                RaisePropertyChanged(() => PostalCodeEnter);
            }
        }

        //PaymentService paymentService = paymillContext.PaymentService;

        public ICommand PayCommand => new MvxCommand(() => {

        //    Payment payment = paymentService.CreateWithTokenAsync("32732925984efbfec3c4976e7f579201").Result;
            Mvx.Resolve<IUserDialogs>().Alert("The payment has been processed successfully");

        });


    }
}







