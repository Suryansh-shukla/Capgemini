using System;
using System.Diagnostics;
using System.Reflection;

namespace PracticeTest
{
    public class Desktop : Computer
    {

        public int MonitorSize{set;get;}
        public int PowerSupplyVolt{set;get;}


        /// <summary>
        /// Pre Defined Prices of the accessories of Desktop
        /// </summary>
        int RamPrice=200;
        int HardDiskPrice=1500;
        int GraphicCardPrice=2500;
        int PowerSupplyVoltPrice=20;
        int MonitorSizePrice=250;

        /// <summary>
        /// The Constructor to Take all user Inputs 
        /// </summary>
        public Desktop(){

            //Input of processor is Taken and Stored in Text format to Lower Case
            System.Console.WriteLine("Enter Processor:");
            Processor=Console.ReadLine();
            Processor.ToLower();

            //UserInut of all Variables and Storing it in String and later verify for invalid input
            System.Console.WriteLine("Enter The ram Size");
            string? inputRam=Console.ReadLine();

            System.Console.WriteLine("Enter the Hard Disk Size");
            string? inputHardDisk=Console.ReadLine();

            System.Console.WriteLine("Enter the Graphic card Size");
            string? inputGraphicCard=Console.ReadLine();

            System.Console.WriteLine("Enter the Monitor Size");
            string? inputMonitorSize=Console.ReadLine();

            System.Console.WriteLine("Enter the Battery Volt");
            string inputPowerSupplyVolt=Console.ReadLine();

            ///Parssing all the inputs and checking if those are integers are not .....
            if(!int.TryParse(inputRam,out int RamSizea))
            {
                System.Console.WriteLine("Incorrect Ram Size Entered");
                return;
            }
            RamSize=RamSizea;
            if(!int.TryParse(inputHardDisk,out int HardDiskSizea))
            {
                System.Console.WriteLine("Incorrect hard Disk Size Entered");
                return;
            }
            HardDiskSize=HardDiskSizea;

            if(!int.TryParse(inputGraphicCard,out int GraphicCarda))
            {
                System.Console.WriteLine("Incorrect hard Disk Size Entered");
                return;
            }
            GraphicCard=GraphicCarda;

            if(!int.TryParse(inputMonitorSize,out int MonitorSizea))
            {
                System.Console.WriteLine("Incorrect Monitor Size Entered");
                return;
            }
            MonitorSize=MonitorSizea;

            if(!int.TryParse(inputPowerSupplyVolt,out int PowerSupplyVolta))
            {
                System.Console.WriteLine("Incorrect Power Supply VOlt Entered");
                return;
            }
            PowerSupplyVolt=PowerSupplyVolta;

        }
        public double DesktopPriceCalculator()
        {
            int ProcessorCost=0;
            double DesktopPrice=0;



            //Checking which Processor was choosen by USer for further Calculation by using if else if 
            if (Processor == "i3")
            {
                ProcessorCost=1500;
                
            }else if (Processor == "i5")
            {
                ProcessorCost=3000;
                
            }else if (Processor == "i7")
            {
                ProcessorCost=4500;
            }
            else
            {
                System.Console.WriteLine("Wrong Processor Name Entered");
                
            }


            //if the ProcessorCost is not 0 then user has selected correct processor then only perform calculation.
            if (ProcessorCost != 0)
            {
                // System.Console.WriteLine("{0}{1}{2}{3}{4}",RamSize,HardDiskSize,GraphicCard,MonitorSize,PowerSupplyVolt);
                DesktopPrice=ProcessorCost+(RamPrice*RamSize)+(HardDiskPrice*HardDiskSize)+(GraphicCard*GraphicCardPrice)+(MonitorSize*MonitorSizePrice)+(PowerSupplyVolt*PowerSupplyVoltPrice);
                

                
            }
            return DesktopPrice;
        }
        
    }
}