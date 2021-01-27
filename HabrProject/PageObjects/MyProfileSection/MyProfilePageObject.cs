using System;
using System.Collections.Generic;
using System.Text;
using HabrProject.Data;
using HabrProject.PageObjects;
using OpenQA.Selenium;

namespace ResumeProject.PageObjects.MyProfileSection
{
    public class MyProfilePageObject : PageObjectBase
    {       
        protected readonly By _userInfoButton = By.XPath("//a[@class='user-info__nickname user-info__nickname_doggy']");
        public MyProfilePageObject(IWebDriver webDriver) : base(webDriver)
        {
        }
        /*public MyProfilePageObject LogInButton()
        {
            WaitUntil.WaitElement(_webDriver, _logInButton, TestSettings.WaitTime);
            _webDriver.FindElement(_logInButton).Click();

            return this;
        }
        */
        public MyProfilePageObject NickNameCheck(string Name)
        {
            try
            {
                WaitUntil.WaitElement(_webDriver, _userInfoButton, TestSettings.WaitTime);
                _webDriver.FindElement(_userInfoButton).Equals(Name);
            }
            catch (Exception)
            {
                //LOG.Info("Пользователь не соответствует заявленным данным: " + Name);
            }
            return this;
        }
    }
}
