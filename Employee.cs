using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAndDeserialization
{
    public class Employee
    {
        public int eId{get; set;}
        public string Name { get; set;} 
        public int age {  get; set;}

        public Employee(int eId, string name, int age)
        {
            this.eId = eId;
            Name = name;
            this.age = age;
        }

        public override string? ToString()
        {
            return $"Id:{eId} Name:{Name} Age:{age}\n";
        }
    }
}
