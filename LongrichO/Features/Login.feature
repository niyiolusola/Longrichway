Feature: Login
	As a registered user of longrichway.com
	I want to login to my already created account
	so I can view or buy products

@mytag
Scenario: Valid Login
	Given that the user navigates to "https://longrichway.com"
	When the user clicks on Login button
	And the user enters Email AddressLog "niyiolusola@outlook.com"
	And the user enters Password for Login "akbncf8e"
	And the user clicks on the Login button
	Then the user account checkout is displayed