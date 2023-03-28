using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterSixHandson
{
    public class DateTimeHandsOn
    {
        public enum Colors { Red = 1, White, Yellow, Green };

        public void DateTimeFormatString()
        {
            DateTime dt = new DateTime(2018, 01, 06, 16, 01, 0);

            //Honour current culture and format string settings
            Console.WriteLine("Culture Related");
            Console.WriteLine("========================================");
            Console.WriteLine(dt.ToString("d"));
            Console.WriteLine(dt.ToString("D"));
            Console.WriteLine(dt.ToString("f"));
            Console.WriteLine(dt.ToString("F"));
            Console.WriteLine(dt.ToString("t"));
            Console.WriteLine(dt.ToString("T"));
            Console.WriteLine(dt.ToString("g"));
            Console.WriteLine(dt.ToString("G"));
            Console.WriteLine(dt.ToString("m"));
            Console.WriteLine(dt.ToString("y"));
            Console.WriteLine(dt.ToString("M"));
            Console.WriteLine(dt.ToString("Y"));

            //Do not Honor current culture and format string settings
            Console.WriteLine("Culture Not Related");
            Console.WriteLine("========================================");
            Console.WriteLine(dt.ToString("o"));
            Console.WriteLine(dt.ToString("r"));
            Console.WriteLine(dt.ToString("R"));
            Console.WriteLine(dt.ToString("s"));
            Console.WriteLine(dt.ToString("u"));
            Console.WriteLine(dt.ToString("U"));

            Console.WriteLine(dt.ToString("yyyy-dd-mm mm:hh:ss"));

        }
        public void ParseWithDateTimeStyles()
        {
            string strDateTime = "       2016/ 01/02 4:17:37    ";
            string strTime = "13:04:45";
            DateTimeFormatInfo dateTimeFormatInfo = DateTimeFormatInfo.CurrentInfo ;
            Console.WriteLine("DateTimeStyles");
            Console.WriteLine("========================================");
            Console.WriteLine(DateTime.Parse(strDateTime, dateTimeFormatInfo, DateTimeStyles.AssumeLocal|DateTimeStyles.None));
            Console.WriteLine(DateTime.Parse(strTime, dateTimeFormatInfo, DateTimeStyles.NoCurrentDateDefault ));
        }

        public void EnumParsingandFormatting()
        {
            Console.WriteLine(System.ConsoleColor.Red.ToString("G"));//General
            Console.WriteLine(System.ConsoleColor.Red.ToString("F"));//treats as if Flags attribute is present
            Console.WriteLine(System.ConsoleColor.Red.ToString("D")); //gets the integer value of enum
            Console.WriteLine(System.ConsoleColor.Red.ToString("X"));//Prints the value in hexa decimal
        }

        public void EnumConversions()
        {
            int i = (int)Colors.Red;
            Colors newcolor = (Colors)3;
            Console.WriteLine("the integer equivalant of color Red is:" + i);
            Console.WriteLine("The color equivalant of integer 3 is:" + newcolor.GetType().Name + "." + newcolor.ToString());
            Console.WriteLine("Integral value of Yellow using object conversion: " + GetIntegralValueUsingObject(Colors.Yellow));
            Console.WriteLine("Integral value of Yellow using Decimal conversion: " + GetIntegralValueUsingDecimal(Colors.Yellow));
            Console.WriteLine("Integral value of Yellow using type conversion: " + GetIntegralValueUsingType(Colors.Yellow));
            Console.WriteLine("Integral value of Yellow using string conversion: " + GetIntegralValueUsingString(Colors.Yellow));
            
        }

        public object GetIntegralValueUsingObject(Enum value)
        {
            var integralval = (int)(object)value;

            return integralval;
        }

        public decimal GetIntegralValueUsingDecimal(Enum value)
        {
            return Convert.ToDecimal(value);
        }

        public object GetIntegralValueUsingType(Enum value)
        {
            var type = Enum.GetUnderlyingType(value.GetType());
            return Convert.ChangeType(value, type);
        }

        public string  GetIntegralValueUsingString(Enum value)
        {
            return value.ToString("d");
        }
    }
}
