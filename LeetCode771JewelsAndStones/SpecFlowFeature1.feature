Feature: Jewels and Stones


@mytag
Scenario Outline: NumJewelsInStones
	Given I have entered J <J> into the solution
	And I have entered S <S> into the solution
	When I press NumJewelsInStones
	Then the result should be <result> on the screen

	Examples: 
	| J  | S       | result |
	| aA | aAAbbbb | 3      |
	| z  | ZZ      | 0      |
