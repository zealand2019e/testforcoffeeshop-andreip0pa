using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Cortado : Coffee
    {
        public Cortado()
        {
        }

        public override int price()
        {
            return 25;
        }

    }
}
