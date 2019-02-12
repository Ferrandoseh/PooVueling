Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers
	
@mytag
Scenario: Add two numbers
	Given I first have entered 4 into the calculator
	And I have also entered 2 into the calculator
	When I press add
	Then the result should be 6 on the screen

@mytag
Scenario: Substract two numbers
	Given I first have entered 4 into the calculator
	And I have also entered 2 into the calculator
	When I press substract
	Then the result should be 2 on the screen

@mytag
Scenario: Multiply two numbers
	Given I first have entered 4 into the calculator
	And I have also entered 2 into the calculator
	When I press multiply
	Then the result should be 8 on the screen

@mytag
Scenario: Divide two numbers
	Given I first have entered 4 into the calculator
	And I have also entered 2 into the calculator
	When I press divide
	Then the result should be 2 on the screen
