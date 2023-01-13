Feature: AppiumTemplate

@mytag
Scenario: Smoke test katoennatie.com
	Given that user opens KTN web page 
	Then user tries opens Get in touch page
	Then add user details on contact form