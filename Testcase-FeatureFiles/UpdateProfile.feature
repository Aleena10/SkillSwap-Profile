Feature: UpdateProfile
	In order to login to the Skillswap website
	As a new user
	I want to be registered in the website 
	And Update my profile as a skill seeker

@Profile Update
Scenario: Verify if user is able to add description

	Given the user have signed in & profile page opened
	When the user adds a description in the field and save
	Then the added details should be reflected.

Scenario: Verify if user is able to add languages

	Given the user have signed in & profile page opened
	When the user adds a language in the field and save
	Then the added language should be reflected.

Scenario: Verify if user is able to add skills

	Given the user have signed in &  profile page opened
	When the user adds a skill in the field and save
	Then the added skill should be reflected.

Scenario: Verify if user is able to add education

	Given the user have signed in &  profile page opened
	When the user adds an education in the field and save
	Then the added education should be reflected.

Scenario: Verify if user is able to add certifications

	Given the user have signed in &  profile page opened
	When the user adds certification in the field and save
	Then the added certification should be reflected.

@Edit Profile
Scenario: Verify if user is able to Edit description

	Given the user have signed in &  profile page opened
	When the user updates details in the description field and save
	Then the updated details should be reflected.

	@mytag
Scenario Outline: Edit a language details
	Given a web browser is on the Profile page
	And the Languages tab has been selected
	And the languages list has at least <listPosition> languages
	When the user clicks on the edit language button in position <listPosition>
	And the user updates the "<languageName>" and <levelId> of the language
	Then that updated "<languageName>" and "<levelValue>" should be displayed in position <listPosition>



Scenario: Verify if user is able to Edit skills

	Given the user have signed in &  profile page opened
	When the user updates skills in the language field and save
	Then the updated skill should be reflected.

Scenario: Verify if user is able to update education

	Given the user have signed in &  profile page opened
	When the user updates education in the language field and save
	Then the updated education should be reflected.

Scenario: Verify if user is able to Update certifications

	Given the user have signed in &  profile page opened
	When the user updates certification in the language field and save
	Then the updated certification should be reflected.

@Delete Profile
Scenario: Verify if user is able to Delete description

	Given the user have signed in &  profile page opened
	And  have clicked on pencil sign adjacent to the Description copy
	And removes the details from the description box
	When the user clicks on Save button with no input in the box 
	Then the user should see the prompt message to add details
	When the user clicks on Save button after entering details 
	Then the user should be able to see the prompt success message
	And the newly added details should be displayed below the description copy

@mytag
Scenario Outline: Delete a language
	Given a web browser is on the Profile page
	And the Languages tab has been selected
	And the languages list has at least <listPosition> languages
	When the user clicks on the delete language button at <listPosition>
	Then that language should not be displayed on the profile

Scenario: Verify if user is able to Delete skills
	Given the user have signed in &  profile page opened
	When the user clicks on cross mark for any skills in the skills tab
	Then the user should be able to see the prompt success message
	And the details should be removed from the respective section

Scenario: Verify if user is able to Delete Education

	Given the user have signed in &  profile page opened
	When the user clicks on cross mark for any education in the education tab
	Then the user should be able to see the prompt success message
	And the details should be removed from the respective section

Scenario: Verify if user is able to Delete Certification

	Given the user have signed in &  profile page opened
	When the user clicks on cross mark for any certification in the certification tab
	Then the user should be able to see the prompt success message
	And the details should be removed from the respective section
