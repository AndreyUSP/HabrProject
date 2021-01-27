using System;
using System.Collections.Generic;
using System.Text;
using HabrProject.Data;
using NUnit.Framework;

namespace HabrProject.Tests
{
    
    public class GoToProfileAndCheckUserName : TestBase
    {
        [Test]
        public void CheckUserName()
        {
            app.MainPage.LogInButton();
            app.Auth.Login(TestSettings._loginOfMailRu, TestSettings._passwordHabr);
            app.MainPage.NavigateToMyProfile();
            app.MyProfilePage.NickNameCheck(TestSettings._loginHabr);
        }
    }
}
