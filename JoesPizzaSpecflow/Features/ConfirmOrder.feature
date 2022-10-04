Feature: ConfirmOrder

This feature will add pizzas to cart and then proceed to checkout and order confirmation.

@tag1
Scenario: Placing an order of multiple pizzas
	Given Navigate to the homepage of website
	When I click Add to cart for any pizza
	And I click Continue Shopping
	Then I add another pizza to cart
	When Cart page comes up click on Checkout
	Then Order is confirmed
