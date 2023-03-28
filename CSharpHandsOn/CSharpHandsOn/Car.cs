using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn
{
    public class Car :IVehical
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Make { get; set; }
        public long year { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{this.Name} is driving...");
        }

        public void TakeTurn()
        {
            Console.WriteLine($"{ this.Name } is taking a turn...");
        }
    }
}
