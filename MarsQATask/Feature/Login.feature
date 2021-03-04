Feature:Login
In order to add my Profile Details
As a Seller I want to be able to login to profile 

@mytag
Scenario Outline:Login with valid Credentials 
	Given User is navigate the URL
	And click on Sign in button to login
	When User enters < Username > and < Password > 
	Then click on login button  

	Examples:
		| Username                 | Password    |
		| Shriya1.gajjar@gmail.com | Shriya@2906 |