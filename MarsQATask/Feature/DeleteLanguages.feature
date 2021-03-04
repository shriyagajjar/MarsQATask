Feature: DeleteLanguages
In order to add my Profile Details
As a User I want to be able to Delete languages

Background:
	Given open chrome browser
	When User is navigates to "http://localhost:5000/Home" url
	And  Enter the valid login credentials "shriya1.gajjar@gmail.com" and "Shriya@2906"
	Then verify user is able to logged in 

	Scenario Outline: Delete Language successfully
	Given User is click on the Languages tab in profile page
	When User is click on the Delete button
	Then Languages should be deleted on the Languages page