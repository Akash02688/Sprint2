using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricentis_project.Utility;

namespace Tricentis_project.Pages
{
     public class Myaccount : utility
    {
        private IWebDriver driver;

        public Myaccount(IWebDriver driver)
        {
            this.driver = driver;   
        }
        private By myacc = By.XPath("/html/body/div[4]/div[2]/div[1]/div[3]/ul/li[1]/a");
        private By gender = By.Id("gender-male");
        private By firstname = By.Id("FirstName");
        private By lastname = By.Name("LastName");
        private By save = By.Name("save-info-button");
       // private By email = By.Name("Email");
       public void Myacc()
        {
            driver.FindElement(myacc).Click();
        }
        public void Gender()
        {
            driver.FindElement(gender).Click();
        }
        public void Firstname()
        {
            IWebElement username_field = driver.FindElement(firstname);
            Actions Act = new Actions(driver);

            Act.MoveToElement(username_field).Click(username_field).KeyDown(username_field, Keys.Shift)
                .SendKeys(username_field, "Akash").KeyUp(username_field, Keys.LeftShift).DoubleClick(username_field)
                .ContextClick(username_field).Build().Perform();
            //driver.FindElement(firstname).SendKeys("Raj");
        }
        public void Lastname()
        {

            IWebElement username_field = driver.FindElement(lastname);
            Actions Act = new Actions(driver);

            Act.MoveToElement(username_field).Click(username_field).KeyDown(username_field, Keys.Shift)
                .SendKeys(username_field, "A").KeyUp(username_field, Keys.LeftShift).DoubleClick(username_field)
                .ContextClick(username_field).Build().Perform();
            //driver.FindElement(lastname).SendKeys("kumar");
        }
        public void Save()
        {
            driver.FindElement(save).Click();
        }

            }
}
