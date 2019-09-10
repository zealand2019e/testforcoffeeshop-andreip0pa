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

        }
    }
}
