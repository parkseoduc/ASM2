using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace T2409M_C_.session1
{
    internal class Teacher
    {
        private string name;
        private string email;

        public string Name
        {
          get { return name; } 
            set { name = value; }
        }

        public string Email
        {
            get => name;
            set => name = value;
        }

        // abtract properties
        public string Address { get; set; }
        public void Teaching()
        {

        }
    }
}
