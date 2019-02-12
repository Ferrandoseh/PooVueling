Feature: Calculator
	I want to make some operations
	Calculate the sum of two numbers
	Calculate the substraction of two numbers
	Calculate the multiplication of two numbers
	Calculate the division of two numbers
	
Scenario: Add two numbers
	Given I first have entered 4 into the calculator
	And I have also entered 2 into the calculator
	When I press add
	Then the result should be 6 on the screen

Scenario: Substract two numbers
	Given I first have entered 4 into the calculator
	And I have also entered 2 into the calculator
	When I press substract
	Then the result should be 2 on the screen

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