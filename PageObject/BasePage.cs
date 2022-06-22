using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumRozetka.PageObject
{
    class BasePage
    {
        protected AppiumDriver<AndroidElement> driver;
        public BasePage(AppiumDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }
    }
}
