using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Payloads
{
    public class EmployeeResponseDTO
    {
        public int Id { get; set; }
        public string WorkAddress { get; set; } = string.Empty;
        public string Fullname { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public string WorkPhone { get; set; } = string.Empty;
        public string PersonalPhone { get; set; } = string.Empty;
        public string HomePhone { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
    }
}
