Feature: CardPayment
	As a registered user of longrichway.com
	I want to view payment options 
	So I can pay for items by card 

@mytag
Scenario: Verify pay by card at checkout
	Given that the user navigates to "https://longrichway.com"
	And the user clicks on OK to accept country
	When the user clicks on Categories
	And the user clicks "Skin Care"
	And the user selects preferred product
	And the user enters quantity of product "5"
	And the user clicks on Add to Cart
	And the user clicks on the shopping basket
	And the user clicks on checkout
	And the user enters Email AddressLog "Oluolu@yahoo.com"
	And the user enters Password for Login "Password"
	And the user clicks on the Login button
	And the user clicks PayStack option
	And the user clicks Home Delivery option
	And the user clicks complete order
	And the user selects the Success Card
	When the user click Pay
	Then payment made successfully message should be displayed