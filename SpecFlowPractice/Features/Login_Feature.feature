Feature: Login_Feature
	In order to access my account
	As a user of the website
	I want to log into the website

@mytag
Scenario Outline: Successfull login with valid credentials
	Given User is at Home page
	And Navigate to Login page	
	When User enter <UserName> and <Password>
	And clicks on login button
	Then Successful LogIn message should display
Examples: 
| UserName       | Password  |
| vinod3404      | vinod9030 |
| vasundhara3404 | vinod3404 |

Scenario: Successful Logout
	When User clicks on logout
	Then Successful LogOut message should display
