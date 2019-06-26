using System;
using NUnit.Framework;
using Allure;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;
using System.Diagnostics;

namespace Test
{

    [TestClass]
    [Parallelizable(ParallelScope.Fixtures)]
    [AllureNUnit]
    [AllureSuite("Test4")]
    [AllureDisplayIgnored]
    public class UnitTest4
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver();
        }
        
        [Test(Description = "TestMethod4_0")]
        [AllureTag("CI")]
        [AllureOwner("vfrolov")]
        [Category("main_branch")]
        public void TestMethod4_0()
        {
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
        }

        [Test(Description = "TestMethod4_1")]
        [AllureTag("CI")]
        [AllureOwner("vfrolov")]
        [Category("main_branch")]
        public void TestMethod4_1()
        {
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga---"));
            Debug.WriteLine("Test4_1");
            Console.WriteLine("Test4_1");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
        }

        [Test(Description = "TestMethod4_2")]
        [AllureTag("CI")]
        [AllureOwner("vfrolov")]
        [Category("3d_branch")]
        public void TestMethod4_2()
        {
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
        }

        [Test(Description = "TestMethod41_3")]
        [AllureTag("CI")]
        [AllureOwner("vfrolov")]
        [Category("3d_branch")]
        public void TestMethod4_3()
        {
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
        }

        [Test(Description = "TestMethod4_4")]
        [AllureTag("CI")]
        [AllureOwner("vfrolov")]
        [Category("Test1_1")]
        [AllureTms("test")]
        public void TestMethod4_4()
        {
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
        }

        [Test(Description = "TestMethod4_5")]
        [AllureTag("CI")]
        [AllureOwner("vfrolov")]
        [Category("Test1_1")]
        [AllureTms("test")]
        public void TestMethod4_5()
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
