using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using Xunit;

namespace TestWeb1
{
    public class UnitTestChrome : IDisposable
    {
        public IWebDriver driver { get; private set; }

        public UnitTestChrome()
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
            driver.Navigate().GoToUrl("http://automationpractice.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(783, 864);
            driver.FindElement(By.LinkText("Contact us")).Click();
            driver.FindElement(By.Id("id_contact")).Click();
            {
                var dropdown = driver.FindElement(By.Id("id_contact"));
                dropdown.FindElement(By.XPath("//option[. = 'Customer service']")).Click();
            }
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("alexsencion99@ggg.com");
            driver.FindElement(By.Id("id_order")).Click();
            driver.FindElement(By.Id("id_order")).SendKeys("sell a product");
            driver.FindElement(By.Id("message")).Click();
            driver.FindElement(By.Id("id_order")).Click();
            driver.FindElement(By.Id("id_order")).Click();
            {
                var element = driver.FindElement(By.Id("id_order"));
                Actions builder = new Actions(driver);
                builder.DoubleClick(element).Perform();
            }
            driver.FindElement(By.Id("id_order")).Click();
            driver.FindElement(By.Id("id_order")).Click();
            driver.FindElement(By.Id("id_order")).SendKeys("vender un producto");
            driver.FindElement(By.Id("message")).Click();
            driver.FindElement(By.Id("message")).SendKeys("Como puedo vender un producto en la web?");
            driver.FindElement(By.CssSelector("#submitMessage > span")).Click();
            driver.FindElement(By.CssSelector(".logo")).Click();
        }
    }
    }
