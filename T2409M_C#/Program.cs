// See https://aka.ms/new-console-template for more information
using T2409M_C_.bank;
using T2409M_C_.session1;

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

