using LongrichO.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LongrichO.PageObjects
{
    class LoginPage
    {
        IWebDriver driver;

        public LoginPage()
        {
            driver = WebHook.driver;
        }

        IWebElement _ok => driver.FindElement(By.XPath("/html/body/div[4]/div/div[3]/button[1]"));
        IWebElement _login => driver.FindElement(By.XPath("//*[@id='header']/div[2]/div[1]/div/div[1]/div[2]/div[4]/div[1]/a/span"));
        IWebElement _emailAddressLog => driver.FindElement(By.XPath("//*[@id='emailaddress']"));
        IWebElement _passwordLog => driver.FindElement(By.Id("password"));
        IWebElement _loginButton => driver.FindElement(By.XPath("//*[@id='btn_login']"));
        IWebElement _checkOut => driver.FindElement(By.XPath("//*[@id='page_header']/div[4]/div/div/div[2]/div/h2"));

        public void ClickOk()
        {
            _ok.Click();
        }

        public void ClickLogin()
        {
            _login.Click();
        }
        public void EnterEmail(string EmailAddressLog)
        {
            _emailAddressLog.SendKeys(EmailAddressLog);
        }
        public void EnterPasswordLog(string Password)
        {
            _passwordLog.SendKeys(Password);
        }
        public void ClickLoginButton()
        {
            _loginButton.Click();
        }
        public bool CheckOutIsDisplayed()
        {
            return _checkOut.Displayed;
        }
        //{
        //    return _
        //}

    }
}
