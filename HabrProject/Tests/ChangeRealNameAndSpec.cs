using System;
using System.Collections.Generic;
using System.Text;
using HabrProject.Data;
using HabrProject.Tests;
using NUnit.Framework;

namespace ResumeProject.Tests
{
    public class ChangeRealNameAndSpec : TestBase
    {
        [Test]
        public void ChangingAndChecking()
        {
            app.MainPage.LogInButton();
            app.Auth.Login(TestSettings._loginOfMailRu, TestSettings._passwordHabr);
            app.MainPage.NavigateToSettings();
            app.Settings
                .ChangeRealName(TestSettings._realName)
                .ChangeSpecialization(TestSettings._specialization)
                .PushSaveButton();
            app.MainPage
                .NavigateToMyProfile()
                .NavigateToSettings();
            app.Settings
                .CheckingRealName(TestSettings._realName)
                .CheckingSpecialization(TestSettings._specialization);
        }
    }
}
