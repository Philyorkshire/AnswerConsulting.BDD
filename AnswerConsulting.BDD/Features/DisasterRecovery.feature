Feature: Disaster Recovery
	In order to verify that all key areas of the site are working
	As webmaster for PPH
	I want check all main sections of the site

Scenario Outline: Main pages showing correct header
    Given I am on the <page> page
     Then I can see the <header text>

Examples:
	| page               | header text       |
	| Careers            | Careers           |
	| Contact Us         | Contact           |

Scenario Outline: All required footer information is displayed
	Given I am on the <page> page
	 When I look at the footer information
	 Then the social link are displayed
	  And the company information '© 2016 PeoplePerHour Inc.' is dispayed

Examples:
	| page               |
	| Home               |
	| How we do it       |
	| Who we are         |
	| Careers            |
	| Contact Us         |

Scenario: Sitemap is correctly being generated
   Given I navigate to the sitemap
    Then the XML markup is valid
	 And all pages are working
