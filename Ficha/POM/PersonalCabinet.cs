using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha.POM
{
    class PersonalCabinet
    {
        IWebDriver driver;
        private By admin;
        private By outField;

        public PersonalCabinet(IWebDriver driver)
        {
            this.driver = driver;
            admin = By.Id("adminmenu");
            outField = By.XPath("//a[@class='ab-item']/*[position()= 1][@class='display-name']");
            if (driver.FindElements(By.Id("adminmenu")).Count < 0)
            {
                throw new InvalidOperationException("Не та страница");
            }

        }
    }
}
