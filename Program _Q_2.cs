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

            int secondtotal = 0;
            int time = 0;
           

            Console.WriteLine("insert number bigger then 0");
            secondtotal = Convert.ToInt32(Console.ReadLine());
            if(secondtotal>=0)
            {
                time = secondtotal / 86400;
                Console.WriteLine("days: {0}", time);
                time = (secondtotal % 86400)/60/60;
                Console.WriteLine("hourse: {0}", time);
                time = (secondtotal % 3600)/60;
                Console.WriteLine("minute: {0}", time);
                time = (secondtotal % 60);
                Console.WriteLine("seconde: {0}", time);




            }
           else
                Console.WriteLine("error message: the number should be bigger from 0");

          
        }
    }
}