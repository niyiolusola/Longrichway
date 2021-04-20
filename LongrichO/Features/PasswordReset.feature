Feature: PasswordReset
	As a registered user of longrichway.com
	I want to get a password reset code
	If I forget my password
	

@mytag
Scenario: Forgetten Password Reset
	Given that the user navigates to "https://longrichway.com"
	When the user clicks on Login button 
	And the user enters Email AddressLog "user@yahoo.com"
	And the user clicks on Lost your Password?
	And the user enters Email AddressRes "user@yahoo.com"
	And the user clicks on Reset Password
	Then the Success Notification message should be dispalayed