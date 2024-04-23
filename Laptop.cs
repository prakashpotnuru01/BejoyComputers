using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BejoyComputers
{
    public class Laptop:Computer
    {
        public int DisplaySize;
        public int BatteryVolt;

        public Laptop(string processor,int ramSize,int hardDiskSize,int graphicCard):base(processor,ramSize,hardDiskSize,graphicCard)
        {
             this.DisplaySize=displaySize;
            this.BatteryVolt=batteryVolt;
        }

        public double LaptopPriceCalculation()
        {
            double laptopPrice = 0;
            return laptopPrice;
        }
    }
}