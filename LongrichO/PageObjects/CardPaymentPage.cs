using LongrichO.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LongrichO.PageObjects
{
    class CardPaymentPage
    {
        IWebDriver driver;

        public CardPaymentPage()
        {
            driver = WebHook.driver;
        }
        IWebElement payStack => driver.FindElement(By.XPath("//*[@id='paystack']"));
        IWebElement homeDelivery => driver.FindElement(By.XPath("//*[@id='shipping_home']"));
        IWebElement frame => driver.FindElement(By.CssSelector("#app > section > div > div > div.checkout__core > div"));
        IWebElement successCard => driver.FindElement(By.CssSelector("#test-cards > div.cards > div.card.card--is-active > div > div.card__details__select > div"));
        IWebElement payButton => driver.FindElement(By.Id("testCardsPaymentButton"));
        IWebElement successNotice => driver.FindElement(By.Id("dialoguetext"));

        public void ClickPayStack()
        {
            payStack.Click();
        }
        public void ClickHomeDelivery()
        {
            homeDelivery.Click();
        }
        
        public void ClickSuccessCard()
        {
            frame.Click();
            driver.SwitchTo().Frame(1);
            successCard.Click();
        }
        public void ClickPay()
        {
            payButton.Click();
        }
        public bool SuceesssNoticeDisplayed()
        {
            return successNotice.Displayed;
        }
    }
}
