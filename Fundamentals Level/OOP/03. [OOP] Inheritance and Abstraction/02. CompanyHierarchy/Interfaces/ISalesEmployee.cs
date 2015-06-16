using System;
using System.Collections.Generic;
using Sales;

namespace Interfaces
{
    public interface ISalesEmployee : IRegularEmployee
    {
        List<Sale> Sales { get; set; }

        void AddSale(Sale sale);
    }
}
