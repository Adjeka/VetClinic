using System.ComponentModel.DataAnnotations;

namespace MedicalExaminations.Models
{
    public class AnimalPhoto
    {
        [Key]
        public int Id { get; set; }
        public int IdAnimal { get; set; }
        public virtual Animal Animal { get; set; }
        public string FilePath { get; set; }
    }
}
