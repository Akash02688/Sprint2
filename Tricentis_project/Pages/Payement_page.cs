using NPOI.SS.Formula.Functions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricentis_project.Utility;

namespace Tricentis_project.Pages
{
    public class Payement_page : utility
    {
        private IWebDriver driver;

        public Payement_page(IWebDriver driver)
        {
            this.driver = driver;
        }
        private By apparel = By.XPath("/html/body/div[4]/div[1]/div[2]/ul[1]/li[4]/a");
        private By top = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div[2]/div[3]/div[1]/div/div[2]/h2/a");
        private By cart = By.Id("add-to-cart-button-5");
        private By pant = By.XPath("//*[@id=\"product-details-form\"]/div/div[2]/div[2]/div[3]/div/div[2]/h2/a");
        private By enter = By.Id("add-to-cart-button-36");
        private By scart = By.XPath("//*[@id=\"topcartlink\"]/a/span[1]");
        private By tbox = By.Id("termsofservice");
        private By checkout = By.Id("checkout");
        private By billadd = By.XPath("//*[@id=\"billing-buttons-container\"]/input");
        // private By billadd = By.Id("billing-address-select");
        // private By billadd = By.XPath("//*[@id=\"billing-address-select\"]");
        private By shipadd = By.XPath("//*[@id=\"shipping-buttons-container\"]/input");
        private By shipmethod = By.Id("shippingoption_1");
        //private By payoption = By.Id("paymentmethod_0");
        private By cont = By.XPath("//*[@id=\"shipping-method-buttons-container\"]/input");
        private By payselect = By.Id("paymentmethod_1");
        private By con = By.XPath("//*[@id=\"payment-method-buttons-container\"]/input");
        private By payinfo = By.XPath("//*[@id=\"payment-info-buttons-container\"]/input");
        private By confirmorder = By.XPath("//*[@id=\"confirm-order-buttons-container\"]/input");
        private By backhome = By.XPath("/html/body/div[4]/div[1]/div[4]/div/div/div[2]/div/div[2]/input");

        public void Apparel()
        {
            driver.FindElement(apparel).Click();
        }
        public void Top()
        {
            driver.FindElement(top).Click();
        }
        public void Cart()
        {
            driver.FindElement(cart).Click();
        }
        public void Pant()
        {
            driver.FindElement(pant).Click();
        }
        public void Enter()
        {
            driver.FindElement(enter).Click();
        }
        public void Scart()
        {
            driver.FindElement(scart).Click();
        }
        public void Tbox()
        {
            driver.FindElement(tbox).Click();

        }
        public void Checkout()
        {
            driver.FindElement(checkout).Click();
        }
        public void Billadd()
        {
            //SelectElement s1 = new SelectElement(driver);
            //s1.SelectByValue("New Address");

            driver.FindElement(billadd).Click();
        }
        public void Shipadd()
        {
            driver.FindElement(shipadd).Click();
        }
        public void Shipmethod()
        {
            driver.FindElement(shipmethod).Click();
        }
        public void Cont()
        {
            driver.FindElement(cont).Click();
        }
        //public void Payoption()
        //{
        //    driver.FindElement(payoption).Click();
        //}
        public void Con()
        {
            driver.FindElement(con).Click();
        }
        public void Payselect()
        {
            driver.FindElement(payselect).Click();
        }
        public void PayInfo()
        {
            driver.FindElement(payinfo).Click();
        }
        public void Confirmorder()
        {
            driver.FindElement(confirmorder).Click();
        }
        public void Backhome()
        {
            driver.FindElement(backhome).Click();
        }

    }
}
