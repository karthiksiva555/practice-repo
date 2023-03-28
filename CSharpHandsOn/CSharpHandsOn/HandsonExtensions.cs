using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn
{
    public static class HandsonExtensions
    {
        public static void GetName(this IVehical vehical)
        {
            Console.WriteLine($"the name of vehical is " + vehical.Name);
        }
    }
}
