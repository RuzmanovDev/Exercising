using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateNCycles
{
    class NCycles
    {
        static int numberOfLoops;
        static int[] loops;
        static void Main(string[] args)
        {
            numberOfLoops = int.Parse(Console.ReadLine());
            loops = new int[numberOfLoops];
            SimulateNCycles(0);
        }
        private static void SimulateNCycles(int currentNumber)
        {
            if (numberOfLoops == currentNumber)
            {
                PrintLoops();
                return;
            }
            for (int i = 1; i <= numberOfLoops; i++)
            {

                loops[currentNumber] = i;
                SimulateNCycles(currentNumber + 1);
               
            }
        }
        private static void PrintLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write("{0} ",loops[i]);
            }
            Console.WriteLine();
        }
    }
    
}
