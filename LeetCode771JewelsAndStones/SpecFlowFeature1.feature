Feature: Jewels and Stones


@mytag
Scenario: NumJewelsInStones
	Given I have entered J aA into the solution
	And I have entered S aAAbbbb into the solution
	When I press NumJewelsInStones
	Then the result should be 3 on the screen
