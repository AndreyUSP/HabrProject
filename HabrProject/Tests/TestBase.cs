using NLog;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HabrProject.Tests
{
    public class TestBase
    {
        protected ApplicationManager app;
        protected static Logger LOG = LogManager.GetCurrentClassLogger();
        [SetUp]
        public void SetupTest()
        {
            app = new ApplicationManager();
        }

        [TearDown]
        public void TearDownTest()
        {
            app.Stop();
        }
    }
}
