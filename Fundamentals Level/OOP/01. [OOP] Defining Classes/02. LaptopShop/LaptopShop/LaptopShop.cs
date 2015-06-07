using System;
using System.Collections.Generic;
using LaptopParts;

namespace LaptopShop
{
    using Laptop;
    public class LaptopShop
    {
        static void Main()
        {
            Laptop laptopLenovo = new Laptop("Lenovo Yoga 2 Pro", 2259)
            {
                Manufacturer = "Lenovo",
                Processor = new Processor("Intel Core i5-4210U", 2, new Tuple<double, double>(1.70, 2.70), 3),
                RamMemory = 8,
                GraphicsCard = "Intel HD Graphics 4400",
                HardDisk = new HardDisk("SSD", 128),
                Screen = new Screen(13.3, new Tuple<int, int>(3200, 1800), "QHD+", "IPS sensor display"),
                Battery = new Battery("Li-Ion", 4, 2550, 4.5),
            };

            Laptop laptopHP = new Laptop("HP 250 G2", 699);

            Console.WriteLine(laptopLenovo);
            Console.WriteLine();
            Console.WriteLine(laptopHP);
        }
    }
}
