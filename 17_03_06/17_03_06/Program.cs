using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int start_1 = 1;
            int end_1 = 3;

            int start_2 = -1;
            int end_2 = 2;

            if(start_1 > end_1)
            {
                int box = start_1;
                start_1 = end_1;
                end_1 = box;        
            }

            if((start_1 < start_2) && (end_1 < start_2))
            {
                Console.WriteLine("라인이 겹친다.");
            }
            else if((start_2 < start_1) && (end_2 < start_1)
            {
                Console.WriteLine("라인이 겹친다.");
            }
            else
            {
                Console.WriteLine("라인이 겹치지않는다.");
            }
  
        }
    }
}
