Feature: CheckoutNew
	As an intending user of longrichway.com
	I want to checkout selected products
	So I can complete my order by quick registration

@mytag
Scenario: Verify new user can register at checkout
	Given that the user navigates to "https://longrichway.com"
	When the user clicks on Categories
	And the user clicks "Feminine Care"
	And the user selects preferred product
	And the user enters quantity of product "2"
	And the user clicks on Add to Cart
	And the user clicks on the shopping basket
	And the user clicks on checkout
	And the user clicks New Customer Quick Registration
	And the user enters First Name "Olusegun"
	And the user enters Last Name "Obasanjo"
	And the user enters Email Address "testbabasege+2@gmail.com"
	And the user enters Phone "01302811956"
	And the user enters Password "P@ssw0rd"
	And the user enters confirm Password "P@ssw0rd"
	And the user enters Address "48 Isale Oja Boulevard"
	And the user enters Town/City "Islington"
	And the user enters State/Country "Britain"
	And the user clicks on Create Account
	And the user clicks x to close notification box
	And the user clicks on Login button
	And the user enters Email AddressLog "testbabasege+2@gmail.com"
	And the user enters Password for Login "P@ssw0rd"
	And the user clicks on the Login button
	And the user clicks Stripe button
	And the user clicks Store Pickup button
	And the user clicks complete order
	Then the card enter card detail box should be displayed