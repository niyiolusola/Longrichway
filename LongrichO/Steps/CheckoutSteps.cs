using LongrichO.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace LongrichO.Steps
{
    [Binding]
    public class CheckoutSteps
    {
        CheckoutPage checkoutPage;
        public CheckoutSteps()
        {
            checkoutPage = new CheckoutPage();
        }

        [When(@"the user clicks on Categories")]
        public void WhenTheUserClicksOnCategories()
        {
            checkoutPage.ClickCategories();
        }
        
        [When(@"the user clicks ""(.*)""")]
        public void WhenTheUserClicks(string FeminineCare)
        {
            checkoutPage.ClickFemCare();
        }
        
        [When(@"the user selects preferred product")]
        public void WhenTheUserSelectsPreferredProduct()
        {
            checkoutPage.ClickProduct();
        }

        [When(@"the user enters quantity of product ""(.*)""")]
        public void WhenTheUserEntersQuantityOfProduct(string ProductQty)
        {
            checkoutPage.EnterQuantity(ProductQty);
        }

        //[When(@"the user enters quantity of product")]
        //public void WhenTheUserEntersQuantityOfProduct(string ProductQty)
        //{
        //    checkoutPage.EnterQuantity(ProductQty);
        //}

        [When(@"the user clicks on Add to Cart")]
        public void WhenTheUserClicksOnAddToCart()
        {
            checkoutPage.ClickAddCart();
        }
        
        //[When(@"the user clicks on the Cart icon")]
        //public void WhenTheUserClicksOnTheCartIcon()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        [When(@"the user clicks on the shopping basket")]
        public void WhenTheUserClicksOnTheShoppingBasket()
        {
            checkoutPage.ClickBasket();
        }

        [When(@"the user clicks on checkout")]
        public void WhenTheUserClicksOnCheckout()
        {
            checkoutPage.ClickCheckout();
        }
        
        [Then(@"the checkout page is displayed")]
        public bool ThenTheCheckoutPageIsDisplayed()
        {
            return checkoutPage.DisplayCheckout();
        }
    }
}
