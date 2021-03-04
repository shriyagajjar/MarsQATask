Feature: Skills
In order to add my Profile Details
As a User I want to be able to add Skills

Scenario Outline:Add Skills to the profile
	Given User clicks on the Skills tab in profile page
	And User clicks on Add New button
	When User add new skills < Skill > and < Level >
	Then The should be added to the Skills page

	Examples:
		| Skill   | Level        |
		| Testing | intermidiate |

Scenario Outline:Edit Skills successfully
	Given User clicks on the Skills tab in profile page
	And User click on Edit button
	When User update the Skills information < Level >
	Then that updated details should be visible on the Skills page

	Examples:
		| Skill   | Level  |
		| Testing | Expert |

Scenario Outline:Delete Skill successfully
	Given User clicks on the Skills tab in profile page
	When User click on Delete button
	Then that Skills should not be visible on the Skills page