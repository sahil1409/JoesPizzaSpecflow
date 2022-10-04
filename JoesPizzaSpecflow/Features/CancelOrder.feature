Feature: CancelOrder

Remving pizza from cart

@tag1
Scenario: Removing pizza from cart
	Given Navigate to home page of website
	When I click Add to cart for pizza
	Then Cart page should open
	When I click on cross icon
	Then Pizza should be removed from cart
