Feature: Registration
	As am intending user of longrichway.com
	I want to register a new account
	so I can buy product

@mytag
Scenario: Valid Registration
	Given that the user navigates to "https://longrichway.com"
	When the user clicks on Register button
	And the user enters First Name "Firstname"
	And the user enters Last Name "Lastname"
	And the user enters Email Address "bimpeolusola@yahoo.com"
	And the user enters Phone "07587717121"
	And the user enters Password "P@ssw0rd"
	And the user enters confirm Password "P@assw0rd"
	And the user enters Address "22 Coronation Road"
	And the user enters Town/City "Mexborough"
	And the user enters State "Scotland"
	And the user clicks on Create Account
	Then the user gets an account successfully created message 