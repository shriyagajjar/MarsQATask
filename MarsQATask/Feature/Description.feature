Feature: Description
In order to add my Profile Details
As a Seller I want to be able to add DESCRIPTION 

Scenario:Add/Edit DESCRIPTION to profile page
	Given Login with given Url
	And click description Add/Edit icon on profile page
	And Enter description about 600 or less characters
	When click save button to save and display saved description