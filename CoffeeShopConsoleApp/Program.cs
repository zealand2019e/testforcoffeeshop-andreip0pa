using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new Cortado(3),
                new BlackCoffee(4),
                new Latte(5),
                new Cortado(),
                new BlackCoffee(),
                new Latte(),
                new Espresso("Akmel Espresso")
            };


            foreach (var coffeeItem in orderList)
            {
                Console.WriteLine($"The price of the coffee is : {coffeeItem.price()} and the strength is {coffeeItem.Strength()}");
            }

            // an list that consists of objects that implements the IMilk interface
            var OrderListMilk = new List<IMilk>() {
                new Cortado(3),
                new Latte(5),
                new Cortado(),
                new Latte(),
            };

            foreach (var coffeeItem in OrderListMilk)
            {
                Console.WriteLine($"The amount of milk used is : {coffeeItem.MlMilk()}");
            }


            foreach (var coffeeItem in orderList)
            {
                if (coffeeItem is IMilk)
                {// the item implements the IMilk interface so I cast to this
                    IMilk cItem = coffeeItem as IMilk;
                    Console.WriteLine("see mme as an IMilk object");
                    //The only method in IMilk is MlMilk so I print it out 
                    Console.WriteLine($"Ml Milk used {cItem.MlMilk()}");
                }
                if (coffeeItem is ICoffeeBlend)
                {
                    ICoffeeBlend cBlend = coffeeItem as ICoffeeBlend;
                    Console.WriteLine("see me as an ICoffeBlend object");
                    //The only method in ICoffeBlend is the method CoffeeBlend so I print it out 
                    Console.WriteLine($"CoffeBlend:  {cBlend.CoffeeBlend()}");
                }

                Console.WriteLine($"The price of the coffee is : {coffeeItem.price()} and the strength is {coffeeItem.Strength()}");
            }






        }
    }
}
