using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_3_Marks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 3 numbers");
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            int Average;

            Average = (a + b + c) / 3;

            if (Average>55) Console.WriteLine("pass");
            else Console.WriteLine("fail");
        }
    }
}
