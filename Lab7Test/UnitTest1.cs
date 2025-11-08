using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
namespace Lab7Test
{
    [TestFixture]
    public class Tests
    {
       //[TestCase]
       //public void mainTitle()
       //{
       //     IWebDriver webDriver = new ChromeDriver();
       //     webDriver.Url = "https://kbkdist.ru/";
       //     Assert.That(webDriver.Title,Is.EqualTo("Образовательная платформа Калининградского бизнес-колледжа"));
       //     webDriver.Close();
       //     webDriver.Quit();
       // }
        [TestCase]
        public void google_request()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-infobars");
            IWebDriver webDriver = new ChromeDriver(options);
            webDriver.Url = "https://www.rambler.ru/";
            IWebElement search = webDriver.FindElement(By.XPath("/html/body/div[1]/header/div[3]/div/div[2]/form/input"));
            search.SendKeys("Планшет");
            IWebElement button = webDriver.FindElement(By.XPath("/html/body/div[1]/header/div[3]/div/div[2]/form/button[2]"));
            button.Click();
            webDriver.Close();
            webDriver.Quit();
        }
        
    }
}
