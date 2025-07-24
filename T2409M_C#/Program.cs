// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;
using T2409M_C_.bank;
using T2409M_C_.session1;
using T2409M_C_.session2;
using T2409M_C_.session3;
using T2409M_C_.session4;

Console.WriteLine("May con ga biet gi e?");
Student s = new Student();
s.learn();
s.learn(" ong troi co mat");

Teacher t = new Teacher();
t.Name = "bo la thanh ";
t.Address = " que vo bac ninh";

Subject csharp = new Subject { Name = "C Sharp", Hours = 1 ,Cost= 4.5};

BankAccount o = new BankAccount("000001287323", "Pham chi duc", 1000000  );
o.PrintInfo();

o.Deposit(500000);
o.PrintInfo();

o.Withdraw(10000);
o.PrintInfo();

FPTAPTECHStudent ls = new FPTAPTECHStudent();
ls.learn();
ls.name = "Pham chi duc ";
ls.learn("abc");

List<MaleStudent> fs = new List<MaleStudent>();
fs.Add(new MaleStudent());
fs.Add(new MaleStudent());
fs.Add(new MaleStudent());
fs.Add(new MaleStudent());

foreach (MaleStudent m in fs)
{
    m.Eat();
}

for(int i = 0;  i < fs.Count; i++)
{
    fs[i].Eat();
}

Dog dog = new Dog("cho muc", 3, 10.5, true);
Cat cat = new Cat("meo tay", 2, 4.2);
Bird bird = new Bird("chim se di nang", 1, 0.3, "vang");

// tao cua hang thu cung
PetStore store = new PetStore();
store.AddPet(cat);
store.AddPet(dog);
store.AddPet(bird);

//hien thi thong tin va tieng keu 
store.ShowAllPets();
store.MakeAllSounds();

Console.ReadLine();


