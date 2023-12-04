using System.ComponentModel.DataAnnotations;

namespace MedicalExaminations.Models
{
    public class Organization
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int INN { get; set; }
        public int KPP { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int? IdOrganizationType { get; set; }
        public virtual OrganizationType OrganizationType { get; set; }
        public int? IdOrganizationAttribute { get; set; }
        public virtual OrganizationAttribute OrganizationAttribute { get; set; }
        public int? IdLocation { get; set; }
        public virtual Location Location { get; set; }

        public List<User> Users { get; set; }
        public List<MedicalExamination> MedicalExaminations { get; set; }
    }
}
