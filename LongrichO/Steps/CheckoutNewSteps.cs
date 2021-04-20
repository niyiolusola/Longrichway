using FluentAssertions;
using LongrichO.PageObjects;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace LongrichO.Steps
{
    [Binding]
    public class CheckoutNewSteps
    {
        CheckoutNewPage checkoutNewPage;

        public CheckoutNewSteps()
        {
            checkoutNewPage = new CheckoutNewPage();
        }
        [When(@"the user enters State/Country ""(.*)""")]
        public void WhenTheUserEntersStateCountry(string StateCountry)
        {
            checkoutNewPage.EnterState(StateCountry);
        }

        [When(@"the user clicks New Customer Quick Registration")]
        public void WhenTheUserClicksNewCustomerQuickRegistration()
        {
            checkoutNewPage.QuickReg();
        }
        
        [When(@"the user clicks x to close notification box")]
        public void WhenTheUserClicksXToCloseNotificationBox()
        {
            checkoutNewPage.CloseNoticeBox();
        }
        
        [When(@"the user clicks Stripe button")]
        public void WhenTheUserClicksStripeButton()
        {
            //Thread.Sleep(30000);
            checkoutNewPage.ChoseStripe();
        }
        
        [When(@"the user clicks Store Pickup button")]
        public void WhenTheUserClicksStorePickupButton()
        {
            checkoutNewPage.StorePickup();
        }
        
        [When(@"the user clicks complete order")]
        public void WhenTheUserClicksCompleteOrder()
        {
            checkoutNewPage.CompleteOrder();
        }

        [Then(@"the card enter card detail box should be displayed")]
        public void ThenTheCardEnterCardDetailBoxShouldBeDisplayed()
        {
            Thread.Sleep(10000);
            Assert.IsTrue(checkoutNewPage.DisplayPaymentPage());

            //checkoutNewPage.DisplayPaymentPage().Should().BeTrue();
        }
       
    }
}
