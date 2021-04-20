//using AssertLibrary;
using FluentAssertions;
using LongrichO.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace LongrichO.Steps
{
    [Binding]
    public class RegistrationSteps
    {

        RegistrationPage _registrationPage;
        public RegistrationSteps()
        {
            _registrationPage = new RegistrationPage();
        }

        [Given(@"that the user navigates to ""(.*)""")]
        public void GivenThatTheUserNavigatesTo(string url)
        {
            _registrationPage.Navigate(url);
        }
        
        [When(@"the user clicks on Register button")]
        public void WhenTheUserClicksOnRegisterButton()
        {
            _registrationPage.ClickReg();
        }
        
        [When(@"the user enters First Name ""(.*)""")]
        public void WhenTheUserEntersFirstName(string FirstNameText)
        {
            _registrationPage.EnterFirstName(FirstNameText);
        }
        
        [When(@"the user enters Last Name ""(.*)""")]
        public void WhenTheUserEntersLastName(string LastNameText)
        {
            _registrationPage.EnterLastName(LastNameText);
        }
        
        [When(@"the user enters Email Address ""(.*)""")]
        public void WhenTheUserEntersEmailAddress(string EmailAddress)
        {
            _registrationPage.EnterEmail(EmailAddress);
        }
        
        [When(@"the user enters Phone ""(.*)""")]
        public void WhenTheUserEntersPhone(string Phone)
        {
            _registrationPage.EnterPhone(Phone);
        }
        
        [When(@"the user enters Password ""(.*)""")]
        public void WhenTheUserEntersPassword(string Password)
        {
            _registrationPage.EnterPassword(Password);
        }
        
        [When(@"the user enters confirm Password ""(.*)""")]
        public void WhenTheUserEntersConfirmPassword(string CoPassword)
        {
            _registrationPage.EnterCoPassword(CoPassword);
        }
        
        [When(@"the user enters Address ""(.*)""")]
        public void WhenTheUserEntersAddress(string Address)
        {
            _registrationPage.EnterAddress(Address);
        }
        
        [When(@"the user enters Town/City ""(.*)""")]
        public void WhenTheUserEntersTownCity(string TownCity)
        {
            _registrationPage.EnterTownCity(TownCity);
        }
        
        [When(@"the user enters State ""(.*)""")]
        public void WhenTheUserEntersState(string State)
        {
            _registrationPage.EnterState(State);
        }
        
        [When(@"the user clicks on Create Account")]
        public void WhenTheUserClicksOnCreateAccount()
        {
            _registrationPage.ClickCreateAccount();
        }
        
        [Then(@"the user gets an account successfully created message")]
        public bool ThenTheUserGetsAnAccountSuccessfullyCreatedMessage()
        {
            return _registrationPage.SuccessNotificationDisplayed();
            //Assert.IsTrue(_registrationPage.SuccessNotificationDisplayed());
            //_registrationPage.SuccessNotificationDisplayed().Should().BeTrue();
        }

    }
}
