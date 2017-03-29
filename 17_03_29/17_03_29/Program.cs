using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_29
{
    class Program
    {
        class MyClass
        {
            public int MyField1;
            public int MyField2;
        }

        class Base
        {
            public void BaseMethod()
            {
                Console.WriteLine("BaseMethod");
            }
        }

        class Derived : Base
        {
            public void test()
            {
                BaseMethod();
            }
        }
        static void Main(string[] args)
        {
            MyClass source = new MyClass();
            source.MyField1 = 10;
            source.MyField2 = 20;

            MyClass target = source;
            target.MyField2 = 30;

            Console.WriteLine("{0},{1}", source.MyField1, source.MyField2);
            Console.WriteLine("{0},{1}", target.MyField1, target.MyField2);

            Derived bad = new Derived();
            bad.BaseMethod();
        }
    }
}
