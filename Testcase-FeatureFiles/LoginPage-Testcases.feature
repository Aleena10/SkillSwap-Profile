Feature: Testcases-Login
	In order to login to my account
	With same credentials
	
@Login Functionality Tests
Scenario: User attempts to log in from homepage successfully

	Given the user have home page opened
	And  have clicked on Signin link from the top right side
	Then the user should be navigated to the Login Module
	And the user clicks on Login button after inputting the valid email address and password
	Then the user should be logged in successfully in the website

Scenario: User views the appropriate error messages when attempts to login with no valid inputs

	Given the user have home page opened
	And  have clicked on Signin link from the top right side
	Then the user should be navigated to the Login Module
	When the user clicks on Login button with no valid inputs in the respective fields
	Then the user should be able to see the appropriate error messages

Scenario: User receives an email verification link when attempts to login with new email ID

	Given the user have home page opened
	And  have clicked on Signin link from the top right side
	Then the user should be navigated to the Login Module
	And the user clicks on Login button after entering the new valid email ID and password
	Then the user should be able to see the appropriate pop up message
	And the user clicks on Send Verification Email button 
	Then the appropriate error message should be displayed

Scenario: Verification of Forgot password functionality 

	Given the user have home page opened
	And  have clicked on Signin link from the top right side
	Then the user should be navigated to the Login Module
	When the user clicks on Forgot Password link
	Then the user should be navigated to the Email Verification Module
	When the user clicks on Send verificatin Email link with no valid input
	Then the user should see the appropriate alert message
	When the user clicks on Send verification Email link after entering valid email address
	Then the user should receive an email link for setting up a new password. 

Scenario: Verification of Remember your password functionality 
    Given the user have home page opened
	And  have clicked on Signin link from the top right side
	Then the user should be navigated to the Login Module
	When the user clicks on Forgot Password link
	Then the user should be navigated to the Email Verification Module
	When the user clicks on Remember Your Password Link
	Then the user should be navigated to the login module

Scenario: Verification of Haven't got an account?Join! link functionality

	Given the user have home page opened
	And  have clicked on Signin link from the top right side
	Then the user should be navigated to the Login Module
	When the user clicks on Haven't got an account? Join! link
	Then the user should be navigated to the Sign Up Module
