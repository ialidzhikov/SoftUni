using System;

namespace TheSlum.Items
{
    public class Injection : Bonus
    {
        private const int DefaultHealthEffect = 200;
        private const int DefaultDefenseEffect = 0;
        private const int DefaultAttackEffect = 0;
        private const int DefaultTimeout = 3;
        public Injection(string id) 
            : base (id, DefaultHealthEffect, DefaultDefenseEffect, DefaultAttackEffect)
        {
            this.Timeout = DefaultTimeout;
            this.Countdown = DefaultTimeout;
        }
    }
}
