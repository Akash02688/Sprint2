//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Tricentis_project.Application_Hooks;

//namespace Tricentis_project.StepDefinitions
//{
//    [Binding]
//    public class Jewelry_steps : Applicationhooks
//    {
//        [Given(@"User is on home page of tricentis\.")]
//        public void GivenUserIsOnHomePageOfTricentis_()
//        {
//            lp.Login();
//            lp.UserEmail();
//            lp.Password();
//            Thread.Sleep(2000);
//            //throw new PendingStepException();
//        }

//        [When(@"User clicks on Jewelry button")]
//        public void WhenUserClicksOnJewelryButton()
//        {
//            lp.Loginbutton();
//            jp.Jewel();
//            Thread.Sleep(1000);
//            //throw new PendingStepException();
//        }

//        [When(@"user adds item to cart")]
//        public void WhenUserAddsItemToCart()
//        {
//            jp.Heart_item();
//            Thread.Sleep(1000);
//            jp.Button();
//            //throw new PendingStepException();
//        }

//        [Then(@"user is able to add items to cart successfully\.")]
//        public void ThenUserIsAbleToAddItemsToCartSuccessfully_()
//        {
//            Console.WriteLine("User is able to add successfully");
//            //throw new PendingStepException();
//        }

//    }
//}
