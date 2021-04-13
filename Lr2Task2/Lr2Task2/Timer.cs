using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static Lr2Task2.Program;

namespace Lr2Task2
{
    class Timer
    {
        private int seconds { get; set; }
        public void Start(int sec)
        {
            Methods[] met = new Methods[] 
            { Met1, Met2, Met3 };
            Random rand = new Random();
            while (true)
            {
                Thread.Sleep(sec * 1000);
                int a = rand.Next(0, 3);
                met[a]();
            }
        }
        private static void Met1()
        {
            Random rand = new Random();
            int a = rand.Next(0, 100);
            Console.WriteLine("Метод номер 1. Рандомне число: "+a);
        }
        private static void Met2()
        {
            Console.WriteLine("Метод номер 2. Час: "+DateTime.Now.TimeOfDay); 
        }
        private static void Met3()
        {
            Console.WriteLine("Метод номер 3. День мiсяца: " + DateTime.Now.Day);
        }
    }
}