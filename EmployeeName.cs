using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SerializationAndDeserialization
{
    public class EmployeeName
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(1, "Sahil", 22));
            employees.Add(new Employee(2, "Raj", 21));
            employees.Add(new Employee(3, "Sohail", 12));
            employees.Add(new Employee(4, "Raju", 28));
            employees.Add(new Employee(5, "Prem", 30));
            var options=new JsonSerializerOptions {WriteIndented=true };    
            var contact= JsonSerializer.Serialize(employees,options);
            Console.WriteLine(contact);
            var cont=JsonSerializer.Deserialize<List<Employee>>(contact);
            Console.WriteLine("_______________________________________________________________");
           foreach(var c in cont)
            {
                Console.WriteLine(c);
            }
        }
    }
}
