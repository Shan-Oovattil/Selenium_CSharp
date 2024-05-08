Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowBasic/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag @SmokeTest
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be "PASSED"

Scenario Outline: Login module
	Given user types <username> and <password>
	Then  user should be able to login

	Examples: 
	| username | password |
	| user1    | pass1    |
	| user2    | pass2    |

Scenario: Adding following numbers
	Given I enter following input numberss
	| Numbers |
	| 60     |
	| 80     |	
	When the two numbers are added
	Then the result should be "PASSED"


Scenario: Displaying following number
	Given I enter following input number
	| Number |
	| 60     |		
	When the number is displayed
	Then the result should be "PASSED"

Scenario: Adding following Dynamic numbers
	Given I enter following Dynamic input numberss
	| NumbersToAdd |
	| 80     |
	| 10     |	
	When the two numbers are added
	Then the result should be "PASSED"

Scenario: Adding following Dynamic numbers with Extra Paramaters
	Given I enter following Dynamic input numberss
	| NumbersToAdd |
	| 80     |
	| 70     |	
	When the two numbers are added
	Then I see the result and few more details
	| Result | Logo |
	| 150    | plus |
	And the result should be "PASSED"