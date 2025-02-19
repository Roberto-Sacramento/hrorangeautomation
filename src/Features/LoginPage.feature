Feature: BasePage

Scenario: Access the Home page
	Given I navigate to Login page 
	When I logged with following credentials Admin, admin123
	Then I should see the Home page
	