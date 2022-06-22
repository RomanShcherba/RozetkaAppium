using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using AppiumDemo.BuisnessObject;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;

namespace AppiumRozetka.Tests
{
    [TestFixture]
    [AllureNUnit]
    [AllureSuite("Rozetka app tests")]
    [AllureDisplayIgnored]

    class BaseTest
    {
        protected AndroidDriver<AndroidElement> driver;

        private RozetkaBO rozetkaBO;
        private readonly string expectedText = "Ноутбуки";
        private readonly string expectedProduct = "Телевізор Philips 55PUS7906/12";
        private readonly string query = "ноутбуки";


        [SetUp]
        public void SetUp()
        {
            rozetkaBO = new RozetkaBO(AndroidDriver.AndroidDriver.getDriver());
        }
        [Test(Description = "Searching product")]
        [AllureOwner("Roman")]
        [AllureSubSuite("Search test")]
        public void SearchTest()
        {
            rozetkaBO.GoToSearchPage();
            rozetkaBO.SearchByKeyword(query);
            rozetkaBO.ClickHelper();
            Assert.AreEqual(rozetkaBO.GetProductText(), expectedText);
            
        }

        [Test(Description = "Adding an item to wishlist test")]
        [AllureOwner("Roman")]
        [AllureSubSuite("Add to cart test")]
        public void AddToCartTest()
        {
            rozetkaBO.GoToCatalog();
            rozetkaBO.ClickCategoryTab();
            rozetkaBO.ClickTab();
            rozetkaBO.Sorting();
            rozetkaBO.AddToCart();
            rozetkaBO.GoToCart();
            Assert.AreEqual(rozetkaBO.GetCartCount(), expectedProduct);

        }
        [TearDown]
       public void CleanUp()
        {
            AndroidDriver.AndroidDriver.quitDriver();
        }
    }
}
