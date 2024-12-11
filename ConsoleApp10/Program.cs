using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {/// <summary>
     /// По номеру месяца вывести название времени года.
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            int mon = Input("mon=");
            Console.WriteLine($"{GetMontch(mon)}");
        }
        static int Input(string mes)
        {
            Console.Write(mes);
            return int.Parse(Console.ReadLine());
        }
        static string GetMontch(int mon)
        {
            switch (mon)
            {
                case 1: return "Winter";
                case 2: return "Winter";
                case 3: return "Spring";
                case 4: return "Spring";
                case 5: return "Spring";
                case 6: return "Summer ";
                case 7: return "Summer ";
                case 8: return "Summer ";
                case 9: return "Autumn";
                case 10: return "Autumn";
                case 11: return "Autumn";
                case 12: return "Winter";
                default: return "Error";

            }
        }
    }
}
