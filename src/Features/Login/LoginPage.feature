Feature: BasePage

Scenario: Access the Home page
	Given I navigate to Login page 
	When I logged on the application
	Then I should see the Home page
	