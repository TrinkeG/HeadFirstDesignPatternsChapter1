using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior= new FlyWithWings();
            QuackBehavior = new Quacker();
            
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real mallard duck");
        }
    }
}
