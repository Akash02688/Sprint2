using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricentis_project.Pages;
using Tricentis_project.Utility;

namespace Tricentis_project.Application_Hooks
{
    public class Applicationhooks : utility
    {
        public Loginpage lp;
        public Myaccount mi;
        public jewelry_page jp;
        public Payement_page pg;
          
        [BeforeScenario]
        public void BeforeScenario()
        {
            LaunchBrowser("CHROME");
            browserMaximize();
            LaunchApp(url);

            Thread.Sleep(5000);
            lp= new Loginpage(driver);
            mi=new Myaccount(driver);
            jp= new jewelry_page(driver);
            pg= new Payement_page(driver);
        }
        [AfterScenario]
        public void AfterScenario()
        {
            Thread.Sleep(5000);
            CloseBrowser();
        }
    }
}
