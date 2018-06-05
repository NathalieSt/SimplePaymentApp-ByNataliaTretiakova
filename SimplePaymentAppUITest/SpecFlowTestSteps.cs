using System;
using TechTalk.SpecFlow;
using SimplePaymentApp.Core;

namespace SimplePaymentAppUITest
{
    [Binding]
    public class SpecFlowTestSteps
    {
        [Given(@"I fill the Name")]
        public void GivenIFillTheName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I fill also the Card Number")]
        public void GivenIFillAlsoTheCardNumber()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press pay now")]
        public void WhenIPressPayNow()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be the notification on the screen")]
        public void ThenTheResultShouldBeTheNotificationOnTheScreen()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
