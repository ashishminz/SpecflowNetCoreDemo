﻿Feature: Login
     Login to Vtiger Application

@smoke
Scenario: Perform Login to Vtiger Application
	Given I launch the application
	And I enter the following details
	       | Username | Password |
	       | admin    | admin    |
	And I click the login button
	Then I should be on the homepage of the vtiger website
