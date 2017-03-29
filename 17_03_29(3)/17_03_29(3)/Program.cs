using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_29_3_
{
    class Program
    {
        class Armorsuite
        {
            public virtual void lnitialize()
            {
                Console.WriteLine("armorsuite");
            }
        }
        class lronMan : Armorsuite
        {
            public override void lnitialize()
            {
                base.lnitialize();
                Console.WriteLine("ironMan");
            }
        }
        class warsuite : Armorsuite
        {
            public override void lnitialize()
            {
                base.lnitialize();
                Console.WriteLine("warsuite");
            }
        }
        static void Main(string[] args)
        {
            Armorsuite suite = new lronMan();

            suite.lnitialize();
        }
    }
}
