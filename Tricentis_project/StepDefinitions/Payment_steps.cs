//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Tricentis_project.Application_Hooks;

//namespace Tricentis_project.StepDefinitions
//{
//    [Binding]
//    public class Payment_steps : Applicationhooks
//    {
//        [Given(@"User is on home page of tricentirs\.")]
//        public void GivenUserIsOnHomePageOfTricentirs_()
//        {
//            lp.Login();
//            lp.UserEmail();
//            lp.Password();
//            Thread.Sleep(3000);
//            //throw new PendingStepException();
//        }

//        [When(@"User should login using registered email-id and password\.")]
//        public void WhenUserShouldLoginUsingRegisteredEmail_IdAndPassword_()
//        {
//            lp.Loginbutton();
//            //throw new PendingStepException();
//        }

//        [When(@"user should be able to select apparel and shoes section\.")]
//        public void WhenUserShouldBeAbleToSelectApparelAndShoesSection_()
//        {
//            pg.Apparel();
//            //throw new PendingStepException();
//        }

//        [When(@"user is able to add items into the carts\.")]
//        public void WhenUserIsAbleToAddItemsIntoTheCarts_()
//        {
//            pg.Top();
//            pg.Cart();
//            Thread.Sleep(2000);
//            pg.Pant();
//            pg.Enter();
//            Thread.Sleep(2000);
//            //throw new PendingStepException();
//        }

//        [When(@"user is able to click on shopping cart\.")]
//        public void WhenUserIsAbleToClickOnShoppingCart_()
//        {
//            pg.Scart();
//            pg.Tbox();
//            Thread.Sleep(2000);

//            //throw new PendingStepException();
//        }

//        [When(@"user is able to click on checkout\.")]
//        public void WhenUserIsAbleToClickOnCheckout_()
//        {
//            pg.Checkout();
//            //throw new PendingStepException();
//        }

//        [When(@"user is able to click on billing address\.")]
//        public void WhenUserIsAbleToClickOnBillingAddress_()
//        {
//            pg.Billadd();
//            Thread.Sleep(2000);
//            //throw new PendingStepException();
//        }

//        [When(@"user is able to click on shipping address\.")]
//        public void WhenUserIsAbleToClickOnShippingAddress_()
//        {
//            pg.Shipadd();
//            Thread.Sleep(2000);
//            //throw new PendingStepException();
//        }

//        [When(@"user is able to click on shipping method\.")]
//        public void WhenUserIsAbleToClickOnShippingMethod_()
//        {
//            pg.Shipmethod();
//            Thread.Sleep(2000);
//            pg.Cont();
//            //throw new PendingStepException();
//        }

//        [When(@"user is able to click on payment method\.")]
//        public void WhenUserIsAbleToClickOnPaymentMethod_()
//        {
//            //pg.Payoption();
//            Thread.Sleep(2000);
//            //pg.Con();
//            pg.Payselect();
//            Thread.Sleep(2000);
//            pg.Con();
//            //throw new PendingStepException();
//        }

//        [When(@"user is able to click on payment information\.")]
//        public void WhenUserIsAbleToClickOnPaymentInformation_()
//        {
//            Thread.Sleep(1000);
//            pg.PayInfo();
//            Thread.Sleep(1000);
//            //throw new PendingStepException();
//        }

//        [When(@"user is able to click on confirm order\.")]
//        public void WhenUserIsAbleToClickOnConfirmOrder_()
//        {
//            pg.Confirmorder();
//            Thread.Sleep(2000);
//            //throw new PendingStepException();
//        }

//        [When(@"user able to click on continue button\.")]
//        public void WhenUserAbleToClickOnContinueButton_()
//        {
//            pg.Backhome();
//            Thread.Sleep(2000);
//            //throw new PendingStepException();
//        }

//        [Then(@"user able to make order successfully\.")]
//        public void ThenUserAbleToMakeOrderSuccessfully_()
//        {
//            Console.WriteLine("Payment done successfully");
//            //throw new PendingStepException();
//        }

//    }
//}
