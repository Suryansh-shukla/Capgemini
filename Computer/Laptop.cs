using System;

namespace PracticeTest
{
    public class Laptop : Computer
    {
        public int DisplaySize{set;get;}
        public int BatteryVolt{set;get;}



        /// <summary>
        /// Predefined Prices of the accessories of the Laptop
        /// </summary>
        int RamPrice=200;
        int HardDiskPrice=1500;
        int GraphicCardPrice=2500;
        int PowerSupplyVoltPrice=20;
        int DisplaySizePrice=250;


        public Laptop(){

            //The Input of processor and conversion of it to lower case;
            System.Console.WriteLine("Enter Processor:");
            Processor=Console.ReadLine();
            Processor.ToLower();
    
            //The Input of Other Variables take in form of validaton and later on converting it to integer by parsing using try parse for validation

            System.Console.WriteLine("Enter The ram Size");
            string? inputRam=Console.ReadLine();


            System.Console.WriteLine("Enter the Hard Disk Size");
            string? inputHardDisk=Console.ReadLine();

            System.Console.WriteLine("Enter the Graphic card Size");
            string? inputGraphicCard=Console.ReadLine();



            System.Console.WriteLine("Enter the Display Size");
            string? inputMonitorSize=Console.ReadLine();

            
            System.Console.WriteLine("Enter the Battery Volt");
            string inputPowerSupplyVolt=Console.ReadLine();








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

            if(!int.TryParse(inputGraphicCard,out int GraphicCardPricea))
            {
                System.Console.WriteLine("Incorrect hard Disk Size Entered");
                return;
            }
            GraphicCard=GraphicCardPricea;

            if(!int.TryParse(inputMonitorSize,out int DisplaySizea))
            {
                System.Console.WriteLine("Incorrect Dispay Size Entered");
                return;
            }

            DisplaySize=DisplaySizea;

            if(!int.TryParse(inputPowerSupplyVolt,out int PowerSupplyVolta))
            {
                System.Console.WriteLine("Incorrect Power battery Entered");
                return;
            }
            BatteryVolt=PowerSupplyVolta;
            

        }



       
        public double LaptopPriceCalculator()
        {
            double LaptopPrice=0.0;
            int ProcessorCost=0;

            ///The check of processor to get excat price for calculation
            if (Processor == "i3")
            {
                ProcessorCost=2500;
                
            }else if (Processor == "i5")
            {
                ProcessorCost=5000;
                
            }else if (Processor == "i7")
            {
                ProcessorCost=6500;
            }
            else
            {
                System.Console.WriteLine("Wrong Processor Name Entered");
                
            }




            if (ProcessorCost != 0)
            {
                // System.Console.WriteLine("{0}{1}{2}{3}",RamSize,HardDiskSize,GraphicCard,DisplaySize);
                LaptopPrice=ProcessorCost+(RamPrice*RamSize)+(HardDiskPrice*HardDiskSize)+(GraphicCard*GraphicCardPrice)+(DisplaySize*DisplaySizePrice)+(BatteryVolt*PowerSupplyVoltPrice);

                
            }
            return LaptopPrice;
           
        } 

    }
}
