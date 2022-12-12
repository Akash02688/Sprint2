Feature: Myaccount

A short summary of the feature

@tag1
Scenario: To validate user is able to make updates in My account.
	Given Open Browser and enter url for the website.
	When user enters userid and password
	And clicks on login button.
	And clicks on My account.
	And user able to update details.
	And clicks on save.
	Then user is able to update successfully.
