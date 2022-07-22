using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo.LoginTest
{
    internal class LoginTest
    {
        [Test]
        public void Login()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://opensource-demo.orangehrmlive.com/";
            driver.Manage().Window.Maximize();

            IWebElement username = driver.FindElement(By.Id("txtUsername"));
            username.SendKeys("Admin");

            IWebElement password = driver.FindElement(By.Id("txtPassword"));
            password.SendKeys("admin123");
            Thread.Sleep(3000);

            IWebElement loginBtn = driver.FindElement(By.Id("btnLogin"));
            loginBtn.Click();
            Thread.Sleep(3000);

            driver.Close();
            //dfghjklfghjkhjkl
        }
    }
}
