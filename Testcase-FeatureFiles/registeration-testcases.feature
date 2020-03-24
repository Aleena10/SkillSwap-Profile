Feature: Register new profile
	In order to login to the Skillswap website
	As a new user
	I want to be registered in the website 
	
@Registration Functionality Tests
Scenario: User is verified through email link after successful signup

	Given the user successfully signs up in a website
	And the user clicks on a link in an email address to get verified
	Then the user should be navigated to the login page
	When the user clicks on a login button after entering valid inputs
	Then the user should be successfully logged in the website.

Scenario: User attempts to register with no values in FirstName field

	Given the user have registration page opened
	And the user have entered the valid inputs in all the fields except the FirstName field and left it blank
	Then the user becomes unable to click on Join button

Scenario: User attempts to register with no values in LastName field

	Given the user have registration page opened
	And the user have entered the valid inputs in all the fields except the LastName field and left it blank
	Then the user becomes unable to click on Join button

Scenario: User attempts to register with no values in Email field

	Given the user have registration page opened
	And the user have entered the valid inputs in all the fields except the Email field and left it blank
	Then the user becomes unable to click on Join button

Scenario: User attempts to register with no values in Password field

	Given I have registration page opened
	And I have entered the valid inputs in all the fields except the Password field and left it blank
	Then the user becomes unable to click on Join button

Scenario: User attempts to register with no values in Confirm Password field

	Given the user have registration page opened
	And the user have entered the valid inputs in all the fields except the Confirm Password field and left it blank
	Then the user becomes unable to click on Join button

Scenario: User attempts to register without ticking the T&C checkbox

	Given the user have registration page opened
	And the user have entered all the valid inputs in all the fields 
	Then the user becomes unable to click on Join button

Scenario: User attempts to register with invalid Email ID

	Given the user have registration page opened
	And the user have entered valid inputs in all the fields except Email ID
	And the user have entered special characters in an Email field
	Then the appropriate error message should be displayed 
	And the user becomes unable to click on Join button

Scenario: User attempts to register with the known Email ID

	Given the user have registration page opened
	And the user have entered valid inputs in all the fields 
	And the user have entered used an Email ID which is already registered
	Then the appropriate error message should be displayed 
	And the user becomes unable to click on Join button

Scenario: User attempts to go to login page from SignUp page

	Given the user have registration page opened
	And the user have clicked on Login hyperlink
	Then the user should be navigated to the login page

Scenario: User attempts to go to Terms and Conditions page

	Given the user have registration page opened
	And the user have clicked on Terms and Conditions hyperlink
	Then the user should be navigated to the T&C page in a new tab
