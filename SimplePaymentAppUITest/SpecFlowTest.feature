Feature: SpecFlowTest
	Add information into card form

@mytag
Scenario: Fill the form
	Given I fill the Name
	And I fill also the Card Number
	When I press pay now
	Then the result should be the notification on the screen
