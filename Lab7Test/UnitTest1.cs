using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
namespace Lab7Test
{
    [TestFixture]
    public class Tests
    {
       [TestCase]
       public void mainTitle()
       {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Url = "https://kbkdist.ru/";
            Assert.That(webDriver.Title,Is.EqualTo("Образовательная платформа Калининградского бизнес-колледжа"));
            webDriver.Close();
            webDriver.Quit();
        }
        [TestCase]
        public void google_request()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Url = "https://www.dns-shop.ru/";
            IWebElement search = webDriver.FindElement(By.XPath("//*[@id=\"header - mobile - inner\"]/div[2]/div[1]/div/div/div[1]/div/input"));
            search.SendKeys("Планшет");
            IWebDriver 
            webDriver.Close();
            //webDriver.Quit();
        }
        [TearDown]
        public void testEnd()
        {
        }
    }
}
