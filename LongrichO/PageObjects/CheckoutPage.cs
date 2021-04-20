using LongrichO.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LongrichO.PageObjects
{

    class CheckoutPage
    {
        IWebDriver driver;

        public CheckoutPage()
        {
            driver = WebHook.driver;
        }
        IWebElement categories => driver.FindElement(By.CssSelector("#menu-main-menu > li:nth-child(2) > a"));
        IWebElement feminineCare => driver.FindElement(By.CssSelector("#menu-main-menu > li:nth-child(2) > ul > li:nth-child(2) > a"));
        IWebElement choseProduct => driver.FindElement(By.XPath("//*[@id='page_wrapper']/section/div/div/div[1]/div/div/div/div[2]/div/div/div/div[1]/a/img[2]"));
        IWebElement quantityBox => driver.FindElement(By.XPath("//*[@id='38']"));
        IWebElement addToCart => driver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div/div[1]/div[2]/div/form/div/div[2]/button"));
        IWebElement shoppingBasket => driver.FindElement(By.XPath("//*[@id='cart_area']/a/i"));
        IWebElement checkout => driver.FindElement(By.XPath("//*[@id='cart_area']/div/div/div/p[2]/a[2]"));
        IWebElement checkoutPage => driver.FindElement(By.XPath("//*[@id='page_header']/div[4]/div/div/div[2]/div/h2"));

        public void ClickCategories()
        {
            categories.Click();
        }

        public void ClickFemCare()
        {
            feminineCare.Click();
        }

        public void ClickProduct()
        {
            choseProduct.Click();
        }

        public void EnterQuantity(string ProductQty)
        {
            quantityBox.SendKeys(ProductQty);
        }

        public void ClickAddCart()
        {
            addToCart.Click();
        }
        public void ClickBasket()
        {
            shoppingBasket.Click();
        }
        public void ClickCheckout()
        {
            checkout.Click();
        }
        public bool DisplayCheckout()
        {
            return checkoutPage.Displayed;
        }
    }
}
