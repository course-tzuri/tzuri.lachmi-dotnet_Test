﻿using System;
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

            int x = 0;

            int counter = 0;
            int numcounter = 0;
            int isprimecounter = 0;
            int isprimecount = 0;
            do
            {
                Console.WriteLine("insert number between 1-1000");
                x = Convert.ToInt32(Console.ReadLine());
                numcounter++;
                if (x >= 1 && x < 1001)
                {
                    for (int i = 2; i < x; i++)
                    {
                        if (x % i == 0)
                        {
                            counter++;
                        }


                    }
                    if (counter == 0)
                    {
                        Console.WriteLine("is prime");
                        isprimecounter++;
                        isprimecount = isprimecount + x;
                    }
                    else
                    {
                        Console.WriteLine("sorry-the number is not prime");
                        break;
                    }
                }
                else
                    Console.WriteLine("invalid number");
            } while (x >= 0 && numcounter <= 2);
            if (isprimecounter == 3)
            {
                Console.WriteLine(isprimecount);
            }

        }
    }
}