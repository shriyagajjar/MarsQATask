Feature: Languages
In order to add my Profile Details
As a Seller I want to be able to add languages 


Scenario:Add/Edit LANGUAGES to profile page
	Given Login to MarsQA with valid credential 
	And click Add new button to add one or more languages
	And enter language in "Add language" Field 
	When Choose Language Level and click "Add" button 
	Then language should be added and shown to profile page
	When click "Cancel" button 
	Then written language should't be added and shown to profile page
	When click on "X" icon to added languages 
	Then it should be deleted from the languages 
	When click on "edit" icon to added languages
	Then user should able to edit before added languges 