using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterSevenHandsOn
{
    public class Cars
    {
        public Car[] CarList
        {
            get {
                if (CarList == null)
                    return new Car[10];
                return CarList;
            }
        }

        public void Add(Car c)
        {
            if(CarList?.Length>0)
                CarList[CarList.Length-1] = c;
        }
    }
}
    