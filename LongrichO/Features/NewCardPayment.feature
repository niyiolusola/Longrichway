Feature: NewCardPayment
	Simple calculator for adding two numbers

@mytag
Scenario: Add two numbers
	Given that the user navigates to "https://longrichway.com"
	And the user clicks on OK to accept country
	When the user clicks on Categories
	And the user clicks "Feminine Care"
	And the user selects preferred product
	And the user enters quantity of product "7"
	And the user clicks on Add to Cart
	And the user clicks on the shopping basket
	And the user clicks on checkout
	Then the checkout page is displayed