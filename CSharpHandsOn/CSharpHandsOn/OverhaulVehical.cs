using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn
{
    public class OverhaulVehical
    {
        public void ServiceVehical(IVehical vehical)
        {
            Console.WriteLine("Vehical details: Name - "+ vehical.Name+", type of vehical:"+ vehical.GetType().Name);
            vehical.Drive();
            vehical.TakeTurn();
            vehical.GetName();
        }
        
    }
}
