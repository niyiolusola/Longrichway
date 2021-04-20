using LongrichO.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace LongrichO.Steps
{
    [Binding]
    public class DisplayPaymentSteps
    {
        DisplayPaymentPage displayPaymentPage;

        public DisplayPaymentSteps()
        {

            displayPaymentPage = new DisplayPaymentPage();
        }
        //[When(@"the checkout page is displayed")]
        //public void WhenTheCheckoutPageIsDisplayed()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        [Then(@"the payment page should be displayed")]
        public bool ThenThePaymentPageShouldBeDisplayed()
        {
            return displayPaymentPage.DisplayPayment();
        }
    }
}
