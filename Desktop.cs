using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BejoyComputers
{
    public class Desktop:Computer
    {
        public int MonitorSize;
        public int PowerSupplyVolt;

        public Desktop(string processor,int ramSize,int hardDiskSize,int graphicCard,int monitorSize,int powerSupplyVolt):base(processor,ramSize,hardDiskSize,graphicCard)
        {
            this.MonitorSize = monitorSize;
            this.PowerSupplyVolt=powerSupplyVolt;
        }

        public double DesktopPriceCalculation()
        {
            double desktopPrice=0;
            int processorCost=0;
            int ramPrice=200;
            int hardDiskPrice=1500;
            int graphicCardPrice=2500;
            int powerSupplyVoltPrice=20;
            int monitorPrice=250;

            if(Processor == "i3")
            {
                processorCost =1500;
            }
            else if(Processor == "i5")
            {
                processorCost=3000;
            }
            else if(Processor == "i7")
            {
                processorCost=4500;
            }

            desktopPrice= processorCost+(RamSize*ramPrice)+(HardDiskSize*hardDiskPrice)+(GraphicCard*graphicCardPrice)+(MonitorSize*monitorPrice)+(PowerSupplyVolt*powerSupplyVoltPrice);
            return desktopPrice;
        }
    }
}