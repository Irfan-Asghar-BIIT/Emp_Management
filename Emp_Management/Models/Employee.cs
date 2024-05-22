using System.ComponentModel.DataAnnotations;

namespace Emp_Management.Models
{
    public class Employee
    {
        public int id { get; set; }
      
        public string Name { get; set; }
       
        public string address { get; set; }
      
        public int salary { get; set; }
    }
}
