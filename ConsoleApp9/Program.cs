using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{/// <summary>
///  По номеру месяца вывести его название.
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int mon = Input("mon=");
            Console.WriteLine($"{GetMon(mon)}");
        }
        static int Input(string mes)
        {
            Console.Write(mes);
            return int.Parse(Console.ReadLine());
        }
        static string GetMon(int mon)
        {
            switch (mon)
            {
                case 1: return "январь";
                case 2: return "февраль";
                case 3: return "март";
                case 4: return "апрель";
                case 5: return "май";
                case 6: return "июнь";
                case 7: return "июль ";
                case 8: return "август";
                case 9: return "сентябрь";
                case 10: return "октябрь";
                case 11: return "ноябрь";
                case 12: return "декабрь";
                default: return "Error";

            }
        }
    }
}
