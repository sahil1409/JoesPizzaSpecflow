using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace JoesPizzaSpecflow.StepDefinitions
{
    [Binding]
    public class ConfirmOrderStepDefinitions
    {
        private String searchKeyword;

        private ChromeDriver chromeDriver;
        public ConfirmOrderStepDefinitions() => chromeDriver = new ChromeDriver("C:\\Users\\sahil.shaikh\\Downloads\\chromedriver_win32");

        [Given(@"Navigate to the homepage of website")]
        public void GivenNavigateToTheHomepageOfWebsite()
        {
            chromeDriver.Navigate().GoToUrl("https://joespizzaappproject.azurewebsites.net/");
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
        }

        [When(@"I click Add to cart for any pizza")]
        public void WhenIClickAddToCartForAnyPizza()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
            var Add_to_cart = chromeDriver.FindElement(By.XPath("/html/body/div/div[5]/div[2]/div/div/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", Add_to_cart);
        }

        [When(@"I click Continue Shopping")]
        public void WhenIClickContinueShopping()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
            var Conitinue_Shopping = chromeDriver.FindElement(By.XPath("/html/body/div/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", Conitinue_Shopping);
        }

        [Then(@"I add another pizza to cart")]
        public void ThenIAddAnotherPizzaToCart()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
            var Add_to_cart = chromeDriver.FindElement(By.XPath("/html/body/div/div[5]/div[5]/div/div/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", Add_to_cart);
        }

        [When(@"Cart page comes up click on Checkout")]
        public void WhenCartPageComesUpClickOnCheckout()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
            var Checkout = chromeDriver.FindElement(By.XPath("/html/body/div/a[2]"));
            chromeDriver.ExecuteScript("arguments[0].click();", Checkout);
        }

        [Then(@"Order is confirmed")]
        public void ThenOrderIsConfirmed()
        {
            bool res1 = chromeDriver.PageSource.Contains("Peppy Paneer");
            bool res2 = chromeDriver.PageSource.Contains("Non Veg Supreme");
            Assert.IsTrue(res1);
            Assert.IsTrue(res2);
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
        }
    }
}
