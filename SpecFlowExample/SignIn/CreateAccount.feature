#Tags are used to mark Features/Scenarios for special handling / organization
@CreateAccount
@Clean
Feature: Create Account
	As a new Starbucks user
	I want to be able to create an account

Scenario: A new User creates a new account
	Given I am on the Sign-In page
	And I click the Create An Account link
	When I fill out the new Account form
	#The step below shows the usage of a 'Global Step' - See GlobalSteps.cs
	And I click the button with the text 'Create An Account'
	Then my account should be created
	And I should be logged in
