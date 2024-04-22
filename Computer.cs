using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BejoyComputers
{
    public class Computer
    {
        public string Processor;
        public int RamSize;
        public int HardDiskSize;
        public int GraphicCard;

        public Computer(string processor,int ramSize,int hardDiskSize,int graphicCard)
        {
            this.Processor=processor;
            this.RamSize=ramSize;
            this.HardDiskSize=hardDiskSize;
            this.GraphicCard=graphicCard;

        }

    }
}