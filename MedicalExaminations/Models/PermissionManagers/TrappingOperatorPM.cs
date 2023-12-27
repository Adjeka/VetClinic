using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalExaminations.Models.PermissionManagers
{
    [NotMapped]
    public class TrappingOperatorPM : PermissionManager
    {
        public override bool CanViewAnimalsRegistry => true;
        public override bool CanViewOrganizationsRegistry => false;
        public override bool CanViewContractsRegistry => false;
        public override bool CanChangeAnimalsRegistry => false;
        public override bool CanChangeOrganizationsRegistry => false;
        public override bool CanChangeContractsRegistry => false;
        public override Func<Animal, bool> AnimalsFilter => (animal => true);
        public override Func<Organization, bool> OrganizationsFilter => (organization => false);
        public override Func<Contract, bool> ContractsFilter => (contract => false);
    }
}
