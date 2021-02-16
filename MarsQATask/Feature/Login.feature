Feature:Login
In order to add my Profile Details
As a Seller I want to be able to login to profile 

Scenario:valid Login 
	Given Navigate to given URL
	And click sign in to open login 
	When Login with valid Username,Password  
	And verify user name should be seen on the profilePage 
	Examples: 
	| email                    | Password    |
	| Shriya1.gajjar@gmail.com | Shriya@2906 |

