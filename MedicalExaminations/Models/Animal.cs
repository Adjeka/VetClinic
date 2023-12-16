using System.ComponentModel.DataAnnotations;

namespace MedicalExaminations.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        public int RegistrationNumber { get; set; }
        public int LocationId { get; set; }
        public Location? Location { get; set; }
        public int CategoryId { get; set; }
        public AnimalCategory? AnimalCategory { get; set; }
        public char sex { get; set; }
        public int BirthYear { get; set; }
        public int ChipNumber { get; set; }
        public string Nickname { get; set; }
        public string? DistinguishingMarks { get; set; }

        public List<OwnerSign> OwnerSigns { get; set; }
        public List<MedicalExamination> MedicalExaminations { get; set; }
        public List<AnimalPhoto> AnimalPhotos { get; set; }
    }
}
