using HabrProject.Data;
using NLog;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HabrProject.PageObjects
{
    public class PageObjectBase
    {
        protected static Logger LOG = LogManager.GetCurrentClassLogger();
        protected IWebDriver _webDriver;
        public PageObjectBase(IWebDriver _webDriver)
        {
            this._webDriver = _webDriver;
        }
        
        public bool CheckingElementByName(string ElementName)
        {
            try
            {
                WaitUntil.WaitElement(_webDriver, By.XPath(ElementName), TestSettings.WaitTime);
                _webDriver.FindElement(By.XPath(ElementName));
                LOG.Info(ElementName + " - найден");
                return true;
            }
            catch (Exception)
            {
                LOG.Error(ElementName + " - отсутствует");
                return false;
            }
        }
    }
}
