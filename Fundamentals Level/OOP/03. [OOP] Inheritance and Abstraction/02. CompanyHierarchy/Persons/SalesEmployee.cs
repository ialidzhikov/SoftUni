using System;
using System.Collections.Generic;
using Interfaces;
using Sales;

namespace Persons
{
    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        #region Fields

        private List<Sale> sales;

        #endregion

        #region Constructors

        public SalesEmployee(string firstName, string lastName, string id, double salary, Department department)
            : base(firstName, lastName, id, salary, department)
        {
            this.Sales = new List<Sale>();
        }

        #endregion

        #region Porperties

        public List<Sale> Sales
        {
            get { return this.sales; }
            set { this.sales = value; }
        }

        #endregion

        #region Methods

        public void AddSale(Sale sale)
        {
            this.Sales.Add(sale);
        }

        public override string ToString()
        {
            return string.Format("{0}{1}Sales: {2}", base.ToString(), Environment.NewLine, string.Join(", ", this.Sales));
        }

        #endregion
    }
}
