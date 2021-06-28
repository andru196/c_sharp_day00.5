namespace d00_5
{
    public class Customer
    {
        public int Number {get;}
        public string Name {get;}

        public uint NumberInBasket {get; private set;}
        

        public Customer (string name, int num)
        {
            Name = name;
            Number = num;
            NumberInBasket = 0;
        }

        public static bool operator ==(Customer a, Customer b) => a?.Equals(b) ?? b as object == null;
        public static bool operator !=(Customer a, Customer b) => !a?.Equals(b) ?? b as object != null;

        public void FillCart(uint max)
        {
            var rand = new System.Random();
            NumberInBasket += (uint)rand.Next(1, (int)max);
        }
        public override bool Equals(object o)
        {
            var cust = o as Customer;
            return cust != null
                && (cust.Number == Number)
                    && (cust.Name == Name);
        }

        public override string ToString()
            => $"{Number} - {Name}\t{NumberInBasket}";

    }
}