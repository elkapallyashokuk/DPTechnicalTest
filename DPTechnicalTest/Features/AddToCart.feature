Feature: Verify cart functionality

Scenario: Add items to the cart and verify the count
    Given I am on the shopping website
    When I Add four items to cart
    And I view my cart
    Then I should find a total of four items in my cart
    When I search for the lower priced item
    And I remove the lowest price item from my cart
    Then I verify three items in my cart


