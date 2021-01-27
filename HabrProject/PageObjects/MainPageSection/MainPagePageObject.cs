using HabrProject.Data;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HabrProject.PageObjects.MainPageObject
{
    public class MainPagePageObject : PageObjectBase
    {
        protected readonly By _logInButton = By.XPath("//a[@id='login']");
        protected readonly By _dropDownButton = By.XPath("//span[@class='default-image default-image_navbar default-image_green']"); 
        protected readonly By _userInfoButton = By.XPath("//a[@class='dropdown__user-info user-info']");
        protected readonly By _settingsButton = By.XPath("//a[@class='n-dropdown-menu__item-link n-dropdown-menu__item-link_user-menu']");
        
        public MainPagePageObject(IWebDriver webDriver) : base(webDriver)
        {
        }
        public MainPagePageObject LogInButton()
        {
            WaitUntil.WaitElement(_webDriver, _logInButton, TestSettings.WaitTime);
            _webDriver.FindElement(_logInButton).Click();

            return this;
        }
        public MainPagePageObject NavigateToMyProfile()
        {
            WaitUntil.WaitElement(_webDriver, _dropDownButton, TestSettings.WaitTime);
            _webDriver.FindElement(_dropDownButton).Click();
            _webDriver.FindElement(_userInfoButton).Click();

            return this;
        }
        public MainPagePageObject NavigateToSettings()
        {
            WaitUntil.WaitElement(_webDriver, _dropDownButton, TestSettings.WaitTime);
            _webDriver.FindElement(_dropDownButton).Click();
            _webDriver.FindElement(_settingsButton).Click();
            return this;
        }
    }
}
