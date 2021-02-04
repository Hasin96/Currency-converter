using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney
{
    public class Money 
    {
        protected int _amount;
        protected string _currency;

        public Money(int amount, string currency)
        {
            _amount = amount;
            _currency = currency;
        }

        public string Currency() => _currency;

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Money money = (Money)obj;

            return this._amount == money._amount && Currency().Equals(money.Currency());
        }

        public static Money Dollar(int value)
        {
            return new Money(value, "USD");
        }

        public static Money Franc(int value)
        {
            return new Money(value, "CHF");
        }

        public Money Times(int multiplier)
        {
            return new Money(_amount * multiplier, _currency);
        }
    }
}
