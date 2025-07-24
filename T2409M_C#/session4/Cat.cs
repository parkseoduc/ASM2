using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2409M_C_.session4
{
    internal class Cat : Pet

    {
        public Cat(string name, int age, double weight) : base(name, age, weight)
        {
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }
        public override void MakeSound()
        {
            Console.WriteLine("Meo Meo???");
        }
    }
}
