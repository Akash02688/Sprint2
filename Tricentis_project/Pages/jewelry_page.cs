using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricentis_project.Utility;

namespace Tricentis_project.Pages
{
    public class jewelry_page : utility
    {
        private IWebDriver driver;

        public jewelry_page(IWebDriver driver)
        {
            this.driver = driver;
        }
        private By jewel = By.XPath("/html/body/div[4]/div[1]/div[2]/ul[1]/li[6]/a");
        private By heart_item = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div[2]/div[3]/div[2]/div/div[2]/h2/a");
        private By button = By.Id("add-to-cart-button-14");

        public void Jewel()
        {
            driver.FindElement(jewel).Click();
        }
        public void Heart_item()
        {
            driver.FindElement(heart_item).Click(); 
        }
        public void Button()
        {
            driver.FindElement(button).Click();
        }
    }
}
