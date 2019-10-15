using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadaca8_1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if(a>10 && a<200)
            {
                for(int i=a;i>1;i--)
                {
                    if (i % 7 == 0)
                    {
                        Console.WriteLine(i);
                       
                    }
                }
      
            }
        }
    }
}
