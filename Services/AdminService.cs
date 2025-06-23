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
    public class AdminService:IAdminService
    {
        private readonly string username = "Ws@489}Rm#";
        private readonly string password = "78Tgm>@^329mf@D";


        private readonly IAdminRepository _adminRepository;
        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }


        public object AddA(AdminRequestDTO adminRequestDTO)
        {
            if (adminRequestDTO == null)
            {
                throw new ArgumentNullException(nameof(adminRequestDTO));
            }
            if (string.IsNullOrWhiteSpace(adminRequestDTO.Username))
            {
                throw new ArgumentException("Username is required", nameof(adminRequestDTO.Username));
            }
            if (string.IsNullOrWhiteSpace(adminRequestDTO.Password))
            {
                throw new ArgumentException("Password is required", nameof(adminRequestDTO.Password));
            }
            if (string.IsNullOrWhiteSpace(adminRequestDTO.Fullname))
            {
                throw new ArgumentException("Fullname is required", nameof(adminRequestDTO.Fullname));
            }
            if(adminRequestDTO.Username != username)
            {
                throw new ArgumentException("Username is not valid", nameof(adminRequestDTO.Username));
            }
            if (adminRequestDTO.Password != password)
            {
                throw new ArgumentException("Password is not valid", nameof(adminRequestDTO.Password));
            }
            var admin = new AdminUser
            {
                Fullname = adminRequestDTO.Fullname,
                Username = adminRequestDTO.Username,
                Password = adminRequestDTO.Password,
                Role = "Admin",
                DateOfBirth = DateTime.UtcNow,
            };
            var admin1=_adminRepository.AddA(admin);

            return new AdminResponseDTO
            {
                Id = admin1.Id,
                Fullname = admin1.Fullname,
                Username = admin1.Username,
                Password = admin1.Password,
                Role = admin1.Role,
                DateLife = DateTime.UtcNow
            };
        }

        public object DeleteA(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id must be greater than zero", nameof(id));
            }
            var admin = _adminRepository.GetAById(id);
            if (admin == null)
            {
                throw new KeyNotFoundException($"Admin with id {id} not found");
            }
            _adminRepository.DeleteA(id);
            return "Admin deleted successfully";
        }

        public object GetA()
        {
            var admins = _adminRepository.GetAAll();
            if (admins == null || admins.Count == 0)
            {
                throw new KeyNotFoundException("No admins found");
            }
            var adminResponseDTOs = admins.Select(admin => new AdminResponseDTO
            {
                Id = admin.Id,
                Fullname = admin.Fullname,
                Username = admin.Username,
                Password = admin.Password,
                Role = admin.Role,
                DateLife = DateTime.UtcNow
            }).ToList();
            return adminResponseDTOs;
        }

        public object GetAById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id must be greater than zero", nameof(id));
            }
            var admin = _adminRepository.GetAById(id);
            if (admin == null)
            {
                throw new KeyNotFoundException($"Admin with id {id} not found");
            }
            return new AdminResponseDTO
            {
                Id = admin.Id,
                Fullname = admin.Fullname,
                Username = admin.Username,
                Password = admin.Password,
                Role = admin.Role,
                DateLife = DateTime.UtcNow
            };
        }

        public object UpdateA(int id, AdminRequestDTO adminRequestDTO)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id must be greater than zero", nameof(id));
            }
            if (adminRequestDTO == null)
            {
                throw new ArgumentNullException(nameof(adminRequestDTO));
            }
            if (adminRequestDTO.Username != username)
            {
                throw new ArgumentException("Username is not valid", nameof(adminRequestDTO.Username));
            }
            if (adminRequestDTO.Password != password)
            {
                throw new ArgumentException("Password is not valid", nameof(adminRequestDTO.Password));
            }
            var admin = _adminRepository.GetAById(id);
            if (admin == null)
            {
                throw new KeyNotFoundException($"Admin with id {id} not found");
            }
            admin.Fullname = adminRequestDTO.Fullname;
            admin.Username = adminRequestDTO.Username;
            admin.Password = adminRequestDTO.Password;
            admin.Role = "Admin";
            admin.DateOfBirth = DateTime.UtcNow;
            var admin1= _adminRepository.EditA(admin);

            return new AdminResponseDTO
            {
                Id = admin1.Id,
                Fullname = admin1.Fullname,
                Username = admin1.Username,
                Password = admin1.Password,
                Role = admin1.Role,
                DateLife = DateTime.UtcNow
            };
        }
        //public object loginSuccess(AdminRequestDTO adminRequestDTO)
        //{
        //    List<AdminUser> adminUsers=_adminRepository.GetAAll();
        //    foreach (var admin in adminUsers)
        //    {
        //        if(admin.Fullname != adminRequestDTO.Fullname)
        //        {
        //            AddA(adminRequestDTO);
        //        }
        //    }
        //    return "Success";
        //}





        public int loginSuccess(AdminRequestDTO adminRequestDTO)
        {
            var adminUsers = _adminRepository.GetAAll();

            // Avval mavjud admin bormi tekshiradi
            var existingAdmin = adminUsers.FirstOrDefault(admin =>
                admin.Fullname == adminRequestDTO.Fullname &&
                admin.Username == adminRequestDTO.Username &&
                admin.Password == adminRequestDTO.Password);

            // Agar mavjud bo‘lsa, o‘sha adminning Id sini qaytaradi
            if (existingAdmin != null)
            {
                return existingAdmin.Id;
            }

            // Agar mavjud bo‘lmasa, yangi admin qo‘shadi va uning Id sini qaytaradi
            var added = AddA(adminRequestDTO) as AdminResponseDTO;
            return added.Id;
        }

    }
}
