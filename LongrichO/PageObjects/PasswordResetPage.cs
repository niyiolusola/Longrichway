using LongrichO.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LongrichO.PageObjects
{
    class PasswordResetPage
    {
        IWebDriver driver;

        public PasswordResetPage()
        {
            driver = WebHook.driver;
        }

        IWebElement _lostPassword => driver.FindElement(By.XPath("//*[@id='loginbox']/form/p[4]/a"));
        IWebElement _resetPassword => driver.FindElement(By.XPath("//*[@id='btn_resetpass']"));
        IWebElement _emailAddressRes => driver.FindElement(By.XPath("//*[@id='emailaddressres']"));
        IWebElement _resetSuccessNotice => driver.FindElement(By.XPath("//*[@id='dialoguetext']"));

        public void ClickLostPassword()
        {
            _lostPassword.Click();
        }

        public void ClickResetPassword()
        {
            _resetPassword.Click();
        }

        public void EnterEmailAddressRes(string EmailAddressRes)
        {
            _emailAddressRes.SendKeys(EmailAddressRes);
           
        }

        public bool SuccessNotice()
        {
            return _resetSuccessNotice.Displayed;   
                
        }
        
        
    }

  
}
