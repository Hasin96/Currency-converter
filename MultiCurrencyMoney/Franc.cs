using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            _amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(_amount * multiplier);
        }

    }
}
