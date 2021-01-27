using HabrProject.Data;
using HabrProject.PageObjects.AuthSection;
using HabrProject.PageObjects.MainPageObject;
using NLog;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ResumeProject.PageObjects.MyProfileSection;
using ResumeProject.PageObjects.Settings;
using System;



namespace HabrProject
{
    public class ApplicationManager
    {
        protected IWebDriver _webDriver;
        protected static Logger LOG = LogManager.GetCurrentClassLogger();

        //protected static Logger LOG = LogManager.GetCurrentClassLogger();

        //Ссылки на Page objects    
        protected MainPagePageObject _mainPage;
        protected AuthorizationPageObject _authPage;
        protected MyProfilePageObject _myProfile;
        protected SettingsPageObject _settingsPage;
        // Геттеры
        public MainPagePageObject MainPage { get { return _mainPage; } }
        public AuthorizationPageObject Auth { get { return _authPage; } }
        public MyProfilePageObject MyProfilePage { get { return _myProfile; } }
        public SettingsPageObject Settings { get { return _settingsPage; } }
        // Конструктор ApplicatonManager 
        public ApplicationManager()
        {       
            _webDriver = new ChromeDriver();

            _webDriver.Navigate().GoToUrl(TestSettings.UrlHabr);
            _webDriver.Manage().Cookies.DeleteAllCookies();
            //_webDriver.Manage().Window.Maximize();     

            _mainPage = new MainPagePageObject(_webDriver); 
            _authPage = new AuthorizationPageObject(_webDriver);
            _myProfile = new MyProfilePageObject(_webDriver);
            _settingsPage = new SettingsPageObject(_webDriver); 
        }

        public void Stop()
        {
            try
            {
                _webDriver.Quit();
                LOG.Info("Текущий тест завершен, браузер закрыт");
            }
            catch (Exception ex)
            {
                LOG.Error("Невозможно закрыть браузер, ошибка:" + ex);
            }
        }
        /// </summary>

        
        public void AcceptAlert()
        {
            try
            {
                //WaitUntil.WaitSomeInterval(1);
                _webDriver.SwitchTo().Alert().Accept();
            }
            catch (Exception)
            {
                //exception handling
            }
        }        
    }
}
