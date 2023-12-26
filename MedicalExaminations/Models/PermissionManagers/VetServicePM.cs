namespace MedicalExaminations.Models.PermissionManagers
{
    public class VetServicePM : PermissionManager
    {
        public override bool CanViewAnimalsRegistry => true;

        public override bool CanViewOrganizationsRegistry => true;

        public override bool CanViewContractsRegistry => true;

        public override bool CanChangeAnimalsRegistry => false;

        public override bool CanChangeOrganizationsRegistry => false;

        public override bool CanChangeContractsRegistry => false;

        public override Func<Animal, bool> AnimalsFilter => (animal => true);

        public override Func<Organization, bool> OrganizationsFilter => (organization => true);

        public override Func<Contract, bool> ContractsFilter => (contract => true);
    }
}
