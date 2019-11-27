using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowTest
{
	[Binding]
	public class Bindings
	{
		private int _accountNumber;
		[Given(@"Patient Account (.*) Exists in (\S+) database")]
		public void GivenPatientAccountExistsInTempDatabase(int p0, string p2)
		{
			_accountNumber = p0;
		}

		[When(@"get patient account from PatientAccountService")]
		public void WhenGetPatientAccountFromPatientAccountService()
		{
		}

		[Then(@"Patient Account Information Should Be Retrieved")]
		public void ThenPatientAccountInformationShouldBeRetrieved()
		{
			_accountNumber.Should().BeGreaterOrEqualTo(10);
		}

		[Then(@"Validated")]
		public void ThenValidated()
		{
		}

	}
}
