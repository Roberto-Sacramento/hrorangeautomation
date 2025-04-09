Feature: PIMSidePanel

 A short summary of the feature


Scenario: Create an ESS User
	Given I navigate to Login page 
	When I logged on the application
	And I create an ESS user with the informations: John, Smith, Silvas
	Then The system should display a sucefully message
