Feature: Disaster Recovery
	In order to verify that all key areas of the site are working
	As webmaster for Answer Consulting
	I want check all main sections of the site

Scenario Outline: Main pages showing correct header
    Given I am on the <page> page
     Then I can see the <header text>

Examples:
	| page               | header text       |
	| Stunning Solutions | Stunning solutions|
	| Great Clients      | Great clients     |
	| How we do it       | How we do it      |
	| Who we are         | Who we are        |
	| Careers            | Careers           |
	| Contact Us         | Contact           |

Scenario Outline: All required footer information is displayed
	Given I am on the <page> page
	 When I look at the footer information
	 Then the social link are displayed
	  And the address '© Answer Consulting Ltd, Union Mills, 9 Dewsbury Road, Leeds LS11 5DD' is displayed
	  And the company information 'Registered in England and Wales with company number 03655429' is dispayed

Examples:
	| page               |
	| Home               |
	| Stunning Solutions |
	| Great Clients      |
	| How we do it       |
	| Who we are         |
	| Careers            |
	| Contact Us         |

Scenario: Sitemap is correctly being generated
   Given I navigate to the sitemap
    Then the XML markup is valid
	 And all pages are working
