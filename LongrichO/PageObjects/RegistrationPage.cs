using LongrichO.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LongrichO.PageObjects
{
    class RegistrationPage
    {
        //IWebDriver driver = WebHook.driver;
        IWebDriver driver;

        public RegistrationPage()
        {
            driver = WebHook.driver;
        }
        
        IWebElement _registration => driver.FindElement(By.XPath("//*[@id='header']/div[2]/div[1]/div/div[1]/div[2]/div[4]/div[2]/a/span"));
        IWebElement _firstName => driver.FindElement(By.XPath("//*[@id='firstname']"));
        IWebElement _lastName => driver.FindElement(By.XPath("//*[@id='lastname']"));
        IWebElement _emailAddress => driver.FindElement(By.XPath("//*[@id='emailaddressreg']"));
        IWebElement _phone => driver.FindElement(By.XPath("//*[@id='telephone']"));
        IWebElement _password => driver.FindElement(By.XPath("//*[@id='passwordreg']"));
        IWebElement _coPassword => driver.FindElement(By.XPath("//*[@id='cnpassword']"));
        IWebElement _address => driver.FindElement(By.XPath("//*[@id='address']"));
        IWebElement _townCity => driver.FindElement(By.XPath("//*[@id='city']"));
        IWebElement _state => driver.FindElement(By.XPath("//*[@id='state']"));
        IWebElement _createAccount => driver.FindElement(By.XPath("//*[@id='btn_register']"));
        IWebElement _notification => driver.FindElement(By.XPath("//*[@id='dialoguetitle']"));

        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
            //_navigate.GoToUrl(url);
        }

        public void ClickReg()
        {
            _registration.Click();

        }
        public void EnterFirstName(string FirstNameText)
        {
            _firstName.SendKeys(FirstNameText);
        }
        public void EnterLastName(string LastNameText)
        {
            _lastName.SendKeys(LastNameText);
        }
        public void EnterEmail(string EmailAddress)
        {
            _emailAddress.SendKeys(EmailAddress);
        }
        public void EnterPhone(string Phone)
        {
            _phone.SendKeys(Phone);
        }
        public void EnterPassword(string Password)
        {
            _password.SendKeys(Password);
        }
        public void EnterCoPassword(string CoPassword)
        {
            _coPassword.SendKeys(CoPassword);
        }
        public void EnterAddress(string Address)
        {
            _address.SendKeys(Address);
        }
        public void EnterTownCity(string TownCity)
        {
            _townCity.SendKeys(TownCity);
        }
        public void EnterState(string State)
        {
            _state.SendKeys(State);
        }
        public void ClickCreateAccount()
        {
            _createAccount.Click();
        }
        public bool SuccessNotificationDisplayed()
        {
            return _notification.Displayed;
        }



    }
}
    
    
