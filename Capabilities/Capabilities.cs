﻿using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;

namespace AppiumRozetka.Capabilities
{
    public class Capabilities
    {
        private static readonly string PLATFORM_NAME_CAPABILITY = "Android";
        private static readonly string DEVICE_NAME_CAPABILITY = "emulator-5554";
        private static readonly string APP_PACKAGE_CAPABILITY = "ua.com.rozetka.shop";
        private static readonly string APP_ACTIVITY_CAPABILITY = "ua.com.rozetka.shop.screen.MainActivity";
        private static readonly string URI = "http://localhost:4723/wd/hub";

        public static AppiumOptions getCapabilities()
        {
            AppiumOptions driverOption = new AppiumOptions();
            driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformName, PLATFORM_NAME_CAPABILITY);
            driverOption.AddAdditionalCapability(MobileCapabilityType.DeviceName, DEVICE_NAME_CAPABILITY);
            driverOption.AddAdditionalCapability("appPackage", APP_PACKAGE_CAPABILITY);
            driverOption.AddAdditionalCapability("appActivity", APP_ACTIVITY_CAPABILITY);

            return driverOption;
        }

        public static Uri getAppiumServerUri()
        {
            try
            {
                return new Uri(URI);
            }
            catch (UriFormatException e)
            {
                Console.WriteLine(e);
            }
            return null;
        }
    }
}
