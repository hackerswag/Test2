using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;
            while (!finished)
            {
                Console.WriteLine("q to exit");
                
                Console.WriteLine("Sida:");
                double sida = double.Parse(Console.ReadLine());
                Console.WriteLine("Area: " + Area(sida));
                string meny = Console.ReadLine();
                if (meny == "q")
                    finished = true;
                else
                    finished = false;
            }
            

        }
        static double Area(double s)
        {
            double a = s * s;
            return a;

        }

    }
}
