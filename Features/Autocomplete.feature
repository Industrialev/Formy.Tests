Feature: Autocomplete
	In fill the address form
	As a user
	I want the webpage to autocomplete the data

@Browser_Firefox
@Browser_Chrome
@positive
Scenario Outline: Autocomplete the valid address
	Given I am on the Autocomplete page
	When I enter <address> in address field
	And I select first address from autosuggestion list
	Then I should not see list with autocomplete suggestions

	Examples: 
	| address                                          |
	| 1553 Shawson Drive, Mississauga, Ontario, Kanada |
	| Dolnych Młynów 10, Kraków, Polska                |
	| Wuhe County, Bengbu, Chiny, 233333               |

	# TODO: How to handle 'I can see' steps?
@Browser_Firefox
@Browser_Chrome
Scenario Outline: Autocomplete with one of proposed addresses
	Given I am on the Autocomplete page
	When I enter only beginning of the address 242
	And I select <id> address from autosuggestion list
	Then I should not see list with autocomplete suggestions
	
	Examples:
	| id     |
	| first  |
	| second |
	| third  |
	| fourth |
	| fifth  |