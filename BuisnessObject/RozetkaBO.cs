using AppiumDemo.PageObject;
using AppiumRozetka.PageObject;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumDemo.BuisnessObject
{
    public class RozetkaBO
    {
        private readonly BasePage basePage;
        private readonly HomePage homePage;
        private readonly SearchPage searchPage;
        private readonly CartPage cartPage;
 

        public RozetkaBO(AppiumDriver<AndroidElement> driver)
        {
            basePage = new BasePage(driver);
            homePage = new HomePage(driver);
            searchPage = new SearchPage(driver);
            cartPage = new CartPage(driver);
        }

        public RozetkaBO GoToSearchPage()
        {
            homePage.ClickClosePopup().SearchButton();
            return this;
        }
        public RozetkaBO SearchByKeyword(string query)
        {
            searchPage.ClickOnSearchInput().SearchByKeyword(query);
            return this;
        }
        public RozetkaBO ClickHelper()
        {
            searchPage.SearchHelperResult();
            return this;
        }
        public string GetProductText()
        {
            return searchPage.GetProductText();

        }
        public RozetkaBO GoToCatalog()
        {
            homePage.ClickClosePopup().CatalogButton();
            return this;
        }
        public RozetkaBO ClickCategoryTab()
        {
            searchPage.TabClick();
            return this;
        }
        public RozetkaBO ClickTab()
        {
            searchPage.ProductTabClick();
            return this;
        }
        public RozetkaBO Sorting()
        {
            searchPage.SortOrderClick();
            return this;
        }
        public RozetkaBO AddToCart()
        {
            searchPage.AddToCartClick();
            return this;
        }
        public RozetkaBO GoToCart()
        {
            searchPage.CartButtonClick();
            return this;
        }
        public string GetCartCount()
        {
            return cartPage.GetCartCount();
        }
    }
}
