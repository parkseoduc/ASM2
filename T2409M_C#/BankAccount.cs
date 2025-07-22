using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2409M_C_.bank
{
    internal class BankAccount
    {
       private String AccountNumber {  get; set; }
        private String OwnerName { get; set; }
        private Double Balance { get; set; }

        public BankAccount(string accountNumber, string ownerName, double balance)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = balance;
        }

        public void Deposit(double amount) {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($" Da nap{amount}VND vao tk ");
            }
            else
            {
                Console.WriteLine("nap tien deo duoc");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Da rut{amount}VND khoi tai khoan");

            }
            else {
                Console.WriteLine("khong rut duoc");
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("/n ----- Thong tin tai khoan-----");
            Console.WriteLine($" So tai khoan: {AccountNumber}");
            Console.WriteLine($"Chu tai khoan: {OwnerName}");
            Console.WriteLine($"So du: {Balance}");
        }

    }

}
