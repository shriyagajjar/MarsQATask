Feature: AddLanguages
In order to add my Profile Details
As a User I want to be able to add languages

Background:
	Given User is using chrome browser
	When Navigate to "http://localhost:5000/Home" url
	And Enter valid login credentials "shriya1.gajjar@gmail.com" and "Shriya@2906"
	Then verify user is logged in 

Scenario Outline:Add Language to the profile
	Given User click Languages tab in profile page
	And User click Add New button
	When add new language < Language > and < LanguageLevel >
	Then language should be added

	Examples:
		| Language | LanguageLevel |
		| English  | Conversational  |

