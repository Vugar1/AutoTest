Feature: SpecFlowFeature1



Scenario: Go to PersonalCabinet
	Given login page is open
	When I write down username
	And I write down password
	And click button Login
	Then Personal Cabinet is open
