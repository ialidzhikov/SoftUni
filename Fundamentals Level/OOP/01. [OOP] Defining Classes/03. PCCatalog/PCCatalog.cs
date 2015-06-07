using System;
using System.Collections.Generic;
using System.Linq;

namespace PCCatalog
{
    using Computer;
    using Component;
    class PCCatalog
    {
        static void Main()
        {
            Computer appleComputer = new Computer(
                "Apple",
                new List<Component>()
                {
                    new Component(ComponentName.Processor, "3 MB cache", 50), 
                    new Component(ComponentName.HardDisk, "128 GB SSD", 200), 
                    new Component(ComponentName.GraphicsCard, "Nvidia", 320),
                    new Component(ComponentName.RAM, 400),
                });

            Computer lenovoComputer = new Computer(
                "Lenovo",
                new List<Component>()
                {
                    new Component(ComponentName.Motherboard, 100),
                    new Component(ComponentName.HardDisk, "1 TB HDD", 300), 
                    new Component(ComponentName.Processor, "3 MB cache", 80), 
                    new Component(ComponentName.GraphicsCard, 32),
                    new Component(ComponentName.RAM, 150),
                });

            Computer dellComputer = new Computer(
                "Dell",
                new List<Component>()
                {
                    new Component(ComponentName.Motherboard, 100),
                    new Component(ComponentName.HardDisk, "512 GB SSD", 1200), 
                    new Component(ComponentName.Processor, "Intel Core i7", 180),
                });

            Computer[] computers = new Computer[]
            {
                appleComputer,
                lenovoComputer,
                dellComputer,
            };

            Computer[] sortedComputers = computers.OrderBy(computer => computer.Price).ToArray();

            for (int i = 0; i < sortedComputers.Length; i++)
            {
                Console.WriteLine(sortedComputers[i]);
                Console.WriteLine();
            }
        }
    }
}
