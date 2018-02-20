namespace AndrewAndTheBilliardGame
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Customer
    {
        public string Name { get; set; }

        public Dictionary<string, int> ShopList { get; set; }

        public decimal Bill { get; set; }
    }
}
