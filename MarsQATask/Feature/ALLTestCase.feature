Feature: Seller [] add profile details 
In order to add my Profile Details
As a Seller I want to be able to login to profile 
so that user able to see seller's details on profile page

Acceptance Criteria
● Seller is able to add the Profile Details.
● Seller is able to see the seller’s details on the Profile page.

Scenario: Sign up
	Given I Navigate to Given URL
	Then Create an account with valid details

Scenario:Login Successfully 
	Given I Navigate to the Login page
	When I Login with valid Username,Password 
	Then the User should be sign in 
	And user's Name should be seen on the profile Page 
	Examples: 
	| email                    | password    |
	| Shriya1.gajjar@gmail.com | Shriya@2906 |

Scenario:In Valid Login 
	Given I Navigate to the Login page
	When I Login with invalid Username,password 
	Then the User Should not be sign in
	And seen error message 
	Examples: 
	| email                | password |
	| Shr.gajjar@gmail.com | Shri9845 |

Scenario:Add/Edit DESCRIPTION to profile page
	Given On profile page click description Add/Edit icon  
	And Write about yourself about 596 or less characters in description box
	When click save button to save changes 
	Then it shows notification "Description has been saved successfully" and shows edited description 

Scenario:Add/Edit LANGUAGES to profile page
	Given On profile page click Add new button to add one or more languages
	And Add language in "Add language" Field 
	And Choose Language Level as per your command on that language
	When i click "Add" button 
	Then written language should be added and shown to profile page
	When i click "Cancel" button 
	Then written language should't be added and shown to profile page
	When click on "X" icon to added languages 
	Then it should be deleted from the languages 
	When click on "edit" icon to added languages
	Then user should able to edit before added languges 

Scenario:Add/Edit SKILLS to profile page
	Given Click on skills field 
	And On profile page click Add new button to add one or more Skills
	And Add language in "Add Skill" Field 
	And Choose Skill Level as per your Knowledge 
	When i click "Add" button 
	Then written Skill should be added and shown to profile page
	When i click "Cancel" button 
	Then written Skill should't be added and shown to profile page 
	When click on "X" icon to added Skill 
	Then it should be deleted from the Skill
	When click on "edit" icon to added Skill
	Then user should able to update before added Skill 

Scenario:Add/Edit CERTIFICATES to profile page
    Given Click Certificates field on profile page  
	And click Add new button to add one or more Certificate
	And enter name of certificate in "Certificate " box 
	And enter source from you got certificate in "certified from" Field 
	And select year when you got certificate 
	When i click "Add" button 
	Then written Certificate should be added and shown to profile page
	When i click "Cancel" button 
	Then written Certificate should't be added and shown to profile page 
	When click on "X" icon to added Certificate 
	Then it should be deleted from the Certificate
	When click on "edit" icon to added Certificate
	Then user should able to update before added Certificate 


Scenario:Add/Edit EDUCATION to profile page
    Given Click Education field on profile page
	And click Add new button to add one or more Education 
	And enter name of college/university in "College/university" Field 
	And select country of college and title  
	And enter name of degree in "degree" field 
	And select year of graduation
	When i click "Add" button 
	Then written Education should be added and shown to profile page
	When i click "Cancel" button 
	Then written Education should't be added and shown to profile page 
	When click on "X" icon to added Education 
	Then it should be deleted from the Education
	When click on "edit" icon to added Education
	Then user should able to update before added Education 


Scenario:Add/Edit AVAIBILITY to profile page
	Given  default Avaibility  
	And click on edit Avaibility button 
	When select one of given options from dropdown 
	Then it should be updated Avaibility on profile page 


Scenario:Add/Edit HOURS to profile page
    Given  default hours 
	And click on edit hours button 
	When select one of given options from dropdown 
	Then it should be updated hours on profile page 


Scenario:Add/Edit EARN TARGET to profile page
	Given  default target 
	And click on edit target button 
	When select one of given options from dropdown 
	Then it should be updated target on profile page 

Scenario: LOGOUT Successfully
	Given On profile page 
	When click on "Sign Out" button from profile page
	Then used should logout successfull 
	And navigate to MarQa home Page 
	And shows sign in ,join options