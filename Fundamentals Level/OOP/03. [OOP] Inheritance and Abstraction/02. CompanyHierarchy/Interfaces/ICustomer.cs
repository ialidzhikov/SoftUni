using System;

namespace Interfaces
{
    public interface ICustomer : IPerson
    {
        double NetPurchaseAmount { get; set; }
    }
}
