using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       static void sum(ref int x, ref int y)
        {
            if (x > 0)
            {
                x--;
                y++;
                sum(ref x, ref y);
            }
            else
            {
                Console.WriteLine(y);
            }


        }
        static void Main(string[] args)
        {

        int a = 5;
        int b = 20;
        sum(ref a, ref b);



   
    }


    }
}
