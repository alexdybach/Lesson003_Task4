using System;
using System.Text;

namespace Lesson003_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Вгадайте число (від 0 до 10):");

            int numb = int.Parse(Console.ReadLine());
            int corr_numb = 8;
            string res = numb == corr_numb ? "Вгадав" : "Не вгадав";
            Console.WriteLine(res);
        }
    }
}
