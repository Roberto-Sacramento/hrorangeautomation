Feature: BasePage

Scenario: Access the Home page
	Given I navigate to Login page 
	When I logged on the application Admin, admin123
	Then I should see the Home page
	