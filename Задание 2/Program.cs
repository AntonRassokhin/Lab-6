using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи строку:");
            string aString = Console.ReadLine();
            string cString = aString.ToLower();
            string[] splArray = cString.Split();
            string bString = String.Join("", splArray);

            char[] symArray = bString.ToCharArray();
            Array.Reverse(symArray);
            string revString = String.Join("", symArray);

            if (bString == revString)
            {
                Console.WriteLine("Ура! Палиндром!");
            }
            else
            {
                Console.WriteLine("Не палиндром(");
            }                    
            Console.ReadKey();
        }
    }
}
