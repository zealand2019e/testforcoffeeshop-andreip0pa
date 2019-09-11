using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoffeTest
{
    [TestClass]
    public class UnitTestCoffeShop
    {
        [TestMethod]
        public void CoffePriceCortado()
        {

            //ARRANGE
            int price;
            CoffeeShopConsoleApp.Cortado c = new CoffeeShopConsoleApp.Cortado();

            //ACT
           price= c.price();

            //ASSERT
            Assert.AreEqual(price, 25);
        }
        [TestMethod]
        public void CoffePriceLatte()
        {

            //ARRANGE
            int price;
            CoffeeShopConsoleApp.Latte c = new CoffeeShopConsoleApp.Latte();

            //ACT
            price = c.price();

            //ASSERT
            Assert.AreEqual(price, 40);
        }
        [TestMethod]
        public void CoffePriceEspresso()
        {

            //ARRANGE
            int price;
            CoffeeShopConsoleApp.Espresso c = new CoffeeShopConsoleApp.Espresso("some blend");

            //ACT
            price = c.price();

            //ASSERT
            Assert.AreEqual(price, 20);
        }
        [TestMethod]
        public void CoffePriceFlatWhite()
        {

            //ARRANGE
            int price;
            CoffeeShopConsoleApp.FlatWhite c = new CoffeeShopConsoleApp.FlatWhite();

            //ACT
            price = c.price();

            //ASSERT
            Assert.AreEqual(price, 35);
        }
        [TestMethod]
        public void CoffePriceBlackCoffe()
        {

            //ARRANGE
            int price;
            CoffeeShopConsoleApp.BlackCoffee c = new CoffeeShopConsoleApp.BlackCoffee();

            //ACT
            price = c.price();

            //ASSERT
            Assert.AreEqual(price, 20);
        }
        [TestMethod]
        [DataRow( typeof(CoffeeShopConsoleApp.BlackCoffee) ,"Strong")]
        [DataRow(typeof(CoffeeShopConsoleApp.Cortado), "Medium")]
        [DataRow(typeof( CoffeeShopConsoleApp.Espresso), "Strong")]
        [DataRow(typeof(CoffeeShopConsoleApp.FlatWhite), "Medium")]
        [DataRow(typeof(CoffeeShopConsoleApp.Latte), "Weak")]
     
        public void TestCoffeStrength(System.Type coffeType, string strength)
        {

            object ob=new object();
            ob = System.Activator.CreateInstance(coffeType);
            

            string ty = coffeType.ToString();
            CoffeeShopConsoleApp.Coffee k = (CoffeeShopConsoleApp.Coffee)ob; 
           
                       Assert.AreEqual(k.Strength(), strength);

        }

    }
}
