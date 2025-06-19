using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string WorkAddress { get; set; }=string.Empty;
        public string Fullname { get; set; }= string.Empty;
        public string Position { get; set; } = string.Empty;
        public string WorkPhone { get; set; } = string.Empty;
        public string PersonalPhone { get; set; } = string.Empty;
        public string HomePhone { get; set; } = string.Empty;

        public string Role { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }

    }
}
