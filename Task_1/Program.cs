using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
              
            int hour_ = Convert.ToInt32(Console.ReadLine());
            int minute_ = Convert.ToInt32(Console.ReadLine());
            int second_ = Convert.ToInt32(Console.ReadLine());

            Clock clock = new Clock(hour_, minute_, second_);

            int totalSecond = clock.ToSecond();
            Console.WriteLine(totalSecond);
            Console.ReadKey();
            
        } 
    }
}
