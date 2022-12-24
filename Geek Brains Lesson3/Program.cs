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
            GetNumber();
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

        public static void GetNumber()
        {
            Console.WriteLine("Введите координату x1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y1: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату z1: ");
            int z1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату x2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y2: ");
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату z2: ");
            int z2 = int.Parse(Console.ReadLine());
            double result = 0;                    
               

            result = Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2) + (Math.Pow(z2 - z1, 2))));
            Console.WriteLine(result);          
           
        }
        


    }
}
