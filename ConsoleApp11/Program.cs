﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{/// <summary>
/// Вывести название предмета по введенной первой букве: ф – физика, м – математика, и – история, г – география, б – биология.
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
                case 'ф':
                    Console.WriteLine("Физика");
                    break;
                case 'м':
                    Console.WriteLine("Математика");
                    break;
                case 'и':
                    Console.WriteLine("История");
                    break;
                case 'г':
                    Console.WriteLine("География");
                    break;
                case 'б':
                    Console.WriteLine("Биология");
                    break;
                default:
                    Console.WriteLine("Неизвестная буква");
                    break;
            }
        }
      
    }
}
