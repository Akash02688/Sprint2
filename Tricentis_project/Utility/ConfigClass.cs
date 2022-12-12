using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Tricentis_project.Utility
{
    public class ConfigClass
    {
        public static IWebDriver? driver;
        public static string chromeDriverPath = @"C:\Users\Akash\Documents\C#\Tricentis_project\Tricentis_project\Driver\chromedriver_win32 (3)\";
        //public static string geckoDriverPath = @"C:\Users\username\source\repos\SeleniumSpecFlowPO\SeleniumSpecFlowPO\drivers\";

        public static string url = "https://demowebshop.tricentis.com/";

       public static string filePath = @"C:\Users\Akash\Documents\C#\Tricentis_project\Tricentis_project\screenshot\";

        public static int PAGE_LOAD_TIMEOUT = 10;
        public static int IMPLICIT_WAIT = 10;

        public static Actions? action;
    }
}
