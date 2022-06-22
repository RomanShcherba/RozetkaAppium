using AppiumRozetka.PageObject;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumDemo.PageObject
{
    class CartPage : BasePage
    {
        public CartPage(AppiumDriver<AndroidElement> driver) : base(driver)
        {
        }

        private readonly string CartCount = "ua.com.rozetka.shop:id/item_cart_offer_tv_title";


        public string GetCartCount()
        {
            return driver.FindElementById(CartCount).Text;
        }
    }
}
