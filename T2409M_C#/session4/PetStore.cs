using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2409M_C_.session4
{
    internal class PetStore
    {
        private List<Pet> pets = new List<Pet>();
        
        public void AddPet(Pet pet)
        {
                
             pets.Add(pet);  
        }

        public void ShowAllPets()
        {
            Console.WriteLine("/n Danh sach thu cung");
            foreach (Pet pet in pets)  {
                pet.ShowInfo();
                Console.WriteLine();
            }
        }

        public void MakeAllSounds()
        {
            Console.WriteLine("Am thanh cua cac thu cung :");
            foreach (var pet in pets) { 
            Console.WriteLine($"{pet.Name} keu:");
                pet.MakeSound();
            }
        }
    }
}
