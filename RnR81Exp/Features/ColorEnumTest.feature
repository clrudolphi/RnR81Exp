Feature: Color Enum Testing


Scenario: Using the the full TypeName a color enum will disambiguate conflicting enum names
	Given the color of 'Red'
	Then the color of 'Black' should be OK

