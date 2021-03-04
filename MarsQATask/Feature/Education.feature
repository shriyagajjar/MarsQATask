Feature: Education
In order to add my Profile Details
As a User I want to be able to add Skills

Background:
	Given User is using the chrome browser
	When User is navigates to "http://localhost:5000/Home" url
	And User enter the valid login credentials "shriya1.gajjar@gmail.com" and "Shriya@2906"
	Then User able to log in to the application

Scenario Outline: 1 Check whether the user is bale to add Education to the profile
	Given User clicks on the Education tab in profile page
	And User clicks on the Add New button
	When User adds a new Education < college/universityname > ,< country >,< Title >,< degree > and < yearofgraduation >
	Then The Education should be added to the Education page

	Examples:
		| college/universityname | country | Title  | degree      | yearofgraduation |
		| GTU                    | India   | B.Tech | engineering | 2016             |

Scenario Outline:2  Check whether the user is able to Edit the added Education successfully
	Given User clicks on the Education tab in profile page
	And User clicks on Edit button
	When User updates the Education year < yearofgraduation >
	Then that updated details should be visible on the Education page

	Examples:
		| college/universityname | country | Title  | degree      | yearofgraduation |
		| GTU                    | India   | B.Tech | engineering | 2015             |

Scenario Outline: 3 Check whether the user is able to Delete the added Education successfully
	Given User clicks on the Education tab in profile page
	When User clicks on the Delete button
	Then that Education should not be visible on the Education page