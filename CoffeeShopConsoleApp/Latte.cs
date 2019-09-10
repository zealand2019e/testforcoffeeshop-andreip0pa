using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Latte : Coffee
    {
        public Latte()
        {
        }

        public override int price()
        {
            return 40;
        }
    }
}
