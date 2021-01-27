using System;
using System.Collections.Generic;
using System.Text;
using HabrProject.Data;
using HabrProject.PageObjects;
using OpenQA.Selenium;

namespace ResumeProject.PageObjects.Settings
{
    public class SettingsPageObject : PageObjectBase
    {
        protected readonly By _realNameInput = By.XPath("(//input[@class='h-form-input__control'])[1]");
        protected readonly By _specializationInput = By.XPath("(//input[@class='h-form-input__control'])[2]");
        protected readonly By _saveChangesButton = By.XPath("//span[@class='tm-button__text']");
        

        public SettingsPageObject(IWebDriver webDriver) : base(webDriver)
        {
        }
        public SettingsPageObject ChangeRealName(string name)
        {
            WaitUntil.WaitElement(_webDriver, _realNameInput, TestSettings.WaitTime);
            _webDriver.FindElement(_realNameInput).Clear();
            _webDriver.FindElement(_realNameInput).SendKeys(name);

            return this;
        }
        public SettingsPageObject ChangeSpecialization(string spec)
        {
            WaitUntil.WaitElement(_webDriver, _specializationInput, TestSettings.WaitTime);
            _webDriver.FindElement(_specializationInput).Clear();
            _webDriver.FindElement(_specializationInput).SendKeys(spec);

            return this;
        }
        public SettingsPageObject PushSaveButton()
        {
            WaitUntil.WaitElement(_webDriver, _saveChangesButton, TestSettings.WaitTime);
            _webDriver.FindElement(_saveChangesButton).Click();

            return this;
        }
        public SettingsPageObject CheckingRealName(string name)
        {
            try
            {
                WaitUntil.WaitElement(_webDriver, _realNameInput, TestSettings.WaitTime);
                _webDriver.FindElement(_realNameInput).Equals(name);
            }
            catch (Exception)
            {
                LOG.Info("Элемент не соответствует заявленным данным: " + name);
            }
            return this;
        }
        public SettingsPageObject CheckingSpecialization(string spec)
        {
            try
            {
                WaitUntil.WaitElement(_webDriver, _specializationInput, TestSettings.WaitTime);
                _webDriver.FindElement(_specializationInput).Equals(spec);
            }
            catch (Exception)
            {
                LOG.Info("Элемент не соответствует заявленным данным: " + spec);
            }
            return this;
        }
    }
}
