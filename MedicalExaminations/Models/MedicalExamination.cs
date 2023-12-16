using System.ComponentModel.DataAnnotations;

namespace MedicalExaminations.Models
{
    public class MedicalExamination
    {
        [Key]
        public int Id { get; set; }
        public int AnimalId { get; set; }
        public Animal? Animal { get; set; }
        public string BehaviourFeatures { get; set; }
        public string AnimalCondition { get; set; }
        public double BodyTemperature { get; set; }
        public string SkinCovers { get; set; }
        public string WoolCondition { get; set; }
        public string Injuries { get; set; }
        public bool EmergencyHelpRequired { get; set; }
        public string Diagnosis { get; set; }
        public string ActionsTaken { get; set; }
        public string TreatmentPrescribed { get; set; }
        public DateTime ExaminationDate { get; set; }
        public string VeterinarianFullName { get; set; }
        public string VeterinarianPosition { get; set; }
        public int VetClinicId { get; set; }
        public Organization? VetClinic { get; set; }
        public int ContractId { get; set; }
        public Contract? Contract { get; set; }
    }
}
