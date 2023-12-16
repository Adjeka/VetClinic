using System.ComponentModel.DataAnnotations;

namespace MedicalExaminations.Models
{
    public class Organization
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public long INN { get; set; }
        public long KPP { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int OrganizationTypeId { get; set; }
        public OrganizationType? OrganizationType { get; set; }
        public int OrganizationAttributeId { get; set; }
        public OrganizationAttribute? OrganizationAttribute { get; set; }
        public int LocationId { get; set; }
        public Location? Location { get; set; }

        public List<User> Users { get; set; }
        public List<MedicalExamination> MedicalExaminations { get; set; }
    }
}
