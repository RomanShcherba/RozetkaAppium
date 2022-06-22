using NUnit.Allure.Attributes;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumRozetka.PageObject
{
    class HomePage : BasePage
    {
        public HomePage(AppiumDriver<AndroidElement> driver) : base(driver)
        {
        }
        public readonly string CloseButton = "ua.com.rozetka.shop:id/banner_iv_close";
        public readonly string OpenSearchButton = "ua.com.rozetka.shop:id/view_search_tv";

        public readonly string OpenCatalog = "ua.com.rozetka.shop:id/graph_fatMenu";


        [AllureStep("Clicked on close popup")]
        public HomePage ClickClosePopup()
        {
            driver.FindElementById(CloseButton).Click();
            return this;
        }
        [AllureStep("Clicked on catalog Button")]
        public HomePage CatalogButton()
        {
            driver.FindElementById(OpenCatalog).Click();
            return this;
        }
        [AllureStep("Clicked on the search line input")]
        public HomePage SearchButton()
        {
            driver.FindElementById(OpenSearchButton).Click();
            driver.Navigate().Back();
            driver.Navigate().Back();
            return this;
        }
        
    }
}
