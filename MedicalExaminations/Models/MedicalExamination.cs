using System.ComponentModel.DataAnnotations;

namespace MedicalExaminations.Models
{
    public class MedicalExamination
    {
        [Key]
        public int Id { get; set; }
        public int? IdAnimal { get; set; }
        public virtual Animal Animal { get; set; }
        public string? BehaviourFeatures { get; set; }
        public string AnimalCondition { get; set; }
        public double BodyTemperature { get; set; }
        public string SkinCovers { get; set; }
        public string WoolCondition { get; set; }
        public string? Injuries { get; set; }
        public bool EmergencyHelpRequired { get; set; }
        public string Diagnosis { get; set; }
        public string? ActionsTaken { get; set; }
        public string TreatmentPrescribed { get; set; }
        public DateTime ExaminationDate { get; set; }
        public string VeterinarianFullName { get; set; }
        public string VeterinarianPosition { get; set; }
        public int IdVetClinic { get; set; }
        public virtual Organization Organization { get; set; }
        public int IdMunicipalContract { get; set; }
        public virtual Contract Contract { get; set; }
    }
}
