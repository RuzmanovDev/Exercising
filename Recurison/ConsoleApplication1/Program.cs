using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsideTheBuilding
{
    class InsideTheBuilding
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());

            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());



            isDotIn(x1, y1, h);



        }
        static void isDotIn(int x, int y, int h)
        {
            if ((x < h && y > h) || (x > h && x < 2 * h && y < 4 * h) || (x > 2 * h && x < 3 * h && y < h))
            {
                Console.WriteLine("inside");
            }
            else if (x> 3 *h || (x <2*h && y> h) || (x>2*h && y > h))
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("border");
            }





        }
    }
}
