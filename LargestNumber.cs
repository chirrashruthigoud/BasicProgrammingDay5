using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalpoblems
{
    public class LargestNumber
    {
        public static void FindLargestNumber() {
            int n1, n2, n3;
         Console.WriteLine("Find the largest of three number");
            Console.WriteLine("Input the 1st number");
            n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 2st number");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 3rd number");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                if (n1 > n3)

                {
                    Console.WriteLine("The 1st number is grestest among three");
                }
                else
                {
                    Console.WriteLine("The 3rd number is grestest among three");
                }

            }else if(n2>n3)
            {
                Console.WriteLine("The 2nd number is grestest among three");
            }
            else
            {
                Console.WriteLine("The 3rd number is grestest among three");
            }

        }
    }
}
