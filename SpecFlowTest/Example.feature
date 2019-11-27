Feature: PatientAccountCases
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Get Patient Account From R1.Insight.PatientAccount Service
Given Patient Account 636573 Exists in temp database
When get patient account from PatientAccountService
Then Patient Account Information Should Be Retrieved
And Validated