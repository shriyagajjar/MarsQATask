Feature:Login
In order to add my Profile Details
As a Seller I want to be able to login to profile 

Scenario: Sign up
	Given Navigate to URL
	And click join bution 
	Then add valid details to create account 

Scenario:valid Login 
	Given click sign in 
	When enter valid Username,Password 
	And click login 
	Then User should be sign in 
	And seller Name should be seen on the profile Page 
	Examples: 
	| email                    | password    |
	| Shriya1.gajjar@gmail.com | Shriya@2906 |

Scenario:InValid Login 
	Given Navigate to the Login page
	When Login with invalid Username,password 
	Then User Should not able to sign in
	And shows error message 
	Examples: 
	| email                | password |
	| Shr.gajjar@gmail.com | Shri9845 |