using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlaserCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //the used measurement unit is centimeter
            double width, height, woodLength, glassArea;
            const double MAX_WIDTH = 100.0;
            const double MIN_WIDTH = 20.5;
            const double MAX_HEIGHT = 200.0;
            const double MIN_HEIGHT = 30.75;
            const double FRAME_WIDTH = 5.5;
            string widthString, heightString;

            Console.WriteLine(" *Welcome to GlaserCalc V1.0* ");
            Console.WriteLine("                              ");
            Console.WriteLine("Important note: The Frame width is fixed to 5.5 cm and can not be changed!");
            Console.WriteLine("                              ");
            do
            {
                Console.Write("Enter the width of the window between " + MIN_WIDTH + "cm" + " and " + MAX_WIDTH + "cm" + ":");
                widthString = Console.ReadLine();
                width = double.Parse(widthString);
            }
            while (width < MIN_WIDTH || width > MAX_WIDTH);
            do
            {
                Console.Write("Enter the height of the window between " + MIN_HEIGHT + "cm" + " and " + MAX_HEIGHT + "cm" + ":");
                heightString = Console.ReadLine();
                height = double.Parse(heightString);
            }
            while (height < MIN_HEIGHT || height > MAX_HEIGHT);

            //The following formulas calculate the needed amount of wood and the area of the glass for the window.
            woodLength = 2 * (width + height) * FRAME_WIDTH; 
            glassArea = woodLength - (4 * FRAME_WIDTH);
            
            Console.WriteLine("The amount of wood needed is " + woodLength + " square centimeters" + " at a given width of " + FRAME_WIDTH + "cm");
            Console.WriteLine("The area of the glass is " + glassArea + " square centimeters");
                       
        }
    }
}
