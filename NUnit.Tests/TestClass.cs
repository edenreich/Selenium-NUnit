using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnit.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://www.google.com");
        }
    }
}
