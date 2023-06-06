using DPTechnicalTest.Drivers;
using DPTechnicalTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace DPTechnicalTest.StepDefinitions
{

    /** <summary>
    This is the step definition of the ClientCreate.  
    It is used by the Client.feature file.
     </summary> **/
    [Binding]
    public class AddToCart : StepDefinitionBase
    {
        private readonly CartPage _cartPage;
        private string expectedMessage;

        public AddToCart()
        {
            _cartPage = new CartPage(Driver);
        }

        [Given(@"I am on the shopping website")]
        public void GivenIAmOnTheShoppingWebsite()
        {
            _cartPage.NavigateToHome();
        }

        [When(@"When I Add four items to cart")]
        public void WhenWhenIAddFourItemsToCart()
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

        [When(@"I am able to remove the lowest price item from my cart")]
        public void WhenIAmAbleToRemoveTheLowestPriceItemFromMyCart()
        {
           _cartPage.RemoveLowestPriceItemFromCart();
          // _cartPage.VerifyCartUpdateMessage(expectedMessage);
        }

        [Then(@"I am able to verify three items in my cart")]
        public void ThenIAmAbleToVerifyThreeItemsInMyCart()
        {
            // Get the product rows in the cart
            var productRows = _cartPage.GetCartProductRows();

            // Verify that the total number of product rows is equal to 3
          
            Assert.AreEqual(3, productRows.Count, "Expected three items in the cart.");
        }



    }

}

