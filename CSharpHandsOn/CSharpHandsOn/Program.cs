using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car audi = new Car { ID = 1, Name = "A4", Make = "Audi", year = 2010 };

            Truck ashokLeyland = new Truck { ID=2, Name="Ashok Leyland", year=2012, capacity="100 tons"};

            var vehical = new OverhaulVehical();

            vehical.ServiceVehical(audi);
            vehical.ServiceVehical(ashokLeyland);
        }
    }
}
