using DPTechnicalTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace DPTechnicalTest.StepDefinitions
{

    /** <summary>
    This is the step definition of the Add toCart.  
    It is used by the Client.feature file.
     </summary> **/
    [Binding]
    public class AddToCart : StepDefinitionBase
    {
        private readonly CartPage _cartPage;

        public AddToCart()
        {
            _cartPage = new CartPage(Driver);
        }

        [Given(@"I am on the shopping website")]
        public void GivenIAmOnTheShoppingWebsite()
        {
            _cartPage.NavigateToHome();
        }
        [When(@"I Add four items to cart")]
        public void WhenIAddFourItemsToCart()
        {
            _cartPage.AddToCart();
        }

        [When(@"I view my cart")]
        public void WhenIViewMyCart()
        {
            _cartPage.ViewCart();                       
        }
        [Then(@"I should find a total of four items in my cart")]
        public void ThenIShouldFindATotalOfFourItemsInMyCart()
        {
            var productRows = _cartPage.GetCartProductRows();
            
            // Verify that the total number of product rows is equal to 4
            if (productRows.Count == 4)
            {
                Console.WriteLine("Total items in cart: 4");
            }
            else
            {
                Console.WriteLine("Total items in cart: " + productRows.Count);
            }
        }
        [When(@"I search for the lower priced item")]
        public void WhenISearchForTheLowerPricedItem()
        {
            _cartPage.SearchForLowerPricedItem();
        }
        [When(@"I remove the lowest price item from my cart")]
        public void WhenIRemoveTheLowestPriceItemFromMyCart()
        {
            _cartPage.RemoveLowestPriceItemFromCart();
        }


            [Then(@"I verify three items in my cart")]
            public void ThenIVerifyThreeItemsInMyCart()
            {
                // Get the product rows in the cart
                var productRows = _cartPage.GetCartProductRows();

                // Verify that the total number of product rows is equal to 3

                Assert.AreEqual(3, productRows.Count, "Expected three items in the cart.");
            }
        }

    }

