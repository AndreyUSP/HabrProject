using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HabrProject.PageObjects.AuthSection
{
    public class AuthorizationPageObject : PageObjectBase
    {               
        protected readonly By _emailInput = By.XPath("//input[@id='email_field']");
        protected readonly By _passwordInput = By.XPath("//input[@id='password_field']");
        protected readonly By _submitButton = By.XPath("//button[@type='submit']");

        public AuthorizationPageObject(IWebDriver webDriver) : base(webDriver)
        {
        }

        //Авторизируемся под пользователем
        public void Login(string login, string password)
        {
            _webDriver.FindElement(_emailInput).SendKeys(login);
            _webDriver.FindElement(_passwordInput).SendKeys(password);
            _webDriver.FindElement(_submitButton).Click();
        }
    }
}
