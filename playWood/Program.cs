using System;

namespace playWood
{
    class Program
    {
        static void Main(string[] args)
        {

            int sidePanelHeight = Convert.ToInt32(78);
            int sidePanelDepth = Convert.ToInt32(56.2);
            int middlePanelDepth = Convert.ToInt32(56.2);
            int cabinetSize;
            int sidePanels;
           

            Console.Write("What is the size of your Cabinet? \n");

            double cabinetSize = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is the thickness of your side panels? \n");
            _ = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is the thickness of your cabinet back? \n");

            double backThickness = Convert.ToDouble(Console.ReadLine());

            Console.Write("How many doors will you install? \n");

            int doorNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the thickeness of your doors? \n");

            double doorThickness = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The size of your cabinet is " + Convert.ToInt32(cabinetSize));

            //Console.WriteLine($"The side panels sizes are {0} x {1} = 2 pcs", Convert.ToInt32(sidePanelHeight),Convert.ToDouble(sidePanelDepth));
            Console.WriteLine("The size of side panels are " + sidePanelHeight + " x " + sidePanelDepth + "= 2 pcs");

            int middlePanelWidth = cabinetSize - sidePanels;


            Console.Write.Line("The size of middle panels are " );
            Console.ReadLine();

        }
    }
}
