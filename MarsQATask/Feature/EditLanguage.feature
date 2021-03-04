Feature: EditLanguage
In order to add my Profile Details
As a User I want to be able to Edit languages

Background:
	Given using chrome browser
	When User navigate to "http://localhost:5000/Home" url
	And User is Enter the valid login credentials "shriya1.gajjar@gmail.com" and "Shriya@2906"
	Then verify user to logged in 

	Scenario Outline:Edit language successfully
	Given User is  click on the Languages tab in profile page
	And User is click on Edit button
	When User update Language information < LanguageLevel >
	Then updated detail should be visible on the Languages page

	Examples:
		| Language | LanguageLevel |
		| English  | Fluent        |

