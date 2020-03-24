Feature: AddDetails
	In order to login to the Skillswap website
	As a new user
	Update my profile as a skill seeker
    check the profile of a skill trader

	@User Updates own Profile and views sellers profile
Scenario: Non-logged-in skill seeker views Traders profile detials and updaes his/her profile.
	Given a user views traders profile by seeking skill from homepage search
	And he logs into his account to update his profile
	When a user clicks on Profile Tab
	Then he is navigated to his profile section to update and eventually logs out
