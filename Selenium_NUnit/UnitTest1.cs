using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Selenium_NUnit
{
    [Parallelizable]
    public class Tests1
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1a()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.utep.edu/");
            Console.WriteLine("1a");
            driver.Quit();
            //Assert.Pass();
        }
        [Test]
        public void Test1b()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.utep.edu/");
            Console.WriteLine("1b");
            driver.Quit();
            //Assert.Pass();
        }
    }
    [Parallelizable]
    public class Tests2
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test2a()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://betamy.utep.edu/My");
            Console.WriteLine("2a");
            driver.Quit();
            //Assert.Pass();
        }
        [Test]
        public void Test2b()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://betamy.utep.edu/My");
            Console.WriteLine("2b");
            driver.Quit();
            //Assert.Pass();
        }
    }
}