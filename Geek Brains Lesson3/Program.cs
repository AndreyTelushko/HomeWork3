using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Brains_Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(PolinomNum(number));
        }
        public static string PolinomNum(int number)
        {
            if (number.ToString().Length != 5) return "Число не пятизначное";
            char[] check = number.ToString().ToCharArray();
            Array.Reverse(check);
            string result = new string(check);
            if (result == number.ToString())
            {
                return "Да";
            }
            else return "Нет";
        }
    }
}
