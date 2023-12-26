namespace MedicalExaminations.Models.PermissionManagers
{
    public class CuratorPM : PermissionManager
    {
        private readonly User user;
        public CuratorPM(User user) => this.user = user;

        public override bool CanViewAnimalsRegistry => true;
        public override bool CanViewOrganizationsRegistry => true;
        public override bool CanViewContractsRegistry => true;
        public override bool CanChangeAnimalsRegistry => false;
        public override bool CanChangeOrganizationsRegistry => false;
        public override bool CanChangeContractsRegistry => false;
        public override Func<Animal, bool> AnimalsFilter => (animal => true);
        public override Func<Organization, bool> OrganizationsFilter => (organization => true);
        /// <summary>
        /// Организация, которая соответствует месту работы пользователя.
        /// </summary>
        public override Func<Contract, bool> ContractsFilter => (contract => contract.ExecutorId == user.WorkplaceId);
    }
}
