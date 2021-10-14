using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FSIS_autTest
{
    
    public class PagesNavigating
    {
        [Fact]
        [Trait("Category", "Smoke")]
        public void OpenMainPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://floodsimple.huisdigital.com/");
                driver.Manage().Window.FullScreen();

                driver.Navigate().GoToUrl("http://floodsimple.huisdigital.com/faq");
                DemoHelper.Pause();
                driver.Navigate().GoToUrl("http://floodsimple.huisdigital.com/insurance-agents");
                DemoHelper.Pause();
                driver.Navigate().GoToUrl("http://floodsimple.huisdigital.com/http:/floodsimple.huisdigital.com/contact");
                DemoHelper.Pause();
                driver.Navigate().GoToUrl("http://floodsimple.huisdigital.com/quote");
                DemoHelper.Pause();
            }
        }
    }
}
