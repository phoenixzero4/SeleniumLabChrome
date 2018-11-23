
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url= "https://blog.testproject.io/contact-us/";
            
            driver.FindElement(By.Name("your-name")).SendKeys("Brodi");
            driver.FindElement(By.Name("your-email")).SendKeys("OkanaganCollege@hotmail.com");
            driver.FindElement(By.Name("your-subject")).SendKeys("I am learning IWebDriverTests.");
            driver.FindElement(By.Name("your-message")).SendKeys("This is pretty cool stuff. I had no idea about this before");
            driver.FindElement(By.ClassName("wpcf7-form-control")).Submit();
          
        }
    }
}
