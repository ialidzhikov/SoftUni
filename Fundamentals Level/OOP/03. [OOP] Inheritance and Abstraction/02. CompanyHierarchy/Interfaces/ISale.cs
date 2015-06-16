using System;

namespace Interfaces
{
    public interface ISale
    {
        string ProductName { get; set; }

        DateTime Date { get; set; }

        double Price { get; set; }  

    }
}
