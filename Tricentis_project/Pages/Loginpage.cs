using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricentis_project.Utility;

namespace Tricentis_project.Pages
{
    public class Loginpage : utility
    {
        private IWebDriver driver;
        public Loginpage( IWebDriver driver) 
        { 
            this.driver= driver;
        }
        private By login = By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a");
        private By userEmail = By.Name("Email");
        private By password = By.Name("Password");
        private By loginbutton = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div/div[2]/div[1]/div[2]/div[2]/form/div[5]/input");


        public void Login()
        {
            driver.FindElement(login).Click();
        }
        public void UserEmail() 
        {
            driver.FindElement(userEmail).SendKeys("an1621@gmail.com");
        }
        public void Password()
        {
            driver.FindElement(password).SendKeys("Rana@1621");
        }
        public void Loginbutton()
        {
            driver.FindElement(loginbutton).Click();
        }
    }
}
