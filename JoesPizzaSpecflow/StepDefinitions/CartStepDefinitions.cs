using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace JoesPizzaSpecflow.StepDefinitions
{
    [Binding]
    public class CartStepDefinitions
    {
        private String searchKeyword;
        private ChromeDriver chromeDriver;
        public CartStepDefinitions() => chromeDriver = new ChromeDriver("C:\\Users\\sahil.shaikh\\Downloads\\chromedriver_win32");

        [Given(@"Navigate to homepage of website")]
        public void GivenNavigateToHomepageOfWebsite()
        {
            chromeDriver.Navigate().GoToUrl("https://joespizzaappproject.azurewebsites.net/");
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
        }

        [When(@"I click Add to cart for a pizza")]
        public void WhenIClickAddToCartForAPizza()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
            var Add_to_cart = chromeDriver.FindElement(By.XPath("/html/body/div/div[5]/div/div/div/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", Add_to_cart);
        }

        [Then(@"Cart page open")]
        public void ThenCartPageOpen()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
        }
    }
}
