using EmployeeApp.Models;
using EmployeeApp.Payloads;
using EmployeeApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public object AddE(EmployeeRequestDTO employeeRequestDTO)
        {
            if (employeeRequestDTO == null)
            {
                throw new ArgumentNullException(nameof(employeeRequestDTO));
            }
            if (string.IsNullOrWhiteSpace(employeeRequestDTO.Fullname))
            {
                throw new ArgumentException("Fullname is required", nameof(employeeRequestDTO.Fullname));
            }
            if (string.IsNullOrWhiteSpace(employeeRequestDTO.WorkAddress))
            {
                throw new ArgumentException("WorkAddress is required", nameof(employeeRequestDTO.WorkAddress));
            }
            if (string.IsNullOrWhiteSpace(employeeRequestDTO.Position))
            {
                throw new ArgumentException("Position is required", nameof(employeeRequestDTO.Position));
            }
            if (string.IsNullOrWhiteSpace(employeeRequestDTO.WorkPhone))
            {
                throw new ArgumentException("WorkPhone is required", nameof(employeeRequestDTO.WorkPhone));
            }
            if (string.IsNullOrWhiteSpace(employeeRequestDTO.PersonalPhone))
            {
                throw new ArgumentException("PersonalPhone is required", nameof(employeeRequestDTO.PersonalPhone));
            }
            if (string.IsNullOrWhiteSpace(employeeRequestDTO.HomePhone))
            {
                throw new ArgumentException("HomePhone is required", nameof(employeeRequestDTO.HomePhone));
            }


           var employee = new Employee
           {
               WorkAddress = employeeRequestDTO.WorkAddress,
               Fullname = employeeRequestDTO.Fullname,
               Position = employeeRequestDTO.Position,
               WorkPhone = employeeRequestDTO.WorkPhone,
               PersonalPhone = employeeRequestDTO.PersonalPhone,
               HomePhone = employeeRequestDTO.HomePhone,
               DateOfBirth = employeeRequestDTO.DateOfBirth
           };
          var emp= _employeeRepository.AddE(employee);
         return new EmployeeResponseDTO
         {
             Id = emp.Id,
             WorkAddress = emp.WorkAddress,
             Fullname = emp.Fullname,
             Position = emp.Position,
             WorkPhone = emp.WorkPhone,
             PersonalPhone = emp.PersonalPhone,
             HomePhone = emp.HomePhone,
             DateOfBirth = emp.DateOfBirth
         };
        }



        public object DeleteE(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Invalid employee ID", nameof(id));
            }
            var employee = _employeeRepository.GetEById(id);
            if (employee == null)
            {
                throw new KeyNotFoundException($"Employee with ID {id} not found");
            }
            _employeeRepository.DeleteE(id);

            return "Successfully deleted";
        }

        public object GetEAll()
        {
            var employees = _employeeRepository.GetEAll();
            //if (employees == null || !employees.Any())
            //{
            //    throw new KeyNotFoundException("No employees found");
            //}
            var employeeList = employees.Select(e => new EmployeeResponseDTO
            {
                Id = e.Id,
                WorkAddress = e.WorkAddress,
                Fullname = e.Fullname,
                Position = e.Position,
                WorkPhone = e.WorkPhone,
                PersonalPhone = e.PersonalPhone,
                HomePhone = e.HomePhone,
                DateOfBirth = e.DateOfBirth
            }).ToList();
            return employeeList;
        }




        public object GetEById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Invalid employee ID", nameof(id));
            }
            var employee = _employeeRepository.GetEById(id);
            if (employee == null)
            {
                throw new KeyNotFoundException($"Employee with ID {id} not found");
            }
            return new EmployeeResponseDTO
            {
                Id = employee.Id,
                WorkAddress = employee.WorkAddress,
                Fullname = employee.Fullname,
                Position = employee.Position,
                WorkPhone = employee.WorkPhone,
                PersonalPhone = employee.PersonalPhone,
                HomePhone = employee.HomePhone,
                DateOfBirth = employee.DateOfBirth
            };
        }



        public object UpdateE(int id, EmployeeRequestDTO employeeRequestDTO)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Invalid employee ID", nameof(id));
            }
            if (employeeRequestDTO == null)
            {
                throw new ArgumentNullException(nameof(employeeRequestDTO));
            }
            if(_employeeRepository.GetEById(id) == null)
            {
                throw new KeyNotFoundException($"Employee with ID {id} not found");
            }
            var employee = _employeeRepository.GetEById(id);

            employee.WorkAddress = string.IsNullOrWhiteSpace(employeeRequestDTO.WorkAddress)
    ? employee.WorkAddress
    : employeeRequestDTO.WorkAddress;

            employee.Fullname = string.IsNullOrWhiteSpace(employeeRequestDTO.Fullname)
                ? employee.Fullname
                : employeeRequestDTO.Fullname;

            employee.Position = string.IsNullOrWhiteSpace(employeeRequestDTO.Position)
                ? employee.Position
                : employeeRequestDTO.Position;

            employee.WorkPhone = string.IsNullOrWhiteSpace(employeeRequestDTO.WorkPhone)
                ? employee.WorkPhone
                : employeeRequestDTO.WorkPhone;

            employee.PersonalPhone = string.IsNullOrWhiteSpace(employeeRequestDTO.PersonalPhone)
                ? employee.PersonalPhone
                : employeeRequestDTO.PersonalPhone;

            employee.HomePhone = string.IsNullOrWhiteSpace(employeeRequestDTO.HomePhone)
                ? employee.HomePhone
                : employeeRequestDTO.HomePhone;
            var emp=_employeeRepository.EditE(employee);

            return new EmployeeResponseDTO
            {
                Id = emp.Id,
                WorkAddress = emp.WorkAddress,
                Fullname = emp.Fullname,
                Position = emp.Position,
                WorkPhone = emp.WorkPhone,
                PersonalPhone = emp.PersonalPhone,
                HomePhone = emp.HomePhone,
                DateOfBirth = emp.DateOfBirth
            };
        }
    }
}
