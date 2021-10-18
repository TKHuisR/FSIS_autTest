using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FSIS_autTest
{
    public class DeclineByMobile
    {
        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicationPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://floodsimple.huisdigital.com/quote");
                //driver.Manage().Window.FullScreen();

                DemoHelper.Pause();

                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/div/div/input")).SendKeys("4847 W TENNESSEE AVE, DENVER, CO 80219");
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

                IWebElement propertyType = driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/ul/li[1]/button/h3"));
                //Select "House" option
                propertyType.Click();

                DemoHelper.Pause();

                IWebElement PrTypeSelect = driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/ul/li[1]/div/app-field-select2/mat-form-field/div/div[1]/div[3]/mat-select/div/div[2]"));

                IWebElement TypeDropdown = driver.FindElement(By.ClassName("mat-select-arrow-wrapper"));

                TypeDropdown.Click();
                //Open dropdown list
                DemoHelper.Pause();

                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/mat-option[6]")).Click();
                //Select "Mobile Home - Permanent Foundation"
                DemoHelper.Pause();

                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/ul/li[3]/button")).Click();
                //Select "Home on Stilts or Pilings"
                DemoHelper.Pause();

                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/div/div[1]/input")).SendKeys("2790");
                //Input The Square Footage
                DemoHelper.Pause();

                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/div/mat-radio-group/mat-radio-button[2]/label/div[1]")).Click();
                //Flood Loss - NO
                DemoHelper.Pause();


                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/button")).Click();

                DemoHelper.Pause();

                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/div/div[1]/div[1]/input")).SendKeys("DeclineByMobile");
                //Input First Name
                driver.FindElement(By.XPath("/html/body/app-root/div/section/app-quote/div[1]/div/div/div[1]/div[2]/input")).SendKeys("DeclineByMobile");
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


