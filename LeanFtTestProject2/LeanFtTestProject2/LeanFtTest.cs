using System;
using NUnit.Framework;
using HP.LFT.SDK;
using HP.LFT.Verifications;
using HP.LFT.SDK.Web;

namespace LeanFtTestProject2
{
    [TestFixture]
    public class LeanFtTest : UnitTestClassBase
    {

        IBrowser OBrowser;
        ApplicationModel1 apm;


        [OneTimeSetUp]
        public void TestFixtureSetUp()
        {
            // Setup once per fixture

            OBrowser = BrowserFactory.Launch(BrowserType.InternetExplorer);
            apm = new ApplicationModel1(OBrowser);

        }

        [SetUp]
        public void SetUp()
        {
            // Before each test
        }

        [Test]
        public void Test()
        {
            OBrowser.Navigate("Google.com");

            OBrowser.Sync();
            apm.SearchEditField.SetValue("abc");
            apm.GoogleSearchButton.Click();

        }

        [TearDown]
        public void TearDown()
        {
            // Clean up after each test
            OBrowser.Close();
        }

        [OneTimeTearDown]
        public void TestFixtureTearDown()
        {
            // Clean up once per fixture
        }
    }
}
