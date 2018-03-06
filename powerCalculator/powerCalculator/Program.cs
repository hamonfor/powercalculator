using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powerCalculator
{
    class Program
    {
        static double catchDouble()
            // read line from console and convert it to double
        {
           double caughtDouble = Convert.ToDouble(Console.ReadLine());
            return caughtDouble;
        }

        static double calculatePower(double i, double u)
            //calulate power from parameters
        {
            double power = u * i;
            return power;
        }
        static void Main(string[] args)
        {
            //init variables
            double i;
            double u;
            //greeting message
            Console.WriteLine("Witaj!");
            //input i;
            Console.Write("Podaj I [A]: ");
            i = catchDouble();
            //input u;
            Console.Write("Podaj U [V]: ");
            u = catchDouble();
            //calculate p and return the value to the user
            Console.WriteLine("Obliczona moc: " + calculatePower(i, u) + "W");
            //wait for user input
            Console.ReadKey(true);

        }
    }
}
