Feature: Calculadora
	A calculator with basics mathematics operations.
	Calculate the sum of two numbers.
	Calculate the substract of two numbers.
	Calculate the multiply of two numbers.
	Calculate the multiplication of two numbers.

Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have also entered 70 into the calculator
	When I press the sum button
	Then the result should be 120 on the screen


Scenario: Substract two numbers
	Given I have entered 7 into the calculator
	And I have also entered 5 into the calculator
	When I press the subtracts button
	Then the result should be 2 on the screen

Scenario: Divide two numbers
	Given I have entered 4 into the calculator
	And I have also entered 2 into the calculator
	When I press the divide button
	Then the result should be 2 on the screen

Scenario: Multiply two numbers
	Given I have entered 2 into the calculator
	And I have also entered 2 into the calculator
	When I press the multiply button
	Then the result should be 4 on the screen
