using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Mvc5UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void test01()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1054, 664);
            driver.FindElement(By.Name("q")).Click();
            driver.FindElement(By.Name("q")).SendKeys("selenium");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            driver.FindElement(By.LinkText("維基百科")).Click();
        }
    }
}
