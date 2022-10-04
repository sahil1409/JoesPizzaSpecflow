Feature: Cart

Cart page should open up after adding a pizza to the cart.

@tag1
Scenario: Adding pizza to cart
	Given Navigate to homepage of website
	When I click Add to cart for a pizza
	Then Cart page open
