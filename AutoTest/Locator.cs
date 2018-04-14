using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;

using OpenQA.Selenium.Interactions;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace AutoTest
{
    class Locator
    {
        //закрыть окно "Ваш город Киев?"
        //static void CloseCity()
        //{
        //    IWebElement City = new FirefoxDriver();
        //    IWebElement City = driver.FindElement(By.CssSelector(".confirm-city > i:nth-child(1)"));
        //    City.Click();
        //}
        //IWebElement City = new FirefoxDriver();
        //public IWebElement City = driver.FindElement(By.CssSelector(".confirm-city > i:nth-child(1)"));
        [FindsBy(How = How.CssSelector, Using = ".confirm-city > i:nth-child(1)")]
        public IWebElement CityClose { get; set; }
        


        //Test 2
        [FindsBy(How = How.XPath, Using = ".//*[@id='page-index']/header/div[1]/div/div/div[1]/div/div[2]/div/div[3]/div/div/span[2]")]
        public IWebElement searchButton_ukr { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='page-index']/header/div[1]/div/div/div[1]/div/div[2]/div/div[3]/div/div/span[1]")]
        public IWebElement searchButton_rus { get; set; }


        //Test 3-4
        [FindsBy(How = How.XPath, Using = ".//*[@id='page-index']/div[1]/div[1]/div[2]/aside/nav/ul/li[16]/a")]
        public IWebElement smartphones { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div[1]/div[3]/div[3]/ul/li[6]/div/a/span[2]/span[1]")]
        public IWebElement PowerBank { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='page-catalog']/div[1]/div[1]/div[1]/aside/div/div[3]/div[1]/div[1]/div[2]/ul/li[5]/label")]
        public IWebElement CapacityRange { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='page-catalog']/div[1]/div[1]/div[1]/aside/div/div[3]/div[1]/div[6]/div[2]/div/div[1]/input[3]")]
        public IWebElement MaxPrice { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='page-catalog']/div[1]/div[1]/div[1]/aside/div/div[3]/div[1]/div[6]/div[2]/div/div[1]/input[5]")]
        public IWebElement okButton { get; set; }

        //Test 5
        [FindsBy(How = How.XPath, Using = ".//*[@id='page-index']/div[1]/div[1]/div[2]/aside/nav/ul/li[22]/a")]
        public IWebElement WatchesJewerly { get; set; }
        
        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div[1]/div[3]/div[2]/ul/li[2]/div/a/span[2]/span[1]")]
        public IWebElement BusinessCardCatalog { get; set; }
        //IWebElement BusinessCardCatalog = driver.FindElement(By.XPath("html/body/div[1]/div[1]/div[3]/div[2]/ul/li[2]/div/a/span[2]/span[1]"));
        //BusinessCardCatalog.Click();

        

    }
}
