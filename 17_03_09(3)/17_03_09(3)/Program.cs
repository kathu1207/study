using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_09_3_
{
    class Program
    {
        // 메소드 형변환( 메소드 이름이 같아도 해당형이 있음 그것으로 계산)
        public static int plus(int a, int b)
        {
            return a + b;
        }
        public static float plus(float a, float b)
        {
            return a + b;
        }


        static void Main(string[] args)
        {
            float x = 4.5f;
            float y = 3.2f;
            plus(x, y);

            Console.WriteLine("{0},{1}", x,y);
        }
    }
}
