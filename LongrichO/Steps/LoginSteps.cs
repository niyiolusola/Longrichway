using LongrichO.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace LongrichO.Steps
{
    [Binding]
    public class LoginSteps
    {
        LoginPage _loginPage;
        public LoginSteps()
        {
            _loginPage = new LoginPage();
        }

        [When(@"the user enters Email AddressLog ""(.*)""")]
        public void WhenTheUserEntersEmailAddressLog(string EmailAddressLog)
        {
            _loginPage.EnterEmail(EmailAddressLog);
        }

        [When(@"the user clicks on Login button")]
        public void WhenTheUserClicksOnLoginButton()
        {
            _loginPage.ClickLogin();
        }

        [When(@"the user enters Password for Login ""(.*)""")]
        public void WhenTheUserEntersPasswordForLogin(string Password)
        {
            _loginPage.EnterPasswordLog(Password);
        }

        [When(@"the user clicks on the Login button")]
        public void WhenTheUserClicksOnTheLoginButton()
        {
            _loginPage.ClickLoginButton();
        }

        [Then(@"the user account checkout is displayed")]
        public void ThenTheUserAccountCheckoutIsDisplayed()
        {
            _loginPage.CheckOutIsDisplayed();
        }



    }
}

