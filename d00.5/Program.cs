using System;
using System.Linq;
using System.Collections.Generic;

namespace d00_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new CashRegister[]
            {
                new CashRegister("Alpha"),
                new CashRegister("Beta"),
                new CashRegister("Charly")
            };

            var store = new Storage(40);

            var customers = new List<Customer>
            {
                new Customer("Kover", 0),
                new Customer("Andru", 1),
                new Customer("Anbu", 2),
                new Customer("Onbu", 3),
                new Customer("Abu", 4),
                new Customer("Apu", 5),
                new Customer("Alladin", 6),
                new Customer("Jasmine", 7),
                new Customer("Ghafar", 8),
                new Customer("Raja", 9),
            };
            


            foreach (var cust in customers)
            {
                cust.FillCart(7);
                if (store.Elements >= cust.NumberInBasket)
                    store.Elements -= cust.NumberInBasket;
                else if (store.Elements < cust.NumberInBasket)
                    while (store.Elements != cust.NumberInBasket)
                        cust.FillCart(store.Elements);
                if (store.IsEmpty)
                    break;
            }
            
            customers.Where(x=>x.NumberInBasket == 0).ToList().ForEach(x=>customers.Remove(x));

            foreach(var customer in customers)
            {
                var cas = customer.ChooseEffectiveCashRegister(shop);
                cas.Customers.Enqueue(customer);
            }


            foreach (var cash in shop)
            {
                Console.WriteLine($"{cash}: {string.Join('\n', cash.Customers)}");
                cash.Customers.Clear();
            }
            foreach(var customer in customers)
            {
                customer.ChooseExtesiveCashRegister(shop).Customers.Enqueue(customer);
            }
            foreach (var cash in shop)
            {
                Console.WriteLine($"{cash}: {string.Join("\n\t", cash.Customers)}");
                cash.Customers.Clear();
            }
        }
    }
}
