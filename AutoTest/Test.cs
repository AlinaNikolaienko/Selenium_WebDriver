using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using AutoTest;

namespace AutoTest
{
    [TestFixture]
    public class Test
    {
        IWebDriver driver = new FirefoxDriver();

        [OneTimeSetUp] 
        public void OneTimeSetUp()
        {
            driver.Navigate().GoToUrl("http://google.ua");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Close();
        }

        [Test]
        public void EnterHotlineInGoogle()
        {
           // IWebDriver driver = new FirefoxDriver();
            //driver.Manage().Window.Maximize();
            IWebElement searchField = driver.FindElement(By.Id("lst-ib"));
            searchField.Clear();
            searchField.SendKeys("Hotline");
            IWebElement searchButton = driver.FindElement(By.CssSelector(".jsb>center>input"));
            searchButton.Click();
            IWebElement linkHotline = driver.FindElement(By.CssSelector(".r>a"));
            linkHotline.Click();
            Assert.AreEqual("Hotline - сравнить цены в интернет-магазинах Украины", driver.Title);
        }

        [Test]
        public void LanguageSwitching()
        {
            driver.Navigate().GoToUrl("https://hotline.ua/");
            AutoTest.Locator HotlinePage = new AutoTest.Locator();
            PageFactory.InitElements(driver, HotlinePage);
            HotlinePage.CityClose.Click();
            HotlinePage.searchButton_ukr.Click();
            Assert.AreEqual("Порівняння цін в інтернет магазинах", driver.FindElement(By.CssSelector("div.viewbox.cell-sm-none > p.h3")).Text);
            HotlinePage.searchButton_rus.Click();
            Assert.AreEqual("Сравнение цен в интернет магазинах", driver.FindElement(By.CssSelector("div.viewbox:nth-child(6) > p:nth-child(1)")).Text);
        }

        [Test]
        public void PowerBankForSmartphone()
        {
            driver.Navigate().GoToUrl("https://hotline.ua/");
            AutoTest.Locator HotlinePage = new AutoTest.Locator();
            PageFactory.InitElements(driver, HotlinePage);
            HotlinePage.CityClose.Click();
            HotlinePage.smartphones.Click();
            HotlinePage.PowerBank.Click();
            Assert.IsTrue(driver.PageSource.Contains("Внешние аккумуляторы (Power Bank)"));
        }

        [Test]
        public void SortedByPowerBankCapacityWithMaxPrice()
        {
            driver.Navigate().GoToUrl("https://hotline.ua/");
            AutoTest.Locator HotlinePage = new AutoTest.Locator();
            PageFactory.InitElements(driver, HotlinePage);
            HotlinePage.CityClose.Click();
            HotlinePage.smartphones.Click();
            HotlinePage.PowerBank.Click();
            HotlinePage.CapacityRange.Click();
            HotlinePage.MaxPrice.Clear();
            HotlinePage.MaxPrice.SendKeys("1000");
            HotlinePage.okButton.Click();
            Assert.IsTrue(driver.PageSource.Contains("Внешние аккумуляторы (Power Bank)"));
            Assert.AreEqual("Внешние аккумуляторы (Power Bank)", driver.FindElement(By.XPath(".//*[@id='page-catalog']/div[1]/div[1]/div[1]/div[1]/div/h1")).Text);
        }

        [Test]
        public void BusinessCardsSortedByPrice()
        {
            driver.Navigate().GoToUrl("https://hotline.ua/");
            AutoTest.Locator HotlinePage = new AutoTest.Locator();
            PageFactory.InitElements(driver, HotlinePage);
            HotlinePage.CityClose.Click();
            HotlinePage.WatchesJewerly.Click();
            HotlinePage.BusinessCardCatalog.Click();
            var SortingOrder = driver.FindElement(By.XPath(".//*[@id='catalog-products']/div[1]/div/div[3]/ul/li[1]/select"));
            var selectOrder = new SelectElement(SortingOrder);
            selectOrder.SelectByText("возрастанию цены");
            Assert.IsTrue(driver.PageSource.Contains("Визитницы"));
            Assert.AreEqual("Визитницы", driver.FindElement(By.XPath(".//*[@id='page-catalog']/div[1]/div[1]/div[1]/div[1]/div/h1")).Text);
        }

    }
    }
