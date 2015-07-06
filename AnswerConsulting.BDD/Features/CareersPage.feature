Feature: CareersPage
	In order to understand the careers at Answer Consulting
	As a prospective employee or graduate
	I want to view the careers section

<<<<<<< HEAD
Background:
	Given I am on the careers section
	  And the heading 'Careers' is displayed
=======
Background: 
     Given I am on the careers section
       And the heading 'Careers' is displayed
>>>>>>> a6fd621e4b8a0f5d81ca132cd84ddb3bd6169333

Scenario: Check the current vacancies
    Given the sub-heading 'Current Vacancies' is displayed
     When I click on the first vacancy
     Then I am taken to the vacancy page
      And 'Strictly no agencies.' is displayed

Scenario: Check the graduate scheme information
    Given the sub-heading 'Academy Graduate Scheme' is displayed
     When I click on the 'Read more...' section
     Then the information relates to the graduate academy
