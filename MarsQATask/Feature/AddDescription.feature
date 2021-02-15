Feature: Description
In order to add my Profile Details
As a Seller I want to be able to add DESCRIPTION 


Scenario:Add/Edit DESCRIPTION to profile page
	Given click description Add/Edit icon on profile page 
	And Add description about yourself about 600 or less characters in description box
	When you click save button to save changes 
	Then shows notification "Description has been saved successfully" and shows edited description 



