using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace JoesPizzaSpecflow.StepDefinitions
{
    [Binding]
    public class CheckTitleStepDefinitions
    {
        private String searchKeyword;
        private ChromeDriver chromeDriver;
        public CheckTitleStepDefinitions() => chromeDriver = new ChromeDriver("C:\\Users\\sahil.shaikh\\Downloads\\chromedriver_win32");

        [Given(@"Open the homepage of website")]
        public void GivenOpenTheHomepageOfWebsite()
        {
            chromeDriver.Navigate().GoToUrl("https://joespizzaappproject.azurewebsites.net/");
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
        }
        [Then(@"Check the title")]
        public void ThenCheckTheTitle()
        {
            Assert.IsTrue(chromeDriver.Title.Contains("Joes Pizza"));
        }
    }
}
