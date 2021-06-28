using System.Collections.Generic;
using System.Linq;

namespace d00_5
{
    public static class CustomerExtensions
    {
        public static CashRegister ChooseEffectiveCashRegister(this Customer cust, IEnumerable<CashRegister> lst)
            => lst.OrderBy(x=>x.Customers.Sum(x=>x.NumberInBasket)).FirstOrDefault();

        public static CashRegister ChooseExtesiveCashRegister(this Customer cust, IEnumerable<CashRegister> lst)
            => lst.OrderBy(x=>x.Customers.Count).FirstOrDefault();
    }
}