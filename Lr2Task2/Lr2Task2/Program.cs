using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2Task2
{
    class Program
    {
        delegate void Delegate(int sec);
        public delegate void Methods();
        static void Main(string[] args)
        {
            Console.Write("Введiть кiлькiсть секунд: ");
            int sec = int.Parse(Console.ReadLine());
            Timer timer = new Timer();
            Delegate del = timer.Start;
            del.Invoke(sec);
        }
    }
}
