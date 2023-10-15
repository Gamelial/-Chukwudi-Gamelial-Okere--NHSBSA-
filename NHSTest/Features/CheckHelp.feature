Feature: CheckHelp

A short summary of the feature

@tag1
Scenario: UK Test ticket
	Given I navigate to the website						"https://services.nhsbsa.nhs.uk/check-for-help-paying-nhs-costs/start"
	And I Click on Cookies
	And I Click on Start now
	And I Click on Country I Live as Scotland
	And I Click Next
	And I Click do I Live Highlands and Island Yes
	And I Click Next
	And I Click is your Dental Practice in Scotland
	And I Click Next
	And I Enter Day										"20"
	And I Enter Month									"03"
	And I Enter Year									"2000"
	And I Click Next
	And I Click Do I Live with a partner No
	And I Click Next
	And I Click Do You Claim Benefit or tax No
	And I Click Next
	And Click on Are you pregnant No
	And I Click Next
	And Click Do you have any injury No
	And I Click Next
	And I Click Do you live permantly in care home No
	And I Click Next
	And I Click Do you have more than No
	And I Click Next
	And I Click Find out more
	And I Click on Continue
	And I Enter Email												"johne@yahoo.com"
	And I Click on Continuee
	And I Enter the DDays													"10"
	And I Enter the MMonths											        "11"
	And I Enter the YYear												    "2015"
	When I Click on continueee
	Then This displace You Get NHS costs
