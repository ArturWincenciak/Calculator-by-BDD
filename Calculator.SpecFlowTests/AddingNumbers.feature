Feature: AddingNumbers

	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of few numbers

@Adding
Scenario: Add two equal numbers
	Given I have entered 2 into the calculator
	When I press plus
	Given I have entered 2 into the calculator
	When I press equal
	Then the result should be 4 on the screen

	Scenario: Add two diffirent numbers
	Given I have entered 7 into the calculator
	When I press plus
	Given I have entered 12 into the calculator
	When I press equal
	Then the result should be 19 on the screen

Scenario: Add three numbers
	Given I have entered 2 into the calculator
	When I press plus
	Given I have entered 3 into the calculator
	When I press plus
	Given I have entered 4 into the calculator
	When I press equal
	Then the result should be 9 on the screen

Scenario: Adding one several time
	Given I have entered 1 into the calculator
	When I press plus
	Given I have entered 1 into the calculator
	When I press equal
	When I press equal
	When I press equal
	When I press equal
	When I press equal
	When I press equal
	Then the result should be 7 on the screen

Scenario: Adding seven several time
	Given I have entered 1 into the calculator
	When I press plus
	Given I have entered 7 into the calculator
	When I press equal
	When I press equal
	When I press equal
	When I press equal
	Then the result should be 29 on the screen

@Multiplying
Scenario: Multiply two numbers
	Given I have entered 3 into the calculator
	When I press asterisk
	Given I have entered 3 into the calculator
	When I press equal
	Then the result should be 9 on the screen

Scenario: Multiply two several time
	Given I have entered 2 into the calculator
	When I press asterisk
	Given I have entered 2 into the calculator
	When I press equal
	When I press equal
	When I press equal
	When I press equal
	When I press equal
	When I press equal
	Then the result should be 128 on the screen

@Subtraction
Scenario: Substruction two numbers
	Given I have entered 4 into the calculator
	When I press minus
	Given I have entered 1 into the calculator
	When I press equal
	Then the result should be 3 on the screen
