using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2409M_C_.session4
{
    internal class Dog : Pet
    {
        private string v;

        public bool IsTrained {  get; set; }

        public Dog(String name, int age, double weight, bool IsTrained) : base(name,age,weight)
        {
         
           IsTrained = IsTrained;

        }


        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Huấn luyện: {(IsTrained ? "Đã huấn luyện" : "Chưa huấn luyện")}");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Gau Gau???");
        }
    }
}
