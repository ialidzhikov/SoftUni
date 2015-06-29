using System;

namespace TheSlum.Items
{
    public class Pill : Bonus
    {
        private const int DefaultHealthEffect = 100;
        private const int DefaultDefenseEffect = 0;
        private const int DefaultAttackEffect = 0;
        private const int DefaultTimeout = 1;
        public Pill(string id) 
            : base (id, DefaultHealthEffect, DefaultDefenseEffect, DefaultAttackEffect)
        {
            this.Timeout = DefaultTimeout;
            this.Countdown = DefaultTimeout;
        }
    }
}
