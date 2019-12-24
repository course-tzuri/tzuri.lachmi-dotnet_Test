using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_tzuri_lachmi
{
    class Program
    {
        static void Main(string[] args)
        {
      
            int x = 8;



            for (int i = 1; i < x; i++)
            {
                for (int j = 1; j < x; j++)
                {
                    if (j <= i)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }

                Console.WriteLine();

            }
        }
    }
}