using LongrichO.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace LongrichO.Steps
{
    [Binding]
    public class PasswordResetSteps
    {
        PasswordResetPage passwordResetPage;
        //[Given(@"a user navigates to ""(.*)""")]
        //public void GivenAUserNavigatesTo(string p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}
        public PasswordResetSteps()
        {
            passwordResetPage = new PasswordResetPage();
        }
        
            
        
        [When(@"the user clicks on Lost your Password\?")]
        public void WhenTheUserClicksOnLostYourPassword()
        {
            passwordResetPage.ClickLostPassword();
        }
        
        [When(@"the user clicks on Reset Password")]
        public void WhenTheUserClicksOnResetPassword()
        {
            passwordResetPage.ClickResetPassword();
        }

        [When(@"the user enters Email AddressRes ""(.*)""")]
        public void WhenTheUserEntersEmailAddressRes(string EmailAddressRes)
        {
            passwordResetPage.EnterEmailAddressRes(EmailAddressRes);
        }

        [Then(@"the Success Notification message should be dispalayed")]
        public bool ThenTheSuccessNotificationMessageShouldBeDispalayed()
        {
            return passwordResetPage.SuccessNotice();
        }
    }
}
