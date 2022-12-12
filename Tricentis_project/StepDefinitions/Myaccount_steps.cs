using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricentis_project.Application_Hooks;

namespace Tricentis_project.StepDefinitions
{
    [Binding]
    public class Myaccount_steps : Applicationhooks

    {
        [Given(@"Open Browser and enter url for the website\.")]
        public void GivenOpenBrowserAndEnterUrlForTheWebsite_()
        {
            lp.Login();
            // throw new PendingStepException();
        }

        [When(@"user enters userid and password")]
        public void WhenUserEntersUseridAndPassword()
        {
            lp.UserEmail();
            lp.Password();
            Thread.Sleep(2000);
            //throw new PendingStepException();
        }

        [When(@"clicks on login button\.")]
        public void WhenClicksOnLoginButton_()
        {
            lp.Loginbutton();
            Thread.Sleep(2000);
            //throw new PendingStepException();
        }

        [When(@"clicks on My account\.")]
        public void WhenClicksOnMyAccount_()
        {
            mi.Myacc();
            //throw new PendingStepException();
        }

        [When(@"user able to update details\.")]
        public void WhenUserAbleToUpdateDetails_()
        {
            mi.Gender();
            Thread.Sleep(2000);
            mi.Firstname();
            mi.Lastname();
            //throw new PendingStepException();
        }

        [When(@"clicks on save\.")]
        public void WhenClicksOnSave_()
        {
            mi.Save();
            //throw new PendingStepException();
        }

        [Then(@"user is able to update successfully\.")]
        public void ThenUserIsAbleToUpdateSuccessfully_()
        {
            Console.WriteLine("user updated successfully");
            //throw new PendingStepException();
        }


    }
}
