using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Francis_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "string";
            Console.WriteLine($"{myString} = is een \'string\' datatype.");
            int myNumber = 10;
            Console.WriteLine($"{myNumber} = is een \'integer\' datatype. Zijn minimaal waarde is {int.MinValue} en zijn maximaal waarde is {int.MaxValue}");
            uint myUnumber = 10;
            Console.WriteLine($"{myUnumber} = is een \'uinteger\' datatype. Zijn minimaal waarde is {uint.MinValue} en zijn maximaal waarde is {uint.MaxValue}");
            bool myBoo = true;
            Console.WriteLine($"{myBoo} = is een \'boolean\' datatype. Er zijn enkel 2 waarden: \"True\" en \"False\".");
            double myDoub = 10.25d;
            Console.WriteLine($"{myDoub} = is een \'double\' datatype. Zijn minimaal waarde is {double.MinValue} en zijn maximaal waarde is {double.MaxValue}");
            decimal myDecim = 2.8E6m;
            Console.WriteLine($"{myDecim} = is een \'decimal\' datatype. Zijn minimaal waarde is {decimal.MinValue} en zijn maximaal waarde is {decimal.MaxValue}");
            float myFloat = 3_000.5F;
            Console.WriteLine($"{myFloat} = is een \'float\' datatype. Zijn minimaal waarde is {float.MinValue} en zijn maximaal waarde is {float.MaxValue}");
            long myLong = 50;
            Console.WriteLine($"{myLong} = is een \'long\' datatype. Zijn minimaal waarde is {long.MinValue} en zijn maximaal waarde is {long.MaxValue}");
            ulong myUlong = 50;
            Console.WriteLine($"{myUlong} = is een \'ulong\' datatype. Zijn minimaal waarde is {ulong.MinValue} en zijn maximaal waarde is {ulong.MaxValue}");
            short myShort = 5;
            Console.WriteLine($"{myShort} = is een \'short\' datatype. Zijn minimaal waarde is {short.MinValue} en zijn maximaal waarde is {short.MaxValue}");
            ushort myUshort = 5;
            Console.WriteLine($"{myUshort} = is een \'ushort\' datatype. Zijn minimaal waarde is {ushort.MinValue} en zijn maximaal waarde is {ushort.MaxValue}");
            char myChar = 'c';
            Console.WriteLine($"{myChar} = is een \'char\' datatype.");
            byte myByte = 1;
            Console.WriteLine($"{myByte} = is een \'byte\' datatype. Zijn minimaal waarde is {byte.MinValue} en zijn maximaal waarde is {byte.MaxValue}");
            sbyte mySbyte = 1;
            Console.WriteLine($"{mySbyte} = is een \'sbyte\' datatype. Zijn minimaal waarde is {sbyte.MinValue} en zijn maximaal waarde is {sbyte.MaxValue}");





        }
    }
}
