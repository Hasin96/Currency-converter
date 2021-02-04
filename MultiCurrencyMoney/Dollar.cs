using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney
{
    public class Dollar
    {
        public int Amount;
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

        public bool Equals(Dollar obj)
        {
            if (this.Amount == obj.Amount)
                return true;
            else
                return false;
        }
    }
}
