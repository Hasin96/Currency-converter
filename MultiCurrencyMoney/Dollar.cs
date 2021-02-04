using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            _amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(_amount * multiplier);
        }
    }
}
