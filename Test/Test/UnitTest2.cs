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
    [AllureSuite("Test2")]
    [AllureDisplayIgnored]
    public class UnitTest2
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test(Description = "TestMethod2_0")]
        [AllureTag("CI")]
        [AllureOwner("vfrolov")]
        public void TestMethod2_0()
        {
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
        }

        [Test(Description = "TestMethod2_1")]
        [AllureTag("CI")]
        [AllureOwner("vfrolov")]
        public void TestMethod2_1()
        {
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
        }

        [Test(Description = "TestMethod2_2")]
        [AllureTag("CI")]
        [AllureOwner("vfrolov")]
        public void TestMethod2_2()
        {
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
        }

        [Test(Description = "TestMethod2_3")]
        [AllureTag("CI")]
        [AllureOwner("vfrolov")]
        public void TestMethod2_3()
        {
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
        }

        [Test(Description = "TestMethod2_4")]
        [AllureTag("CI")]
        [AllureOwner("vfrolov")]
        public void TestMethod2_4()
        {
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
        }

        [Test(Description = "TestMethod2_5")]
        [AllureTag("CI")]
        [AllureOwner("vfrolov")]
        public void TestMethod2_5()
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
