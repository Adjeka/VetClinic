using MedicalExaminations.Controllers;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MedicalExaminations.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Patronymic { get; set; } = null!;
        public int RoleId { get; set; }
        public UserRole? Role { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int PermissionManagerId { get; set; }
        public PermissionManager? PermissionManager { get; set; }
        public int WorkplaceId { get; set; }
        public Organization? Workplace { get; set; }
    }
}
