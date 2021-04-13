using System;

namespace Lr2Task3
{
    class Program
    {
        public delegate void DivideOn(int[] mas);
        static void Main(string[] args)
        {
            int[] mas = {-30,-29,-28,-27,-26,-25,-24,-23,-22,-21,-20,-19,-18,-17,
                -16,-15,-14,-13,-14,-13,-12,-11,-10,-9,-8,-7,-6,-5-4,-3,-2,-1,0,1,
                2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,
                27,28,29,30};
            DivideOn d3 = new DivideOn(IfDividedOn3);
            DivideOn d7 = new DivideOn(IfDividedOn7);
            d3(mas);
            d7.Invoke(mas);
            Console.ReadKey();
        }
        public static void IfDividedOn3(int[] mas)
        {
            Console.WriteLine("Числа подiльнi на 3: ");
            foreach (int a in mas)
            {
                if (a % 3 == 0)
                {
                    Console.Write(a + " ");
                }
            }
            Console.WriteLine();
        }
        public static void IfDividedOn7(int[] mas)
        {
            Console.WriteLine("Числа подiльнi на 7: ");
            foreach (int a in mas)
            {
                if (a % 7 == 0)
                {
                    Console.Write(a + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
