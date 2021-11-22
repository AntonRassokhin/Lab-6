using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи строку:");
            string aString = Console.ReadLine();
            string[] sArray = aString.Split();
            int max = sArray[0].Length;
            
            foreach (string s in sArray)
            {
                int sC = s.Length;
                if (sC > max)
                    max = sC;
            }
            Console.WriteLine("Самое длинное слово -{0} букв",max);
            Console.ReadKey();
        }
    }
}
