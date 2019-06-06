using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{

    [TestClass]
    [Parallelizable(ParallelScope.Children)]
    public class UnitTest1
    {
       // IWebDriver driver;

        //[SetUp]
        //public void StartBrowser()
        //{
        //    driver = new ChromeDriver();
        //}

        [Test]
        public void TestMethod()
        {
            var driver = new ChromeDriver();
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
            driver.Close();
        }

        [Test]
        public void TestMethod1()
        {
           var driver = new ChromeDriver();
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
            driver.Close();
        }

        [Test]
        public void TestMethod2()
        {
           var driver = new ChromeDriver();
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
            driver.Close();
        }

        [Test]
        public void TestMethod3()
        {
           var driver = new ChromeDriver();
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
            driver.Close();
        }

        [Test]
        public void TestMethod4()
        {
           var driver = new ChromeDriver();
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
            driver.Close();
        }

        [Test]
        public void TestMethod5()
        {
          var  driver = new ChromeDriver();
            driver.Url = "http://www.google.com";
            var picture = driver.FindElements(By.Id("lga"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(picture.Count != 0);
            driver.Close();
        }

    }
}
