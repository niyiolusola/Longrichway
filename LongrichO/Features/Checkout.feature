Feature: Checkout
	As a user of longrichway.com
	I want to add products to the cart
	And view the checkout page

@mytag
Scenario: Verify viewing the checkout page
	Given that the user navigates to "https://longrichway.com"
	When the user clicks on Categories
	And the user clicks "Feminine Care"
	And the user selects preferred product
	And the user enters quantity of product "15"
	And the user clicks on Add to Cart
	And the user clicks on the shopping basket
	And the user clicks on checkout
	Then the checkout page is displayed