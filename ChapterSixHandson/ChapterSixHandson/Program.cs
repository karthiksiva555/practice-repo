using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterSixHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimeHandsOn d = new DateTimeHandsOn();
            //d.DateTimeFormatString();
            //d.ParseWithDateTimeStyles();
            //d.EnumParsingandFormatting();
            d.EnumConversions();
            Console.ReadLine();
        }
    }
}
