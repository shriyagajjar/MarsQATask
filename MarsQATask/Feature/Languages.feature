Feature: Languages
In order to add my Profile Details
As a Seller I want to be able to add languages 


Scenario:Add/Edit LANGUAGES to profile page
	Given Login to MarsQA with valid credential 
	And click Add new button to add one or more languages
	And enter language in "Add language" Field 
	When Choose Language Level and click "Add" button 
	Then verify that language to profile page
	