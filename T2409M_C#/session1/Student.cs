using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2409M_C_.session1
{
    internal class Student
    {
        public string name;
        public int age;
        public string telephone;

        public Student() // constructor : hàm khởi tạo 
        {
            Console.WriteLine("Student constructor......");
        }

        public void learn()
        {
            Console.WriteLine("Student is learning...");
        }
        
        public void learn(String msg)
        {
            Console.WriteLine("learning...." +msg);
        }
    }
}
