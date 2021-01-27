using System;
using System.Collections.Generic;
using System.Text;
using HabrProject.Data;
using OpenQA.Selenium;

namespace HabrProject.PageObjects.MainPageObject
{
    public class AdminPageObject : PageObjectBase
    {
        /*
        protected readonly By _logInButton = By.XPath("//a[@id='login']");
        protected readonly By _dropDownButton = By.XPath("//span[@class='default-image default-image_navbar default-image_green']");
        protected readonly By _userInfoButton = By.XPath("//a[@class='dropdown__user-info user-info']");
        protected readonly By _settingsButton = By.XPath("//a[@class='n-dropdown-menu__item-link n-dropdown-menu__item-link_user-menu']");
        */
        public AdminPageObject(IWebDriver webDriver) : base(webDriver)
        {
        }
        /*
        public AdminPageObject LogInButton()
        {
            WaitUntil.WaitElement(_webDriver, _logInButton, TestSettings.WaitTime);
            _webDriver.FindElement(_logInButton).Click();

            return this;
        }    
        */
    }
}
