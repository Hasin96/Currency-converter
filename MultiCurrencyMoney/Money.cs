using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney
{
    public class Money 
    {
        protected int _amount;

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (this.GetType() != obj.GetType())
                return false;

            Money money = (Money)obj;
            if (this._amount == money._amount)
                return true;
            else
                return false;
        }
    }
}
