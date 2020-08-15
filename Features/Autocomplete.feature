Feature: Autocomplete
	In fill the address form
	As a user
	I want the webpage to autocomplete the data

@Browser_Firefox
@Browser_Chrome
Scenario Outline: Autocomplete the valid address
	Given I am on the Autocomplete page
	When I enter <address> in address field
	Then I can select autocomplete suggestion

	Examples: 
	| address                                          |
	| 1553 Shawson Drive, Mississauga, Ontario, Kanada |
	| Dolnych Młynów 10, Kraków, Polska                |
	| Wuhe County, Bengbu, Chiny, 233333               |