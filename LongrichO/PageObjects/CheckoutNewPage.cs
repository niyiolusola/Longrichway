using LongrichO.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LongrichO.PageObjects
{
    class CheckoutNewPage
    {
        IWebDriver driver;

        public CheckoutNewPage()
        {
            driver = WebHook.driver;
        }
        IWebElement enterState => driver.FindElement(By.XPath("//*[@id='country']"));
        IWebElement quickReg => driver.FindElement(By.XPath("//*[@id='headingTwo']/a"));
        IWebElement closeNoticeBox => driver.FindElement(By.XPath("//*[@id='modal_panel']/button"));
        IWebElement choseStripe => driver.FindElement(By.CssSelector("#stripes"));
        IWebElement storePickup => driver.FindElement(By.XPath("//*[@id='shipping_store']"));
        IWebElement completeOrder => driver.FindElement(By.XPath("//*[@id='btn_order']"));
        IWebElement enterCardDetails => driver.FindElement(By.XPath("//*[@id='container']/section/span[2]/div/div/main/div/header/div[2]/div/div[2]"));

        public void EnterState(string StateCountry)
        {
            enterState.SendKeys(StateCountry);
        }
        public void QuickReg()
        {
            quickReg.Click();
        }
        public void CloseNoticeBox()
        {
            closeNoticeBox.Click();
        }
        public void ChoseStripe()
        {
            choseStripe.Click();
        }
        public void StorePickup()
        {
            storePickup.Click();
        }
        public void CompleteOrder()
        {
            completeOrder.Click();
        }
        public bool DisplayPaymentPage()
        {
            return enterCardDetails.Displayed;
        }

    }   
}
