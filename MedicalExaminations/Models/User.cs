using MedicalExaminations.Controllers;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MedicalExaminations.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public int RoleId { get; set; }
        public UserRole? Role { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int PermissionManagerId { get; set; }
        public PermissionManager? PermissionManager { get; set; }
        public int WorkplaceId { get; set; }
        public Organization? Organization { get; set; }
    }
}
