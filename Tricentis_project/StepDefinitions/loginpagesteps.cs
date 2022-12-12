//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Tricentis_project.Application_Hooks;

//namespace Tricentis_project.StepDefinitions
//{
//    [Binding]
//    public class loginpagesteps : Applicationhooks
//    {
//        [Given(@"user navigates to LoginPage")]
//        public void GivenUserNavigatesToLoginPage()
//        {
//            lp.Login();
//            //throw new PendingStepException();
//        }

//        [When(@"I enter Username and Password")]
//        public void WhenIEnterUsernameAndPassword()
//        {
//            Thread.Sleep(2000);
//            lp.UserEmail();
            
//            lp.Password();
//            Console.WriteLine("hello");
//            //throw new PendingStepException();
//        }

//        [Then(@"login should be successful")]
//        public void ThenLoginShouldBeSuccessful()
//        {
//            Thread.Sleep(2000);
//            lp.Loginbutton();
//            Console.WriteLine("hii");
//            //throw new PendingStepException();
//        }

//    }
//}
