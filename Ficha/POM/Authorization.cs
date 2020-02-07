using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha.POM
{
    class Authorization
    {
        private IWebDriver driver;
        private By loginFild;
        private By passwordFild;
        private By loginBtn;
        private By correctPage;

        public Authorization (IWebDriver driver)
        {
            string urlLogin = "https://s1.demo.opensourcecms.com/wordpress/wp-login.php";
            loginFild = By.Name("log");
            passwordFild = By.Name("pwd");
            loginBtn = By.Name("wp-submit");
            this.driver = driver;
            correctPage = By.XPath("//form[@name = 'loginform']");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(urlLogin);

        }

        public void EnterUserName (string name)
        {
            driver.FindElement(loginFild).SendKeys(name);
        }

        public void EnterPass (string password)
        {
            driver.FindElement(passwordFild).SendKeys(password);
        }

        public void ClickSubmit ()
        {
            driver.FindElement(loginBtn).Click();
        }

        public void Authorise (string name, string password)
        {
            EnterUserName(name);
            EnterPass(password);
            ClickSubmit();
        }
    }
}
