using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        delegate double Delegates(int x);
        static double Method0(int x) => Math.Sqrt(Math.Abs(x));
        static double Method1(int x) => x * x * x;
        static double Method2(int x) => x + 3.5;
        static void Main(string[] args)
        {
            Delegates[] Methods = new Delegates[] { Method0, Method1, Method2 };
            while (true)
            {
                try
                {
                    int[] nums = Array.ConvertAll(Convert.ToString(Console.ReadLine()).Split(' '), int.Parse);
                    double output = Methods[nums[0]](nums[1]);
                    Console.WriteLine(output);
                }
                catch (Exception)
                {
                    Console.WriteLine("error");
                    break;
                }
            }
            Console.Read();
        }
    }
}