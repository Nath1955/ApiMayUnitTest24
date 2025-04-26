Feature: GetUsers

Api request to get all users

@tag1
Scenario: Get all users request
	Given I have a resource
	When I attempt to retrieve all users
	Then the response code is 200
	And users info is returned successfully
