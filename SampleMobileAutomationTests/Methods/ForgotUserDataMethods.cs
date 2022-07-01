using NUnit.Framework;
using SampleMobileAutomationTests.Pages;

namespace SampleMobileAutomationTests.Methods
{
    public class ForgotUserDataMethods
    {
        private readonly RestoreAccountScreen _restoreAccountScreen;

        public ForgotUserDataMethods()
        {
            _restoreAccountScreen = new RestoreAccountScreen();
        }

        public void VerifyAccountRetrievalScreen()
        {
            Assert.IsTrue(_restoreAccountScreen.FirstNameField.Element.Displayed);
            Assert.IsTrue(_restoreAccountScreen.LastNameField.Element.Displayed);
            Assert.IsTrue(_restoreAccountScreen.MobileNumberField.Element.Displayed);
            Assert.IsTrue(_restoreAccountScreen.RetrievalAccountButton.Element.Displayed);
            Assert.IsTrue(_restoreAccountScreen.DateOfBirthField.Element.Displayed);
        }

        public void VerifyPinResetScreen()
        {
            Assert.IsTrue(_restoreAccountScreen.FirstNameField.Element.Displayed);
            Assert.IsTrue(_restoreAccountScreen.LastNameField.Element.Displayed);
            Assert.IsTrue(_restoreAccountScreen.MobileNumberField.Element.Displayed);
            Assert.IsTrue(_restoreAccountScreen.ResetPinButton.Element.Displayed);
            Assert.IsTrue(_restoreAccountScreen.DateOfBirthField.Element.Displayed);
            Assert.IsTrue(_restoreAccountScreen.AccountNumberField.Element.Displayed);
        }
    }
}