using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Locators
{
    public class Class1
    {
        [FindsBy(How = How.Id, Using = "lst-ib")]
        public IWebElement searchField { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".jsb>center>input")]
        public IWebElement searchButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".r>a")]
        public IWebElement linkHotline { get; set; }

    }
}
