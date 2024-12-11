using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {/// <summary>
     ///  Дано целое число n, указывающее номер дня недели от 1 до 7. По указанному номеру n вывести название соответствующего дня недели.
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            int day = Input("day=");
            Console.WriteLine($"{GetDay(day)}");
            
        }
        static int Input(string mes)
        {
            Console.Write(mes);
            return int.Parse(Console.ReadLine());
        }
        static string GetDay(int day)
        {
            switch(day)
            {
                case 1:return "Понедельник";
                case 2:return "Вторник";
                case 3:return "Cреда";
                case 4:return "Четверг";
                case 5:return "Пятница";
                case 6:return "Cуббота";
                case 7:return "Воскресенье";
                default:return "Error";

            }
        }
    }
}
