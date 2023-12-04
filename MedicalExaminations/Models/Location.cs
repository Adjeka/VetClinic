using System.ComponentModel.DataAnnotations;

namespace MedicalExaminations.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public string Mame { get; set; }
        public int ExaminationCost { get; set; }

        public List<Organization> Organizations { get; set; }
        public List<Contract> Contracts { get; set; }
        public List<Animal> Animals { get; set; }
    }
}
