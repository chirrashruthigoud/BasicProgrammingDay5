using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalpoblems
{
    public class QuotientAndRemainder
    {
        public static void FindQuotientAndRemainder() {
            int divident = 30, divisor = 1;
            int quotient =divident=divident/divisor;
            int remainder = quotient%divisor;
            Console.WriteLine("Divider : {0} Divisor : {1}",divident, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}
