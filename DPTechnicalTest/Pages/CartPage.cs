using OpenQA.Selenium;


namespace DPTechnicalTest.Pages
{
    internal class CartPage : BasePage
    {
        public CartPage(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement UI_AddToCart_Button_FlyingNinja => Driver.FindElement(By.CssSelector("a[aria-label='Add “Flying Ninja” to your cart']"));

        private IWebElement UI_AddToCart_Button_NinjaSilhouette => Driver.FindElement(By.XPath("//a[@aria-label='Add “Ninja Silhouette” to your cart']"));
        private IWebElement UI_AddToCart_Button_ShipYourIdea => Driver.FindElement(By.XPath("//a[@aria-label='Add “Ship Your Idea” to your cart']"));

        private IWebElement UI_AddToCart_Button_PatientNinja => Driver.FindElement(By.XPath("//a[@aria-label='Add “Patient Ninja” to your cart']"));
   
        private IWebElement UI_Cart_Button => Driver.FindElement(By.XPath("  //a[text()='Cart']"));

        private IWebElement UI_CartUpdateMessage_Element => Driver.FindElement(By.CssSelector("div.woocommerce-message"));

        private IWebElement UI_RemoveItem_Button => Driver.FindElement(By.XPath("//tbody/tr[3]/td[1]/a[1]"));
    
        internal void NavigateToHome()
        {
            Driver.Navigate().GoToUrl(AppConfigReader.GetUrl);
        }

        public void AddToCart()
        {

            Thread.Sleep(2000);
            UI_AddToCart_Button_FlyingNinja.Click();
            Thread.Sleep(2000);
            UI_AddToCart_Button_NinjaSilhouette.Click();
            Thread.Sleep(2000);
            UI_AddToCart_Button_PatientNinja.Click();
            Thread.Sleep(2000);
            UI_AddToCart_Button_ShipYourIdea.Click();
        }
        public void ViewCart()
        {
            UI_Cart_Button.Click();      
        }
        public IList<IWebElement> GetCartProductRows()
        {
            // Find all the product rows in the cart table
            var productRows = Driver.FindElements(By.XPath("//table[@class='shop_table shop_table_responsive cart woocommerce-cart-form__contents']//tr[contains(@class, 'cart_item')]"));
            return productRows;
        }
        public void SearchForLowerPricedItem()
        {
            // Find all the product rows in the cart table
            var productRows = GetCartProductRows();

            // Find the product with the lowest price
            var lowestPriceProduct = productRows.OrderBy(GetPrice).FirstOrDefault();
        }
        private decimal GetPrice(IWebElement productElement)
        {
            var priceElement = productElement.FindElement(By.XPath(".//span[@class='woocommerce-Price-amount amount']"));

            // Extract the price text from the element and remove any currency symbols or special characters
            var priceText = priceElement.Text.Replace("$", "").Replace(",", "").Trim();

            // Parse the price text to a decimal value
            if (decimal.TryParse(priceText, out decimal price))
            {
                return price;
            }

            // Return a default value if the price couldn't be parsed
            return 0;
        }

        public void RemoveLowestPriceItemFromCart()
        {
            UI_RemoveItem_Button.Click();
            }
        }
    }


    
    


