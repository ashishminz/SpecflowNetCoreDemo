Feature: Login
     Login to Vtiger Application

@smoke
Scenario: Perform Login to Vtiger Application
	Given I launch the application
	And I enter the following details
	       | Username | Password |
	       | admin    | admin    |
	And I click the login button
	Then I should be on the homepage of the vtiger website
	Then I close the browser

@smoke
Scenario: Perform Login to Vtiger Application using wrong password
	Given I launch the application
	And I enter the following details
	       | Username | Password |
	       | admin    | admin123    |
	And I click the login button
	Then I should be on the loginpage of the vtiger website
	Then I close the browser
