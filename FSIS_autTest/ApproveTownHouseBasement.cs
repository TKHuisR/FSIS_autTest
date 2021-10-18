using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace FSIS_autTest
{
    public class ApproveTownHouse1
    {
        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicationPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://staging.floodsimple.com/quote");
                driver.Manage().Window.FullScreen();

                DemoHelper.Pause();

                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/div/div/input")).SendKeys("5953 W MULBERRY DR, PHOENIX, AZ 85033");
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

                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/mat-option[6]")).Click();
                //Select "Apartment"
                DemoHelper.Pause();

                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/ul/li[2]")).Click();
                //Select "Home with Basement"
                DemoHelper.Pause();

                driver.FindElement(By.ClassName("mat-select-arrow-wrapper")).Click();
                //Open dropdown list

                DemoHelper.Pause();
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/mat-option[1]")).Click();
                //Select "Full basement"

                DemoHelper.Pause();

                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/div/div[1]/input")).SendKeys("1500");
               //Input Square Footage
                DemoHelper.Pause();

                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/div/mat-radio-group/mat-radio-button[2]/label/div[1]")).Click();
                //Flood Loss - NO
                DemoHelper.Pause();


                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/button")).Click();

                DemoHelper.Pause();

                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/div/div[1]/div[1]/input")).SendKeys("AZ85033Test");
                //Input First Name
                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/div/div[1]/div[2]/input")).SendKeys("AZ85033Test");
                //Input Last Name
                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/div/div[1]/div[3]/input")).SendKeys("test@huisdigital.com");
                //Input Email
                DemoHelper.Pause();
                //driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/div/button")).Click();
                //Click "Email Quote"
                DemoHelper.Pause(7000);
            }
        }
    }
}
