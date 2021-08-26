using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            looping(1);
        }

        public static void looping(int a)
        {
            Console.WriteLine(a);
            if(a < 10){
                looping(a + 1);
            }
        }
    }
}
