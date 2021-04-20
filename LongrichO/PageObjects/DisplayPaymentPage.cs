using LongrichO.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LongrichO.PageObjects
{
    class DisplayPaymentPage
    {
        IWebDriver driver;

        public DisplayPaymentPage()
        {
            driver = WebHook.driver;
        }

        IWebElement paymentPage => driver.FindElement(By.XPath("//*[@id='btn_order']"));

        public bool DisplayPayment()
        {
            return paymentPage.Displayed;
        }
    }
}
