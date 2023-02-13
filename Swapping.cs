using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalpoblems
{
    public class Swapping
    {
        public static void SwappingtheNumber()
        {
            int a=4; int b=9;
            Console.WriteLine("Before swap a= " +a+ "b=" +b);
            a = a * b;
                b= a/b;
            a = a / b;
            Console.WriteLine("Afer swap a = " + a + " b= " + b);
        
        }

    }
}
