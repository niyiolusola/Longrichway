using FluentAssertions;
using LongrichO.PageObjects;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace LongrichO.Steps
{
    [Binding]
    public class CardPaymentSteps
    {
        CardPaymentPage cardPaymentPage;
        public CardPaymentSteps()
        {
            cardPaymentPage = new CardPaymentPage();
        }
               
        [When(@"the user clicks PayStack option")]
        public void WhenTheUserClicksPayStackOption()
        {
            cardPaymentPage.ClickPayStack();
        }
        
        [When(@"the user clicks Home Delivery option")]
        public void WhenTheUserClicksHomeDeliveryOption()
        {
            cardPaymentPage.ClickHomeDelivery();
                    
        }
        
        [When(@"the user selects the Success Card")]
        public void WhenTheUserSelectsTheSuccessCard()
        {
            //Thread.Sleep(4000);
            cardPaymentPage.ClickSuccessCard();
        }
        
        [When(@"the user click Pay")]
        public void WhenTheUserClickPay()
        {
            cardPaymentPage.ClickPay();
        }
        
        [Then(@"payment made successfully message should be displayed")]
        public void ThenPaymentMadeSuccessfullyMessageShouldBeDisplayed()
        {
            cardPaymentPage.SuceesssNoticeDisplayed().Should().BeTrue();
        }
    }
}
