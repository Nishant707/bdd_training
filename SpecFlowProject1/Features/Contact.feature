Feature: Contact

A short summary of the feature

@tag1
Scenario Outline: Add emergency contact
Given I have browser with OrangeHrm Page
When I enter username as 'Admin'
And I enter password as 'admin123'
And I click on login
And I click on My Info
And I click on emergency contact section
And I click on add Assigned Emergency Contacts
And I fill emergency contact details
	| name   | relationship   | home_telephone   | mobile   | work_telephone   |
	| <name> | <relationship> | <home_telephone> | <mobile> | <work_telephone> |
And I click on save emergency contact	
Then I should be navigated to view emergency contact section
Examples: 
	| username | password | name    | relationship | home_telephone | mobile     | work_telephone |
	| Admin    | admin123 | Sushant | Brother      | 122233         | 9898978654 | 77777          |
	| Admin    | admin123 | Prayut  | Brother      | 334455         | 9898978854 | 99999          |

