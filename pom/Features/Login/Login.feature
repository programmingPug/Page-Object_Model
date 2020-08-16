Feature: Login
	In order to use the application
	As a user
	I want to log into the application

Scenario: Log into the application
	Given I am at the login page
	And I have entered my credentials
	When I press login
	Then the I have logged into the application