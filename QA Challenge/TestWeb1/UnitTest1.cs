using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using Xunit;

namespace TestWeb2
{
    public class UnitTest1 : IDisposable
    {
        public IWebDriver driver { get; private set; }
        public UnitTest1()
        {
            driver = new ChromeDriver();

        }
        public void Dispose()
        {
            driver.Quit();
        }


        [Fact]
        public void Test1()
        {


            driver.Navigate().GoToUrl("http://zero.webappsecurity.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(785, 864);
            driver.FindElement(By.Id("searchTerm")).Click();
            driver.FindElement(By.CssSelector("#onlineBankingMenu > div")).Click();
            driver.FindElement(By.CssSelector("#feedback strong")).Click();
            driver.FindElement(By.Id("name")).Click();
            driver.FindElement(By.Id("name")).SendKeys("11111");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("alexsencion");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("alexsencion99gggg.com");
            driver.FindElement(By.Id("subject")).Click();
            driver.FindElement(By.Id("subject")).SendKeys("mi cuenta");
            driver.FindElement(By.Id("comment")).Click();
            driver.FindElement(By.Id("comment")).Click();
            driver.FindElement(By.Id("comment")).SendKeys("Como puedo aperturar mi cuenta?");
            driver.FindElement(By.Id("name")).Click();
            driver.FindElement(By.Id("name")).Click();
            driver.FindElement(By.Id("name")).Click();
            {
                var element = driver.FindElement(By.Id("name"));
                Actions builder = new Actions(driver);
                builder.DoubleClick(element).Perform();
            }
            driver.FindElement(By.Id("name")).Click();
            driver.FindElement(By.Id("name")).Click();
            driver.FindElement(By.Id("name")).SendKeys("111111");
            driver.FindElement(By.Name("submit")).Click();
            driver.FindElement(By.LinkText("Zero Bank")).Click();
        }
    }
}