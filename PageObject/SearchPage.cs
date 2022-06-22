using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumRozetka.PageObject
{
    class SearchPage : BasePage
    {
        public SearchPage(AppiumDriver<AndroidElement> driver) : base(driver)
        {

        }
        public readonly string SearchInput = "ua.com.rozetka.shop:id/search_et_query";
        private readonly string SearchItem = "//androidx.cardview.widget.CardView[1]";
        private readonly string SortOrder = "ua.com.rozetka.shop:id/section_ll_sort";

        private readonly string Tab = "//android.widget.LinearLayout[2]";
        private readonly string ProductTab = "//androidx.recyclerview.widget.RecyclerView";
        private readonly string RadioButton = "//android.widget.RadioButton[3]";
        private readonly string AddToCartButton = "//(//android.widget.ImageView[@content-desc='Додати в кошик'])[1]";
        private readonly string CartButton = "ua.com.rozetka.shop:id/graph_cart";
        private readonly string ProductText = "//android.widget.TextView";

        [AllureStep("Clicked on the search input")]
        public SearchPage ClickOnSearchInput()
        {
            driver.FindElementById(SearchInput).Click();
            return this;
        }
        [AllureStep("Writed the query")]
        public void SearchByKeyword(string query)
        {
            driver.FindElementById(SearchInput).SendKeys(query);
        }
        [AllureStep("Clicked on the search helper tab")]
        public void SearchHelperResult()
        {
            driver.FindElementByXPath(SearchItem).Click();
        }
        [AllureStep("Clicked on the category tab")]
        public void TabClick()
        {
            driver.FindElementByXPath(Tab).Click();
        }
        [AllureStep("Clicked on the product tab")]
        public void ProductTabClick()
        {
            driver.FindElementByXPath(ProductTab).Click();
        }
        [AllureStep("Open sorting and clicked on popular radiobutton")]
        public void SortOrderClick()
        {
            driver.FindElementById(SortOrder).Click();
            driver.FindElementByXPath(RadioButton).Click();
        }
        [AllureStep("Click on add to cart button")]
        public void AddToCartClick()
        {
            driver.FindElementByXPath(AddToCartButton).Click();
        }
        [AllureStep("Clicked on cart button")]
        public void CartButtonClick()
        {
            driver.FindElementById(CartButton).Click();
        }
        [AllureStep("Get text of search product")]
        public string GetProductText()
        {
            return driver.FindElementByXPath(ProductText).Text;
        }
    }
}
