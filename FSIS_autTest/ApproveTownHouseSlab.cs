using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace FSIS_autTest
{
    public class ApproveTownHouse
    {
        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadQuotePage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://staging.floodsimple.com/quote");
                //driver.Manage().Window.FullScreen();

                DemoHelper.Pause();

                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/div/div/input")).SendKeys("2745 PEACHTREE RUN RD, DOVER, DE 19901");
                //Input Address
                //You should change the address after running this test to avoid duplicate quotes
                
                DemoHelper.Pause();
              

                IWebElement continueButton = driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/button"));

                continueButton.Click();

                DemoHelper.Pause();

                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/div[1]/div[2]/div[2]/input")).SendKeys("75000");
                //Input Coverage
                
                DemoHelper.Pause();

                IWebElement continueButton1 = driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/button"));

                continueButton1.Click();

                DemoHelper.Pause();

                IWebElement propertyType = driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/ul/li[2]/button"));

                propertyType.Click();
                //Select "Condo/Townhouse"
                DemoHelper.Pause();

                IWebElement TypeDropdown = driver.FindElement(By.ClassName("mat-select-arrow"));

                TypeDropdown.Click();
                //Open dropdown list
                DemoHelper.Pause();

                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/mat-option[3]")).Click();
                //Select "Townhouse"
                DemoHelper.Pause();

                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/ul/li[1]/button")).Click();
                //Select "Home on Slab"
                DemoHelper.Pause();

                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/div/div[1]/input")).SendKeys("1500");
               //Input Square Footage
                DemoHelper.Pause();

                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/div/mat-radio-group/mat-radio-button[2]/label/div[1]")).Click();
                //Flood Loss - NO
                DemoHelper.Pause();


                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/button")).Click();

                DemoHelper.Pause();

                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/div/div[1]/div[1]/input")).SendKeys("ApproveTownhouseTestDE");
                //Input First Name
                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/div/div[1]/div[2]/input")).SendKeys("ApproveTownhouseTestDE");
                //Input Last Name
                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/div/div[1]/div[3]/input")).SendKeys("test@huisdigital.com");
                //Input Email
                DemoHelper.Pause();
                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/div/button")).Click();
                //Click "Email Quote"
                DemoHelper.Pause(7000);
            }
        }
    }
}
