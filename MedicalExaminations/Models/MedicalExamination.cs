using System.ComponentModel.DataAnnotations;

namespace MedicalExaminations.Models
{
    public class MedicalExamination
    {
        [Key]
        public int Id { get; set; }
        public int AnimalId { get; set; }
        public Animal? Animal { get; set; }
        [Display(Name = "Особенности поведения")]
        public string BehaviourFeatures { get; set; }
        [Display(Name = "Состояние животного")]
        public string AnimalCondition { get; set; }
        [Display(Name = "Температура тела")]
        public double BodyTemperature { get; set; }
        [Display(Name = "Кожные покровы")]
        public string SkinCovers { get; set; }
        [Display(Name = "Состояние шерсти")]
        public string WoolCondition { get; set; }
        [Display(Name = "Ранения, травмы, и другие повреждения")]
        public string Injuries { get; set; }
        [Display(Name = "Требуется экстренная ветеринарная помощь")]
        public bool EmergencyHelpRequired { get; set; }
        [Display(Name = "Диагноз")]
        public string Diagnosis { get; set; }
        [Display(Name = "Проведенные манипуляции")]
        public string ActionsTaken { get; set; }
        [Display(Name = "Назначено лечение")]
        public string TreatmentPrescribed { get; set; }
        [Display(Name = "Дата осмотра")]
        public DateTime ExaminationDate { get; set; }
        [Display(Name = "ФИО ветеринарного специалиста")]
        public string VeterinarianFullName { get; set; }
        [Display(Name = "Должность ветеринарного специалиста")]
        public string VeterinarianPosition { get; set; }
        public int VetClinicId { get; set; }
        [Display(Name = "Ветклиника, в которой проведён осмотр")]
        public Organization? VetClinic { get; set; }
        public int ContractId { get; set; }
        [Display(Name = "Муниципальный контракт")]
        public Contract? Contract { get; set; }
    }
}
