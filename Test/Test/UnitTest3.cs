using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;

namespace Test
{

    [TestClass]
    [Parallelizable(ParallelScope.Fixtures)]
    [AllureNUnit]
    [AllureSuite("Test3")]
    [AllureDisplayIgnored]
    public class UnitTest3
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test(Description = "TestMethod3_0")]
        [AllureTag("CI")]
        [AllureOwner("vfrolov")]
        [AllureSuite("3d_branch")]
        [AllureSeverity]
        public void TestMethod3_0()
        {
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
        }

        [Test(Description = "TestMethod3_1")]
        [AllureTag("CI")]
        [AllureOwner("vfrolov")]
        [Category("3d_branch")]
        [Category("main_branch")]
        [AllureSuite("3d_branch")]
        [AllureSeverity]
        public void TestMethod3_1()
        {
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
        }

        [Test(Description = "TestMethod3_2")]
        [AllureTag("CI")]
        [AllureOwner("vfrolov")]
        [AllureSuite("3d_branch")]
        [AllureSeverity]
        public void TestMethod3_2()
        {
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
        }

        [Test(Description = "TestMethod3_3")]
        [AllureTag("CI")]
        [AllureOwner("vfrolov")]
        [AllureSuite("3d_branch")]
        [AllureSeverity]
        public void TestMethod3_3()
        {
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
        }

        [Test(Description = "TestMethod3_4")]
        [AllureTag("CI")]
        [AllureOwner("vfrolov")]
        [AllureSuite("3d_branch")]
        [AllureSeverity]
        public void TestMethod3_4()
        {
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
        }

        [Test(Description = "TestMethod3_5")]
        [AllureTag("CI")]
        [AllureOwner("vfrolov")]
        public void TestMethod3_5()
        {
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
        }

        [TearDown]
        public void BrowserClose()
        {
            driver.Close();
        }
    }
}
