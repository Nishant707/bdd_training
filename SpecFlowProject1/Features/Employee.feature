Feature: Employee

A short summary of the feature

@tag1
Scenario Outline: Add valid employee
Given I have browser with OrangeHrm Page
When I enter username as 'Admin'
And I enter password as 'admin123'
And I click on login
And I click on PIM
And I click on Add Employee
And I fill the add employee section
	| firstname   | middlename   | lastname | employee_id | toggle_login_detail | username       | password           | confirm_password   | status   |
	| <firstname> | <middlename> | <lname>  | <empid>     | <toggle_login>      | <account_user> | <account_password> | <confirm_password> | <status> |
And I click on save employee
And I should navigate to add personal detail section with added employee
Examples: 
	| username | password | firstname | middlename | lname | empid | toggle_login |account_user | account_password | confirm_password | status   |
	| Admin    | admin123 | Nishant   | j          | Bhat  | 1001  | on           | nishant     | Welcome@123      | Welcome@123      | disabled |