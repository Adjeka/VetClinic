using System.ComponentModel.DataAnnotations;

namespace MedicalExaminations.Models
{
    public class Contract
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime SigningDate { get; set; }
        public DateTime ValidUntil { get; set; }
        public int? IdClient { get; set; }
        public virtual Organization Client { get; set; }
        public int? IdExecutor { get; set; }
        public virtual Organization Executor { get; set; }

        public List<Location> Locations { get; set; }
        public List<MedicalExamination> MedicalExaminations { get; set; }
    }
}
