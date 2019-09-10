using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Espresso : Coffee, ICoffeeBlend
    {
        private string coffeeBlend;
        public Espresso(string coffeblend)
            :base()
        {
            this.coffeeBlend = coffeblend;
        }

        public string CoffeeBlend()
        {
            return coffeeBlend;
        }

        public override string Strength()
        {
            return "Strong";
        }

    }
}
