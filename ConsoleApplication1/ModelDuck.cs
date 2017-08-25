using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ModelDuck :Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Quacker();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
