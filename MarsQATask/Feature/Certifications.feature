Feature: Certifications
	In order to add my Profile Details
As a User I want to be able to add Certifications

Background:
	Given Using chrome browser
	When user is Navigate to "http://localhost:5000/Home" url
	And Enter valid login credential "shriya1.gajjar@gmail.com" and "Shriya@2906"
	Then verify user logged in 

Scenario Outline:Add Certificate 
	Given user clicks on the Certificate tab in profile page
	And User click on the Add New button
	When User add new Certificate  < Certificate >,< CertificateFrom > and < Year >
	Then certificate details added to the Certifications page

	Examples:
		| Certificate | CertificateFrom | Year |
		| ISTQB       | BCS             | 2020 |

Scenario Outline:2 Edit certificate successfully
	Given User is clicks on the Certifications tab in profile page
	And User is clicks on Edit button
	When Update Certifications year < year >
	Then updated detail should be visible on the Certifications page

	Examples:
		| Certificate | CertificateFrom | Year |
		| ISTQB       | BCS             | 2019 |

Scenario Outline:delete certificate successfully
	Given User click on the Certifications tab in profile page
	When User click on the Delete button
	Then certificate should not be visible on the Certifications page