using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace JoesPizzaSpecflow.StepDefinitions
{
    [Binding]
    public class CancelOrderStepDefinitions
    {
        private String searchKeyword;

        private ChromeDriver chromeDriver;
        public CancelOrderStepDefinitions() => chromeDriver = new ChromeDriver("C:\\Users\\sahil.shaikh\\Downloads\\chromedriver_win32");

        [Given(@"Navigate to home page of website")]
        public void GivenNavigateToHomePageOfWebsite()
        {
            chromeDriver.Navigate().GoToUrl("https://joespizzaappproject.azurewebsites.net/");
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
        }

        [When(@"I click Add to cart for pizza")]
        public void WhenIClickAddToCartForPizza()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
            var Add_to_cart = chromeDriver.FindElement(By.XPath("/html/body/div/div[5]/div[3]/div/div/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", Add_to_cart);
        }

        [Then(@"Cart page should open")]
        public void ThenCartPageShouldOpen()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(2500));
        }

        [When(@"I click on cross icon")]
        public void WhenIClickOnCrossIcon()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
            var Remove_from_cart = chromeDriver.FindElement(By.XPath("/html/body/div/form/table/tbody/tr/td/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", Remove_from_cart);
        }

        [Then(@"Pizza should be removed from cart")]
        public void ThenPizzaShouldBeRemovedFromCart()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(2500));
        }
    }
}
