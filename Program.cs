namespace BejoyComputers
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("1.Desktop\n2.Laptop\nChoose option");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the processor");
            string? processor = Console.ReadLine();

            Console.WriteLine("Enter the ram size");
            int ramSize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the hard disk size");
            int hardDiskSize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the graphic card size");
            int graphicCardSize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter monitor size");
            int monitorSize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the powerSupplyVolt");
            int powerSupplyVolt = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                Desktop d = new Desktop(processor,ramSize,hardDiskSize,graphicCardSize,monitorSize,powerSupplyVolt);
                Console.WriteLine("Deskstop price is "+d.DesktopPriceCalculation());
                break;

                case 2:
                Laptop l = new Laptop(processor,ramSize,hardDiskSize,graphicCardSize);
                Console.WriteLine("Laptop price is "+l.LaptopPriceCalculation());
                break;
            }
        }
    }
    
       
}