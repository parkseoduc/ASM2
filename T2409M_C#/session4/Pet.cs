using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2409M_C_.session4
{
    internal abstract class Pet
    {
        public string Name {  get; set; }
        public int Age {  get; set; }
        public double Weight {  get; set; }




        public Pet(string name, int age, double weight)
        {
            Name = name;
            Age = age;
                
            Weight = weight;

        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Tên:{Name} , Tuổi:{Age}, Cân nặng:{Weight}Kg");
        }

        public abstract void MakeSound();
    }
}
