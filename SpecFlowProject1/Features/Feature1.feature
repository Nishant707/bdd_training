Feature: Login

A short summary of the feature
In Order to maintain the Employee Records
As a User
I want to login into the portal

@high @valid
Scenario: Valid Credential
	Given I have browser with OrangeHrm Page
	When I enter username as 'Admin'
	And I enter password as 'admin123'
	And I click on login
	Then I should be navigate to 'PIM' dashboard screen

@low @invalid
Scenario Outline: Invalid Crredential
	Given I have browser with OrangeHrm Page
	When I enter username as '<username>'
	And I enter password as '<password>'
	And I click on login
	Then I should get error message as 'Invalid credentials'
	Examples: 
	| username | password |
	| shyam    | pass     |
	| ram      | pass123  |