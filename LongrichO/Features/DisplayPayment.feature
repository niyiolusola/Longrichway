Feature: DisplayPayment
	As a registered user of longrichway.com
	I want to login into my account after filling ny basket
	So I can view the payment page

@mytag
Scenario: Display payment page
	Given that the user navigates to "https://longrichway.com"
	And the user clicks on OK to accept country
	When the user clicks on Categories
	And the user clicks "Feminine Care"
	And the user selects preferred product
	And the user enters quantity of product "5"
	And the user clicks on Add to Cart
	And the user clicks on the shopping basket
	And the user clicks on checkout
	#And the checkout page is displayed
	And the user enters Email AddressLog "niyiolusola@outlook.com"
	And the user enters Password for Login "aebdkdhn"
	When the user clicks on the Login button
	Then the payment page should be displayed 