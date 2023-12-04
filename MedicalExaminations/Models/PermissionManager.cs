using System.ComponentModel.DataAnnotations;

namespace MedicalExaminations.Models
{
    public class PermissionManager
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public List<User> Users { get; set; }
    }
}
