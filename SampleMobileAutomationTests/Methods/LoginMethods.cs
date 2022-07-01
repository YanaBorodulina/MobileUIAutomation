using Sample.Mobile.Core.Extensions;
using SampleMobileAutomationTests.Models;
using SampleMobileAutomationTests.Pages;

namespace SampleMobileAutomationTests.Methods
{
    public class LoginMethods
    {
        private readonly LoginScreen _loginScreen;

        public LoginMethods()
        {
            _loginScreen = new LoginScreen();
        }

        public void Login(LoginUserModel user)
        {
            if (user.UserNumber == " " || user.UserNumber == string.Empty)
            {
                _loginScreen.UserNumberFiled.Element.Clear();
            }
            else
            {
                _loginScreen.UserNumberFiled.Element.TypeInto($" {user.UserNumber}");
            }

            if (user.Pin == " " || user.Pin == string.Empty)
            {
                _loginScreen.PinField.Element.Clear();
            }
            else
            {
                _loginScreen.PinField.Element.TypeInto(user.Pin);
            }

            _loginScreen.LoginButton.Element.Click();
        }
    }
}