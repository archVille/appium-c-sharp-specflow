Feature: AppiumTest

@smoke
Scenario: A simple appium test
	Given I enter email and password
	| email | passw |
	| test  | test  |
	And I select the currency drop down
	Then I verify the currency type