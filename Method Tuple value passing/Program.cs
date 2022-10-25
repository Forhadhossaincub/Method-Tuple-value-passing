using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Method_Tuple_value_passing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var result = SumAvgValue(1.5, 2.5, 3.5);
            Console.WriteLine($"Sum (1.5 + 2.5 +  3.5) is :{result.Item1} ");
            Console.WriteLine($"Sum (1.5 + 2.5 +  3.5) is :{result.Item1} and Average (1.5 + 2.5 +  3.5) is :{result.Item2} ");

            Console.WriteLine();

            var result1 = SumAvgValue1(1.5, 2.5, 3.5);
            Console.WriteLine($"Sum (1.5 + 2.5 +  3.5) is :{result1.sum} ");
            Console.WriteLine($"Sum (1.5 + 2.5 +  3.5) is :{result1.sum} and Average (1.5 + 2.5 +  3.5) is :{result1.avg} ");


            Console.ReadKey();

        }//Main

        static (double , double) SumAvgValue(double x , double y, double z)
        {
            return (x + y + z, (x+y+z)/3 );
        }

        static (double sum, double avg ) SumAvgValue1(double x, double y, double z)
        {
            return (x + y + z, (x + y + z) / 3);
        }


    }//Class
}//Namespace
