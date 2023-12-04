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
        public string? Patronymic { get; set; }
        public int IdRole { get; set; }
        public virtual UserRole Role { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int IdPermissionManager { get; set; }
        public virtual PermissionManager PermissionManager { get; set; }
        public int? IdWorkplace { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
