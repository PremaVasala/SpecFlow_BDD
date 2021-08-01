Feature: BillingOrder
	Simple calculator for adding two numbers

@mytag
Scenario:BiliingOder Scenario
	Given Open Billing Order Page
	When Enter user details
 	And submit user details
	Then Form should be submitted successfully

	@mytag
Scenario: Open Gmail Login
	Given Open Gmail Login page
	When User Enter valid Credentials
 	And submit user details
	Then Successful Login into account

