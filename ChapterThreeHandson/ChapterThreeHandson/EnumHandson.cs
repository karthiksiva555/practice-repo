using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterThreeHandson
{
    public enum Animals { Tiger, Lion, Cat, Dog, Bird}

    [Flags]
    public enum BorderSides { None=0, Left=1, Right=2, Top=4, Botton=8};

    [Flags]
    public enum RevisedBorders {None=0, Left=1, Right=2,Top =4, Bottom = 8,
                                LeftRight = Left | Right, TopBottom = Top| Bottom,
                                All = LeftRight | TopBottom };

    public class EnumHandson
    {
        public void GetDefaultValueOfEnum() => Console.WriteLine($"default value if enum Animals is {(int)Animals.Tiger}");
        
        public void EnumConversions()
        {
            Animals newAnimal = (Animals)6;
            int animalintvalue = (int)Animals.Cat;
            bool checkCat = (animalintvalue == (int)Animals.Cat);
            Animals catValue = (Animals)animalintvalue;

            Console.WriteLine($" is check cat true? : {checkCat}");
            Console.WriteLine($"The cat value after converting from integer: {catValue.ToString()}");
            Console.WriteLine($"the name of new animal is :{newAnimal.ToString()}");
            
            foreach (string enumName in Enum.GetNames(typeof(Animals))){
                Console.WriteLine($"Enum value {enumName}");
            }
            
        }

        public void EnumWithflags()
        {
            BorderSides leftRight = BorderSides.Left | BorderSides.Right;

            if ((leftRight & BorderSides.Left) != 0) Console.WriteLine("Border includes left");
            Console.WriteLine($"The value of combined enum is: {leftRight.ToString()}");

            BorderSides side = BorderSides.Left;
            side |= BorderSides.Right;
            if(side==leftRight) Console.WriteLine($"side is :{side.ToString()}");
                        
            side ^= BorderSides.Left;
            Console.WriteLine($"another side value is: {side.ToString()}");

            foreach(int value in Enum.GetValues(typeof(RevisedBorders)))
            {
                RevisedBorders check = (RevisedBorders)value;
                Console.WriteLine($"Enum value is {check.ToString()} and its integer is :{value}");
            }
        }
        public static bool IsEnumDefined(Enum e)
        {
            decimal d;
            Console.WriteLine($"The stirng value of enum is : {e.ToString()}");
            return !decimal.TryParse(e.ToString(), out d);
        }
        public void EnumValidation()
        {
            BorderSides bs = (BorderSides)32322;
            Console.WriteLine($"The border side value is {bs.ToString()}");

            Console.WriteLine($"Validationg border side: {Enum.IsDefined(typeof(BorderSides),12345)}");

            BorderSides LeftRight = BorderSides.Left | BorderSides.Right;
            Console.WriteLine($"Is Defined check on LeftRight combined flag value: {Enum.IsDefined(typeof(BorderSides),LeftRight )}");

            for(int i = 0; i <= 19; i++)
            {
                Console.WriteLine($"The enum value exists for {i} :{IsEnumDefined((BorderSides)i)}");
            }
        }
    }
}
