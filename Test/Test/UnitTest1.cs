﻿using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{

    [TestClass]
    [Parallelizable(ParallelScope.Fixtures)]
    public class UnitTest1
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestMethod1_0()
        {
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
        }

        [Test]
        public void TestMethod1_1()
        {
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
        }

        [Test]
        public void TestMethod1_2()
        {
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
        }

        [Test]
        public void TestMethod1_3()
        {
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
        }

        [Test]
        public void TestMethod1_4()
        {
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
        }

        [Test]
        public void TestMethod1_5()
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
