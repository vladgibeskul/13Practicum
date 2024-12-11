using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{/// <summary>
/// Дан признак транспортного средства: a – автомобиль, в – велосипед, м - мотоцикл, с – самолет, п – поезд. Вывести на экран максимальную скорость транспортного средства в зависимости от введенного признака.
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую букву:");
            char letter = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (letter)
            {
                case 'а':
                    Console.WriteLine("максимальную скорость автомобилья-532,93 км/ч");
                    break;
                case 'в':
                    Console.WriteLine("максимальную скорость велосипеда- 268,8 километра в час");
                    break;
                case 'м':
                    Console.WriteLine("максимальную скорость мотоцикла- 370км/ч");
                    break;
                case 'с':
                    Console.WriteLine("максимальную скорость самолета- 7 274 км/ч");
                    break;
                case 'п':
                    Console.WriteLine("максимальную скорость поезда- 603 километра в час");
                    break;
                default:
                    Console.WriteLine("Неизвестная буква");
                    break;
            }
        }
    }
}
