namespace AndrewAndTheBilliardGame
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class AndrewAndTheBilliardGame
    {        
        public static void Main()
        {
            int numberOfProducts = int.Parse(Console.ReadLine());
            var stock = new Dictionary<string, decimal>();
            var validCustomers = new List<Customer>();

            for (int i = 0; i < numberOfProducts; i++)
            {
                string[] productsInStore = Console.ReadLine().Split('-');
                string product = productsInStore[0];
                decimal price = decimal.Parse(productsInStore[1]);

                if (!stock.ContainsKey(product))
                {
                    stock[product] = 0;
                }

                stock[product] = price;
            }

            string productsWanted = Console.ReadLine();
            while (productsWanted != "end of clients")
            {
                string[] orders = productsWanted.Split(new[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string customerName = orders[0];
                string productOrdered = orders[1];
                int quantity = int.Parse(orders[2]);

                if (stock.ContainsKey(productOrdered))
                {
                    var newCustomer = new Customer();
                    newCustomer.Name = customerName;
                    newCustomer.ShopList = new Dictionary<string, int>();
                    newCustomer.ShopList.Add(productOrdered, quantity);
                    newCustomer.Bill = newCustomer.Bill + stock[productOrdered] * quantity;

                    validCustomers.Add(newCustomer);
                }

                productsWanted = Console.ReadLine();
            }

            decimal totalBill = 0M;

            foreach (var customer in validCustomers.OrderBy(c => c.Name))
            {
                Console.WriteLine(customer.Name);
                foreach (var product in customer.ShopList)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }

                Console.WriteLine($"Bill: {customer.Bill:F2}");
                totalBill += customer.Bill;
            }

            Console.WriteLine($"Total bill: {totalBill:F2}");
        }        
    }
}
