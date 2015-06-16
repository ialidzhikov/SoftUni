using System;
using Interfaces;

namespace Persons
{
    public class Customer : Person, ICustomer
    {
        #region Fields

        private double netPurchaseAmount;

        #endregion

        #region Constructors

        public Customer(string firstName, string lastName, string id, double netPurchaseAmount)
            : base(firstName, lastName, id)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        #endregion

        #region Properties

        public double NetPurchaseAmount
        {
            get { return this.netPurchaseAmount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The net purchase amount cannot be nagative.");
                }
                else
                {
                    this.netPurchaseAmount = value;
                }
            }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("{0} {1,-10:C2}", base.ToString(), this.NetPurchaseAmount);
        }

        #endregion
    }
}
