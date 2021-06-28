using System.Collections.Generic;

namespace d00_5
{
    public class CashRegister
    {
        public string Title {get; set;}

        public CashRegister(string title)
        {
            Title = title;
            Customers = new Queue<Customer>();
        }

        public Queue<Customer> Customers {get;}

        public override bool Equals(object o) =>
            (o as CashRegister)?.Title == Title;

        public override string ToString()
            => $"{Title}";
    }
}